<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RevisedRecipe
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
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lstUnit = New System.Windows.Forms.ListBox()
        Me.lstAmount = New System.Windows.Forms.ListBox()
        Me.lstIngredient = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(441, 83)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(46, 24)
        Me.lblUnit.TabIndex = 5
        Me.lblUnit.Text = "Unit"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(292, 83)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(81, 24)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "Amount"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(8, 83)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 24)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Ingredient"
        '
        'lstUnit
        '
        Me.lstUnit.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUnit.FormattingEnabled = True
        Me.lstUnit.ItemHeight = 20
        Me.lstUnit.Location = New System.Drawing.Point(445, 107)
        Me.lstUnit.Name = "lstUnit"
        Me.lstUnit.Size = New System.Drawing.Size(125, 324)
        Me.lstUnit.TabIndex = 8
        '
        'lstAmount
        '
        Me.lstAmount.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAmount.FormattingEnabled = True
        Me.lstAmount.ItemHeight = 20
        Me.lstAmount.Location = New System.Drawing.Point(296, 107)
        Me.lstAmount.Name = "lstAmount"
        Me.lstAmount.Size = New System.Drawing.Size(150, 324)
        Me.lstAmount.TabIndex = 7
        '
        'lstIngredient
        '
        Me.lstIngredient.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIngredient.FormattingEnabled = True
        Me.lstIngredient.ItemHeight = 20
        Me.lstIngredient.Location = New System.Drawing.Point(12, 107)
        Me.lstIngredient.Name = "lstIngredient"
        Me.lstIngredient.Size = New System.Drawing.Size(285, 324)
        Me.lstIngredient.TabIndex = 6
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(5, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(176, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Recipe Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServings
        '
        Me.lblServings.AutoSize = True
        Me.lblServings.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServings.Location = New System.Drawing.Point(8, 50)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(81, 24)
        Me.lblServings.TabIndex = 2
        Me.lblServings.Text = "Serves: "
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(470, 437)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(171, 437)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(290, 50)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back to Selection"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 437)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(150, 50)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "Back to Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'RevisedRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 499)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstUnit)
        Me.Controls.Add(Me.lstAmount)
        Me.Controls.Add(Me.lstIngredient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RevisedRecipe"
        Me.Text = "Your Recipe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnit As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lstUnit As ListBox
    Friend WithEvents lstAmount As ListBox
    Friend WithEvents lstIngredient As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblServings As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnStart As Button
End Class
