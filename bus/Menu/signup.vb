Imports System.Data.OleDb
Public Class signup

    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"""
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        welcome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Save()
        MsgBox("Create Account ", MsgBoxStyle.Information, "Create")

        login.Show()
      
            Me.Hide()
      
    End Sub
End Class