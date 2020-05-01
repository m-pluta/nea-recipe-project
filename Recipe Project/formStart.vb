Public Class formStart
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        formAdd.Show() 'Form shown
    End Sub
    Private Sub btnUse_Click(sender As Object, e As EventArgs) Handles btnUse.Click
        Me.Hide()
        formUse.Show() 'Form shown
        formUse.lstRecipes.SelectedIndex = -1 'Deselects the listbox
        formUse.txtServings.Text = "" 'clears servings input field
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End 'Ends program
    End Sub
End Class
