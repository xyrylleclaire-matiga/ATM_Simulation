Public Class frmMain
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()

    End Sub

    Private Sub btnBalanceInquiry_Click(sender As Object, e As EventArgs) Handles btnBalanceInquiry.Click
        frmBalanceInquiry.Show()
        Me.Hide()

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        frmDeposit.Show()
        Me.Hide()
    End Sub

    Private Sub btnWithdrawal_Click(sender As Object, e As EventArgs) Handles btnWithdrawal.Click
        frmWithdrawal.Show()
        Me.Hide()
    End Sub
End Class