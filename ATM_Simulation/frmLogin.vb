Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub loginEnter()
        Try
            dbConnection.connection()

            Dim query As String = "SELECT * FROM userinfo WHERE AccountNumber = @accNum AND PIN = @pin"
            dbConnection.cmd = New MySqlCommand(query, dbConnection.con)
            dbConnection.cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
            dbConnection.cmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())

            dbConnection.dr = dbConnection.cmd.ExecuteReader()

            If dbConnection.dr.Read() Then
                dbConnection.LoggedInAccNum = txtAccNum.Text.Trim()
                dbConnection.dr.Close()
                dbConnection.con.Close()
                Dim mainForm As New frmMain()
                mainForm.Show()
                Me.Hide()
                txtAccNum.Clear()
                txtPIN.Clear()
            Else
                dbConnection.dr.Close()
                dbConnection.con.Close()
                MessageBox.Show("Invalid Account Number or PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAccNum.Clear()
                txtPIN.Clear()
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If dbConnection.con.State = ConnectionState.Open Then
                dbConnection.con.Close()
            End If
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginEnter()
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("1")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("1")
        End If

    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs) Handles lbl2.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("2")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("2")
        End If
    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs) Handles lbl3.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("3")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("3")
        End If
    End Sub

    Private Sub lbl4_Click(sender As Object, e As EventArgs) Handles lbl4.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("4")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("4")
        End If
    End Sub

    Private Sub lbl5_Click(sender As Object, e As EventArgs) Handles lbl5.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("5")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("5")
        End If
    End Sub

    Private Sub lbl6_Click(sender As Object, e As EventArgs) Handles lbl6.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("6")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("6")
        End If
    End Sub

    Private Sub lbl7_Click(sender As Object, e As EventArgs) Handles lbl7.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("7")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("7")
        End If
    End Sub

    Private Sub lbl8_Click(sender As Object, e As EventArgs) Handles lbl8.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("8")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("8")
        End If
    End Sub

    Private Sub lbl9_Click(sender As Object, e As EventArgs) Handles lbl9.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("9")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("9")
        End If
    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.Close()
    End Sub

    Private Sub lbl0_Click(sender As Object, e As EventArgs) Handles lbl0.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("0")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("0")
        End If
    End Sub

    Private Sub lblEnter_Click(sender As Object, e As EventArgs) Handles lblEnter.Click
        loginEnter()
    End Sub


    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        txtAccNum.Clear()
        txtPIN.Clear()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If txtAccNum.Focused Then
            If txtAccNum.Text.Length > 0 Then
                txtAccNum.Text = txtAccNum.Text.Substring(0, txtAccNum.Text.Length - 1)
                txtAccNum.SelectionStart = txtAccNum.Text.Length
            End If
        ElseIf txtPIN.Focused Then
            If txtPIN.Text.Length > 0 Then
                txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1)
                txtPIN.SelectionStart = txtPIN.Text.Length
            End If
        End If
    End Sub


End Class
