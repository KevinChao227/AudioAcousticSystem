Option Strict Off
Option Explicit On
Imports Microsoft.Win32
Friend Class frmExample
    Inherits System.Windows.Forms.Form

    '   global variables

    Dim str_xdata As String
    Dim str_Tab As String
    Dim str_LF As String
    Dim str_CRLF As String
    Dim str_CR As String
    Dim str_Period As String
    Dim max_NumberCurves As Integer
    Dim color_Orange As Integer
    Dim color_Purple As Integer
    Dim color_BrGreen As Integer
    Dim color_Pale_Green As Integer
    Dim color_Dk_Pale_Green As Integer
    Dim maxDP As DataPoint
    Dim minDP As DataPoint

    Dim g_curveData(8) As DataPointList
    Dim g_numberCurves As Integer
    Dim g_curveColors(8) As Color '0-based
    Dim g_curvePens(8) As Pen '0-based
    Dim g_curveNames As Collection

    Dim g_AvailableCurves As Collection
    Dim g_SelectedCurves As Collection
    Dim g_AutoLoadActiveX As Boolean

    Dim g_curveLabels(8) As System.Windows.Forms.Label
    Dim g_curvePics(8) As System.Windows.Forms.PictureBox

    Dim g_XScrScale As Single ' X Scaling factor to widget coordinates
    Dim g_YScrScale As Single ' Y Scaling factor to widget coordinates

    Dim g_XAxisTick As Integer
    Dim g_YAxisTick As Integer
    Dim g_XAxisTickD As Double
    Dim g_YAxisTickD As Double
    Dim g_XAxisWidth As Integer
    Dim g_YAxisHeight As Integer
    Dim g_XWorldWidth As Double
    Dim g_YWorldHeight As Double
    Dim g_XAxisMax As Integer
    Dim g_YAxisMax As Integer
    Dim g_XAxisMin As Integer
    Dim g_YAxisMin As Integer
    Dim g_XAxisMaxD As Double
    Dim g_YAxisMaxD As Double
    Dim g_XAxisMinD As Double
    Dim g_YAxisMinD As Double

    Dim g_XAxisLabel As String
    Dim g_YAxisLabel As String

    Dim g_HalfTickLength As Integer

    Dim g_YAxisOffset As Integer
    Dim g_XAxisOffset As Integer

    Dim g_GraphLoaded As Boolean
    Dim g_GraphConfigured As Boolean
    Dim g_LogScaleFactor As Double
    Dim g_AutoLoadFile As Boolean
    Dim g_GraphFilePath As String
    Dim g_OpenSequencePath As String
    Dim g_DisableClick As Boolean

    Dim g_WaitState As Integer
    Dim g_CRY6181Success As Boolean
    Dim g_CRY6181Iteration As Integer
    Dim g_SCIterationCurve As String

    Dim g_RunCRY6181Minimized As Boolean
    Dim g_RunCRY6181Hidden As Boolean
    Dim g_HideCRY6181StatusW As Boolean
    Dim g_AppList As Collection ' of SCAppInfo objects

    Dim g_ConfigFilePath As String

    '   scale types
    '   1 = linear
    '   2 = log

    Dim st_Linear As Integer
    Dim st_Log As Integer

    Dim g_XScaleType As Integer
    Dim g_YScaleType As Integer

    '
    '   these variables have to do with interacting with the CRY6181 ActiveX component
    '   must have the CRY6181 Type Library selected in the Project->References section
    '
    Dim lvApp As Object
    Dim lvVI As Object

    Dim paramNames(7) As String
    Dim paramValues(7) As Object

    Function Log10(ByRef X As Double) As Double
        Log10 = System.Math.Log(X) / System.Math.Log(10.0#)
    End Function

    Function TenToX(ByRef inPower As Integer) As Double
        Static temp As Double
        temp = 1.0#
        Do Until inPower = 0
            If (inPower > 0) Then
                temp = temp * 10.0#
                inPower = inPower - 1
            Else
                temp = temp / 10.0#
                inPower = inPower + 1
            End If
        Loop
        TenToX = temp
    End Function

    '   amount needs to be 0 < x < 1 or -1 < x < 0
    '   If x > 0 then the absolute value is increased
    '   If x < 0 then the absolute value is decreased
    '   Do not call this directly.  Use GetAxisMax() or GetAxisMin()
    Private Function AdjustAxis(ByRef inValue As Double, ByRef amount As Double) As Double
        Dim logValue As Double
        Dim integerLog As Integer
        Dim logLower As Double
        Dim factor As Double
        Dim integerFactor As Integer
        Dim newFactor As Double
        Dim bump As Boolean = False

        AdjustAxis = inValue

        If (bump = True) Then
            Return inValue
        End If

        '   Cannot handle 0.0
        If ((inValue < 0.000001#) And (inValue > -0.000001#)) Then
            Return inValue
        End If

        '   Fudge the floating point a bit to ensure proper round-off and truncation
        If (amount > 0.0#) Then
            amount = amount * 1.01
        Else
            amount = amount * 0.99
        End If

        logValue = Log10(inValue)
        integerLog = CInt(Math.Truncate(logValue))
        logLower = TenToX(integerLog)
        factor = inValue / logLower

        'Add amount to fraction
        factor = factor + amount
        'Mutliply by 10 then truncate the rest
        factor = factor * 10
        integerFactor = CInt(Math.Truncate(factor))
        'Scale the magnitude back
        newFactor = logLower * integerFactor / 10.0
        'old code just added 1 to the integer, which is too much esp. for log axis
        'integerFactor = integerFactor + 1
        'maxFactor = logLower * CDbl(integerFactor)
        AdjustAxis = newFactor
    End Function

    Private Function GetAxisMax(ByRef inMaxValue As Double) As Double
        '   Increase the range, i.e newValue > inMaxValue
        Dim isNegative As Boolean
        Dim tempValue As Double
        Dim newValue As Double

        GetAxisMax = inMaxValue

        If (inMaxValue < 0.0#) Then
            tempValue = -inMaxValue
            isNegative = True
            newValue = AdjustAxis(tempValue, -0.1#)
        Else
            tempValue = inMaxValue
            isNegative = False
            newValue = AdjustAxis(tempValue, 0.1#)
        End If

        If (isNegative = False) Then
            GetAxisMax = newValue
        Else
            GetAxisMax = -newValue
        End If

    End Function

    Private Function GetAxisMin(ByRef inMinValue As Double) As Double
        '   find the minimum axial tick mark (i.e., the lower bound of the axis)
        '   given the minimum data value
        '   Decrease the range, i.e newValue < inMinValue
        GetAxisMin = inMinValue
        Dim isNegative As Boolean
        Dim tempValue As Double
        Dim newValue As Double

        GetAxisMin = inMinValue

        If (inMinValue < 0.0#) Then
            tempValue = -inMinValue
            isNegative = True
            newValue = AdjustAxis(tempValue, 0.1#)
        Else
            tempValue = inMinValue
            isNegative = False
            newValue = AdjustAxis(tempValue, -0.1#)
        End If

        If (isNegative = False) Then
            GetAxisMin = newValue
        Else
            GetAxisMin = -newValue
        End If
    End Function

    Private Sub cmdBrowseOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBrowseOpen.Click
        '   browse the file system to find a sequence to open, and open it

        Dim MyResult As System.Windows.Forms.DialogResult

        MyResult = OpenSeqFileDialog.ShowDialog()
        If MyResult = DialogResult.Cancel Then
            GoTo DoNothing
        End If

        g_OpenSequencePath = OpenSeqFileDialog.FileName
        txtSequencePath.Text = g_OpenSequencePath
        '   now do the Open Sequence stuff
        If Not lvVI Is Nothing Then
            paramValues(0) = "open " & txtSequencePath.Text
            paramValues(1) = False
            paramValues(2) = False
            paramValues(3) = 0.0#
            paramValues(4) = ""
            paramValues(5) = ""
            paramValues(6) = ""
            paramValues(7) = ""
            Call DoIndicator("Opening Browsed Sequence", "Waiting...", True)
            Try
                lvVI.Call(paramNames, paramValues)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
            End Try

            If (paramValues(1) = True) Then
                Call DoIndicator("Opening Browsed Sequence", "Success", False)
                Call ParseTableString2(paramValues(4))
                cmdRunSequence.Enabled = True
            Else
                Call DoIndicator("Opening Browsed Sequence", "FAILED", False)
            End If
        End If
        Exit Sub
DoNothing:

    End Sub

    Private Sub cmdConfig_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConfig.Click
        '
        '   create and enable and load the configuration panel
        '   deal with the results when the user hits "OK"
        '
        Dim configForm As frmConfigure
        Dim xMinL As Integer
        Dim xMaxL As Integer
        Dim yMinL As Integer
        Dim yMaxL As Integer
        Dim xTickInterval As Integer
        Dim yTickInterval As Integer
        Dim xTickI As Integer
        Dim yTickI As Integer
        Dim colors As Collection
        Dim numberColors As Integer
        Dim colorIndex As Integer
        Dim newColors As Collection
        Dim iMinLog As Integer
        Dim iMaxLog As Integer
        Dim iMin As Integer
        Dim iMax As Integer
        Dim temp As Integer
        Dim curveName As String

        colors = New Collection
        If (g_curveNames Is Nothing) Then
            g_curveNames = New Collection
            For colorIndex = 0 To 7
                curveName = "Curve " & Str(colorIndex)
                g_curveNames.Add(curveName)
            Next colorIndex
        End If

        configForm = New frmConfigure
        '   make sure we have the correct initial values for the configuration form
        configForm.xScaleType = g_XScaleType - 1 '   1-ref to 0-ref
        configForm.yScaleType = g_YScaleType - 1 '   1-ref to 0-ref
        configForm.setXLabel((g_XAxisLabel))
        configForm.setYLabel((g_YAxisLabel))
        configForm.autoLoadFile = g_AutoLoadFile
        '   determine the tick intervals
        If (g_XScaleType = st_Linear) Then
            xMaxL = g_XAxisMax
            xMinL = g_XAxisMin
            xTickInterval = (xMaxL - xMinL) / g_XAxisTick
        Else
            temp = g_XAxisMax / CInt(g_LogScaleFactor)
            xMaxL = CInt(TenToX(temp))
            temp = g_XAxisMin / CInt(g_LogScaleFactor)
            xMinL = CInt(TenToX(temp))
            xTickInterval = 1
        End If
        If (g_YScaleType = st_Linear) Then
            yMaxL = g_YAxisMax
            yMinL = g_YAxisMin
            yTickInterval = (yMaxL - yMinL) / g_YAxisTick
        Else
            temp = g_YAxisMax / CInt(g_LogScaleFactor)
            yMaxL = CInt(TenToX(temp))
            temp = g_YAxisMin / CInt(g_LogScaleFactor)
            yMinL = CInt(TenToX(temp))
            yTickInterval = 1
        End If
        '   initialize
        Call configForm.setXRangeL(xMinL, xMaxL)
        Call configForm.setYRangeL(yMinL, yMaxL)
        Call configForm.SetCurveNames(g_curveNames)
        Call configForm.SetCurveColors(colors)
        Call configForm.setXTickIntervalI(xTickInterval)
        Call configForm.setYTickIntervalI(yTickInterval)
        configForm.ShowDialog()

        If (configForm.isCommitted = True) Then
            Call configForm.getXRangeL(xMinL, xMaxL)
            Call configForm.getYRangeL(yMinL, yMaxL)
            Call configForm.getXLabel(g_XAxisLabel)
            Call configForm.getYLabel(g_YAxisLabel)
            g_AutoLoadFile = configForm.autoLoadFile

            g_XScaleType = configForm.xScaleType + 1 '   0-ref to 1-ref
            g_YScaleType = configForm.yScaleType + 1 '   0-ref to 1-ref
            '   set the maxes and mins
            If (g_XScaleType = st_Linear) Then
                g_XAxisMax = xMaxL
                g_XAxisMin = xMinL
            Else
                iMinLog = CInt(Log10(xMinL) * 10)
                iMaxLog = CInt(Log10(xMaxL) * 10)
                iMin = CInt(Log10(xMinL)) * 10
                iMax = CInt(Log10(xMaxL)) * 10
                If (iMaxLog > iMax) Then
                    iMaxLog = CInt(Log10(xMaxL)) + 1
                Else
                    iMaxLog = CInt(Log10(xMaxL))
                End If
                If (iMinLog < iMin) Then
                    iMinLog = CInt(Log10(xMinL)) - 1
                Else
                    iMinLog = CInt(Log10(xMinL))
                End If
                '
                '   need to adjust to using log scales
                '   factor things up
                '
                g_XAxisMax = iMaxLog * CInt(g_LogScaleFactor)
                g_XAxisMin = iMinLog * CInt(g_LogScaleFactor)
            End If
            g_XAxisWidth = g_XAxisMax - g_XAxisMin
            If (g_YScaleType = st_Linear) Then
                g_YAxisMax = CInt(yMaxL)
                g_YAxisMin = CInt(yMinL)
            Else
                iMinLog = CInt(Log10(yMinL) * 10)
                iMaxLog = CInt(Log10(yMaxL) * 10)
                iMin = CInt(Log10(yMinL)) * 10
                iMax = CInt(Log10(yMaxL)) * 10
                If (iMaxLog > iMax) Then
                    iMaxLog = CInt(Log10(yMaxL)) + 1
                Else
                    iMaxLog = CInt(Log10(yMaxL))
                End If
                If (iMinLog < iMin) Then
                    iMinLog = CInt(Log10(yMinL)) - 1
                Else
                    iMinLog = CInt(Log10(yMinL))
                End If
                '
                '   need to scale things up
                '
                g_YAxisMax = iMaxLog * CInt(g_LogScaleFactor)
                g_YAxisMin = iMinLog * CInt(g_LogScaleFactor)
            End If
            g_YAxisHeight = g_YAxisMax - g_YAxisMin
            If (g_XScaleType = st_Linear) Then
                xTickInterval = configForm.getXTickIntervalI
                If (xTickInterval > 0) Then
                    xTickI = g_XAxisWidth / xTickInterval
                Else
                    xTickI = g_XAxisWidth / 100 '   looking out for divisor = 0
                End If
            Else
                xTickI = g_LogScaleFactor
            End If
            If (g_YScaleType = st_Linear) Then
                yTickInterval = configForm.getYTickIntervalI
                If (yTickInterval > 0) Then
                    yTickI = g_YAxisHeight / yTickInterval
                Else
                    yTickI = g_YAxisHeight / 100 '   looking out for divisor = 0
                End If
            Else
                yTickI = g_LogScaleFactor
            End If
            g_XAxisTick = xTickI
            g_YAxisTick = yTickI
            g_XAxisOffset = -g_XAxisMin
            g_YAxisOffset = g_YAxisMax '   = g_YAxisHeight - g_YAxisMin
            newColors = New Collection
            Call configForm.GetCurveColors(newColors)
            '   set the curve colors, replace changed colors
            For colorIndex = 0 To (numberColors - 1)
                If (newColors.Item(colorIndex) <> g_curveColors(colorIndex)) Then
                    g_curveColors(colorIndex) = newColors.Item(colorIndex)
                    g_curvePens(colorIndex) = New Pen(g_curveColors(colorIndex))
                End If
            Next colorIndex
            If (g_GraphLoaded = True) Then
                Call ConfigRedrawCurves()
                '   set the legend
                ' TODO Consider RaiseEvent to force paint
                'Call SetDefaultLegend()
                For colorIndex = 0 To (numberColors - 1)
                    Call EnableALegend(colorIndex)
                Next colorIndex
            End If
            g_GraphConfigured = True
        End If
        configForm.Close()
        colors = Nothing
    End Sub

    Private Sub cmdExitCRY6181_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExitCRY6181.Click
        Dim Msg As Object
        If Not lvVI Is Nothing Then
            Call DoIndicator("Exiting CRY6181", "Waiting.....", True)

            ' Check for error, then show message.

            '   only care about setting the Command parameter
            paramValues(0) = "exit"
            paramValues(1) = False
            paramValues(2) = False
            paramValues(3) = 0.0#
            paramValues(4) = ""
            paramValues(5) = ""
            paramValues(6) = ""
            paramValues(7) = ""
            Try
                lvVI.Call(paramNames, paramValues)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
            End Try

            '   check the Success? parameter
            If (paramValues(1) = True) Then
                Call DoIndicator("Exiting CRY6181", "Success!", True)
            Else
                Call DoIndicator("Exiting CRY6181", "Error!", True)
                Msg = "Error encountered during exiting of " & "CRY6181" & Chr(13) & "Error # " & Str(Err.Number) & ": " & Err.Description
                MsgBox(Msg, , "Error")

            End If
            '   note: the virtual instrument is nonexistent at this point
            '   note: the lvApp is also nonexistent at this point
            '   so let's null them
            lvVI = Nothing
            lvApp = Nothing
        End If
        '   enable the "Run CRY6181" stuff
        cmdRunCRY6181.Enabled = True
        cmdBrowseOpen.Enabled = True
        '   disable the rest
        cmdGetCurveNames.Enabled = False
        cmdConfig.Enabled = False
        cmdExitCRY6181.Enabled = False
        'cmdLoadGraphFile.Enabled = False
        'cmdLoadPath.Enabled = False
        cmdOpenSequence.Enabled = False
        cmdRunSequence.Enabled = False
        cmdSetLotNumber.Enabled = False
        cmdSetSerialNumber.Enabled = False
    End Sub

    Private Sub cmdGetCurveNames_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetCurveNames.Click
        Dim curveListForm As frmCurves
        If Not lvVI Is Nothing Then
            '   only care about setting the Command parameter
            '   get the curves from the ActiveX control
            paramValues(0) = "names"
            paramValues(1) = False
            paramValues(2) = False
            paramValues(3) = 0.0#
            paramValues(4) = ""
            paramValues(5) = ""
            paramValues(6) = ""
            paramValues(7) = ""
            Try
                lvVI.Call(paramNames, paramValues)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
            End Try

            '   check the Success? parameter
            If (paramValues(1) = True) Then
                '   get names from the fourth parameter
                g_AvailableCurves = Nothing
                g_AvailableCurves = New Collection
                '   retrieve the curve names from the string returned by the ActiveX control
                Call ParseCurveNames(paramValues(4), g_AvailableCurves)
                g_SelectedCurves = Nothing
                g_SelectedCurves = New Collection
                '   create and load the curve list form to allow the user to pick curves to plot
                curveListForm = New frmCurves
                Call curveListForm.SetAvailableCurves(g_AvailableCurves)
                curveListForm.loadDataAuto = g_AutoLoadActiveX
                Call curveListForm.Initialize()
                curveListForm.ShowDialog()
                If (curveListForm.isCommitted = True) Then
                    Call curveListForm.GetSelectedCurves(g_SelectedCurves)
                    Call curveListForm.GetAvailableCurves(g_AvailableCurves)
                    g_AutoLoadActiveX = curveListForm.loadDataAuto
                    If (g_SelectedCurves.Count() > 0) Then
                        g_GraphLoaded = True
                        Call LoadGraphCurves()
                        Call CalculateGraphData()
                        Me.graphBox.Invalidate()
                        Me.sstTabControl.SelectTab(1)
                        Me.BringToFront()
                        Me.sstTabControl.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmdLoadGraphFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLoadGraphFile.Click

        '   load the data points from a file
        Dim filePath As String

        Dim MyResult As System.Windows.Forms.DialogResult

        MyResult = OpenGraphFileDialog.ShowDialog()
        If MyResult = DialogResult.Cancel Then
            GoTo DoNothing
        End If

        filePath = OpenGraphFileDialog.FileName
        g_GraphFilePath = filePath
        txtGraphFilePath.Text = g_GraphFilePath
        Call ParseGraphData(filePath)
        Call CalculateGraphData()
        g_GraphLoaded = True
        Me.graphBox.Invalidate()
        Exit Sub
DoNothing:

        g_GraphLoaded = False
    End Sub

    'Demonstration of the OPEN command to CRY6181
    Private Sub cmdOpenSequence_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOpenSequence.Click
        '   the above local variables are needed to communicate with the
        '   lab view virtual instrument
        If Not lvVI Is Nothing Then
            '   set the parameter values for an Open
            '   only care about setting the Command parameter
            paramValues(0) = "open " & txtSequencePath.Text
            paramValues(1) = False
            paramValues(2) = False
            paramValues(3) = 0.0#
            paramValues(4) = ""
            paramValues(5) = ""
            paramValues(6) = ""
            paramValues(7) = ""
            Call DoIndicator("Opening Sequence", "Waiting...", True)
            '   push the names and values into the virtual instrument
            Try
                lvVI.Call(paramNames, paramValues)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
            End Try

            '   check the Success? parameter
            If (paramValues(1) = True) Then
                Call DoIndicator("Opening Sequence", "Success", False)
                Call ParseTableString2(paramValues(4))
                cmdRunSequence.Enabled = True
                cmdGetCurveNames.Enabled = True 'Enabled to see input curves
            Else
                Call DoIndicator("Opening Sequence", "FAILED", False)
            End If
        End If
    End Sub

    Private Sub ClearTable()
        lvwTable.Items.Clear()
    End Sub

    Private Sub ParseTableString2(ByRef inTableString As Object)
        Dim tabString As String
        Dim lfString As String
        Dim crString As String
        Dim crlfString As String
        Dim strLength As Integer
        Dim Index As Integer
        Dim testString As String
        Dim dataList As New ArrayList
        Dim dataString As String
        Dim dataStart As Integer
        Dim dataEnd As Integer
        Dim dataIndex As Integer
        Dim numberColumns As Integer
        Dim columnCount As Integer
        Dim dataSize As Integer
        Dim dataIndex2 As Integer
        Dim columnIndex As Integer
        Dim tableRecord As System.Windows.Forms.ListViewItem
        '
        '   parse the data that comes in by string into the table
        '

        Call ClearTable()

        numberColumns = CountColumns(inTableString)

        strLength = Len(inTableString)
        lfString = vbLf
        crString = vbCr
        crlfString = vbCrLf
        tabString = vbTab

        Index = 1
        dataStart = 0
        dataEnd = 0
        dataIndex = 0
        columnCount = 0
        '   find all the strings
        '   this is the brute-force method; it may be easier to
        '   parse the strings using the 'Split' function, as done
        '   in ParseCurveNames
        '   the answer is left to the student as an exercise
        Do Until Index > strLength
            testString = Mid(inTableString, Index, 1)
            If (testString = tabString) Then
                '   we've found a value
                dataIndex = dataIndex + 1
                dataEnd = Index
                If (dataStart > 0) Then
                    dataString = Mid(inTableString, dataStart, dataEnd - dataStart)
                Else
                    dataString = ""
                End If

                dataList.Add(dataString)
                columnCount = columnCount + 1
                dataStart = 0
            ElseIf (testString = lfString) Or (testString = crString) Or (testString = crlfString) Then
                '   we're at the end of a line
                dataIndex = dataIndex + 1
                dataEnd = Index
                If (dataStart > 0) Then
                    dataString = Mid(inTableString, dataStart, dataEnd - dataStart)
                Else
                    dataString = ""
                End If
                '   check to see if we have already added values
                '   if not, we're just getting a blank line
                '   and we shouldn't add anything
                '   (see ParseRunString, because it does the same thing)
                '   (this of course implies it should be a subroutine, used by both)
                '   (which is left to the student as an exercise)
                If (columnCount > 0) Then
                    dataList.Add(dataString)
                    columnCount = columnCount + 1
                    Do Until columnCount = numberColumns '   just in case we didn't get all the columns
                        dataString = ""
                        dataIndex = dataIndex + 1
                        dataList.Add(dataString)
                        columnCount = columnCount + 1
                    Loop
                End If
                dataStart = 0
                columnCount = 0
            Else
                If (dataStart = 0) Then
                    dataStart = Index
                End If
            End If
            Index = Index + 1
        Loop

        dataSize = dataList.Count()
        dataIndex2 = 0
        columnIndex = 0
        '   fill the table
        Do Until dataIndex2 >= dataSize
            If columnIndex = 0 Then
                dataString = dataList.Item(dataIndex2).ToString
                tableRecord = lvwTable.Items.Add(dataString)
            Else
                dataString = dataList.Item(dataIndex2).ToString
                If tableRecord.SubItems.Count > columnIndex Then
                    tableRecord.SubItems(columnIndex).Text = dataString
                Else
                    tableRecord.SubItems.Insert(columnIndex, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dataString))
                End If
            End If
            dataIndex2 = dataIndex2 + 1
            columnIndex = columnIndex + 1
            If (columnIndex >= numberColumns) Then
                columnIndex = 0
            End If

        Loop
    End Sub

    Private Function CountColumns(ByRef inTableString As Object) As Integer
        Dim stringLength As Integer
        Dim Index As Integer
        Dim finished As Boolean
        Dim character As String
        Dim asciiValue As Integer
        '
        '   count the number of columns in the table string
        '
        CountColumns = 1
        Index = 1
        finished = False
        stringLength = Len(inTableString)
        Do Until (finished = True) Or (Index > stringLength)
            character = Mid(inTableString, Index, 1)
            asciiValue = Asc(character)
            If character = vbTab Then
                CountColumns = CountColumns + 1
            ElseIf character = vbCr Then
                finished = True
            ElseIf character = vbLf Then
                finished = True
            ElseIf character = vbCrLf Then
                finished = True
            End If
            Index = Index + 1
        Loop
    End Function

    Private Sub InitializeTable()
        '
        '   initialize the table
        '
        If (lvwTable.Columns.Count = 0) Then
            lvwTable.Columns.Add("Out")
            lvwTable.Columns.Add("In")
            lvwTable.Columns.Add("Cat")
            lvwTable.Columns.Add("", "Step", CInt(VB6.TwipsToPixelsX(1800)))
            lvwTable.Columns.Add("Pass/Fail")
            lvwTable.Columns.Add("Margin")
            lvwTable.Columns.Add("Limits")
        End If
    End Sub

    Private Sub ParseRunString(ByRef inGraphString As Object)
        '   use vbLf for <LF>
        '   use vbTab for <TAB>
        Dim numberColumns As Integer
        Dim tableItem As System.Windows.Forms.ListViewItem
        Dim numberRows As Integer
        Dim rowIndex As Integer
        Dim dataList As New ArrayList
        Dim strLength As Integer
        Dim lfString As String
        Dim crString As String
        Dim tabString As String
        Dim crlfString As String
        Dim Index As Integer
        Dim dataStart As Integer
        Dim dataEnd As Integer
        Dim dataIndex As Integer
        Dim columnCount As Integer
        Dim testString As String
        Dim dataString As String
        Dim itemIndex As Integer
        '
        '   parse the data to be entered into the table
        '
        numberRows = lvwTable.Items.Count
        numberColumns = CountColumns(inGraphString)

        lfString = vbLf
        crString = vbCr
        crlfString = vbCrLf
        tabString = vbTab

        Index = 1
        dataStart = 0
        dataEnd = 0
        dataIndex = 0
        columnCount = 0
        strLength = Len(inGraphString)

        Do Until Index > strLength
            testString = Mid(inGraphString, Index, 1)
            If (testString = tabString) Then
                dataIndex = dataIndex + 1
                dataEnd = Index
                If (dataStart > 0) Then
                    dataString = Mid(inGraphString, dataStart, dataEnd - dataStart)
                Else
                    dataString = ""
                End If

                dataList.Add(dataString)
                columnCount = columnCount + 1
                dataStart = 0
            ElseIf (testString = lfString) Or (testString = crString) Or (testString = crlfString) Then
                dataIndex = dataIndex + 1
                dataEnd = Index
                If (dataStart > 0) Then
                    dataString = Mid(inGraphString, dataStart, dataEnd - dataStart)
                Else
                    dataString = ""
                End If
                '
                '   add extra columns if we've already added one, otherwise don't add at all
                '   (see ParseTableString2 for details)
                '
                If (columnCount > 0) Then
                    dataList.Add(dataString)
                    columnCount = columnCount + 1

                    Do Until columnCount = numberColumns
                        dataString = ""
                        dataIndex = dataIndex + 1
                        dataList.Add(dataString)
                        columnCount = columnCount + 1
                    Loop
                End If
                dataStart = 0
                columnCount = 0
            Else
                If (dataStart = 0) Then
                    dataStart = Index
                End If
            End If
            Index = Index + 1
        Loop

        rowIndex = 0
        itemIndex = 0
        '   for each row in the table, parse the row string and put the items into the table
        Do Until rowIndex >= numberRows
            tableItem = lvwTable.Items.Item(rowIndex)
            If Not tableItem Is Nothing Then
                If (itemIndex <= dataList.Count()) Then
                    testString = dataList.Item(itemIndex).ToString
                Else
                    testString = ""
                End If
                If tableItem.SubItems.Count > 4 Then
                    tableItem.SubItems(4).Text = testString
                Else
                    tableItem.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, testString))
                End If '   pass/fail
                If (itemIndex + 1 <= dataList.Count()) Then
                    testString = dataList.Item(itemIndex + 1).ToString
                Else
                    testString = ""
                End If
                If tableItem.SubItems.Count > 5 Then
                    tableItem.SubItems(5).Text = testString
                Else
                    tableItem.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, testString))
                End If '   margin
                If (itemIndex + 2 <= dataList.Count()) Then
                    testString = dataList.Item(itemIndex + 2).ToString
                Else
                    testString = ""
                End If
                If tableItem.SubItems.Count > 6 Then
                    tableItem.SubItems(6).Text = testString
                Else
                    tableItem.SubItems.Insert(6, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, testString))
                End If '   limits
            End If
            itemIndex = itemIndex + 3
            rowIndex = rowIndex + 1
        Loop
    End Sub

    Private Sub cmdQuit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdQuit.Click
        '   set the timer to go off while writing, so that
        '   the write buffer doesn't get caught by the application ending before
        '   it's finished writing to disk
        QuitWaitTimer.Enabled = True
        '   write the configuration data
        Call WriteConfigData()

    End Sub

    Private Sub cmdRunSequence_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRunSequence.Click
        If Not lvVI Is Nothing Then
            '   only care about setting the Command parameter
            paramValues(0) = "run"
            paramValues(1) = False
            paramValues(2) = False
            paramValues(3) = 0.0#
            paramValues(4) = ""
            paramValues(5) = ""
            paramValues(6) = ""
            paramValues(7) = ""
            '   hide the indicators
            lblPassFail.Visible = False
            lblMargin.Visible = False
            Call DoIndicator("Running Sequence", "Waiting...", True)
            '   make the call
            Try
                lvVI.Call(paramNames, paramValues)
            Catch ex As System.Runtime.InteropServices.COMException
                Call DoIndicator("Call to CRY6181", "FAILED", True)
                GoTo DoNothing
            End Try


            '   call will return after sequence has completed
            '   however long that takes.....
            '   check the Success? parameter
            cmdGetCurveNames.Enabled = True '   enable the get curves regardless of result
            If (paramValues(1) = True) Then
                If (paramValues(2) = True) Then
                    lblPassFail.Text = "PASSED"
                Else
                    lblPassFail.Text = "FAILED"
                End If
                lblPassFail.Visible = True
                'Is this a double?
                lblMargin.Text = paramValues(3)
                lblMargin.Visible = True
                Call ParseRunString(paramValues(4))
                Call DoIndicator("Running Sequence", "Success!", False)
            Else
                Call DoIndicator("Running Sequence", "FAILED", False)
            End If
            If (g_AutoLoadActiveX = True) Then
                '   we need to get the data from the ActiveX component and then graph it
                Call LoadGraphCurves()
            Else
                If (g_AutoLoadFile = True) Then
                    If (Len(g_GraphFilePath) > 0) Then
                        Try
                            Call ParseGraphData(g_GraphFilePath)
                            g_GraphLoaded = True
                            Me.graphBox.Invalidate()
                        Catch ex As System.Runtime.InteropServices.COMException
                            Call DoIndicator("ParseGraphData", "FAILED", True)
                            GoTo DoNothing
                        End Try
                        Exit Sub
DoNothing:
                        g_GraphLoaded = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmdRunCRY6181_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRunCRY6181.Click
        Dim lvPath As String
        Dim Msg As Object

        On Error Resume Next ' Defer error handling.
        Err.Clear()
        Dim cmdString As String
        Dim optHidden As String = " -h"
        Dim optMinimized As String = " -m"
        Dim optHideStatus As String = " -s"
        Dim iApp As Integer
        Dim info As CRYAppInfo

        Call DoIndicator("Launching CRY6181", "Waiting.....", True)

        '  Use the Shell to lauch SC with options
        iApp = cmbVersion.SelectedIndex + 1
        info = g_AppList.Item(iApp)
        cmdString = info.ExePath

        If (g_RunCRY6181Hidden = True) Then
            cmdString = cmdString + optHidden
        End If
        If (g_RunCRY6181Minimized = True) Then
            cmdString = cmdString + optMinimized
        End If
        '   If (g_HideCRY6181StatusW = True) Then
        '       cmdString = cmdString + optHideStatus
        '   End If

        Shell(cmdString)
        '  This is not the ideal way to launch CRY6181, because subsequent ActiveX calls
        '  require CreateObject(), and if this instance has not been properly initialized,
        '  a new process would be created.  In this case we will delay the instantiation
        '  of the COM object with a timer which will enable the Run Sequence button, the next step in the chain.
        SCRunWaitTimer.Enabled = True

        Call DoIndicator("Launching CRY6181", "..... launched", True)

        '   enable some things
        cmdBrowseOpen.Enabled = True
        cmdConfig.Enabled = True
        cmdExitCRY6181.Enabled = True
        'cmdLoadGraphFile.Enabled = True
        'cmdLoadPath.Enabled = True
        'cmdOpenSequence.Enabled = True
        cmdSetLotNumber.Enabled = True
        cmdSetSerialNumber.Enabled = True
        '   disable some things
        cmdRunCRY6181.Enabled = False
    End Sub

    Private Sub PostCRY6181Execute()
        Dim lvPath As String
        Dim Msg As Object
        SCRunWaitTimer.Enabled = False
        '   this code executes as a result of the SCRunWaitTimer object finishing

        '   note: before you can successfully CreateObject to the Labview application,
        '   you need to enable the Labview ActiveX resources.  In VB 2008,
        '   go to Project:Add Reference, find the CRY6181 Type Library with specific version,
        '   and check it off.


        '   initialize the labview connection
        Dim iApp As Integer
        Dim info As CRYAppInfo
        Dim COMString As String

        iApp = cmbVersion.SelectedIndex + 1
        info = g_AppList.Item(iApp)
        COMString = info.COMString

        lvApp = CreateObject(COMString)
        '   if CreateObject fails, lvApp will be set to NOTHING
        If Not (lvApp Is Nothing) Then
            '   set up the path to the virtual instrument
            lvPath = "CRYControlCRY6181.vi"
            '   initialize the labview virtual instrument
            lvVI = lvApp.GetVIReference(lvPath)
            '   if GetVIReference fails, lvVI will be set to NOTHING
            '   but we won't check for that here....

            '   set the parameter names as globals, since they never change
            paramNames(0) = "Command"
            paramNames(1) = "Success?"
            paramNames(2) = "Pass?"
            paramNames(3) = "Margin"
            paramNames(4) = "Table"
            paramNames(5) = "Xdatapoints"
            paramNames(6) = "Ydatapoints"
            paramNames(7) = "Zdatapoints"
        Else
            Msg = "Error encountered during launch of " & COMString & Chr(13) & "CreateObject() failed to obtain handle for SC App"
            MsgBox(Msg, , "Error")

        End If
        Call DoIndicator("Launching CRY6181", "Success!", True)
        cmdOpenSequence.Enabled = True
    End Sub

    Private Sub DoIndicator(ByRef inCommand As String, ByRef inStatus As String, ByRef inTimerEnabled As Boolean)
        lblCommand.Text = inCommand
        lblCommand.Refresh()
        lblStatus.Text = inStatus
        lblStatus.Refresh()
    End Sub

    Private Sub cmdSetLotNumber_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSetLotNumber.Click
        If Not lvVI Is Nothing Then
            '   only care about setting the Command parameter
            paramValues(0) = "lot " & txtLotNumber.Text
            paramValues(1) = False
            paramValues(2) = False
            paramValues(3) = 0.0#
            paramValues(4) = ""
            paramValues(5) = ""
            paramValues(6) = ""
            paramValues(7) = ""
            Call DoIndicator("Setting Lot", "Waiting...", True)
            Try
                lvVI.Call(paramNames, paramValues)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
            End Try

            '   check the Success? parameter
            If (paramValues(1) = True) Then
                Call DoIndicator("Setting Lot", "Success!", False)
            Else
                Call DoIndicator("Setting Lot", "FAILED", False)
            End If
        End If
    End Sub

    Private Sub cmdSetSerialNumber_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSetSerialNumber.Click
        If Not lvVI Is Nothing Then
            '   only care about setting the Command parameter
            paramValues(0) = "serial " & txtSerialNumber.Text
            paramValues(1) = False
            paramValues(2) = False
            paramValues(3) = 0.0#
            paramValues(4) = ""
            paramValues(5) = ""
            paramValues(6) = ""
            paramValues(7) = ""
            Call DoIndicator("Setting Serial", "Waiting...", True)
            Try
                lvVI.Call(paramNames, paramValues)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
            End Try

            '   check the Success? parameter
            If (paramValues(1) = True) Then
                Call DoIndicator("Setting Serial", "Success!", False)
            Else
                Call DoIndicator("SettingSerial", "FAILED", False)
            End If
        End If
    End Sub

    Private Sub detectVersions()
        Dim regVersion As RegistryKey
        Dim keyValue As String
        Dim subkeyValue As String
        Dim names() As String
        Dim strVersion As String
        Dim strPath As String
        Dim strExe As String
        Dim strMajMin As String
        Dim valueString() As String

        ' Retrieve all the subkeys for the specified key. 
        keyValue = "SOFTWARE\CRY6181"
        regVersion = Registry.LocalMachine.OpenSubKey(keyValue, False)
        names = regVersion.GetSubKeyNames()

        If (g_AppList Is Nothing) Then
            g_AppList = New Collection
        End If

        For Each strMajMin In names
            subkeyValue = keyValue + "\" + strMajMin
            regVersion = Registry.LocalMachine.OpenSubKey(subkeyValue, False)
            If (Not regVersion Is Nothing) Then
                strVersion = regVersion.GetValue("Version", 0)
                strPath = regVersion.GetValue("", 0)
                strExe = "CRY6181 " + strMajMin + ".exe"
                cmbVersion.Items.Add("CRY6181 " + strVersion)
                Dim info As CRYAppInfo = New CRYAppInfo()
                info.Version = strVersion
                info.ExePath = strPath + "\" + strExe
                valueString = Split(strMajMin, ".")
                info.COMString = "CRY6181" + valueString(0) + valueString(1) + ".Application"
                g_AppList.Add(info)
                regVersion.Close()
            End If
        Next strMajMin
        cmbVersion.SelectedIndex = cmbVersion.Items.Count - 1
        cmbVersion.Update()
    End Sub

    Private Sub CRY_Form_Initialize()
        '   initialize certain items
        Call detectVersions()
        SCRunWaitTimer.Enabled = False '   disable the output write timer
        g_CRY6181Success = False
        g_CRY6181Iteration = 0
        cmdGetCurveNames.Enabled = False
        cmdBrowseOpen.Enabled = True
        cmdConfig.Enabled = False
        cmdExitCRY6181.Enabled = False
        'cmdLoadGraphFile.Enabled = False
        'cmdLoadPath.Enabled = False
        cmdOpenSequence.Enabled = False
        cmdRunSequence.Enabled = False
        cmdSetLotNumber.Enabled = False
        cmdSetSerialNumber.Enabled = False
        Call checkRunOptions()
        g_DisableClick = False
        g_AutoLoadFile = False
        max_NumberCurves = 8
        g_numberCurves = 0
        g_curveColors(0) = Color.Coral
        g_curveColors(1) = Color.SteelBlue
        g_curveColors(2) = Color.Gold
        g_curveColors(3) = Color.MediumAquamarine
        g_curveColors(4) = Color.Firebrick
        g_curveColors(5) = Color.Gray
        g_curveColors(6) = Color.BlueViolet
        g_curveColors(7) = Color.DeepPink
        Dim colorIndex As Integer
        For colorIndex = 0 To (max_NumberCurves - 1)
            g_curvePens(colorIndex) = New Pen(g_curveColors(colorIndex))
        Next colorIndex
        g_GraphLoaded = False
        cmdConfig.Enabled = True
        color_Orange = &H70FF
        color_Purple = &HFF0080
        color_Pale_Green = &HFBFFFC
        color_Dk_Pale_Green = &H9EB3A3
        str_xdata = "x data"
        str_Tab = vbTab
        str_LF = vbLf
        str_CRLF = vbCrLf
        str_CR = vbCr
        str_Period = "."
        g_AutoLoadActiveX = False
        g_XAxisTick = 100
        g_YAxisTick = 100
        g_XAxisMax = 1000
        g_XAxisMin = 0
        g_YAxisMax = 500
        g_YAxisMin = 0
        g_XAxisTickD = 100.0#
        g_YAxisTickD = 100.0#
        g_XAxisMaxD = 1000.0#
        g_XAxisMinD = 0.0#
        g_YAxisMaxD = 500.0#
        g_YAxisMinD = 0.0#
        g_XAxisWidth = g_XAxisMax - g_XAxisMin
        g_YAxisHeight = g_YAxisMax - g_YAxisMin
        g_XAxisLabel = "X-Axis"
        g_YAxisLabel = "Y-Axis"
        g_HalfTickLength = 5
        st_Linear = 1
        st_Log = 2
        g_XScaleType = st_Linear
        g_YScaleType = st_Linear
        g_GraphConfigured = False
        g_LogScaleFactor = 1.0#
        g_XWorldWidth = Me.graphBox.Width
        g_YWorldHeight = Me.graphBox.Height
    End Sub

    Private Sub frmExample_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        '   initialize the form when it loads
        Dim currentDirectory As String

        currentDirectory = CurDir()
        g_ConfigFilePath = currentDirectory & "\scconfg.txt"
        ' TODO Consider RaiseEvent to force paint
        'Call SetDefaultLegend()
        Call InitializeTable()
        Call ReadConfigData()
    End Sub

    Private Sub SetDefaultLegend_Paint(ByVal sender As Object, ByVal e As _
    System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        '   set the legend text and color squares to their default assignments
        Dim Index As Integer

        g_curveLabels(0) = lblCurve1
        g_curveLabels(1) = lblCurve2
        g_curveLabels(2) = lblCurve3
        g_curveLabels(3) = lblCurve4
        g_curveLabels(4) = lblCurve5
        g_curveLabels(5) = lblCurve6
        g_curveLabels(6) = lblCurve7
        g_curveLabels(7) = lblCurve8

        g_curvePics(0) = picColor1
        g_curvePics(1) = picColor2
        g_curvePics(2) = picColor3
        g_curvePics(3) = picColor4
        g_curvePics(4) = picColor5
        g_curvePics(5) = picColor6
        g_curvePics(6) = picColor7
        g_curvePics(7) = picColor8

        For Index = 0 To 7
            g_curvePics(Index).BackColor = g_curveColors(Index)
            g_curvePics(Index).Invalidate()
            'g_curveLabels(Index).Visible = False
            'g_curvePics(Index).Visible = False
        Next Index

    End Sub

    Private Sub frmExample_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        Call WriteConfigData()
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub frmExample_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call WriteConfigData()
    End Sub

    Private Sub SCRunWaitTimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SCRunWaitTimer.Tick
        '   end the timer
        SCRunWaitTimer.Enabled = False
        Call PostCRY6181Execute()
    End Sub

    Private Sub txtGraphFilePath_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGraphFilePath.Click
        If (g_DisableClick = True) Then
            txtGraphFilePath.Text = ""
        End If
    End Sub

    Private Sub txtGraphFilePath_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtGraphFilePath.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        g_GraphFilePath = txtGraphFilePath.Text
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLotNumber_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLotNumber.Click
        If (g_DisableClick = True) Then
            txtLotNumber.Text = ""
        End If
    End Sub

    Private Sub txtSequencePath_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSequencePath.Click
        If (g_DisableClick = True) Then
            txtSequencePath.Text = ""
        End If
    End Sub

    Private Sub txtSequencePath_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSequencePath.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        g_OpenSequencePath = txtSequencePath.Text
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtSerialNumber_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSerialNumber.Click
        If (g_DisableClick = True) Then
            txtSerialNumber.Text = ""
        End If
    End Sub

    ' Parse metadata of a curve.  This data is returned as a String delimited by LF and Tabs as the
    ' 5th element in the parameter array.  The order is as follows:
    ' N points	<number_of_points>
    ' X data	<"lin" or "dB">
    ' Y data	<"lin" or "dB">
    ' Z data	<"lin" or "dB">
    ' X axis	<"lin" or "log">
    ' Y axis	<"lin" or "log">
    ' Z axis	<"lin" or "log">
    ' X unit	<unit>
    ' Y unit	<unit>
    ' Z unit	<unit>
    ' X dB ref	<float or scientific notation>
    ' Y dB ref	<float or scientific notation>
    ' Z dB ref	<float or scientific notation>
    ' single val?	<"True" or "False">
    ' In this demo only the scale types and units are used to render the curve
    Private Sub ParseMeta(ByRef metaString As Object, ByRef curve As DataPointList)
        Dim dataStrings() As String
        Dim metaEntry() As String
        Dim Index As Integer
        dataStrings = Split(metaString, vbLf)
        For Index = LBound(dataStrings) To UBound(dataStrings)
            metaEntry = Split(dataStrings(Index), vbTab)
            If (InStr(1, metaEntry(0), "X axis")) Then
                If (InStr(1, metaEntry(1), "log")) Then
                    curve.XScaleType = st_Log
                Else
                    curve.XScaleType = st_Linear
                End If
            ElseIf (InStr(1, metaEntry(0), "Y axis")) Then
                If (InStr(1, metaEntry(1), "log")) Then
                    curve.YScaleType = st_Log
                Else
                    curve.YScaleType = st_Linear
                End If
            ElseIf (InStr(1, metaEntry(0), "X unit")) Then
                curve.XUnit = metaEntry(1)
            ElseIf (InStr(1, metaEntry(0), "Y unit")) Then
                curve.YUnit = metaEntry(1)
            End If
        Next Index
    End Sub

    Private Sub ParseCurveNames(ByRef inCurveNames As Object, ByRef outCurveCollection As Collection)
        Dim lfString As String
        Dim crString As String
        Dim crlfString As String
        Dim tabString As String
        Dim Index As Integer
        Dim nameString As String

        Dim nameStrings1() As String
        Dim nameStrings2() As String
        '
        '   get the curve names from the cr-lf delimited string returned from the ActiveX control
        '

        lfString = vbLf
        crString = vbCr
        crlfString = vbCrLf
        tabString = vbTab
        '
        '   split by cr-lf as well as lf, and
        '   see which one has data
        '
        nameStrings1 = Split(inCurveNames, crlfString)
        nameStrings2 = Split(inCurveNames, lfString)
        If (UBound(nameStrings2) > UBound(nameStrings1)) Then
            For Index = LBound(nameStrings2) To UBound(nameStrings2)
                nameString = nameStrings2(Index)
                If (Len(nameString) > 0) Then
                    outCurveCollection.Add(nameString)
                End If
            Next Index
        Else
            For Index = LBound(nameStrings1) To UBound(nameStrings1)
                nameString = nameStrings1(Index)
                If (Len(nameString) > 0) Then
                    outCurveCollection.Add(nameString)
                End If
            Next Index
        End If
    End Sub

    Private Sub LoadGraphCurves()
        Dim curveName As String
        Dim savedData As DataPointList
        Dim numberCurves As Integer
        Dim curveIndex As Integer
        Dim N As Integer
        Dim numberPoints As Integer

        '
        '   load the selected curves from the ActiveX control
        '
        g_curveNames = Nothing
        g_curveNames = New Collection
        numberCurves = g_SelectedCurves.Count()
        For N = 1 To numberCurves
            curveName = g_SelectedCurves.Item(N)
            g_curveNames.Add(curveName)
        Next N
        curveIndex = 1
        Do Until curveIndex > numberCurves
            curveName = g_SelectedCurves.Item(curveIndex).ToString
            If (Len(curveName) > 0) Then
                If (curveIndex <= max_NumberCurves) Then
                    '   call the GetCurveStringK routine (a misnomer)
                    '   to get the DataPointList of points
                    savedData = GetCurveStringK(curveName)
                    If Not (savedData Is Nothing) Then
                        numberPoints = savedData.Count
                        If (numberPoints > 0) Then
                            g_curveData(curveIndex) = New DataPointList
                            savedData.Copy(g_curveData(curveIndex))
                        End If
                    Else
                        g_curveData(curveIndex) = Nothing
                    End If
                End If
            End If
            curveIndex = curveIndex + 1
        Loop
        g_numberCurves = numberCurves
    End Sub

    Private Function GetCurveStringK(ByRef inName As String) As DataPointList
        '   acquire the data points as arrays of floating-point
        '   values, stuff them into a DataPointList
        '   and return
        Dim curveStringK As DataPointList
        Dim done As Boolean
        Dim xValues() As Double
        Dim yValues() As Double
        Dim zValues() As Double
        Dim valueIndex As Integer

        curveStringK = Nothing
        If (Len(inName) > 0) Then
            curveStringK = New DataPointList
            If Not (curveStringK Is Nothing) Then
                If Not (lvVI Is Nothing) Then
                    paramValues(0) = "curve " & inName
                    paramValues(1) = False
                    paramValues(2) = False
                    paramValues(3) = 0.0#
                    paramValues(4) = ""
                    paramValues(5) = VB6.CopyArray(xValues)
                    paramValues(6) = VB6.CopyArray(yValues)
                    paramValues(7) = VB6.CopyArray(zValues)
                    Try
                        lvVI.Call(paramNames, paramValues)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
                    End Try

                    If (paramValues(1) = True) Then
                        '   read the scale (log or linear) and units
                        ParseMeta(paramValues(4), curveStringK)
                        '
                        '   the curves come across as arrays of Double
                        '
                        xValues = paramValues(5)
                        yValues = paramValues(6)
                        zValues = paramValues(7)
                        '   for each data point pair, add it to the curve
                        For valueIndex = LBound(xValues) To UBound(xValues)
                            curveStringK.Add(xValues(valueIndex), yValues(valueIndex))
                        Next valueIndex
                    Else
                        '   wait state code
                        '   need to wait for CRY6181 to be ready
                        '   each lvVI.Call operation will cause CRY6181 internally to wait for 1/10 second
                        '   that gives LabView's internal operations a chance to ready themselves
                        g_CRY6181Success = False
                        g_CRY6181Iteration = 0
                        '   loop for 10 increments
                        '   or until the data has returned
                        done = False
                        Do Until done = True
                            paramValues(0) = "curve " & inName
                            paramValues(1) = False
                            paramValues(2) = False
                            paramValues(3) = 0.0#
                            paramValues(4) = ""
                            paramValues(5) = VB6.CopyArray(xValues)
                            paramValues(6) = VB6.CopyArray(yValues)
                            paramValues(7) = VB6.CopyArray(zValues)
                            Try
                                lvVI.Call(paramNames, paramValues)
                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception during Call to CRY6181.exe")
                            End Try
                            If (paramValues(1) = True) Then
                                xValues = paramValues(5)
                                yValues = paramValues(6)
                                zValues = paramValues(7)
                                For valueIndex = LBound(xValues) To UBound(xValues)
                                    curveStringK.Add(xValues(valueIndex), yValues(valueIndex))
                                Next valueIndex
                                g_CRY6181Success = True
                                done = True
                            Else
                                g_CRY6181Iteration = g_CRY6181Iteration + 1
                                If (g_CRY6181Iteration > 10) Then
                                    g_CRY6181Success = False
                                    MsgBox("CRY6181 Not Ready On Curve: " & inName)
                                    done = True
                                End If
                            End If
                        Loop
                    End If
                End If
            End If
        End If
        GetCurveStringK = curveStringK
    End Function


    Private Sub ParseGraphData(ByRef inPathName As String)
        '   read in graph data (arrays of data values) from file
        '   The file is generated in CRY6181 by saving a curve with these parameters:
        '   - TXT file
        '   - Column format
        '   - Standard header
        '   - Comment (optional)
        '   Data actually begins on line 1 (without comment) or line 2 (with comment)
        '   Data can be found in 2nd and 3rd columns
        '   Header info is found on 1st column
        '   Pattern repeats for n curves
        '   Tab delimited between <> pairs
        '   <Comment line - optional>
        '   <Curve name1><x1><y1>...<Curve namen><xn><yn>
        '   <empty line>
        '   "x data" <value type1 - "lin" for linear progression, "dB" for decibel progression><x1><y1>..."x data"<value typen><xn><yn>
        '   "y data" <value type1>...
        '   "z data" <value type1>...
        '   <empty line>
        '   "x axis" <axis type1 - "lin" for linear scale, "log" for logarithmic scale>...
        '   "y axis" <axis type1>...
        '   "z axis" <axis type1>...
        '   <empty line>
        '   <x unit><x1><y1>...<x unitn><xn><yn>
        '   <y unit>...
        '   <z unit>...
        '
        '   Here, z-axis is not used

        Dim inputLine As String
        Dim fileNumber As Integer
        Dim lineCollection As Collection
        Dim numberLines As Integer
        Dim lineIndex As Integer
        Dim lineString As String
        Dim unitString As String
        Dim unitX As String
        Dim unitY As String
        Dim currentLine As String
        Dim trimLine As String

        Dim vIndex As Integer
        Dim N As Integer

        Dim xValue As Double
        Dim yValue As Double

        Dim valueStrings() As String

        Dim position As Integer
        Dim pos2 As Integer

        Dim haveXValueString As Boolean
        Dim haveYValueString As Boolean
        Dim hasComment As Boolean

        fileNumber = FreeFile()
        lineCollection = New Collection

        FileOpen(fileNumber, inPathName, OpenMode.Input)
        Do Until EOF(fileNumber)
            inputLine = LineInput(fileNumber)
            lineCollection.Add(inputLine)
        Loop
        FileClose(fileNumber)
        numberLines = lineCollection.Count()
        lineIndex = 1

        ' Is x-data on 4th line?
        position = InStr(lineCollection.Item(4), str_xdata)
        If (position > 0) Then
            hasComment = True '   comment is line 1, curve name on line 2
            lineIndex = 2
        Else
            position = InStr(lineCollection.Item(3), str_xdata)
            If (position > 0) Then
                hasComment = False  '   comment is absent, curve name on line 1
            Else
                lineIndex = 0
                MsgBox("Cannot find header info - File Load Aborted.")
            End If
        End If
        g_curveNames = Nothing
        g_curveNames = New Collection
        If (lineIndex > 0) Then
            If (hasComment) Then
                lineString = lineCollection.Item(2)
            Else
                lineString = lineCollection.Item(1)
            End If
            '   parse lineString for curve names
            Call GetCurveNames(lineString, g_curveNames)
        End If
        ' Parse scale types - use the first curve's.  To do - warn about incompatible scales
        If (hasComment) Then
            lineString = lineCollection.Item(8) ' x axis
            unitString = lineCollection.Item(12) ' x unit
        Else
            lineString = lineCollection.Item(7)
            unitString = lineCollection.Item(11) ' x unit
        End If
        position = InStr(lineString, "x axis")
        If (position > 0) Then
            pos2 = InStr(lineString, "lin")
            If (pos2 > 0) Then
                g_XScaleType = st_Linear
            Else
                g_XScaleType = st_Log
            End If
        Else
            MsgBox("Cannot determine X scale type")
        End If
        valueStrings = Split(unitString, str_Tab)
        unitX = valueStrings(0)

        If (hasComment) Then
            lineString = lineCollection.Item(9) ' y axis
            unitString = lineCollection.Item(13) ' y unit
        Else
            lineString = lineCollection.Item(8)
            unitString = lineCollection.Item(12) ' y unit
        End If
        position = InStr(lineString, "y axis")
        If (position > 0) Then
            pos2 = InStr(lineString, "lin")
            If (pos2 > 0) Then
                g_YScaleType = st_Linear
            Else
                g_YScaleType = st_Log
            End If
        Else
            MsgBox("Cannot determine Y scale type")
        End If
        valueStrings = Split(unitString, str_Tab)
        unitY = valueStrings(0)

        g_numberCurves = g_curveNames.Count()
        If (g_numberCurves > max_NumberCurves) Then
            g_numberCurves = max_NumberCurves
        End If
        '   create the needed number of data point sets
        ' g_numberCurves is 1 based, while g_curveData is 0 based
        For N = 1 To (g_numberCurves)
            g_curveData(N) = Nothing
            g_curveData(N) = New DataPointList
            g_curveData(N).Name = g_curveNames.Item(N)
            g_curveData(N).XUnit = unitX
            g_curveData(N).YUnit = unitY
        Next N
        '   parse the data lines
        If (lineIndex > 0) Then
            Do Until lineIndex > numberLines
                currentLine = lineCollection.Item(lineIndex)
                trimLine = Trim(currentLine)
                If (Len(trimLine) > 0) Then
                    valueStrings = Split(trimLine, str_Tab)
                    '   have split the line into N substrings, which should be 3 * numberCurves
                    '   the substring array is 0 to N-1
                    '   we're interested in valueString(1,2).....valueString(3*numberCurves-3, 3*numberCurves-2)
                    For vIndex = 1 To (g_numberCurves)
                        haveXValueString = False
                        haveYValueString = False
                        If (Len(valueStrings(3 * vIndex - 2)) > 0) Then
                            xValue = Val(valueStrings(3 * vIndex - 2)) '   get the X value
                            haveXValueString = True
                        End If
                        If (Len(valueStrings(3 * vIndex - 1)) > 0) Then
                            yValue = Val(valueStrings(3 * vIndex - 1)) '   get the Y value
                            haveYValueString = True
                        End If
                        '   only add if we have both an x-value and a y-value
                        If (haveYValueString = True And haveXValueString = True) Then
                            g_curveData(vIndex).Add(xValue, yValue) '   add to the list of data points (create DataPoint inside)
                        End If
                    Next vIndex
                End If
                lineIndex = lineIndex + 1
            Loop
        End If
        '   we now have all the curves stored as data points
        '   get the metadata about the plots (maxima, minima)
        '   and plot the data
    End Sub

    Private Sub GetCurveNames(ByRef inCurveLine As String, ByRef inCurveNames As Collection)
        '   get the curve names out of the string containing them
        '   (tab-separated)
        Dim splitStrings() As String
        Dim i As Integer

        splitStrings = Split(inCurveLine, str_Tab)
        i = 0
        Do Until i > (splitStrings.Length - 1)
            inCurveNames.Add(splitStrings(i))
            i = i + 3
        Loop
    End Sub

    Private Sub SetGraphScale(ByRef e As _
    System.Windows.Forms.PaintEventArgs)
        '   set the coordinate system
        ' Limits are already converted for Log scale, so treat them as linear
        g_XScrScale = e.Graphics.VisibleClipBounds.Width / g_XWorldWidth

        If g_YWorldHeight <> 0 Then
            g_YScrScale = e.Graphics.VisibleClipBounds.Height / g_YWorldHeight
        Else
            g_YScrScale = 1
        End If

        '   the graphing area scaled to our coordinates: {0,0} = top left, {xW+xT,yH+yT} = bottom right
    End Sub

    Private Sub DrawVerticalTicks(ByRef e As System.Windows.Forms.PaintEventArgs)
        '   draw the tick marks for the x-axis
        Dim numberTicks As Integer
        Dim tickIndex As Integer
        Dim xPoint As Integer
        Dim yLower As Integer
        '   find the tick length that applies to the current scale mode of the graph
        '   so that each tick is 8 pixels high
        'Draw main axis
        Dim majorPen As Pen
        majorPen = New Pen(Color.Gainsboro, 2.0)
        'e.Graphics.DrawLine(majorPen, offsetX * g_XScrScale, 0, offsetX * g_XScrScale, maxY * g_YScrScale)

        If g_XAxisTickD <> 0 Then
            numberTicks = g_XAxisMaxD / g_XAxisTickD
            yLower = g_YWorldHeight * g_YScrScale
            For tickIndex = 1 To numberTicks
                xPoint = (tickIndex * g_XAxisTickD) * g_XScrScale
                e.Graphics.DrawLine(Pens.Gainsboro, xPoint, 0, xPoint, yLower)
            Next tickIndex
        End If        
    End Sub

    Private Sub DrawHorizontalTicks(ByRef e As System.Windows.Forms.PaintEventArgs)
        '   draw the tick marks for the y-axis
        Dim numberTicks As Integer
        Dim tickIndex As Integer
        Dim yPoint As Integer

        'Draw main axis
        Dim majorPen As Pen
        majorPen = New Pen(Color.Gainsboro, 2.0)

        If g_YAxisTickD <> 0 Then
            numberTicks = g_YAxisMaxD / g_YAxisTickD
            For tickIndex = 1 To numberTicks
                yPoint = (g_YAxisOffset - tickIndex * g_YAxisTickD) * g_YScrScale
                e.Graphics.DrawLine(Pens.Gainsboro, 0, yPoint, CSng(g_XWorldWidth * g_XScrScale), yPoint)
            Next tickIndex
        End If
    End Sub

    Private Sub DrawCurves(ByVal sender As Object, ByVal e As _
       System.Windows.Forms.PaintEventArgs) Handles graphBox.Paint
        '   draw all curves from the array
        Dim curveIndex As Integer
        If (g_numberCurves < 1) Then
            Return
        End If
        Call SetGraphScale(e)
        Call ClearAllLegends()
        Call DrawHorizontalTicks(e)
        Call DrawVerticalTicks(e)
        Call DrawAxisLabels(g_curveData(1))
        curveIndex = 1
        Do Until curveIndex > (g_numberCurves)
            Call DrawACurve(curveIndex, e)
            curveIndex = curveIndex + 1
        Loop
    End Sub

    Private Sub DrawACurve(ByRef inCurveIndex As Integer, ByRef e As _
          System.Windows.Forms.PaintEventArgs)
        '   draw a single curve from the array
        Dim aPoint As DataPoint
        Dim curveData As DataPointList
        Dim numberPoints As Integer
        Dim pointIndex As Integer
        Dim xPoint As Single
        Dim yPoint As Single
        Dim testX As Single
        Dim testY As Single
        Dim firstPointSet As Boolean
        Dim goodX As Boolean
        Dim goodY As Boolean
        Dim scaledValue As Double
        Dim currentX As Single
        Dim currentY As Single
        Dim offsetX As Single
        Dim offsetY As Single
        Dim minX As Single
        Dim maxX As Single
        Dim minY As Single
        Dim maxY As Single

        firstPointSet = False
        goodX = True
        goodY = True
        '   get the curve

        curveData = g_curveData(inCurveIndex)
        If Not (curveData Is Nothing) Then '   if curve data is Nothing, then we don't plot
            ' Set the bounds and scale transform
            minX = g_XAxisMinD
            maxX = g_XAxisMinD + g_XWorldWidth
            minY = g_YAxisMinD
            maxY = g_YAxisMinD + g_YWorldHeight
            offsetX = -minX
            offsetY = maxY
            pointIndex = 0
            numberPoints = curveData.Count
            '   cycle for each point
            Do Until pointIndex > (numberPoints - 1)
                aPoint = curveData.Item(pointIndex)
                If Not (aPoint Is Nothing) Then
                    testX = aPoint.X
                    testY = aPoint.Y
                    If (g_XScaleType = st_Linear) Then
                        '   linear
                        goodX = True
                        'xPoint = g_XAxisOffset + CInt(testX) '   the x point is offset from the left side of the box
                        xPoint = offsetX + testX
                    Else
                        '   log
                        '   assume g_XAxisOffset is whatever it needs to be in the appropriate units
                        goodX = GetScaledLogValue(testX, scaledValue)
                        If (goodX = True) Then
                            xPoint = offsetX + scaledValue
                        End If
                    End If
                    If (g_YScaleType = st_Linear) Then
                        '   linear
                        goodY = True
                        yPoint = offsetY - testY '   the y point is offset from the top of the box, but since y values go positive downward, the point value becomes a negative offset from the y-location of the x-axis
                    Else
                        '   log
                        '   assume g_YAxisOffset is whatever it needs to be in the appropriate units
                        goodY = GetScaledLogValue(testY, scaledValue)
                        If (goodY = True) Then
                            yPoint = offsetY - scaledValue
                        End If
                    End If
                    If (pointIndex = 0) Or (firstPointSet = False) Then
                        '   first point in curve
                        '   set starting point
                        '   only if both X and Y values are valid
                        If (goodX = True And goodY = True) Then
                            currentX = xPoint
                            currentY = yPoint
                            firstPointSet = True
                        End If
                    Else
                        '   subsequent points in curve
                        '   draw to next point and reset starting point to it
                        Dim x1, x2, y1, y2 As Single
                        x1 = currentX * g_XScrScale
                        y1 = currentY * g_YScrScale - 1.0
                        x2 = xPoint * g_XScrScale
                        y2 = yPoint * g_YScrScale - 1.0

                        e.Graphics.DrawLine(g_curvePens(inCurveIndex - 1), x1, y1, x2, y2)
                        currentX = xPoint
                        currentY = yPoint
                    End If
                End If
                pointIndex = pointIndex + 1
            Loop
            '   set the curve label and color in the legend
            '   g_curveNames is 1 based
            g_curveLabels(inCurveIndex - 1).Text = g_curveNames.Item(inCurveIndex).ToString
            g_curveLabels(inCurveIndex - 1).Visible = True
            g_curvePics(inCurveIndex - 1).Visible = True
        End If
    End Sub

    Private Sub EnableALegend(ByRef inIndex As Integer)
        '   enable (make visible) a particular legend
        g_curveLabels(inIndex).Visible = True
        g_curvePics(inIndex).Visible = True
        g_curveLabels(inIndex).Text = g_curveNames.Item(inIndex)
    End Sub

    Private Sub ClearAllLegends()
        Dim Index As Integer

        For Index = 0 To 7
            Call ClearALegend(Index)
        Next Index
    End Sub

    Private Sub ClearALegend(ByRef inCurveIndex As Integer)
        '   disable (clear) a particular legend
        g_curveLabels(inCurveIndex).Visible = False
        g_curvePics(inCurveIndex).Visible = False
        g_curveLabels(inCurveIndex).Text = ""
    End Sub

    Private Sub DrawAxisLabels(ByRef curve As DataPointList)
        '   draw the axis labels for the graph
        Dim unlogValue As Double

        lblXAxis.Text = curve.XUnit
        lblYAxis.Text = curve.YUnit
        If (g_XScaleType = st_Linear) Then
            lblXAxisMax.Text = CStr(g_XAxisMaxD)
            lblXAxisMin.Text = CStr(g_XAxisMinD)
        Else
            unlogValue = TenToX(g_XAxisMin)
            lblXAxisMin.Text = CStr(unlogValue)
            unlogValue = TenToX(g_XAxisMax)
            lblXAxisMax.Text = CStr(unlogValue)
        End If
        If (g_YScaleType = st_Linear) Then
            lblYAxisMax.Text = CStr(g_YAxisMaxD)
            lblYAxisMin.Text = CStr(g_YAxisMinD)
        Else
            unlogValue = TenToX(g_YAxisMin)
            lblYAxisMin.Text = CStr(unlogValue)
            unlogValue = TenToX(g_YAxisMax)
            lblYAxisMax.Text = CStr(unlogValue)
        End If
    End Sub

    Private Sub CalculateGraphData()
        '   calculate the default graph data, such as
        '   max and min X, max and min Y, the tick intervals,
        '   the x-axis and y-axis lengths, and the
        '   offsets for drawing the graphs
        Dim xAxisWidth As Integer
        Dim yAxisHeight As Integer

        Dim moron As DataPoint

        Dim dpIndex As Integer

        Dim xAxisMaxD As Double
        Dim yAxisMaxD As Double
        Dim xAxisMinD As Double
        Dim yAxisMinD As Double

        Dim xAxisWidthD As Double
        Dim yAxisHeightD As Double

        Dim xAxisTickD As Double
        Dim yAxisTickD As Double

        Dim xAxisTick As Integer
        Dim yAxisTick As Integer
        Dim scaledValue As Double

        maxDP = New DataPoint
        minDP = New DataPoint
        moron = New DataPoint

        moron = g_curveData(1).Maximum
        maxDP.X = moron.X
        maxDP.Y = moron.Y
        moron = Nothing
        moron = g_curveData(1).Minimum
        minDP.X = moron.X
        minDP.Y = moron.Y
        moron = Nothing
        If g_numberCurves > 8 Then
            g_numberCurves = 8
        End If
        For dpIndex = 2 To (g_numberCurves) 'Loop start from 2nd curve
            moron = g_curveData(dpIndex).Maximum
            If (moron.X > maxDP.X) Then
                maxDP.X = moron.X
            End If
            If (moron.Y > maxDP.Y) Then
                maxDP.Y = moron.Y
            End If
            moron = Nothing
            moron = g_curveData(dpIndex).Minimum
            If (moron.X < minDP.X) Then
                minDP.X = moron.X
            End If
            If (moron.Y < minDP.Y) Then
                minDP.Y = moron.Y
            End If
            moron = Nothing
        Next dpIndex

        '   If we have logarithmic axis, we need to calculate in that space
        If (g_XScaleType = st_Log) Then
            Dim goodX As Boolean = GetScaledLogValue(maxDP.X, scaledValue)
            If (goodX = True) Then
                maxDP.X = scaledValue
            End If
            goodX = GetScaledLogValue(minDP.X, scaledValue)
            If (goodX = True) Then
                minDP.X = scaledValue
            End If
        End If

        If (g_YScaleType = st_Log) Then
            Dim goodY As Boolean = GetScaledLogValue(maxDP.Y, scaledValue)
            If (goodY = True) Then
                maxDP.Y = scaledValue
            End If
            goodY = GetScaledLogValue(minDP.Y, scaledValue)
            If (goodY = True) Then
                minDP.Y = scaledValue
            End If
        End If

        xAxisMaxD = GetAxisMax((maxDP.X))
        yAxisMaxD = GetAxisMax((maxDP.Y))
        xAxisMinD = GetAxisMin((minDP.X))
        yAxisMinD = GetAxisMin((minDP.Y))
        If ((xAxisMinD >= 0.0# And xAxisMinD < 0.000001) Or (xAxisMinD <= 0.0# And xAxisMinD >= -0.000001)) Then
            xAxisMinD = 0.0#
        End If
        If ((yAxisMinD >= 0.0# And yAxisMinD < 0.000001) Or (yAxisMinD <= 0.0# And yAxisMinD >= -0.000001)) Then
            yAxisMinD = 0.0#
        End If
        yAxisHeightD = yAxisMaxD - yAxisMinD
        xAxisWidthD = xAxisMaxD - xAxisMinD

        '       If yAxisHeightD = 0 Then
        'yAxisHeightD = 2
        'End If
        yAxisHeight = CInt(yAxisHeightD)
        xAxisWidth = CInt(xAxisWidthD)
        xAxisTickD = xAxisMaxD / 10.0#
        yAxisTickD = yAxisMaxD / 10.0#
        xAxisTick = CInt(xAxisTickD)
        yAxisTick = CInt(yAxisTickD)

        g_XAxisTick = xAxisTick
        g_YAxisTick = yAxisTick
        g_XAxisTickD = xAxisTickD
        g_YAxisTickD = yAxisTickD
        g_XAxisMax = CInt(xAxisMaxD)
        g_YAxisMax = CInt(yAxisMaxD)
        g_XAxisMin = CInt(xAxisMinD)
        g_YAxisMin = CInt(yAxisMinD)
        g_XAxisMaxD = (xAxisMaxD)
        g_YAxisMaxD = (yAxisMaxD)
        g_XAxisMinD = (xAxisMinD)
        g_YAxisMinD = (yAxisMinD)
        g_XAxisWidth = xAxisWidth
        g_YAxisHeight = yAxisHeight
        g_XWorldWidth = xAxisWidthD
        g_YWorldHeight = yAxisHeightD
        g_XAxisOffset = -g_XAxisMin '   set the x-axis offset to convert from data-space to display space
        g_YAxisOffset = g_YAxisHeight + g_YAxisMin '   set the y-axis offset, same reason
    End Sub

    Private Sub ConfigRedrawCurves()
        Dim curveIndex As Integer

        Call ClearAllLegends()
        curveIndex = 0
        Do Until curveIndex >= g_numberCurves
            Call ConfigRedrawACurve(curveIndex)
            curveIndex = curveIndex + 1
        Loop
    End Sub

    Private Sub ConfigRedrawACurve(ByRef inCurveIndex As Integer)
        Me.graphBox.Invalidate()
    End Sub

    Private Function GetScaledLogValue(ByRef inValue As Double, ByRef outLogPoint As Double) As Boolean
        Dim validPoint As Boolean
        Dim logXValue As Double
        Dim hundredX As Double

        validPoint = True

        If (inValue > 0.00000001) Then
            logXValue = Log10(inValue)
            hundredX = logXValue * g_LogScaleFactor
            outLogPoint = hundredX
        Else
            validPoint = False
            outLogPoint = 0.0#
        End If

        GetScaledLogValue = validPoint
    End Function

    Private Sub WriteConfigData()
        Dim fileNumber As Integer
        Dim printString As String
        Dim colorIndex As Integer
        Dim numberCurves As Integer
        Dim curveIndex As Integer

        fileNumber = FreeFile()
        '   note that currentPath will NOT be the actual current path
        '   if you're running this from within VB
        FileOpen(fileNumber, g_ConfigFilePath, OpenMode.Output)
        PrintLine(fileNumber, "<WHERE_I_THINK_I_AM>:" & g_ConfigFilePath)
        PrintLine(fileNumber, "<OPEN_SEQUENCE_PATH>:" & g_OpenSequencePath)
        PrintLine(fileNumber, "<X_AXIS_LABEL>:" & g_XAxisLabel)
        If (g_XScaleType = st_Linear) Then
            printString = "TRUE"
        Else
            printString = "FALSE"
        End If
        PrintLine(fileNumber, "<X_AXIS_LINEAR>:" & printString)
        PrintLine(fileNumber, "<X_AXIS_MIN>:" & Str(g_XAxisMin))
        PrintLine(fileNumber, "<X_AXIS_MAX>:" & Str(g_XAxisMax))
        PrintLine(fileNumber, "<X_AXIS_TICK>:" & Str(g_XAxisTick))

        PrintLine(fileNumber, "<Y_AXIS_LABEL>:" & g_YAxisLabel)
        If (g_YScaleType = st_Linear) Then
            printString = "TRUE"
        Else
            printString = "FALSE"
        End If
        PrintLine(fileNumber, "<Y_AXIS_LINEAR>:" & printString)
        PrintLine(fileNumber, "<Y_AXIS_MIN>:" & Str(g_YAxisMin))
        PrintLine(fileNumber, "<Y_AXIS_MAX>:" & Str(g_YAxisMax))
        PrintLine(fileNumber, "<Y_AXIS_TICK>:" & Str(g_YAxisTick))

        If (g_AutoLoadFile = True) Then
            printString = "TRUE"
        Else
            printString = "FALSE"
        End If
        PrintLine(fileNumber, "<AUTO_LOAD_FILE>:" & printString)
        PrintLine(fileNumber, "<GRAPH_FILE>:" & g_GraphFilePath)
        For colorIndex = 0 To 7
            PrintLine(fileNumber, "<COLOR_" & Str(colorIndex) & ">:" & Str(g_curveColors(colorIndex).ToArgb))
        Next colorIndex
        If (g_AutoLoadActiveX = True) Then
            printString = "TRUE"
        Else
            printString = "FALSE"
        End If
        PrintLine(fileNumber, "<AUTO_LOAD_CURVES>: " & printString)
        If (g_AutoLoadActiveX = True) Then
            numberCurves = g_SelectedCurves.Count()
            PrintLine(fileNumber, "<NUMBER_CURVES>: " & Str(numberCurves))
            For curveIndex = 1 To numberCurves
                PrintLine(fileNumber, "<CURVE_" & Str(curveIndex) & ">: " & g_SelectedCurves.Item(curveIndex))
            Next curveIndex
        End If

        FileClose(fileNumber)
    End Sub

    Private Sub ReadConfigData()
        Dim fileNumber As Integer
        Dim lineCollection As Collection
        Dim inputLine As String
        Dim lineIndex As Integer
        Dim lineCount As Integer
        Dim valueString As String
        Dim foundPos As Integer
        Dim colorIndex As Integer
        Dim colorValue As Integer

        '   note that currentPath will NOT be the actual current path
        '   if you're running this from within VB
        colorIndex = 0
        fileNumber = FreeFile()
        lineCollection = New Collection
        FileOpen(fileNumber, g_ConfigFilePath, OpenMode.Input)
        Do Until EOF(fileNumber)
            inputLine = LineInput(fileNumber)
            lineCollection.Add(inputLine)
        Loop
        FileClose(fileNumber)
        lineCount = lineCollection.Count()
        lineIndex = 1

        Do Until lineIndex > lineCount
            inputLine = lineCollection.Item(lineIndex)
            If (Len(inputLine) > 0) Then
                foundPos = InStr(1, inputLine, "<OPEN_SEQUENCE_PATH>")
                If (foundPos > 0) Then
                    g_OpenSequencePath = Mid(inputLine, 22)
                    If (Len(g_OpenSequencePath) > 0) Then
                        g_DisableClick = False
                    Else
                        g_DisableClick = True
                    End If
                    txtSequencePath.Text = g_OpenSequencePath
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<X_AXIS_LABEL>")
                If (foundPos > 0) Then
                    g_XAxisLabel = Mid(inputLine, 16)
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<X_AXIS_LINEAR>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 17)
                    If (valueString = "TRUE") Then
                        g_XScaleType = st_Linear
                    Else
                        g_XScaleType = st_Log
                    End If
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<X_AXIS_MIN>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 14)
                    g_XAxisMin = CInt(Val(valueString))
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<X_AXIS_MAX>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 14)
                    g_XAxisMax = CInt(Val(valueString))
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<X_AXIS_TICK>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 15)
                    g_XAxisTick = CInt(Val(valueString))
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<Y_AXIS_LABEL>")
                If (foundPos > 0) Then
                    g_YAxisLabel = Mid(inputLine, 16)
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<Y_AXIS_LINEAR>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 17)
                    If (valueString = "TRUE") Then
                        g_YScaleType = st_Linear
                    Else
                        g_YScaleType = st_Log
                    End If
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<Y_AXIS_MIN>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 14)
                    g_YAxisMin = CInt(Val(valueString))
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<Y_AXIS_MAX>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 14)
                    g_YAxisMax = CInt(Val(valueString))
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<Y_AXIS_TICK>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 15)
                    g_YAxisTick = CInt(Val(valueString))
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<AUTO_LOAD_FILE>")
                If (foundPos > 0) Then
                    valueString = Mid(inputLine, 18)
                    If (valueString = "TRUE") Then
                        g_AutoLoadFile = True
                    Else
                        g_AutoLoadFile = False
                    End If
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<GRAPH_FILE>")
                If (foundPos > 0) Then
                    g_GraphFilePath = Mid(inputLine, 14)
                    txtGraphFilePath.Text = g_GraphFilePath
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<COLOR_")
                If (foundPos > 0) Then
                    foundPos = InStr(1, inputLine, ">:")
                    valueString = Mid(inputLine, foundPos + 2)
                    colorValue = CInt(Val(valueString))
                    colorIndex = colorIndex + 1
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<AUTO_LOAD_CURVES>")
                If (foundPos > 0) Then
                    foundPos = InStr(19, inputLine, "TRUE")
                    If (foundPos > 0) Then
                        g_AutoLoadActiveX = True
                    Else
                        g_AutoLoadActiveX = False
                    End If
                    GoTo DoneTest
                End If
                foundPos = InStr(1, inputLine, "<CURVE_")
                If (foundPos > 0) Then
                    '   get the curve name, and store it in g_SelectedCurves
                    If (g_SelectedCurves Is Nothing) Then
                        g_SelectedCurves = New Collection
                    End If
                    foundPos = InStr(1, inputLine, ">: ")
                    If (foundPos > 0) Then
                        valueString = Mid(inputLine, foundPos + 3)
                        If (Len(valueString) > 0) Then
                            g_SelectedCurves.Add(valueString)
                        End If
                    End If
                    GoTo DoneTest
                End If
DoneTest:
                foundPos = 0
            End If
            lineIndex = lineIndex + 1
        Loop
        g_GraphConfigured = True
        g_XAxisWidth = g_XAxisMax - g_XAxisMin
        g_YAxisHeight = g_YAxisMax - g_YAxisMin
        g_XAxisOffset = -g_XAxisMin
        g_YAxisOffset = g_YAxisHeight + g_YAxisMin
        foundPos = 1
        Exit Sub
EndItAll:
        MsgBox("Couldn't Read In Configuration Data From File: " & str_CRLF & str_CRLF & g_ConfigFilePath & str_CRLF & str_CRLF & "Using Defaults")
        foundPos = -1
    End Sub
    Private Sub checkRunOptions()
        g_RunCRY6181Hidden = False
        g_RunCRY6181Minimized = False
        If (cmbOptions.SelectedItem = "Hidden") Then
            g_RunCRY6181Hidden = True
        Else
            If (cmbOptions.SelectedItem = "Minimized") Then
                g_RunCRY6181Minimized = True
            End If
        End If
    End Sub
    Private Sub cmbOptions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOptions.SelectedIndexChanged
        Call checkRunOptions()
    End Sub

    Private Sub QuitWaitTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitWaitTimer.Tick
        End
    End Sub

End Class