Imports System.Text.RegularExpressions 'importing libraries

Public Class formAdd
    Dim fmtIngredient As String : Dim recipe(1) As String 'declaring the formatted ingredient and recipe
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("All data entered may be lost if you exit", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            End 'If user presses during confirmation the program will close and unsaved data may be lost
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Ingredient, Amount, Unit As String 'Declaring Details about each ingredient
        Ingredient = txtName.Text : Amount = txtAmount.Text : Unit = txtUnit.Text
        'assigning the information entered to these variables

        Dim checker As Boolean = False 'checker variable to check if a response is valid
        If Ingredient <> "" And Amount <> "" Then
            If Not Regex.IsMatch(Ingredient, "^[A-Z, a-z ]+$") Then 'checking if the string contains only chars A-Z and a-z
                MsgBox("The name of the ingredient/s must only use letters from the english alphabet", MessageBoxIcon.Exclamation, "Warning!") 'useful message
                checker = True 'if it contains other characters, checker is set to true
            End If
            If Not Regex.IsMatch(Amount, "^[0-9,. ]+$") Then 'checking if the string contains numbers 0-9 and decimal point
                MsgBox("The amount of the ingredient/s must be a valid number", MessageBoxIcon.Exclamation, "Warning!") 'useful message
                checker = True 'if it contains other characters, checker is set to true
            End If
            If Not Regex.IsMatch(Unit, "^[A-Z, a-z, ]+$") And Unit <> "" Then 'checking if the string contains only chars A-Z, a-z or nothing
                MsgBox("The unit of the ingredient/s must only use letters from the english alphabet", MessageBoxIcon.Exclamation, "Information") 'useful message
                checker = True 'if it contains other characters, checker is set to true
            End If
            If Not checker Then
                lstIngredient.Items.Add(Ingredient)
                lstAmount.Items.Add(Amount)         'adds the details to the corresponding list box
                lstUnit.Items.Add(Unit)

                fmtIngredient = Ingredient & ":" & Amount & ":" & Unit
                'formatting the information into one string

                ReDim Preserve recipe(recipe.Length) 'increases size of recipe array by 1
                recipe(recipe.Length - 1) = fmtIngredient 'adds new ingredient to array
                txtName.Text = "" : txtAmount.Text = "" : txtUnit.Text = "" 'all fields are cleared
            End If
        End If

        txtName.Select() 'TabIndex is set back to ingredient name to speed up entering ingredients
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        Dim RecipeName As String = txtRecipeName.Text : Dim amountOfServings As String = txtServings.Text
        'declaring and assigning general information about the recipe to variables

        Dim checkName As Boolean = False : Dim checkServings As Boolean = False 'check variables for validation
        If Not Regex.IsMatch(RecipeName, "^[A-Z, a-z ]+$") Then 'checking if recipe name contains only chars A-Z and a-z
            checkName = True 'if it contains others, check variable set to true
        End If
        If Not Regex.IsMatch(amountOfServings, "^[0-9 ]+$") Then 'checking if serving amount is a valid integer
            checkServings = True 'if not then, variable set to true
        End If


        If checkName Then
            MsgBox("The name of the recipe must only use letters from the english alphabet", MessageBoxIcon.Exclamation, "Warning!") 'useful message
        End If
        If checkServings Then
            MsgBox("The amount of Servings must be a valid integer", MessageBoxIcon.Exclamation, "Warning!") 'useful message
        End If

        Dim NamingViolation As Boolean 'declaring check variable
        Dim recipes() As String = IO.File.ReadAllLines(GV.filepath & "recipes.txt") 'imports all available recipe names
        For i As Integer = 0 To recipes.Length - 1
            If recipes(i) = RecipeName Then 'If there is already a recipe under that name
                NamingViolation = True 'check variable
            End If
        Next
        If NamingViolation Then
            MsgBox("That recipe name is already in use, choose another name", MessageBoxIcon.Error, "Naming Violation") 'To make sure file isn't overwritten
        End If
        If RecipeName = "recipes" Then
            MsgBox("This recipe name is strictly unavailable", MessageBoxIcon.Error, "Naming Violation") 'To make sure file isn't overwritten
            NamingViolation = True 'check variable
        End If

        If Not checkName And Not checkServings And Not NamingViolation Then

            If recipe.Length = 2 Then 'recipe must be at least length 3 to be allowed (title, servings, ingredient)
                MsgBox("The recipe needs at least 1 ingredient", MessageBoxIcon.Exclamation, "Warning!")
            ElseIf amountOfServings < 2 Then 'Must serve at least 2 people
                MsgBox("The number of servings must be more than or equal to 2", MessageBoxIcon.Exclamation, "Warning!")
            Else
                recipe(0) = RecipeName
                recipe(1) = amountOfServings    'general data about recipe added to recipe array
                SaveRecipe() 'SaveRecipe Subroutine
            End If
        End If

    End Sub

    Sub SaveRecipe()

        For i As Integer = 0 To recipe.Length - 1 'whole recipe array saved to a new text file
            My.Computer.FileSystem.WriteAllText(GV.filepath & recipe(0) & ".txt", recipe(i) + Environment.NewLine, True)
        Next

        My.Computer.FileSystem.WriteAllText(GV.filepath & "recipes.txt", recipe(0) + Environment.NewLine, True)
        'recipe title saved to recipes file

        txtRecipeName.Text = ""
        txtServings.Text = ""
        lstIngredient.Items.Clear() 'All fields are cleared
        lstAmount.Items.Clear()
        lstUnit.Items.Clear()

        ReDim recipe(1) 'clears recipe

        Me.Hide()
        formStart.Show() 'start form is shown
    End Sub

End Class