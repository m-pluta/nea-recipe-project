<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdd
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
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.lblNewAmount = New System.Windows.Forms.Label()
        Me.txtRecipeName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.lstIngredient = New System.Windows.Forms.ListBox()
        Me.lstAmount = New System.Windows.Forms.ListBox()
        Me.lstUnit = New System.Windows.Forms.ListBox()
        Me.lblNewUnit = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblCurrentRecipe = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.txtServings = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblRecipeInfo = New System.Windows.Forms.Label()
        Me.lblIngredientInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRecipeName
        '
        Me.lblRecipeName.AutoSize = True
        Me.lblRecipeName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeName.Location = New System.Drawing.Point(8, 53)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(64, 24)
        Me.lblRecipeName.TabIndex = 15
        Me.lblRecipeName.Text = "Name"
        '
        'lblNewAmount
        '
        Me.lblNewAmount.AutoSize = True
        Me.lblNewAmount.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewAmount.Location = New System.Drawing.Point(8, 346)
        Me.lblNewAmount.Name = "lblNewAmount"
        Me.lblNewAmount.Size = New System.Drawing.Size(81, 24)
        Me.lblNewAmount.TabIndex = 18
        Me.lblNewAmount.Text = "Amount"
        '
        'txtRecipeName
        '
        Me.txtRecipeName.Font = New System.Drawing.Font("Roboto", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecipeName.Location = New System.Drawing.Point(12, 81)
        Me.txtRecipeName.Multiline = True
        Me.txtRecipeName.Name = "txtRecipeName"
        Me.txtRecipeName.Size = New System.Drawing.Size(450, 36)
        Me.txtRecipeName.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(12, 311)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(450, 32)
        Me.txtName.TabIndex = 3
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(12, 373)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(150, 32)
        Me.txtAmount.TabIndex = 4
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewName.Location = New System.Drawing.Point(8, 284)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(64, 24)
        Me.lblNewName.TabIndex = 17
        Me.lblNewName.Text = "Name"
        '
        'lstIngredient
        '
        Me.lstIngredient.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIngredient.FormattingEnabled = True
        Me.lstIngredient.ItemHeight = 20
        Me.lstIngredient.Location = New System.Drawing.Point(567, 81)
        Me.lstIngredient.Name = "lstIngredient"
        Me.lstIngredient.Size = New System.Drawing.Size(275, 324)
        Me.lstIngredient.TabIndex = 9
        '
        'lstAmount
        '
        Me.lstAmount.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAmount.FormattingEnabled = True
        Me.lstAmount.ItemHeight = 20
        Me.lstAmount.Location = New System.Drawing.Point(841, 81)
        Me.lstAmount.Name = "lstAmount"
        Me.lstAmount.Size = New System.Drawing.Size(100, 324)
        Me.lstAmount.TabIndex = 10
        '
        'lstUnit
        '
        Me.lstUnit.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUnit.FormattingEnabled = True
        Me.lstUnit.ItemHeight = 20
        Me.lstUnit.Location = New System.Drawing.Point(940, 81)
        Me.lstUnit.Name = "lstUnit"
        Me.lstUnit.Size = New System.Drawing.Size(100, 324)
        Me.lstUnit.TabIndex = 11
        '
        'lblNewUnit
        '
        Me.lblNewUnit.AutoSize = True
        Me.lblNewUnit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUnit.Location = New System.Drawing.Point(416, 346)
        Me.lblNewUnit.Name = "lblNewUnit"
        Me.lblNewUnit.Size = New System.Drawing.Size(46, 24)
        Me.lblNewUnit.TabIndex = 19
        Me.lblNewUnit.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(262, 373)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(200, 32)
        Me.txtUnit.TabIndex = 5
        '
        'lblCurrentRecipe
        '
        Me.lblCurrentRecipe.AutoSize = True
        Me.lblCurrentRecipe.Font = New System.Drawing.Font("Roboto", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentRecipe.Location = New System.Drawing.Point(562, 9)
        Me.lblCurrentRecipe.Name = "lblCurrentRecipe"
        Me.lblCurrentRecipe.Size = New System.Drawing.Size(171, 29)
        Me.lblCurrentRecipe.TabIndex = 13
        Me.lblCurrentRecipe.Text = "Current Recipe"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 411)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(450, 50)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add Ingredient"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(567, 411)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(275, 50)
        Me.btnFinish.TabIndex = 7
        Me.btnFinish.Text = "Save Recipe"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(940, 411)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblServings
        '
        Me.lblServings.AutoSize = True
        Me.lblServings.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServings.Location = New System.Drawing.Point(8, 120)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(186, 24)
        Me.lblServings.TabIndex = 16
        Me.lblServings.Text = "Amount of Servings"
        '
        'txtServings
        '
        Me.txtServings.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServings.Location = New System.Drawing.Point(12, 147)
        Me.txtServings.Name = "txtServings"
        Me.txtServings.Size = New System.Drawing.Size(250, 32)
        Me.txtServings.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(563, 57)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 24)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Ingredient"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(837, 57)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(81, 24)
        Me.lblAmount.TabIndex = 21
        Me.lblAmount.Text = "Amount"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(936, 57)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(46, 24)
        Me.lblUnit.TabIndex = 22
        Me.lblUnit.Text = "Unit"
        '
        'lblRecipeInfo
        '
        Me.lblRecipeInfo.AutoSize = True
        Me.lblRecipeInfo.Font = New System.Drawing.Font("Roboto", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeInfo.Location = New System.Drawing.Point(7, 9)
        Me.lblRecipeInfo.Name = "lblRecipeInfo"
        Me.lblRecipeInfo.Size = New System.Drawing.Size(217, 29)
        Me.lblRecipeInfo.TabIndex = 12
        Me.lblRecipeInfo.Text = "Recipe Information"
        '
        'lblIngredientInfo
        '
        Me.lblIngredientInfo.AutoSize = True
        Me.lblIngredientInfo.Font = New System.Drawing.Font("Roboto", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredientInfo.Location = New System.Drawing.Point(7, 255)
        Me.lblIngredientInfo.Name = "lblIngredientInfo"
        Me.lblIngredientInfo.Size = New System.Drawing.Size(252, 29)
        Me.lblIngredientInfo.TabIndex = 14
        Me.lblIngredientInfo.Text = "Ingredient Information"
        '
        'formAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 473)
        Me.Controls.Add(Me.lblIngredientInfo)
        Me.Controls.Add(Me.lblRecipeInfo)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtServings)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblCurrentRecipe)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.lblNewUnit)
        Me.Controls.Add(Me.lstUnit)
        Me.Controls.Add(Me.lstAmount)
        Me.Controls.Add(Me.lstIngredient)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtRecipeName)
        Me.Controls.Add(Me.lblNewAmount)
        Me.Controls.Add(Me.lblRecipeName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formAdd"
        Me.Text = "Add a Recipe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRecipeName As Label
    Friend WithEvents lblNewAmount As Label
    Friend WithEvents txtRecipeName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblNewName As Label
    Friend WithEvents lstIngredient As ListBox
    Friend WithEvents lstAmount As ListBox
    Friend WithEvents lstUnit As ListBox
    Friend WithEvents lblNewUnit As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents lblCurrentRecipe As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblServings As Label
    Friend WithEvents txtServings As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblRecipeInfo As Label
    Friend WithEvents lblIngredientInfo As Label
End Class
