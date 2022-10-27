<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmExample
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
        CRY_Form_Initialize()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents SCRunWaitTimer As System.Windows.Forms.Timer
    Public WithEvents cmdGetCurveNames As System.Windows.Forms.Button
    Public WithEvents cmdBrowseOpen As System.Windows.Forms.Button
    Public WithEvents lvwTable As System.Windows.Forms.ListView
    Public WithEvents _sstTabControl_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents lblCurve1 As System.Windows.Forms.Label
    Public WithEvents lblCurve2 As System.Windows.Forms.Label
    Public WithEvents lblCurve3 As System.Windows.Forms.Label
    Public WithEvents lblCurve4 As System.Windows.Forms.Label
    Public WithEvents lblCurve5 As System.Windows.Forms.Label
    Public WithEvents lblCurve6 As System.Windows.Forms.Label
    Public WithEvents lblCurve7 As System.Windows.Forms.Label
    Public WithEvents lblCurve8 As System.Windows.Forms.Label
    Public WithEvents lblXAxis As System.Windows.Forms.Label
    Public WithEvents lblYAxis As System.Windows.Forms.Label
    Public WithEvents lblYAxisMax As System.Windows.Forms.Label
    Public WithEvents lblYAxisMin As System.Windows.Forms.Label
    Public WithEvents lblXAxisMin As System.Windows.Forms.Label
    Public WithEvents lblXAxisMax As System.Windows.Forms.Label
    Public WithEvents graphBox As System.Windows.Forms.PictureBox
    Public WithEvents cmdConfig As System.Windows.Forms.Button
    Public WithEvents picColor1 As System.Windows.Forms.PictureBox
    Public WithEvents picColor2 As System.Windows.Forms.PictureBox
    Public WithEvents picColor3 As System.Windows.Forms.PictureBox
    Public WithEvents picColor4 As System.Windows.Forms.PictureBox
    Public WithEvents picColor5 As System.Windows.Forms.PictureBox
    Public WithEvents picColor6 As System.Windows.Forms.PictureBox
    Public WithEvents picColor7 As System.Windows.Forms.PictureBox
    Public WithEvents picColor8 As System.Windows.Forms.PictureBox
    Public WithEvents _sstTabControl_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents sstTabControl As System.Windows.Forms.TabControl
    Public WithEvents cmdExitCRY6181 As System.Windows.Forms.Button
    Public WithEvents cmdRunSequence As System.Windows.Forms.Button
    Public WithEvents cmdSetSerialNumber As System.Windows.Forms.Button
    Public WithEvents txtSerialNumber As System.Windows.Forms.TextBox
    Public WithEvents cmdSetLotNumber As System.Windows.Forms.Button
    Public WithEvents txtLotNumber As System.Windows.Forms.TextBox
    Public WithEvents cmdOpenSequence As System.Windows.Forms.Button
    Public WithEvents txtSequencePath As System.Windows.Forms.TextBox
    Public WithEvents cmdRunCRY6181 As System.Windows.Forms.Button
    Public WithEvents cmdQuit As System.Windows.Forms.Button
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents lblStatus As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents lblCommand As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents lblMargin As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents lblPassFail As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SCRunWaitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cmdGetCurveNames = New System.Windows.Forms.Button
        Me.cmdBrowseOpen = New System.Windows.Forms.Button
        Me.sstTabControl = New System.Windows.Forms.TabControl
        Me._sstTabControl_TabPage0 = New System.Windows.Forms.TabPage
        Me.lvwTable = New System.Windows.Forms.ListView
        Me._sstTabControl_TabPage1 = New System.Windows.Forms.TabPage
        Me.cmdLoadGraphFile = New System.Windows.Forms.Button
        Me.txtGraphFilePath = New System.Windows.Forms.TextBox
        Me.lblCurve1 = New System.Windows.Forms.Label
        Me.lblCurve2 = New System.Windows.Forms.Label
        Me.lblCurve3 = New System.Windows.Forms.Label
        Me.lblCurve4 = New System.Windows.Forms.Label
        Me.lblCurve5 = New System.Windows.Forms.Label
        Me.lblCurve6 = New System.Windows.Forms.Label
        Me.lblCurve7 = New System.Windows.Forms.Label
        Me.lblCurve8 = New System.Windows.Forms.Label
        Me.lblXAxis = New System.Windows.Forms.Label
        Me.lblYAxis = New System.Windows.Forms.Label
        Me.lblYAxisMax = New System.Windows.Forms.Label
        Me.lblYAxisMin = New System.Windows.Forms.Label
        Me.lblXAxisMin = New System.Windows.Forms.Label
        Me.lblXAxisMax = New System.Windows.Forms.Label
        Me.graphBox = New System.Windows.Forms.PictureBox
        Me.cmdConfig = New System.Windows.Forms.Button
        Me.picColor1 = New System.Windows.Forms.PictureBox
        Me.picColor2 = New System.Windows.Forms.PictureBox
        Me.picColor3 = New System.Windows.Forms.PictureBox
        Me.picColor4 = New System.Windows.Forms.PictureBox
        Me.picColor5 = New System.Windows.Forms.PictureBox
        Me.picColor6 = New System.Windows.Forms.PictureBox
        Me.picColor7 = New System.Windows.Forms.PictureBox
        Me.picColor8 = New System.Windows.Forms.PictureBox
        Me.cmdExitCRY6181 = New System.Windows.Forms.Button
        Me.cmdRunSequence = New System.Windows.Forms.Button
        Me.cmdSetSerialNumber = New System.Windows.Forms.Button
        Me.txtSerialNumber = New System.Windows.Forms.TextBox
        Me.cmdSetLotNumber = New System.Windows.Forms.Button
        Me.txtLotNumber = New System.Windows.Forms.TextBox
        Me.cmdOpenSequence = New System.Windows.Forms.Button
        Me.txtSequencePath = New System.Windows.Forms.TextBox
        Me.cmdRunCRY6181 = New System.Windows.Forms.Button
        Me.cmdQuit = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCommand = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblMargin = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblPassFail = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenSeqFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.OpenGraphFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbOptions = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbVersion = New System.Windows.Forms.ComboBox
        Me.QuitWaitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sstTabControl.SuspendLayout()
        Me._sstTabControl_TabPage0.SuspendLayout()
        Me._sstTabControl_TabPage1.SuspendLayout()
        CType(Me.graphBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SCRunWaitTimer
        '
        Me.SCRunWaitTimer.Interval = 10000
        '
        'cmdGetCurveNames
        '
        Me.cmdGetCurveNames.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetCurveNames.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetCurveNames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGetCurveNames.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetCurveNames.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetCurveNames.Location = New System.Drawing.Point(272, 136)
        Me.cmdGetCurveNames.Name = "cmdGetCurveNames"
        Me.cmdGetCurveNames.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetCurveNames.Size = New System.Drawing.Size(120, 22)
        Me.cmdGetCurveNames.TabIndex = 55
        Me.cmdGetCurveNames.Text = "Get Curve Names"
        Me.cmdGetCurveNames.UseVisualStyleBackColor = False
        '
        'cmdBrowseOpen
        '
        Me.cmdBrowseOpen.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBrowseOpen.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBrowseOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowseOpen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowseOpen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBrowseOpen.Location = New System.Drawing.Point(592, 49)
        Me.cmdBrowseOpen.Name = "cmdBrowseOpen"
        Me.cmdBrowseOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBrowseOpen.Size = New System.Drawing.Size(32, 22)
        Me.cmdBrowseOpen.TabIndex = 51
        Me.cmdBrowseOpen.Text = "..."
        Me.cmdBrowseOpen.UseVisualStyleBackColor = False
        '
        'sstTabControl
        '
        Me.sstTabControl.Controls.Add(Me._sstTabControl_TabPage0)
        Me.sstTabControl.Controls.Add(Me._sstTabControl_TabPage1)
        Me.sstTabControl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstTabControl.ItemSize = New System.Drawing.Size(42, 18)
        Me.sstTabControl.Location = New System.Drawing.Point(8, 185)
        Me.sstTabControl.Name = "sstTabControl"
        Me.sstTabControl.SelectedIndex = 0
        Me.sstTabControl.Size = New System.Drawing.Size(785, 371)
        Me.sstTabControl.TabIndex = 20
        '
        '_sstTabControl_TabPage0
        '
        Me._sstTabControl_TabPage0.Controls.Add(Me.lvwTable)
        Me._sstTabControl_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._sstTabControl_TabPage0.Name = "_sstTabControl_TabPage0"
        Me._sstTabControl_TabPage0.Size = New System.Drawing.Size(777, 345)
        Me._sstTabControl_TabPage0.TabIndex = 0
        Me._sstTabControl_TabPage0.Text = "Table"
        '
        'lvwTable
        '
        Me.lvwTable.BackColor = System.Drawing.SystemColors.Window
        Me.lvwTable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwTable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwTable.FullRowSelect = True
        Me.lvwTable.Location = New System.Drawing.Point(9, 11)
        Me.lvwTable.Name = "lvwTable"
        Me.lvwTable.Size = New System.Drawing.Size(759, 325)
        Me.lvwTable.TabIndex = 21
        Me.lvwTable.UseCompatibleStateImageBehavior = False
        Me.lvwTable.View = System.Windows.Forms.View.Details
        '
        '_sstTabControl_TabPage1
        '
        Me._sstTabControl_TabPage1.Controls.Add(Me.cmdLoadGraphFile)
        Me._sstTabControl_TabPage1.Controls.Add(Me.txtGraphFilePath)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve1)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve2)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve3)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve4)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve5)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve6)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve7)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblCurve8)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblXAxis)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblYAxis)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblYAxisMax)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblYAxisMin)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblXAxisMin)
        Me._sstTabControl_TabPage1.Controls.Add(Me.lblXAxisMax)
        Me._sstTabControl_TabPage1.Controls.Add(Me.graphBox)
        Me._sstTabControl_TabPage1.Controls.Add(Me.cmdConfig)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor1)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor2)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor3)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor4)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor5)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor6)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor7)
        Me._sstTabControl_TabPage1.Controls.Add(Me.picColor8)
        Me._sstTabControl_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._sstTabControl_TabPage1.Name = "_sstTabControl_TabPage1"
        Me._sstTabControl_TabPage1.Size = New System.Drawing.Size(777, 311)
        Me._sstTabControl_TabPage1.TabIndex = 1
        Me._sstTabControl_TabPage1.Text = "Graph"
        '
        'cmdLoadGraphFile
        '
        Me.cmdLoadGraphFile.Location = New System.Drawing.Point(489, 3)
        Me.cmdLoadGraphFile.Name = "cmdLoadGraphFile"
        Me.cmdLoadGraphFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdLoadGraphFile.TabIndex = 52
        Me.cmdLoadGraphFile.Text = "Browse..."
        Me.cmdLoadGraphFile.UseVisualStyleBackColor = True
        '
        'txtGraphFilePath
        '
        Me.txtGraphFilePath.Location = New System.Drawing.Point(80, 5)
        Me.txtGraphFilePath.Name = "txtGraphFilePath"
        Me.txtGraphFilePath.Size = New System.Drawing.Size(404, 20)
        Me.txtGraphFilePath.TabIndex = 51
        '
        'lblCurve1
        '
        Me.lblCurve1.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.Location = New System.Drawing.Point(669, 40)
        Me.lblCurve1.Name = "lblCurve1"
        Me.lblCurve1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve1.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve1.TabIndex = 25
        Me.lblCurve1.Text = "CurveName1"
        '
        'lblCurve2
        '
        Me.lblCurve2.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve2.Location = New System.Drawing.Point(669, 77)
        Me.lblCurve2.Name = "lblCurve2"
        Me.lblCurve2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve2.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve2.TabIndex = 27
        Me.lblCurve2.Text = "CurveName2"
        '
        'lblCurve3
        '
        Me.lblCurve3.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve3.Location = New System.Drawing.Point(669, 113)
        Me.lblCurve3.Name = "lblCurve3"
        Me.lblCurve3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve3.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve3.TabIndex = 28
        Me.lblCurve3.Text = "CurveName3"
        '
        'lblCurve4
        '
        Me.lblCurve4.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve4.Location = New System.Drawing.Point(669, 150)
        Me.lblCurve4.Name = "lblCurve4"
        Me.lblCurve4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve4.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve4.TabIndex = 29
        Me.lblCurve4.Text = "CurveName4"
        '
        'lblCurve5
        '
        Me.lblCurve5.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve5.Location = New System.Drawing.Point(669, 187)
        Me.lblCurve5.Name = "lblCurve5"
        Me.lblCurve5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve5.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve5.TabIndex = 30
        Me.lblCurve5.Text = "CurveName5"
        '
        'lblCurve6
        '
        Me.lblCurve6.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve6.Location = New System.Drawing.Point(669, 224)
        Me.lblCurve6.Name = "lblCurve6"
        Me.lblCurve6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve6.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve6.TabIndex = 31
        Me.lblCurve6.Text = "CurveName6"
        '
        'lblCurve7
        '
        Me.lblCurve7.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve7.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve7.Location = New System.Drawing.Point(669, 261)
        Me.lblCurve7.Name = "lblCurve7"
        Me.lblCurve7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve7.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve7.TabIndex = 32
        Me.lblCurve7.Text = "CurveName7"
        '
        'lblCurve8
        '
        Me.lblCurve8.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurve8.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurve8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurve8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve8.Location = New System.Drawing.Point(669, 297)
        Me.lblCurve8.Name = "lblCurve8"
        Me.lblCurve8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurve8.Size = New System.Drawing.Size(100, 25)
        Me.lblCurve8.TabIndex = 33
        Me.lblCurve8.Text = "CurveName8"
        '
        'lblXAxis
        '
        Me.lblXAxis.BackColor = System.Drawing.SystemColors.Control
        Me.lblXAxis.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblXAxis.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXAxis.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblXAxis.Location = New System.Drawing.Point(272, 327)
        Me.lblXAxis.Name = "lblXAxis"
        Me.lblXAxis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXAxis.Size = New System.Drawing.Size(195, 17)
        Me.lblXAxis.TabIndex = 41
        Me.lblXAxis.Text = "X-Axis"
        Me.lblXAxis.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblYAxis
        '
        Me.lblYAxis.BackColor = System.Drawing.SystemColors.Control
        Me.lblYAxis.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblYAxis.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYAxis.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYAxis.Location = New System.Drawing.Point(3, 154)
        Me.lblYAxis.Name = "lblYAxis"
        Me.lblYAxis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYAxis.Size = New System.Drawing.Size(68, 40)
        Me.lblYAxis.TabIndex = 46
        Me.lblYAxis.Text = "Y-Axis"
        Me.lblYAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYAxisMax
        '
        Me.lblYAxisMax.BackColor = System.Drawing.SystemColors.Control
        Me.lblYAxisMax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblYAxisMax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYAxisMax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYAxisMax.Location = New System.Drawing.Point(18, 32)
        Me.lblYAxisMax.Name = "lblYAxisMax"
        Me.lblYAxisMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYAxisMax.Size = New System.Drawing.Size(62, 14)
        Me.lblYAxisMax.TabIndex = 47
        Me.lblYAxisMax.Text = "Max"
        Me.lblYAxisMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYAxisMin
        '
        Me.lblYAxisMin.BackColor = System.Drawing.SystemColors.Control
        Me.lblYAxisMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblYAxisMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYAxisMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYAxisMin.Location = New System.Drawing.Point(19, 307)
        Me.lblYAxisMin.Name = "lblYAxisMin"
        Me.lblYAxisMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYAxisMin.Size = New System.Drawing.Size(59, 15)
        Me.lblYAxisMin.TabIndex = 48
        Me.lblYAxisMin.Text = "Min"
        Me.lblYAxisMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblXAxisMin
        '
        Me.lblXAxisMin.BackColor = System.Drawing.SystemColors.Control
        Me.lblXAxisMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblXAxisMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXAxisMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblXAxisMin.Location = New System.Drawing.Point(79, 327)
        Me.lblXAxisMin.Name = "lblXAxisMin"
        Me.lblXAxisMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXAxisMin.Size = New System.Drawing.Size(74, 18)
        Me.lblXAxisMin.TabIndex = 49
        Me.lblXAxisMin.Text = "Min"
        '
        'lblXAxisMax
        '
        Me.lblXAxisMax.BackColor = System.Drawing.SystemColors.Control
        Me.lblXAxisMax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblXAxisMax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXAxisMax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblXAxisMax.Location = New System.Drawing.Point(591, 327)
        Me.lblXAxisMax.Name = "lblXAxisMax"
        Me.lblXAxisMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXAxisMax.Size = New System.Drawing.Size(68, 18)
        Me.lblXAxisMax.TabIndex = 50
        Me.lblXAxisMax.Text = "Max"
        Me.lblXAxisMax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'graphBox
        '
        Me.graphBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.graphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.graphBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.graphBox.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graphBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.graphBox.Location = New System.Drawing.Point(80, 32)
        Me.graphBox.Name = "graphBox"
        Me.graphBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.graphBox.Size = New System.Drawing.Size(580, 290)
        Me.graphBox.TabIndex = 23
        Me.graphBox.TabStop = False
        '
        'cmdConfig
        '
        Me.cmdConfig.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConfig.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConfig.Enabled = False
        Me.cmdConfig.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfig.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConfig.Location = New System.Drawing.Point(581, 4)
        Me.cmdConfig.Name = "cmdConfig"
        Me.cmdConfig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConfig.Size = New System.Drawing.Size(76, 22)
        Me.cmdConfig.TabIndex = 24
        Me.cmdConfig.Text = "Configure"
        Me.cmdConfig.UseVisualStyleBackColor = False
        Me.cmdConfig.Visible = False
        '
        'picColor1
        '
        Me.picColor1.BackColor = System.Drawing.SystemColors.Control
        Me.picColor1.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor1.Location = New System.Drawing.Point(672, 34)
        Me.picColor1.Name = "picColor1"
        Me.picColor1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor1.Size = New System.Drawing.Size(95, 5)
        Me.picColor1.TabIndex = 26
        Me.picColor1.TabStop = False
        '
        'picColor2
        '
        Me.picColor2.BackColor = System.Drawing.SystemColors.Control
        Me.picColor2.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor2.Location = New System.Drawing.Point(672, 71)
        Me.picColor2.Name = "picColor2"
        Me.picColor2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor2.Size = New System.Drawing.Size(95, 5)
        Me.picColor2.TabIndex = 34
        Me.picColor2.TabStop = False
        '
        'picColor3
        '
        Me.picColor3.BackColor = System.Drawing.SystemColors.Control
        Me.picColor3.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor3.Location = New System.Drawing.Point(672, 108)
        Me.picColor3.Name = "picColor3"
        Me.picColor3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor3.Size = New System.Drawing.Size(95, 5)
        Me.picColor3.TabIndex = 35
        Me.picColor3.TabStop = False
        '
        'picColor4
        '
        Me.picColor4.BackColor = System.Drawing.SystemColors.Control
        Me.picColor4.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor4.Location = New System.Drawing.Point(672, 145)
        Me.picColor4.Name = "picColor4"
        Me.picColor4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor4.Size = New System.Drawing.Size(95, 5)
        Me.picColor4.TabIndex = 36
        Me.picColor4.TabStop = False
        '
        'picColor5
        '
        Me.picColor5.BackColor = System.Drawing.SystemColors.Control
        Me.picColor5.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor5.Location = New System.Drawing.Point(672, 182)
        Me.picColor5.Name = "picColor5"
        Me.picColor5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor5.Size = New System.Drawing.Size(95, 5)
        Me.picColor5.TabIndex = 37
        Me.picColor5.TabStop = False
        '
        'picColor6
        '
        Me.picColor6.BackColor = System.Drawing.SystemColors.Control
        Me.picColor6.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor6.Location = New System.Drawing.Point(672, 219)
        Me.picColor6.Name = "picColor6"
        Me.picColor6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor6.Size = New System.Drawing.Size(95, 5)
        Me.picColor6.TabIndex = 38
        Me.picColor6.TabStop = False
        '
        'picColor7
        '
        Me.picColor7.BackColor = System.Drawing.SystemColors.Control
        Me.picColor7.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor7.Location = New System.Drawing.Point(672, 256)
        Me.picColor7.Name = "picColor7"
        Me.picColor7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor7.Size = New System.Drawing.Size(95, 5)
        Me.picColor7.TabIndex = 39
        Me.picColor7.TabStop = False
        '
        'picColor8
        '
        Me.picColor8.BackColor = System.Drawing.SystemColors.Control
        Me.picColor8.Cursor = System.Windows.Forms.Cursors.Default
        Me.picColor8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picColor8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picColor8.Location = New System.Drawing.Point(674, 292)
        Me.picColor8.Name = "picColor8"
        Me.picColor8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picColor8.Size = New System.Drawing.Size(95, 5)
        Me.picColor8.TabIndex = 40
        Me.picColor8.TabStop = False
        '
        'cmdExitCRY6181
        '
        Me.cmdExitCRY6181.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExitCRY6181.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExitCRY6181.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExitCRY6181.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitCRY6181.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExitCRY6181.Location = New System.Drawing.Point(122, 562)
        Me.cmdExitCRY6181.Name = "cmdExitCRY6181"
        Me.cmdExitCRY6181.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExitCRY6181.Size = New System.Drawing.Size(140, 21)
        Me.cmdExitCRY6181.TabIndex = 19
        Me.cmdExitCRY6181.Text = "Exit CRY6181"
        Me.cmdExitCRY6181.UseVisualStyleBackColor = False
        '
        'cmdRunSequence
        '
        Me.cmdRunSequence.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRunSequence.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRunSequence.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRunSequence.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRunSequence.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRunSequence.Location = New System.Drawing.Point(122, 136)
        Me.cmdRunSequence.Name = "cmdRunSequence"
        Me.cmdRunSequence.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRunSequence.Size = New System.Drawing.Size(140, 22)
        Me.cmdRunSequence.TabIndex = 13
        Me.cmdRunSequence.Text = "Run Sequence"
        Me.cmdRunSequence.UseVisualStyleBackColor = False
        '
        'cmdSetSerialNumber
        '
        Me.cmdSetSerialNumber.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetSerialNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetSerialNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSetSerialNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetSerialNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetSerialNumber.Location = New System.Drawing.Point(272, 106)
        Me.cmdSetSerialNumber.Name = "cmdSetSerialNumber"
        Me.cmdSetSerialNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetSerialNumber.Size = New System.Drawing.Size(120, 22)
        Me.cmdSetSerialNumber.TabIndex = 11
        Me.cmdSetSerialNumber.Text = "Set Serial Number"
        Me.cmdSetSerialNumber.UseVisualStyleBackColor = False
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.AcceptsReturn = True
        Me.txtSerialNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerialNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSerialNumber.Location = New System.Drawing.Point(122, 107)
        Me.txtSerialNumber.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.txtSerialNumber.MaxLength = 0
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerialNumber.Size = New System.Drawing.Size(140, 20)
        Me.txtSerialNumber.TabIndex = 10
        Me.txtSerialNumber.Text = "<enter serial number>"
        '
        'cmdSetLotNumber
        '
        Me.cmdSetLotNumber.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetLotNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetLotNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSetLotNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetLotNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetLotNumber.Location = New System.Drawing.Point(272, 76)
        Me.cmdSetLotNumber.Name = "cmdSetLotNumber"
        Me.cmdSetLotNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetLotNumber.Size = New System.Drawing.Size(120, 22)
        Me.cmdSetLotNumber.TabIndex = 8
        Me.cmdSetLotNumber.Text = "Set Lot Number"
        Me.cmdSetLotNumber.UseVisualStyleBackColor = False
        '
        'txtLotNumber
        '
        Me.txtLotNumber.AcceptsReturn = True
        Me.txtLotNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtLotNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLotNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLotNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLotNumber.Location = New System.Drawing.Point(122, 78)
        Me.txtLotNumber.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.txtLotNumber.MaxLength = 0
        Me.txtLotNumber.Name = "txtLotNumber"
        Me.txtLotNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLotNumber.Size = New System.Drawing.Size(140, 20)
        Me.txtLotNumber.TabIndex = 7
        Me.txtLotNumber.Text = "<enter lot number>"
        '
        'cmdOpenSequence
        '
        Me.cmdOpenSequence.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOpenSequence.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOpenSequence.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpenSequence.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenSequence.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOpenSequence.Location = New System.Drawing.Point(635, 48)
        Me.cmdOpenSequence.Name = "cmdOpenSequence"
        Me.cmdOpenSequence.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOpenSequence.Size = New System.Drawing.Size(120, 22)
        Me.cmdOpenSequence.TabIndex = 5
        Me.cmdOpenSequence.Text = "Open Sequence"
        Me.cmdOpenSequence.UseVisualStyleBackColor = False
        '
        'txtSequencePath
        '
        Me.txtSequencePath.AcceptsReturn = True
        Me.txtSequencePath.BackColor = System.Drawing.SystemColors.Window
        Me.txtSequencePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSequencePath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSequencePath.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSequencePath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSequencePath.Location = New System.Drawing.Point(122, 49)
        Me.txtSequencePath.MaxLength = 0
        Me.txtSequencePath.Name = "txtSequencePath"
        Me.txtSequencePath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSequencePath.Size = New System.Drawing.Size(464, 20)
        Me.txtSequencePath.TabIndex = 4
        Me.txtSequencePath.Text = "<enter sequence path here>"
        '
        'cmdRunCRY6181
        '
        Me.cmdRunCRY6181.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRunCRY6181.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRunCRY6181.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRunCRY6181.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRunCRY6181.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRunCRY6181.Location = New System.Drawing.Point(635, 15)
        Me.cmdRunCRY6181.Name = "cmdRunCRY6181"
        Me.cmdRunCRY6181.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRunCRY6181.Size = New System.Drawing.Size(120, 22)
        Me.cmdRunCRY6181.TabIndex = 2
        Me.cmdRunCRY6181.Text = "Run CRY6181"
        Me.cmdRunCRY6181.UseVisualStyleBackColor = False
        '
        'cmdQuit
        '
        Me.cmdQuit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdQuit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuit.Location = New System.Drawing.Point(670, 563)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuit.Size = New System.Drawing.Size(120, 21)
        Me.cmdQuit.TabIndex = 0
        Me.cmdQuit.Text = "Quit"
        Me.cmdQuit.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(603, 566)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Ver. 2.0"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(335, 13)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(97, 18)
        Me.lblStatus.TabIndex = 45
        Me.lblStatus.Text = "<status>"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(285, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Status:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCommand
        '
        Me.lblCommand.BackColor = System.Drawing.SystemColors.Control
        Me.lblCommand.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCommand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCommand.Location = New System.Drawing.Point(6, 13)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCommand.Size = New System.Drawing.Size(174, 17)
        Me.lblCommand.TabIndex = 43
        Me.lblCommand.Text = "<command>"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 567)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "6. Exit CRY6181"
        '
        'lblMargin
        '
        Me.lblMargin.BackColor = System.Drawing.SystemColors.Control
        Me.lblMargin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMargin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMargin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMargin.Location = New System.Drawing.Point(622, 139)
        Me.lblMargin.Name = "lblMargin"
        Me.lblMargin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMargin.Size = New System.Drawing.Size(120, 20)
        Me.lblMargin.TabIndex = 17
        Me.lblMargin.Text = "MARGIN"
        Me.lblMargin.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(578, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Margin:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(403, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Overall Pass/Fail:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPassFail
        '
        Me.lblPassFail.BackColor = System.Drawing.SystemColors.Control
        Me.lblPassFail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassFail.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassFail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPassFail.Location = New System.Drawing.Point(500, 139)
        Me.lblPassFail.Name = "lblPassFail"
        Me.lblPassFail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassFail.Size = New System.Drawing.Size(73, 20)
        Me.lblPassFail.TabIndex = 14
        Me.lblPassFail.Text = "PASSED"
        Me.lblPassFail.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(7, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "5. Run Sequence"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(114, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "4. Set Serial Number:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "3. Set Lot Number:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2. Open Sequence:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1. Run CRY6181:"
        '
        'OpenSeqFileDialog
        '
        Me.OpenSeqFileDialog.Filter = "Sequence files (*.cry)|*.cry"
        '
        'OpenGraphFileDialog
        '
        Me.OpenGraphFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCommand)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(122, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 33)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command"
        '
        'cmbOptions
        '
        Me.cmbOptions.DropDownWidth = 120
        Me.cmbOptions.FormattingEnabled = True
        Me.cmbOptions.Items.AddRange(New Object() {"- none -", "Hidden", "Minimized"})
        Me.cmbOptions.Location = New System.Drawing.Point(13, 14)
        Me.cmbOptions.Name = "cmbOptions"
        Me.cmbOptions.Size = New System.Drawing.Size(138, 22)
        Me.cmbOptions.TabIndex = 62
        Me.cmbOptions.Text = "- none -"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbOptions)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 41)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Command Options"
        '
        'cmbVersion
        '
        Me.cmbVersion.FormattingEnabled = True
        Me.cmbVersion.Location = New System.Drawing.Point(122, 17)
        Me.cmbVersion.Name = "cmbVersion"
        Me.cmbVersion.Size = New System.Drawing.Size(270, 22)
        Me.cmbVersion.TabIndex = 65
        '
        'QuitWaitTimer
        '
        Me.QuitWaitTimer.Interval = 1000
        '
        'frmExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 599)
        Me.Controls.Add(Me.cmbVersion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdGetCurveNames)
        Me.Controls.Add(Me.cmdBrowseOpen)
        Me.Controls.Add(Me.sstTabControl)
        Me.Controls.Add(Me.cmdExitCRY6181)
        Me.Controls.Add(Me.cmdRunSequence)
        Me.Controls.Add(Me.cmdSetSerialNumber)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.cmdSetLotNumber)
        Me.Controls.Add(Me.txtLotNumber)
        Me.Controls.Add(Me.cmdOpenSequence)
        Me.Controls.Add(Me.txtSequencePath)
        Me.Controls.Add(Me.cmdRunCRY6181)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblMargin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPassFail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(125, 111)
        Me.Name = "frmExample"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRY6181 ActiveX Demo"
        Me.sstTabControl.ResumeLayout(False)
        Me._sstTabControl_TabPage0.ResumeLayout(False)
        Me._sstTabControl_TabPage1.ResumeLayout(False)
        Me._sstTabControl_TabPage1.PerformLayout()
        CType(Me.graphBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGraphFilePath As System.Windows.Forms.TextBox
    Friend WithEvents OpenSeqFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdLoadGraphFile As System.Windows.Forms.Button
    Friend WithEvents OpenGraphFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbOptions As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbVersion As System.Windows.Forms.ComboBox
    Friend WithEvents QuitWaitTimer As System.Windows.Forms.Timer
#End Region
End Class