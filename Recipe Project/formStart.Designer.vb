<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStart
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUse = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(350, 75)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add a recipe"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUse
        '
        Me.btnUse.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUse.Location = New System.Drawing.Point(12, 93)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(350, 75)
        Me.btnUse.TabIndex = 2
        Me.btnUse.Text = "Use a recipe"
        Me.btnUse.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Roboto", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(162, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 50)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'formStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 236)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUse)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formStart"
        Me.Text = "Recipe Program"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUse As Button
    Friend WithEvents btnExit As Button
End Class
