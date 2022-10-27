Option Strict Off
Option Explicit On
Friend Class frmConfigure
	Inherits System.Windows.Forms.Form
	
	Private mIsCommitted As Boolean
	Private mCurveNames As Collection
    Private mNumberCurves As Integer
	
	Private mAutoLoadFile As Boolean
	Private mAutoLoadEnabled As Boolean
	
	Public WriteOnly Property enableAutoLoad() As Boolean
		Set(ByVal Value As Boolean)
			mAutoLoadEnabled = Value
		End Set
	End Property
	
	Public ReadOnly Property isCommitted() As Boolean
		Get
			isCommitted = mIsCommitted
		End Get
	End Property
	
	
	Public Property autoLoadFile() As Boolean
		Get
			autoLoadFile = chkAutoLoadFile.CheckState
		End Get
		Set(ByVal Value As Boolean)
			chkAutoLoadFile.CheckState = Value
		End Set
	End Property
	
	
    Public Property xScaleType() As Integer
        Get
            xScaleType = cmbXScaleType.SelectedIndex
        End Get
        Set(ByVal Value As Integer)
            If (Value >= 0 And Value <= 1) Then
                cmbXScaleType.SelectedIndex = Value
            Else
                cmbXScaleType.SelectedIndex = 0
            End If
        End Set
    End Property
	
	
    Public Property yScaleType() As Integer
        Get
            yScaleType = cmbYScaleType.SelectedIndex
        End Get
        Set(ByVal Value As Integer)
            If (Value >= 0 And Value <= 1) Then
                cmbYScaleType.SelectedIndex = Value
            Else
                cmbYScaleType.SelectedIndex = 0
            End If
        End Set
    End Property
	
    Private Sub cmbXScaleType_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbXScaleType.TextChanged
        If (cmbXScaleType.SelectedIndex = 0) Then
            txtXTicks.Enabled = True
        Else
            txtXTicks.Enabled = False
        End If
    End Sub
	
	Private Sub cmbXScaleType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbXScaleType.SelectedIndexChanged
        If (cmbXScaleType.SelectedIndex = 0) Then
            txtXTicks.Enabled = True
        Else
            txtXTicks.Enabled = False
        End If
    End Sub
	
	Private Sub cmbYScaleType_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbYScaleType.TextChanged
        If (cmbYScaleType.SelectedIndex = 0) Then
            txtYTicks.Enabled = True
        Else
            txtYTicks.Enabled = False
        End If
    End Sub
	
    Private Sub cmbYScaleType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbYScaleType.SelectedIndexChanged
        If (cmbYScaleType.SelectedIndex = 0) Then
            txtYTicks.Enabled = True
        Else
            txtYTicks.Enabled = False
        End If
    End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		mIsCommitted = False
		Me.Hide()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		
		If (SanityCheck1 = True) Then
			If (LinearSanity = True) Then
				mIsCommitted = True
				Me.Hide()
			Else
				MsgBox("Min Values Must Be Less Than Max Values!")
			End If
		Else
			MsgBox("Log Min/Max Values Cannot Be Negative!")
		End If
	End Sub
	
	Private Function SanityCheck1() As Boolean
		Dim xMaxD As Double
		Dim xMinD As Double
		Dim yMaxD As Double
		Dim yMinD As Double
		Dim sc As Boolean
		
		sc = True
		SanityCheck1 = True
		If (cmbXScaleType.SelectedIndex = 1) Then
			xMaxD = CDbl(txtXMax.Text)
			xMinD = CDbl(txtXMin.Text)
			If (xMaxD <= 0#) Then
				sc = False
			ElseIf (xMinD <= 0#) Then 
				sc = False
			End If
		End If
		If (sc = True And cmbYScaleType.SelectedIndex = 1) Then
			yMaxD = CDbl(txtYMax.Text)
			yMinD = CDbl(txtYMin.Text)
			If (yMaxD <= 0#) Then
				sc = False
			ElseIf (yMinD <= 0#) Then 
				sc = False
			End If
		End If
		SanityCheck1 = sc
	End Function
	
	Private Function LinearSanity() As Boolean
		Dim maxD As Double
		Dim minD As Double
		Dim sc As Boolean
		
		sc = True
		
		maxD = CDbl(txtXMax.Text)
		minD = CDbl(txtXMin.Text)
		If (maxD < minD) Then
			sc = False
		End If
		If (sc = True) Then
			maxD = CDbl(txtYMax.Text)
			minD = CDbl(txtYMin.Text)
			If (maxD < minD) Then
				sc = False
			End If
		End If
		LinearSanity = sc
	End Function
	
	Private Sub frmConfigure_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		mIsCommitted = False
		mNumberCurves = 0
		mAutoLoadFile = False
		chkAutoLoadFile.Enabled = mAutoLoadEnabled
	End Sub
	
	Public Sub SetCurveColors(ByRef inCurveColors As Collection)
        'Dim numberColors As Integer
		Dim colorIndex As Integer
        Dim colorValue As Integer
		
		mNumberCurves = inCurveColors.Count()
		For colorIndex = 1 To mNumberCurves
			colorValue = inCurveColors.Item(colorIndex)
			cmbColor1(colorIndex - 1).SelectedIndex = colorValue
		Next colorIndex
	End Sub
	
	Public Sub GetCurveColors(ByRef outCurveColors As Collection)
        'Dim numberColors As Integer
		Dim colorIndex As Integer
        Dim colorValue As Integer
		
		'   assume that the incoming collection is empty
		For colorIndex = 1 To mNumberCurves
			colorValue = cmbColor1(colorIndex - 1).SelectedIndex
			outCurveColors.Add(colorValue)
		Next colorIndex
	End Sub
	
	Public Sub SetCurveNames(ByRef inCurveNames As Collection)
		Dim numberCurves As Integer
		Dim curveIndex As Integer
		Dim curveName As String
		
		numberCurves = inCurveNames.Count()
		For curveIndex = 1 To 8
			If (curveIndex <= numberCurves) Then
				lblCurve1(curveIndex - 1).Visible = True
				cmbColor1(curveIndex - 1).Visible = True
				curveName = inCurveNames.Item(curveIndex)
				lblCurve1(curveIndex - 1).Text = curveName
			Else
				lblCurve1(curveIndex - 1).Visible = False
				cmbColor1(curveIndex - 1).Visible = False
			End If
		Next curveIndex
	End Sub
	
	'Public Sub setXTickInterval(inInterval As Double)
	'    txtXTicks.Text = inInterval
	'    txtXTicks.SelStart = 0
	'    txtXTicks.SelLength = Len(txtXTicks.Text)
	'End Sub
	
	'Public Sub setYTickInterval(inInterval As Double)
	'    txtYTicks.Text = inInterval
	'    txtYTicks.SelStart = 0
	'    txtYTicks.SelLength = Len(txtYTicks.Text)
	'End Sub
	
    Public Sub setXTickIntervalI(ByRef inInterval As Integer)
        txtXTicks.Text = CStr(inInterval)
        txtXTicks.SelectionStart = 0
        txtXTicks.SelectionLength = Len(txtXTicks.Text)
    End Sub
	
    Public Sub setYTickIntervalI(ByRef inInterval As Integer)
        txtYTicks.Text = CStr(inInterval)
        txtYTicks.SelectionStart = 0
        txtYTicks.SelectionLength = Len(txtYTicks.Text)
    End Sub
	
    Public Function getXTickIntervalI() As Integer
        getXTickIntervalI = CInt(txtXTicks.Text)
    End Function
	
    Public Function getYTickIntervalI() As Integer
        getYTickIntervalI = CInt(txtYTicks.Text)
    End Function
	
	'Public Function getXTickInterval() As Double
	'    getXTickInterval = txtXTicks.Text
	'End Function
	
	'Public Function getYTickInterval() As Double
	'    getYTickInterval = txtYTicks.Text
	'End Function
	
	'Public Sub setXRange(inXMin As Double, inXMax As Double)
	'    txtXMin.Text = inXMin
	'    txtXMax.Text = inXMax
	'    txtXMin.SelStart = 0
	'    txtXMin.SelLength = Len(txtXMin.Text)
	'    txtXMax.SelStart = 0
	'    txtXMax.SelLength = Len(txtXMax.Text)
	'End Sub
	
	'Public Sub setXRangeI(inXMin As Integer, inXMax As Integer)
	'    txtXMin.Text = inXMin
	'    txtXMin.SelStart = 0
	'    txtXMin.SelLength = Len(txtXMin.Text)
	'    txtXMax.Text = inXMax
	'    txtXMax.SelStart = 0
	'    txtXMax.SelLength = Len(txtXMax.Text)
	'End Sub
	
	Public Sub setXRangeL(ByRef inXMin As Integer, ByRef inXMax As Integer)
		txtXMin.Text = CStr(inXMin)
		txtXMin.SelectionStart = 0
		txtXMin.SelectionLength = Len(txtXMin.Text)
		txtXMax.Text = CStr(inXMax)
		txtXMax.SelectionStart = 0
		txtXMax.SelectionLength = Len(txtXMax.Text)
	End Sub
	
	Public Sub setYRangeL(ByRef inYMin As Integer, ByRef inYMax As Integer)
		txtYMin.Text = CStr(inYMin)
		txtYMin.SelectionStart = 0
		txtYMin.SelectionLength = Len(txtYMin.Text)
		txtYMax.Text = CStr(inYMax)
		txtYMax.SelectionStart = 0
		txtYMax.SelectionLength = Len(txtYMax.Text)
	End Sub
	
	'Public Sub getXRange(outXMin As Double, outXMax As Double)
	'    outXMin = txtXMin.Text
	'    outXMax = txtXMax.Text
	'End Sub
	
	'Public Sub getXRangeI(outXMin As Integer, outXMax As Integer)
	'    outXMin = txtXMin.Text
	'    outXMax = txtXMax.Text
	'End Sub
	
	Public Sub getXRangeL(ByRef outXMin As Integer, ByRef outXMax As Integer)
		outXMin = CInt(txtXMin.Text)
		outXMax = CInt(txtXMax.Text)
	End Sub
	
	Public Sub getYRangeL(ByRef outYMin As Integer, ByRef outYMax As Integer)
		outYMin = CInt(txtYMin.Text)
		outYMax = CInt(txtYMax.Text)
	End Sub
	
	'Public Sub setYRange(inYMin As Double, inYMax As Double)
	'    txtYMin.Text = inYMin
	'    txtYMax.Text = inYMax
	'    txtYMin.SelStart = 0
	'    txtYMin.SelLength = Len(txtYMin.Text)
	'    txtYMax.SelStart = 0
	'    txtYMax.SelLength = Len(txtYMax.Text)
	'End Sub
	
	'Public Sub getYRange(outYMin As Double, outYMax As Double)
	'    outYMin = txtYMin.Text
	'    outYMax = txtYMax.Text
	'End Sub
	
	'Public Sub setYRangeI(inYMin As Integer, inYMax As Integer)
	'    txtYMin.Text = inYMin
	'    txtYMin.SelStart = 0
	'    txtYMin.SelLength = Len(txtYMin.Text)
	'    txtYMax.Text = inYMax
	'    txtYMax.SelStart = 0
	'    txtYMax.SelLength = Len(txtYMax.Text)
	'End Sub
	
	'Public Sub getYRangeI(outYMin As Integer, outYMax As Integer)
	'    outYMin = txtYMin.Text
	'    outYMax = txtYMax.Text
	'End Sub
	
	Public Sub setXLabel(ByRef inLabel As String)
		txtXAxisLabel.Text = inLabel
		txtXAxisLabel.SelectionStart = 0
		txtXAxisLabel.SelectionLength = Len(txtXAxisLabel.Text)
	End Sub
	
	Public Sub setYLabel(ByRef inLabel As String)
		txtYAxisLabel.Text = inLabel
		txtYAxisLabel.SelectionStart = 0
		txtYAxisLabel.SelectionLength = Len(txtYAxisLabel.Text)
	End Sub
	
	Public Sub getXLabel(ByRef outLabel As String)
		outLabel = txtXAxisLabel.Text
	End Sub
	
	Public Sub getYLabel(ByRef outLabel As String)
		outLabel = txtYAxisLabel.Text
	End Sub

    Private Sub txtYAxisLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYAxisLabel.TextChanged

    End Sub
End Class