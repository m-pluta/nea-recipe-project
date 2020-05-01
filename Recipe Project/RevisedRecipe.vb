Public Class RevisedRecipe
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End 'Ends Program  
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        formUse.Show() 'Form shown
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        formStart.Show() 'Form shown
    End Sub
End Class