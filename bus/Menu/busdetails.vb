Imports System.Data.OleDb
Public Class busdetails
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub busdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewdatabaseDataSet1.bus' table. You can move, or remove it, as needed.
       

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM bus", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView1.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetInt32(3))

            ListView1.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub
End Class