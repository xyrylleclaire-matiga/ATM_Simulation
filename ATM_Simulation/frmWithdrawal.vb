Public Class frmWithdrawal
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class