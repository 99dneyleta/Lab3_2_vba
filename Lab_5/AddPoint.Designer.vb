<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPoint
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.txtZ = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblM = New System.Windows.Forms.Label()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(12, 277)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(153, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(36, 86)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(36, 120)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(14, 13)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(36, 159)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 13)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y"
        '
        'lblZ
        '
        Me.lblZ.AutoSize = True
        Me.lblZ.Location = New System.Drawing.Point(36, 199)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(14, 13)
        Me.lblZ.TabIndex = 5
        Me.lblZ.Text = "Z"
        '
        'txtZ
        '
        Me.txtZ.Location = New System.Drawing.Point(117, 192)
        Me.txtZ.MaxLength = 3
        Me.txtZ.Name = "txtZ"
        Me.txtZ.Size = New System.Drawing.Size(100, 20)
        Me.txtZ.TabIndex = 6
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(117, 152)
        Me.txtY.MaxLength = 3
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 7
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(117, 113)
        Me.txtX.MaxLength = 3
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(117, 79)
        Me.txtName.MaxLength = 5
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 9
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.Location = New System.Drawing.Point(36, 239)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(16, 13)
        Me.lblM.TabIndex = 10
        Me.lblM.Text = "M"
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(117, 232)
        Me.txtM.MaxLength = 5
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(100, 20)
        Me.txtM.TabIndex = 11
        '
        'AddPoint
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(257, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtZ)
        Me.Controls.Add(Me.lblZ)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPoint"
        Me.Text = "AddPoint"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents txtZ As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblM As System.Windows.Forms.Label
    Friend WithEvents txtM As System.Windows.Forms.TextBox
End Class
