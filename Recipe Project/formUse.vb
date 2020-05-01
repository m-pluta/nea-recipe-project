Imports System.Text.RegularExpressions 'importing libraries

Public Class formUse
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If lstRecipes.SelectedIndex = -1 Then
            MsgBox("Please select a recipe to continue", MessageBoxIcon.Information) 'if nothing is selected
        Else
            Dim chosenRecipe As String 'declaring name variable
            chosenRecipe = lstRecipes.Items.Item(lstRecipes.SelectedIndex) 'retrieving the recipe chosen

            Dim servings As String 'declaring amount of servings variable
            servings = txtServings.Text 'fetching user input
            If servings = "" Then 'if nothing entered
                MsgBox("The amount of servings must be a valid integer", MessageBoxIcon.Exclamation, "Warning!") 'useful message
            ElseIf Not Regex.IsMatch(servings, "^[0-9 ]+$") Then 'checking if serving amount is a valid integer
                MsgBox("The amount of servings must be a valid integer using the digits 0-9", MessageBoxIcon.Exclamation, "Warning!") 'useful message
            Else
                LoadRecipe(chosenRecipe, servings) 'Parses inputs into subroutine
            End If
        End If

        'Me.Hide()
        'RevisedRecipe.Show()
    End Sub

    Sub LoadRecipe(ByVal recipeName As String, ByVal servings As Integer)
        Me.Hide()
        RevisedRecipe.Show() 'Form shown

        Dim recipe() As String = IO.File.ReadAllLines(GV.filepath & recipeName & ".txt")
        'recipe file under that name is accessed
        RevisedRecipe.lblTitle.Text = recipe(0) 'recipe title fetched from file
        RevisedRecipe.lblServings.Text = "Serves: " & servings 'amount of servings fetched from file

        Dim multiplier As Single = servings / recipe(1) 'scalar for the amount of ingredient
        Dim revisedAmount As Single = 0 'temporary variable storing updated values

        RevisedRecipe.lstIngredient.Items.Clear()
        RevisedRecipe.lstAmount.Items.Clear()       'list boxes are cleared
        RevisedRecipe.lstUnit.Items.Clear()

        For i As Integer = 2 To recipe.Length - 1 'goes through each ingredient
            RevisedRecipe.lstIngredient.Items.Add(recipe(i).Split(":")(0)) 'ingredient name added to list box

            revisedAmount = recipe(i).Split(":")(1) * multiplier 'values are updated
            RevisedRecipe.lstAmount.Items.Add(Math.Round(revisedAmount, 1)) 'new values added to list box

            RevisedRecipe.lstUnit.Items.Add(recipe(i).Split(":")(2)) 'ingredient unit added to list box
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End 'Ends program
    End Sub

    Private Sub formUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim recipes() As String = IO.File.ReadAllLines(GV.filepath & "recipes.txt") 'imports all available recipe names
        For Each recipe In recipes 'Goes through each available recipe
            lstRecipes.Items.Add(recipe) 'adds it to the list box
        Next

    End Sub
End Class