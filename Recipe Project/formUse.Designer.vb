<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUse
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
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.lstRecipes = New System.Windows.Forms.ListBox()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.txtServings = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.Location = New System.Drawing.Point(6, 9)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(225, 34)
        Me.lblChoose.TabIndex = 0
        Me.lblChoose.Text = "Choose a Recipe"
        '
        'lstRecipes
        '
        Me.lstRecipes.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecipes.FormattingEnabled = True
        Me.lstRecipes.ItemHeight = 20
        Me.lstRecipes.Location = New System.Drawing.Point(12, 46)
        Me.lstRecipes.Name = "lstRecipes"
        Me.lstRecipes.Size = New System.Drawing.Size(358, 244)
        Me.lstRecipes.TabIndex = 1
        '
        'lblServings
        '
        Me.lblServings.AutoSize = True
        Me.lblServings.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServings.Location = New System.Drawing.Point(8, 307)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(176, 23)
        Me.lblServings.TabIndex = 2
        Me.lblServings.Text = "How many servings"
        '
        'txtServings
        '
        Me.txtServings.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServings.Location = New System.Drawing.Point(12, 333)
        Me.txtServings.Name = "txtServings"
        Me.txtServings.Size = New System.Drawing.Size(358, 34)
        Me.txtServings.TabIndex = 3
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(12, 391)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(250, 50)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Load Recipe"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(270, 391)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'formUse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 453)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtServings)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.lstRecipes)
        Me.Controls.Add(Me.lblChoose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formUse"
        Me.Text = "Use a Recipe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChoose As Label
    Friend WithEvents lstRecipes As ListBox
    Friend WithEvents lblServings As Label
    Friend WithEvents txtServings As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnExit As Button
End Class
