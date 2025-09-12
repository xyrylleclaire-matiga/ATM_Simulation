Imports MySql.Data.MySqlClient

Public Class frmFundTransfer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    'checking if the balance of the user/ logged in account is sufficient for the transfer
    Private Sub balanceCheck()
        Call connection()
        Dim transferAmount As Double
        frmBalanceInquiry.LoadBalance()

        If Not Double.TryParse(txtAmountTransfer.Text.Trim(), transferAmount) OrElse transferAmount <= 0 Then
            MessageBox.Show("Please enter a valid transfer amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            txtAmountTransfer.Clear()
            Return
        End If

        If transferAmount > 10000 Then
            MessageBox.Show("Transfer amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            txtAmountTransfer.Clear()
            Return
        End If

        Try
            Call connection()
            sql = "SELECT * FROM tblaccountbalance WHERE AccountNumber = @acc"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim myBalance As Double = CDbl(dr("BalanceAmount"))
                If transferAmount > myBalance Then
                    MessageBox.Show("Insufficient balance for this transfer.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Get Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'checking if the Account Number of the target account exists
    Private Sub checkAccount()
        Call connection()
        sql = "SELECT * FROM tblaccountbalance WHERE AccountNumber = @accTarget"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
        Else
            MsgBox("Account Not Found")
        End If
        dr.Close()
    End Sub



    ' Transferring the amount to the target account
    Private Sub transferTransaction()
        Call connection()
        sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount + @transfer WHERE AccountNumber = @accTarget"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@transfer", Double.Parse(txtAmountTransfer.Text.Trim()))
        cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
    End Sub



    ' Overall Transaction
    Private Sub overallTransaction()
        Call connection()
        sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @transfer WHERE AccountNumber = " & LoggedInAccNum
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@transfer", Double.Parse(txtAmountTransfer.Text.Trim()))
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        If rowsAffected > 0 Then
            MsgBox("Transaction Complete")
            Call transferTransaction()
        Else
            MsgBox("Transaction Failed")
        End If
    End Sub


    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        balanceCheck()
        checkAccount()
        overallTransaction()
    End Sub
End Class