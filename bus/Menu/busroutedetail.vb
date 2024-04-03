Imports System.Data.OleDb

Public Class busroutedetail
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busroute", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView1.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetInt32(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetInt32(6))
            newlistviewitem.SubItems.Add(myreader.GetString(7))
            newlistviewitem.SubItems.Add(myreader.GetInt32(8))
            newlistviewitem.SubItems.Add(myreader.GetInt32(9))
            ListView1.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub
End Class