Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class frmFundTransfer

    ' ---------------- BALANCE CHECK () --------------
    'checking if the balance of the user/ logged in account is sufficient for the transfer
    Private Function balanceCheck() As Boolean

        Dim transferAmountAsString As String = txtAmountTransfer.Text.Replace(",", "")
        Dim transferAmount As Double = 0
        frmBalanceInquiry.LoadBalance()

        If Not Double.TryParse(transferAmountAsString, transferAmount) OrElse transferAmount <= 0 Then
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
                    dr.Close()
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


    ' ---------------- CHECK ACCOUNT () --------------  
    'checking if the Account Number of the target account exists
    Private Function checkAccount() As Boolean
        Call connection()
        sql = "SELECT u.FirstName, u.MiddleName, u.LastName " &
      "FROM tblaccountbalance a " &
      "INNER JOIN tbluserinfo u ON a.AccountNumber = u.AccountNumber " &
      "WHERE a.AccountNumber = @accTarget"

        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)

        Using dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read = True Then
                Dim realName As String = dr("FirstName").ToString() & " " &
                         dr("MiddleName").ToString() & " " &
                         dr("LastName").ToString()


                If String.Equals(realName, txtAccountName.Text.Trim(), StringComparison.OrdinalIgnoreCase) Then
                    Return True
                Else
                    MessageBox.Show("The account name does not match the target account number. Please check and try again.", "Name Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtAccountName.Clear()
                    txtTargetAccount.Clear()
                    Return False
                End If
            Else
                MessageBox.Show("The target account number does not exist. Please check and try again.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAccountName.Clear()
                txtTargetAccount.Clear()
                Return False
            End If
        End Using
    End Function


    ' ---------- TRANSFER TRANSACTION () --------------
    ' Transferring the amount to the target account
    Private Sub transferTransaction()
        Dim transferAmount As Double
        If Not Double.TryParse(txtAmountTransfer.Text.Replace(",", ""), transferAmount) OrElse transferAmount <= 0 Then
            MessageBox.Show("Invalid transfer amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            Return
        End If
        Try

            Call connection()
            Dim transaction As MySqlTransaction = con.BeginTransaction()

            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount + @transfer WHERE AccountNumber = @accTarget"
            cmd = New MySqlCommand(sql, con, transaction)
            cmd.Parameters.AddWithValue("@transfer", transferAmount)
            cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)
            Dim rowsAffectedTarget As Integer = cmd.ExecuteNonQuery

            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @transfer WHERE AccountNumber = @acc"
            cmd = New MySqlCommand(sql, con, transaction)
            cmd.Parameters.AddWithValue("@transfer", transferAmount)
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



    '------------------------------ BUTTONS --------------------

    'TRANSFER BUTTON
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If balanceCheck() = False Then Exit Sub
        If checkAccount() = False Then
            MessageBox.Show("The target account number does not exist. Please check and try again.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Focus()
            txtTargetAccount.Clear()
            txtAmountTransfer.Clear()
            Exit Sub
        End If
        transferTransaction()

    End Sub


    'FORMAT 0,000
    Private Sub txtAmountTransfer_Leave(sender As Object, e As EventArgs) Handles txtAmountTransfer.Leave
        Dim raw As String = txtAmountTransfer.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtAmountTransfer.Text = value.ToString("N2")
        Else
            txtAmountTransfer.Text = "0.00"
        End If
    End Sub



    ' Number Pad Buttons
    Private Sub lblNo1_Click_1(sender As Object, e As EventArgs) Handles lblNo1.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("1")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("1")
        End If
    End Sub
    Private Sub lblNo2_Click_1(sender As Object, e As EventArgs) Handles lblNo2.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("2")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("2")
        End If
    End Sub
    Private Sub lblNo3_Click_1(sender As Object, e As EventArgs) Handles lblNo3.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("3")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("3")
        End If
    End Sub
    Private Sub lblNo4_Click_1(sender As Object, e As EventArgs) Handles lblNo4.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("4")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("4")
        End If
    End Sub
    Private Sub lblNo5_Click_1(sender As Object, e As EventArgs) Handles lblNo5.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("5")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("5")
        End If
    End Sub
    Private Sub lblNo6_Click_1(sender As Object, e As EventArgs) Handles lblNo6.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("6")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("6")
        End If
    End Sub
    Private Sub lblNo7_Click_1(sender As Object, e As EventArgs) Handles lblNo7.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("7")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("7")
        End If
    End Sub
    Private Sub lblNo8_Click_1(sender As Object, e As EventArgs) Handles lblNo8.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("8")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("8")
        End If
    End Sub
    Private Sub lblNo9_Click_1(sender As Object, e As EventArgs) Handles lblNo9.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("9")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("9")
        End If
    End Sub
    Private Sub lblNo0_Click_1(sender As Object, e As EventArgs) Handles lblNo0.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.AppendText("0")
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("0")
        End If
    End Sub

    'Decimal
    Private Sub lblDecimal_Click(sender As Object, e As EventArgs) Handles lblDecimal.Click
        If txtAmountTransfer.Focused AndAlso Not txtAmountTransfer.Text.Contains(".") Then
            txtAmountTransfer.AppendText(".")
        End If
    End Sub



    'Cancel Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Close()
    End Sub


    'Clear Button
    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        If txtAmountTransfer.Focused Then
            txtAmountTransfer.Clear()
        ElseIf txtTargetAccount.Focused Then
            txtTargetAccount.Clear()
        End If
    End Sub


    'Delete Button
    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        Dim pos As Integer = txtAmountTransfer.Text.Length
        Dim pos1 As Integer = txtTargetAccount.Text.Length

        If txtAmountTransfer.Focused Then
            If pos > 0 Then
                txtAmountTransfer.Text = txtAmountTransfer.Text.Remove(pos - 1, 1)
                txtAmountTransfer.SelectionStart = txtAmountTransfer.Text.Length
            End If
        ElseIf txtTargetAccount.Focused Then
            If pos1 > 0 Then
                txtTargetAccount.Text = txtTargetAccount.Text.Remove(pos1 - 1, 1)
                txtTargetAccount.SelectionStart = txtTargetAccount.Text.Length
            End If
        End If
    End Sub

End Class