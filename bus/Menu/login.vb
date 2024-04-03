Imports System.Data.OleDb
Public Class login

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        forget.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        signup.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        welcome.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username And
            TextBox2.Text = My.Settings.Password Then
            menu1.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username and Password", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class