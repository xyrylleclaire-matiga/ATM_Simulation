Imports MySql.Data.MySqlClient

Public Class frmBalanceInquiry

    ' Make sure you have these variables declared somewhere in your project:
    ' Dim con As MySqlConnection
    ' Dim cmd As MySqlCommand
    ' Dim dr As MySqlDataReader
    ' Dim sql As String
    ' Dim LoggedInAccNum As String  ' Your current logged-in account number

    Private Sub frmBalanceInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load balance immediately when form loads
        LoadBalance()

        ' Start timer for auto refresh (Timer1.Enabled is True by default in Designer)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadBalance()
    End Sub

    Private Sub LoadBalance()
        Try
            ' Open connection if closed
            If con Is Nothing Then
                connection() ' Your method to initialize 'con'
            ElseIf con.State = ConnectionState.Closed Then
                con.Open()
            End If

            sql = "SELECT BalanceAmount FROM accountbalance WHERE AccountNumber = @acc"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                lblBalanceAmount.Text = "₱" & Format(CDbl(dr("BalanceAmount")), "N2")
            Else
                lblBalanceAmount.Text = "No balance found"
            End If

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Load Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBalance() ' Manual refresh on button click
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Timer1.Stop() ' Stop timer when leaving this form
        frmMain.Show()
        Me.Hide()
    End Sub

End Class
