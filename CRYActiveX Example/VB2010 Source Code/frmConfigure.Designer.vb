<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConfigure
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
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
	Public WithEvents chkAutoLoadFile As System.Windows.Forms.CheckBox
	Public WithEvents txtYTicks As System.Windows.Forms.TextBox
	Public WithEvents txtXTicks As System.Windows.Forms.TextBox
	Public WithEvents _cmbColor1_7 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbColor1_6 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbColor1_5 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbColor1_4 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbColor1_3 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbColor1_2 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbColor1_1 As System.Windows.Forms.ComboBox
	Public WithEvents cmbYScaleType As System.Windows.Forms.ComboBox
	Public WithEvents cmbXScaleType As System.Windows.Forms.ComboBox
	Public WithEvents _cmbColor1_0 As System.Windows.Forms.ComboBox
	Public WithEvents txtYMax As System.Windows.Forms.TextBox
	Public WithEvents txtYMin As System.Windows.Forms.TextBox
	Public WithEvents txtXMax As System.Windows.Forms.TextBox
	Public WithEvents txtXMin As System.Windows.Forms.TextBox
    Public WithEvents txtXAxisLabel As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_7 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_6 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_5 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_4 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_3 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_2 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_1 As System.Windows.Forms.Label
	Public WithEvents _lblCurve1_0 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents cmbColor1 As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents lblCurve1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAutoLoadFile = New System.Windows.Forms.CheckBox
        Me.txtYTicks = New System.Windows.Forms.TextBox
        Me.txtXTicks = New System.Windows.Forms.TextBox
        Me._cmbColor1_7 = New System.Windows.Forms.ComboBox
        Me._cmbColor1_6 = New System.Windows.Forms.ComboBox
        Me._cmbColor1_5 = New System.Windows.Forms.ComboBox
        Me._cmbColor1_4 = New System.Windows.Forms.ComboBox
        Me._cmbColor1_3 = New System.Windows.Forms.ComboBox
        Me._cmbColor1_2 = New System.Windows.Forms.ComboBox
        Me._cmbColor1_1 = New System.Windows.Forms.ComboBox
        Me.cmbYScaleType = New System.Windows.Forms.ComboBox
        Me.cmbXScaleType = New System.Windows.Forms.ComboBox
        Me._cmbColor1_0 = New System.Windows.Forms.ComboBox
        Me.txtYMax = New System.Windows.Forms.TextBox
        Me.txtYMin = New System.Windows.Forms.TextBox
        Me.txtXMax = New System.Windows.Forms.TextBox
        Me.txtXMin = New System.Windows.Forms.TextBox
        Me.txtXAxisLabel = New System.Windows.Forms.TextBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me._lblCurve1_7 = New System.Windows.Forms.Label
        Me._lblCurve1_6 = New System.Windows.Forms.Label
        Me._lblCurve1_5 = New System.Windows.Forms.Label
        Me._lblCurve1_4 = New System.Windows.Forms.Label
        Me._lblCurve1_3 = New System.Windows.Forms.Label
        Me._lblCurve1_2 = New System.Windows.Forms.Label
        Me._lblCurve1_1 = New System.Windows.Forms.Label
        Me._lblCurve1_0 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbColor1 = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.lblCurve1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.txtYAxisLabel = New System.Windows.Forms.TextBox
        CType(Me.cmbColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurve1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAutoLoadFile
        '
        Me.chkAutoLoadFile.BackColor = System.Drawing.SystemColors.Control
        Me.chkAutoLoadFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAutoLoadFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoLoadFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAutoLoadFile.Location = New System.Drawing.Point(11, 200)
        Me.chkAutoLoadFile.Name = "chkAutoLoadFile"
        Me.chkAutoLoadFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAutoLoadFile.Size = New System.Drawing.Size(170, 22)
        Me.chkAutoLoadFile.TabIndex = 38
        Me.chkAutoLoadFile.Text = "Load File After Run Sequence"
        Me.chkAutoLoadFile.UseVisualStyleBackColor = False
        '
        'txtYTicks
        '
        Me.txtYTicks.AcceptsReturn = True
        Me.txtYTicks.BackColor = System.Drawing.SystemColors.Window
        Me.txtYTicks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYTicks.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYTicks.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYTicks.Location = New System.Drawing.Point(557, 39)
        Me.txtYTicks.MaxLength = 0
        Me.txtYTicks.Name = "txtYTicks"
        Me.txtYTicks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYTicks.Size = New System.Drawing.Size(37, 20)
        Me.txtYTicks.TabIndex = 8
        '
        'txtXTicks
        '
        Me.txtXTicks.AcceptsReturn = True
        Me.txtXTicks.BackColor = System.Drawing.SystemColors.Window
        Me.txtXTicks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtXTicks.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXTicks.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtXTicks.Location = New System.Drawing.Point(557, 6)
        Me.txtXTicks.MaxLength = 0
        Me.txtXTicks.Name = "txtXTicks"
        Me.txtXTicks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtXTicks.Size = New System.Drawing.Size(37, 20)
        Me.txtXTicks.TabIndex = 4
        '
        '_cmbColor1_7
        '
        Me._cmbColor1_7.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_7, CType(7, Short))
        Me._cmbColor1_7.Location = New System.Drawing.Point(607, 165)
        Me._cmbColor1_7.Name = "_cmbColor1_7"
        Me._cmbColor1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_7.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_7.TabIndex = 35
        Me._cmbColor1_7.Text = "Yellow"
        '
        '_cmbColor1_6
        '
        Me._cmbColor1_6.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_6, CType(6, Short))
        Me._cmbColor1_6.Location = New System.Drawing.Point(607, 133)
        Me._cmbColor1_6.Name = "_cmbColor1_6"
        Me._cmbColor1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_6.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_6.TabIndex = 34
        Me._cmbColor1_6.Text = "Green"
        '
        '_cmbColor1_5
        '
        Me._cmbColor1_5.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_5, CType(5, Short))
        Me._cmbColor1_5.Location = New System.Drawing.Point(607, 105)
        Me._cmbColor1_5.Name = "_cmbColor1_5"
        Me._cmbColor1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_5.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_5.TabIndex = 33
        Me._cmbColor1_5.Text = "Red"
        '
        '_cmbColor1_4
        '
        Me._cmbColor1_4.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_4, CType(4, Short))
        Me._cmbColor1_4.Location = New System.Drawing.Point(608, 77)
        Me._cmbColor1_4.Name = "_cmbColor1_4"
        Me._cmbColor1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_4.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_4.TabIndex = 32
        Me._cmbColor1_4.Text = "White"
        '
        '_cmbColor1_3
        '
        Me._cmbColor1_3.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_3, CType(3, Short))
        Me._cmbColor1_3.Location = New System.Drawing.Point(232, 165)
        Me._cmbColor1_3.Name = "_cmbColor1_3"
        Me._cmbColor1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_3.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_3.TabIndex = 31
        Me._cmbColor1_3.Text = "Cyan"
        '
        '_cmbColor1_2
        '
        Me._cmbColor1_2.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_2, CType(2, Short))
        Me._cmbColor1_2.Location = New System.Drawing.Point(232, 133)
        Me._cmbColor1_2.Name = "_cmbColor1_2"
        Me._cmbColor1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_2.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_2.TabIndex = 30
        Me._cmbColor1_2.Text = "Yellow"
        '
        '_cmbColor1_1
        '
        Me._cmbColor1_1.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_1, CType(1, Short))
        Me._cmbColor1_1.Location = New System.Drawing.Point(232, 105)
        Me._cmbColor1_1.Name = "_cmbColor1_1"
        Me._cmbColor1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_1.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_1.TabIndex = 29
        Me._cmbColor1_1.Text = "Green"
        '
        'cmbYScaleType
        '
        Me.cmbYScaleType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbYScaleType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbYScaleType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYScaleType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbYScaleType.Items.AddRange(New Object() {"Linear", "Logarithmic"})
        Me.cmbYScaleType.Location = New System.Drawing.Point(638, 40)
        Me.cmbYScaleType.Name = "cmbYScaleType"
        Me.cmbYScaleType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbYScaleType.Size = New System.Drawing.Size(160, 22)
        Me.cmbYScaleType.TabIndex = 26
        Me.cmbYScaleType.Text = "Linear"
        '
        'cmbXScaleType
        '
        Me.cmbXScaleType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbXScaleType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbXScaleType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbXScaleType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbXScaleType.Items.AddRange(New Object() {"Linear", "Logarithmic"})
        Me.cmbXScaleType.Location = New System.Drawing.Point(638, 7)
        Me.cmbXScaleType.Name = "cmbXScaleType"
        Me.cmbXScaleType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbXScaleType.Size = New System.Drawing.Size(160, 22)
        Me.cmbXScaleType.TabIndex = 25
        Me.cmbXScaleType.Text = "Linear"
        '
        '_cmbColor1_0
        '
        Me._cmbColor1_0.BackColor = System.Drawing.SystemColors.Window
        Me._cmbColor1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbColor1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbColor1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColor1.SetIndex(Me._cmbColor1_0, CType(0, Short))
        Me._cmbColor1_0.Location = New System.Drawing.Point(232, 77)
        Me._cmbColor1_0.Name = "_cmbColor1_0"
        Me._cmbColor1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbColor1_0.Size = New System.Drawing.Size(96, 22)
        Me._cmbColor1_0.TabIndex = 17
        Me._cmbColor1_0.Text = "Red"
        '
        'txtYMax
        '
        Me.txtYMax.AcceptsReturn = True
        Me.txtYMax.BackColor = System.Drawing.SystemColors.Window
        Me.txtYMax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYMax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYMax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYMax.Location = New System.Drawing.Point(413, 39)
        Me.txtYMax.MaxLength = 0
        Me.txtYMax.Name = "txtYMax"
        Me.txtYMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYMax.Size = New System.Drawing.Size(46, 20)
        Me.txtYMax.TabIndex = 7
        '
        'txtYMin
        '
        Me.txtYMin.AcceptsReturn = True
        Me.txtYMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtYMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYMin.Location = New System.Drawing.Point(316, 39)
        Me.txtYMin.MaxLength = 0
        Me.txtYMin.Name = "txtYMin"
        Me.txtYMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYMin.Size = New System.Drawing.Size(46, 20)
        Me.txtYMin.TabIndex = 6
        '
        'txtXMax
        '
        Me.txtXMax.AcceptsReturn = True
        Me.txtXMax.BackColor = System.Drawing.SystemColors.Window
        Me.txtXMax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtXMax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXMax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtXMax.Location = New System.Drawing.Point(413, 6)
        Me.txtXMax.MaxLength = 0
        Me.txtXMax.Name = "txtXMax"
        Me.txtXMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtXMax.Size = New System.Drawing.Size(46, 20)
        Me.txtXMax.TabIndex = 3
        '
        'txtXMin
        '
        Me.txtXMin.AcceptsReturn = True
        Me.txtXMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtXMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtXMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtXMin.Location = New System.Drawing.Point(316, 6)
        Me.txtXMin.MaxLength = 0
        Me.txtXMin.Name = "txtXMin"
        Me.txtXMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtXMin.Size = New System.Drawing.Size(46, 20)
        Me.txtXMin.TabIndex = 2
        '
        'txtXAxisLabel
        '
        Me.txtXAxisLabel.AcceptsReturn = True
        Me.txtXAxisLabel.BackColor = System.Drawing.SystemColors.Window
        Me.txtXAxisLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtXAxisLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXAxisLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtXAxisLabel.Location = New System.Drawing.Point(85, 6)
        Me.txtXAxisLabel.MaxLength = 0
        Me.txtXAxisLabel.Name = "txtXAxisLabel"
        Me.txtXAxisLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtXAxisLabel.Size = New System.Drawing.Size(179, 20)
        Me.txtXAxisLabel.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(648, 199)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(63, 30)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(736, 199)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(63, 30)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(478, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(73, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Tick Intervals:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(478, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Tick Intervals:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(603, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(39, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Scale:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(603, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(39, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Scale:"
        '
        '_lblCurve1_7
        '
        Me._lblCurve1_7.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_7, CType(7, Short))
        Me._lblCurve1_7.Location = New System.Drawing.Point(386, 167)
        Me._lblCurve1_7.Name = "_lblCurve1_7"
        Me._lblCurve1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_7.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_7.TabIndex = 24
        Me._lblCurve1_7.Text = "CurveName8"
        '
        '_lblCurve1_6
        '
        Me._lblCurve1_6.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_6, CType(6, Short))
        Me._lblCurve1_6.Location = New System.Drawing.Point(386, 135)
        Me._lblCurve1_6.Name = "_lblCurve1_6"
        Me._lblCurve1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_6.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_6.TabIndex = 23
        Me._lblCurve1_6.Text = "CurveName7"
        '
        '_lblCurve1_5
        '
        Me._lblCurve1_5.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_5, CType(5, Short))
        Me._lblCurve1_5.Location = New System.Drawing.Point(386, 107)
        Me._lblCurve1_5.Name = "_lblCurve1_5"
        Me._lblCurve1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_5.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_5.TabIndex = 22
        Me._lblCurve1_5.Text = "CurveName6"
        '
        '_lblCurve1_4
        '
        Me._lblCurve1_4.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_4, CType(4, Short))
        Me._lblCurve1_4.Location = New System.Drawing.Point(386, 79)
        Me._lblCurve1_4.Name = "_lblCurve1_4"
        Me._lblCurve1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_4.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_4.TabIndex = 21
        Me._lblCurve1_4.Text = "CurveName5"
        '
        '_lblCurve1_3
        '
        Me._lblCurve1_3.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_3, CType(3, Short))
        Me._lblCurve1_3.Location = New System.Drawing.Point(11, 167)
        Me._lblCurve1_3.Name = "_lblCurve1_3"
        Me._lblCurve1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_3.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_3.TabIndex = 20
        Me._lblCurve1_3.Text = "CurveName4"
        '
        '_lblCurve1_2
        '
        Me._lblCurve1_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_2, CType(2, Short))
        Me._lblCurve1_2.Location = New System.Drawing.Point(11, 135)
        Me._lblCurve1_2.Name = "_lblCurve1_2"
        Me._lblCurve1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_2.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_2.TabIndex = 19
        Me._lblCurve1_2.Text = "CurveName3"
        '
        '_lblCurve1_1
        '
        Me._lblCurve1_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_1, CType(1, Short))
        Me._lblCurve1_1.Location = New System.Drawing.Point(11, 107)
        Me._lblCurve1_1.Name = "_lblCurve1_1"
        Me._lblCurve1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_1.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_1.TabIndex = 18
        Me._lblCurve1_1.Text = "CurveName2"
        '
        '_lblCurve1_0
        '
        Me._lblCurve1_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblCurve1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCurve1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCurve1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurve1.SetIndex(Me._lblCurve1_0, CType(0, Short))
        Me._lblCurve1_0.Location = New System.Drawing.Point(11, 79)
        Me._lblCurve1_0.Name = "_lblCurve1_0"
        Me._lblCurve1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCurve1_0.Size = New System.Drawing.Size(190, 17)
        Me._lblCurve1_0.TabIndex = 16
        Me._lblCurve1_0.Text = "CurveName1"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(381, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(35, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Max:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(284, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(27, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Min:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(381, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Max:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(284, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(27, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Min:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Y-Axis Label:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "X-Axis Label:"
        '
        'txtYAxisLabel
        '
        Me.txtYAxisLabel.AcceptsReturn = True
        Me.txtYAxisLabel.BackColor = System.Drawing.SystemColors.Window
        Me.txtYAxisLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYAxisLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYAxisLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYAxisLabel.Location = New System.Drawing.Point(85, 39)
        Me.txtYAxisLabel.MaxLength = 0
        Me.txtYAxisLabel.Name = "txtYAxisLabel"
        Me.txtYAxisLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYAxisLabel.Size = New System.Drawing.Size(179, 20)
        Me.txtYAxisLabel.TabIndex = 5
        '
        'frmConfigure
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(803, 233)
        Me.Controls.Add(Me.chkAutoLoadFile)
        Me.Controls.Add(Me.txtYTicks)
        Me.Controls.Add(Me.txtXTicks)
        Me.Controls.Add(Me._cmbColor1_7)
        Me.Controls.Add(Me._cmbColor1_6)
        Me.Controls.Add(Me._cmbColor1_5)
        Me.Controls.Add(Me._cmbColor1_4)
        Me.Controls.Add(Me._cmbColor1_3)
        Me.Controls.Add(Me._cmbColor1_2)
        Me.Controls.Add(Me._cmbColor1_1)
        Me.Controls.Add(Me.cmbYScaleType)
        Me.Controls.Add(Me.cmbXScaleType)
        Me.Controls.Add(Me._cmbColor1_0)
        Me.Controls.Add(Me.txtYMax)
        Me.Controls.Add(Me.txtYMin)
        Me.Controls.Add(Me.txtXMax)
        Me.Controls.Add(Me.txtXMin)
        Me.Controls.Add(Me.txtYAxisLabel)
        Me.Controls.Add(Me.txtXAxisLabel)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me._lblCurve1_7)
        Me.Controls.Add(Me._lblCurve1_6)
        Me.Controls.Add(Me._lblCurve1_5)
        Me.Controls.Add(Me._lblCurve1_4)
        Me.Controls.Add(Me._lblCurve1_3)
        Me.Controls.Add(Me._lblCurve1_2)
        Me.Controls.Add(Me._lblCurve1_1)
        Me.Controls.Add(Me._lblCurve1_0)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmConfigure"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configure Graph"
        CType(Me.cmbColor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurve1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtYAxisLabel As System.Windows.Forms.TextBox
#End Region 
End Class