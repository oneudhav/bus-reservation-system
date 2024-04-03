Imports System.Data.OleDb
Public Class busreg

    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"





    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Label8.Click

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Insert INTO bus(busno,comapanyName,bustype,totalSeat) VALUES (?,?,?,?)", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@comapanyname", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@bustype", ComboBox1.Text)
        mycommand.Parameters.AddWithValue("@totalseat", TextBox4.Text)


        Try
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Saved")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""

            myconnection.Close()

        Catch ex As Exception
            MessageBox.Show("Bus No is Same Enter New One")
        End Try
        
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("UPDATE bus SET busno=@busno,bustype=@bustype,comapanyname=@comapanyname,totalseat=@totalseat, WHERE busno=@busno", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox5.Text)
        mycommand.Parameters.AddWithValue("@bustype", ComboBox1.Text)
        mycommand.Parameters.AddWithValue("@comapanyname", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@totalseat", TextBox4.Text)


        mycommand.ExecuteNonQuery()
        myconnection.Close()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListView1.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView1.SelectedItems
                'Select each of the selected items
                ListView1.Items.Remove(i)

                'from database
                Dim myconnection As New OleDbConnection(myConnString)
                myconnection.Open()
                Dim mycommand As New OleDbCommand("DELETE FROM  bus WHERE busno=@busno", myconnection)
                mycommand.Parameters.AddWithValue("@busno", i.Text)
                mycommand.ExecuteNonQuery()
                myconnection.Close()
            Next
        Else
            MessageBox.Show("Please Select an Item to delete")
        End If


    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox5.TextChanged
        ListView2.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM bus Where busno LIKE @busno", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox3.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetInt32(3))

            ListView2.Items.Add(newlistviewitem)


        End While


        myconnection.Close()

    End Sub
 

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        busdetails.Show()
    End Sub
End Class