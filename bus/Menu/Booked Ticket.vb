Imports System.Data.OleDb
Public Class bookedticket
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"
    Private Sub bookedticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busreserve", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView1.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetInt32(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetInt32(6))
            newlistviewitem.SubItems.Add(myreader.GetString(7))
            newlistviewitem.SubItems.Add(myreader.GetInt32(8))
            newlistviewitem.SubItems.Add(myreader.GetInt32(9))
            newlistviewitem.SubItems.Add(myreader.GetString(10))
            newlistviewitem.SubItems.Add(myreader.GetInt32(11))
            newlistviewitem.SubItems.Add(myreader.GetInt32(12))
            newlistviewitem.SubItems.Add(myreader.GetInt32(13))
            newlistviewitem.SubItems.Add(myreader.GetString(14))
            ListView1.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub
End Class