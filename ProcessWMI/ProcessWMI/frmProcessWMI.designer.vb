<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessWMI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTerminate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProcessName = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbTimer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnListProcess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(1, 1)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(753, 535)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(760, 85)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnTerminate
        '
        Me.btnTerminate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTerminate.BackColor = System.Drawing.Color.Crimson
        Me.btnTerminate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTerminate.FlatAppearance.BorderSize = 0
        Me.btnTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminate.ForeColor = System.Drawing.Color.White
        Me.btnTerminate.Location = New System.Drawing.Point(760, 43)
        Me.btnTerminate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTerminate.Name = "btnTerminate"
        Me.btnTerminate.Size = New System.Drawing.Size(94, 34)
        Me.btnTerminate.TabIndex = 2
        Me.btnTerminate.Text = "Kill Process"
        Me.btnTerminate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 547)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kill Process:"
        '
        'txtProcessName
        '
        Me.txtProcessName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProcessName.Location = New System.Drawing.Point(89, 544)
        Me.txtProcessName.Name = "txtProcessName"
        Me.txtProcessName.Size = New System.Drawing.Size(665, 27)
        Me.txtProcessName.TabIndex = 4
        '
        'Timer1
        '
        '
        'cmbTimer
        '
        Me.cmbTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTimer.FormattingEnabled = True
        Me.cmbTimer.Location = New System.Drawing.Point(760, 544)
        Me.cmbTimer.Name = "cmbTimer"
        Me.cmbTimer.Size = New System.Drawing.Size(53, 28)
        Me.cmbTimer.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(756, 521)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Timer (Sec)"
        '
        'btnListProcess
        '
        Me.btnListProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListProcess.BackColor = System.Drawing.Color.ForestGreen
        Me.btnListProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListProcess.FlatAppearance.BorderSize = 0
        Me.btnListProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListProcess.ForeColor = System.Drawing.Color.White
        Me.btnListProcess.Location = New System.Drawing.Point(760, 1)
        Me.btnListProcess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnListProcess.Name = "btnListProcess"
        Me.btnListProcess.Size = New System.Drawing.Size(94, 34)
        Me.btnListProcess.TabIndex = 1
        Me.btnListProcess.Text = "List Process"
        Me.btnListProcess.UseVisualStyleBackColor = False
        '
        'frmProcessWMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 583)
        Me.Controls.Add(Me.btnListProcess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTimer)
        Me.Controls.Add(Me.txtProcessName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTerminate)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmProcessWMI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Management - coDe bY: Thongkorn Tubtimkrob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTerminate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProcessName As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmbTimer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnListProcess As System.Windows.Forms.Button

End Class
