<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.btnReadFromFile = New System.Windows.Forms.Button()
        Me.btnWriteToFile = New System.Windows.Forms.Button()
        Me.btnShowArray = New System.Windows.Forms.Button()
        Me.btnGetElFromArr = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pointName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddToArray = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReadFromFile
        '
        Me.btnReadFromFile.Location = New System.Drawing.Point(374, 32)
        Me.btnReadFromFile.Name = "btnReadFromFile"
        Me.btnReadFromFile.Size = New System.Drawing.Size(117, 23)
        Me.btnReadFromFile.TabIndex = 0
        Me.btnReadFromFile.Text = "Read From File"
        Me.btnReadFromFile.UseVisualStyleBackColor = True
        '
        'btnWriteToFile
        '
        Me.btnWriteToFile.Location = New System.Drawing.Point(374, 61)
        Me.btnWriteToFile.Name = "btnWriteToFile"
        Me.btnWriteToFile.Size = New System.Drawing.Size(117, 23)
        Me.btnWriteToFile.TabIndex = 1
        Me.btnWriteToFile.Text = "Write to file"
        Me.btnWriteToFile.UseVisualStyleBackColor = True
        '
        'btnShowArray
        '
        Me.btnShowArray.Location = New System.Drawing.Point(374, 90)
        Me.btnShowArray.Name = "btnShowArray"
        Me.btnShowArray.Size = New System.Drawing.Size(117, 23)
        Me.btnShowArray.TabIndex = 2
        Me.btnShowArray.Text = "Show all array"
        Me.btnShowArray.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShowArray.UseVisualStyleBackColor = True
        '
        'btnGetElFromArr
        '
        Me.btnGetElFromArr.Location = New System.Drawing.Point(374, 119)
        Me.btnGetElFromArr.Name = "btnGetElFromArr"
        Me.btnGetElFromArr.Size = New System.Drawing.Size(117, 23)
        Me.btnGetElFromArr.TabIndex = 3
        Me.btnGetElFromArr.Text = "Get element from array"
        Me.btnGetElFromArr.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pointName, Me.X, Me.Y, Me.Z, Me.M})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(355, 274)
        Me.DataGridView1.TabIndex = 5
        '
        'pointName
        '
        Me.pointName.HeaderText = "Name"
        Me.pointName.Name = "pointName"
        '
        'X
        '
        Me.X.HeaderText = "X"
        Me.X.Name = "X"
        '
        'Y
        '
        Me.Y.HeaderText = "Y"
        Me.Y.Name = "Y"
        '
        'Z
        '
        Me.Z.HeaderText = "Z"
        Me.Z.Name = "Z"
        '
        'M
        '
        Me.M.HeaderText = "M"
        Me.M.Name = "M"
        '
        'btnAddToArray
        '
        Me.btnAddToArray.Location = New System.Drawing.Point(373, 148)
        Me.btnAddToArray.Name = "btnAddToArray"
        Me.btnAddToArray.Size = New System.Drawing.Size(118, 24)
        Me.btnAddToArray.TabIndex = 6
        Me.btnAddToArray.Text = "Add Element to Array"
        Me.btnAddToArray.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 503)
        Me.Controls.Add(Me.btnAddToArray)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnGetElFromArr)
        Me.Controls.Add(Me.btnShowArray)
        Me.Controls.Add(Me.btnWriteToFile)
        Me.Controls.Add(Me.btnReadFromFile)
        Me.Name = "Start"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReadFromFile As System.Windows.Forms.Button
    Friend WithEvents btnWriteToFile As System.Windows.Forms.Button
    Friend WithEvents btnShowArray As System.Windows.Forms.Button
    Friend WithEvents btnGetElFromArr As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pointName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents X As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Y As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Z As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddToArray As System.Windows.Forms.Button

End Class
