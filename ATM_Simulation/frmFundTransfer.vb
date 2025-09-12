Imports MySql.Data.MySqlClient

Public Class frmFundTransfer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMain.Show
        Close
    End Sub

    'checking if the balance of the user/ logged in account is sufficient for the transfer
    Private Function balanceCheck() As Boolean
        Call connection()
        Dim transferAmount As Double
        frmBalanceInquiry.LoadBalance()

        If Not Double.TryParse(txtAmountTransfer.Text.Trim(), transferAmount) OrElse transferAmount <= 0 Then
            MessageBox.Show("Please enter a valid transfer amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            txtAmountTransfer.Clear()
            Return False
        End If

        If transferAmount > 10000 Then
            MessageBox.Show("Transfer amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            txtAmountTransfer.Clear()
            Return False
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
                    Return False
                End If
            Else
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Get Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function


    'checking if the Account Number of the target account exists
    Private Function checkAccount() As Boolean
        Call connection()
        sql = "SELECT * FROM tblaccountbalance WHERE AccountNumber = @accTarget"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)
        dr = cmd.ExecuteReader

        Dim exists As Boolean = dr.Read()
        dr.Close()
        Return exists
    End Function



    ' Transferring the amount to the target account
    Private Sub transferTransaction()
        Try
            Call connection()
            Dim transaction As MySqlTransaction = con.BeginTransaction()
            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount + @transfer WHERE AccountNumber = @accTarget"
            cmd = New MySqlCommand(sql, con, transaction)
            cmd.Parameters.AddWithValue("@transfer", Double.Parse(txtAmountTransfer.Text.Trim()))
            cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)
            Dim rowsAffectedTarget As Integer = cmd.ExecuteNonQuery

            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @transfer WHERE AccountNumber = @acc"
            cmd = New MySqlCommand(sql, con, transaction)
            cmd.Parameters.AddWithValue("@transfer", Double.Parse(txtAmountTransfer.Text.Trim()))
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)
            Dim rowsAffectedSender As Integer = cmd.ExecuteNonQuery

            If rowsAffectedSender > 0 And rowsAffectedTarget > 0 Then
                transaction.Commit()
                MsgBox("Transaction Complete")
                txtAmountTransfer.Clear()
                txtTargetAccount.Clear()
            Else
                transaction.Rollback()
                MsgBox("Transaction Failed")
                txtAmountTransfer.Clear()
                txtTargetAccount.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub



    '' Overall Transaction
    'Private Sub overallTransaction()
    '    Call connection()
    '    sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @transfer WHERE AccountNumber = @acc"
    '    cmd = New MySqlCommand(sql, con)
    '    cmd.Parameters.AddWithValue("@transfer", Double.Parse(txtAmountTransfer.Text.Trim()))
    '    cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)
    '    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
    '    If rowsAffected > 0 Then
    '        MsgBox("Transaction Complete")
    '        Call transferTransaction()
    '    Else
    '        MsgBox("Transaction Failed")
    '    End If


    'sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount + @transfer WHERE AccountNumber = @accTarget"
    '    cmd = New MySqlCommand(sql, con)
    '    cmd.Parameters.AddWithValue("@transfer", Double.Parse(txtAmountTransfer.Text.Trim()))
    '    cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)
    '    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


    '    sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @transfer WHERE AccountNumber = @acc"
    '    cmd = New MySqlCommand(sql, con)
    '    cmd.Parameters.AddWithValue("@transfer", Double.Parse(txtAmountTransfer.Text.Trim()))
    '    cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

    '    If rowsAffected > 0 Then
    '        MsgBox("Transaction Complete")
    '    Else
    '        MsgBox("Transaction Failed")
    '    End If

    'End Sub


    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If balanceCheck() = False Then Exit Sub
        If checkAccount() = False Then Exit Sub
        transferTransaction()

    End Sub
End Class