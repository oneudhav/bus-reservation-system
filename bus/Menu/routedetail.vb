Imports System.Data.OleDb
Public Class routedetail
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM route", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView2.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))

            '  newlistviewitem.Text = myreader.GetString(4)
            ListView2.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub
End Class