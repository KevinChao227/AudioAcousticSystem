<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCurves
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
        Initialize_frmCurves()
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
	Public WithEvents chkLoadAuto As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdDone As System.Windows.Forms.Button
	Public WithEvents cmdMoveAll2A As System.Windows.Forms.Button
	Public WithEvents cmdMoveOne2A As System.Windows.Forms.Button
	Public WithEvents cmdMoveAll2S As System.Windows.Forms.Button
	Public WithEvents cmdMoveOne2S As System.Windows.Forms.Button
	Public WithEvents lstSelected As System.Windows.Forms.ListBox
	Public WithEvents lstAvailable As System.Windows.Forms.ListBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkLoadAuto = New System.Windows.Forms.CheckBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDone = New System.Windows.Forms.Button
        Me.cmdMoveAll2A = New System.Windows.Forms.Button
        Me.cmdMoveOne2A = New System.Windows.Forms.Button
        Me.cmdMoveAll2S = New System.Windows.Forms.Button
        Me.cmdMoveOne2S = New System.Windows.Forms.Button
        Me.lstSelected = New System.Windows.Forms.ListBox
        Me.lstAvailable = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'chkLoadAuto
        '
        Me.chkLoadAuto.BackColor = System.Drawing.SystemColors.Control
        Me.chkLoadAuto.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLoadAuto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLoadAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLoadAuto.Location = New System.Drawing.Point(17, 371)
        Me.chkLoadAuto.Name = "chkLoadAuto"
        Me.chkLoadAuto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLoadAuto.Size = New System.Drawing.Size(235, 31)
        Me.chkLoadAuto.TabIndex = 10
        Me.chkLoadAuto.Text = "Load Data After Run Sequence"
        Me.chkLoadAuto.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(406, 361)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(90, 40)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdDone
        '
        Me.cmdDone.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDone.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDone.Location = New System.Drawing.Point(534, 361)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDone.Size = New System.Drawing.Size(90, 40)
        Me.cmdDone.TabIndex = 8
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = False
        '
        'cmdMoveAll2A
        '
        Me.cmdMoveAll2A.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveAll2A.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveAll2A.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveAll2A.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveAll2A.Location = New System.Drawing.Point(279, 291)
        Me.cmdMoveAll2A.Name = "cmdMoveAll2A"
        Me.cmdMoveAll2A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveAll2A.Size = New System.Drawing.Size(78, 35)
        Me.cmdMoveAll2A.TabIndex = 7
        Me.cmdMoveAll2A.Text = "<<"
        Me.cmdMoveAll2A.UseVisualStyleBackColor = False
        '
        'cmdMoveOne2A
        '
        Me.cmdMoveOne2A.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveOne2A.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveOne2A.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveOne2A.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveOne2A.Location = New System.Drawing.Point(279, 240)
        Me.cmdMoveOne2A.Name = "cmdMoveOne2A"
        Me.cmdMoveOne2A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveOne2A.Size = New System.Drawing.Size(78, 35)
        Me.cmdMoveOne2A.TabIndex = 6
        Me.cmdMoveOne2A.Text = "<"
        Me.cmdMoveOne2A.UseVisualStyleBackColor = False
        '
        'cmdMoveAll2S
        '
        Me.cmdMoveAll2S.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveAll2S.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveAll2S.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveAll2S.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveAll2S.Location = New System.Drawing.Point(279, 59)
        Me.cmdMoveAll2S.Name = "cmdMoveAll2S"
        Me.cmdMoveAll2S.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveAll2S.Size = New System.Drawing.Size(78, 35)
        Me.cmdMoveAll2S.TabIndex = 5
        Me.cmdMoveAll2S.Text = ">>"
        Me.cmdMoveAll2S.UseVisualStyleBackColor = False
        '
        'cmdMoveOne2S
        '
        Me.cmdMoveOne2S.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveOne2S.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveOne2S.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveOne2S.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveOne2S.Location = New System.Drawing.Point(279, 110)
        Me.cmdMoveOne2S.Name = "cmdMoveOne2S"
        Me.cmdMoveOne2S.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveOne2S.Size = New System.Drawing.Size(78, 35)
        Me.cmdMoveOne2S.TabIndex = 4
        Me.cmdMoveOne2S.Text = ">"
        Me.cmdMoveOne2S.UseVisualStyleBackColor = False
        '
        'lstSelected
        '
        Me.lstSelected.BackColor = System.Drawing.SystemColors.Window
        Me.lstSelected.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstSelected.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelected.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstSelected.ItemHeight = 14
        Me.lstSelected.Location = New System.Drawing.Point(387, 33)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstSelected.Size = New System.Drawing.Size(236, 312)
        Me.lstSelected.TabIndex = 2
        '
        'lstAvailable
        '
        Me.lstAvailable.BackColor = System.Drawing.SystemColors.Window
        Me.lstAvailable.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstAvailable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAvailable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstAvailable.ItemHeight = 14
        Me.lstAvailable.Location = New System.Drawing.Point(16, 33)
        Me.lstAvailable.Name = "lstAvailable"
        Me.lstAvailable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstAvailable.Size = New System.Drawing.Size(236, 312)
        Me.lstAvailable.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(387, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(157, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Curves To Graph:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Available Curves:"
        '
        'frmCurves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(641, 411)
        Me.Controls.Add(Me.chkLoadAuto)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdMoveAll2A)
        Me.Controls.Add(Me.cmdMoveOne2A)
        Me.Controls.Add(Me.cmdMoveAll2S)
        Me.Controls.Add(Me.cmdMoveOne2S)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.lstAvailable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmCurves"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curves"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class