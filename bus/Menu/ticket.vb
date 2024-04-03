Imports System.Data.OleDb

Public Class ticket
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Update busreserve SET Bookingno=@Bookingno,BusNo=@BusNo,RouteNo=@RouteNo,Bustype=@Bustype,[From]=@from,[To]=@to,totalseat=@totalseat,Cname=@cname,Age=@age,Days=@days,Address=@address,Contact=@contact,cost=@cost,Totalcost=@totalcost,Gender=@gender WHERE busno=@busno", myconnection)
        mycommand.Parameters.AddWithValue("@BookingNo", Integer.Parse(TextBox1.Text))
        mycommand.Parameters.AddWithValue("@Busno", TextBox8.Text)
        mycommand.Parameters.AddWithValue("@RouteNo", TextBox10.Text)
        mycommand.Parameters.AddWithValue("@BusType", TextBox15.Text)
        mycommand.Parameters.AddWithValue("@From", TextBox13.Text)
        mycommand.Parameters.AddWithValue("@To", TextBox14.Text)
        mycommand.Parameters.AddWithValue("@totalseat", TextBox7.Text)
        mycommand.Parameters.AddWithValue("@Cname", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@age", TextBox5.Text)
        mycommand.Parameters.AddWithValue("@Days", TextBox16.Text)
        mycommand.Parameters.AddWithValue("@Address", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@Contact", TextBox4.Text)
        mycommand.Parameters.AddWithValue("@Cost", TextBox12.Text)
        mycommand.Parameters.AddWithValue("@Totalcost", TextBox6.Text)
        mycommand.Parameters.AddWithValue("@gender", ComboBox6.Text)


        mycommand.ExecuteNonQuery()
        myconnection.Close()

    End Sub

    Private Sub ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("INSERT INTO busreserve(Bookingno,BusNo,RouteNo,Bustype,[From],[To],totalseat,Cname,Age,Days,Address,Contact,cost,Totalcost,gender) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", myconnection)
        

        mycommand.Parameters.AddWithValue("@BookingNo", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@Busno", TextBox11.Text)
        mycommand.Parameters.AddWithValue("@RouteNo", TextBox10.Text)
        mycommand.Parameters.AddWithValue("@BusType", TextBox15.Text)
        mycommand.Parameters.AddWithValue("@From", TextBox13.Text)
        mycommand.Parameters.AddWithValue("@To", TextBox14.Text)
        mycommand.Parameters.AddWithValue("@totalseat", TextBox7.Text)
        mycommand.Parameters.AddWithValue("@Cname", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@age", TextBox5.Text)
        mycommand.Parameters.AddWithValue("@Days", TextBox16.Text)
        mycommand.Parameters.AddWithValue("@Address", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@Contact", TextBox4.Text)
        mycommand.Parameters.AddWithValue("@Cost", TextBox12.Text)
        mycommand.Parameters.AddWithValue("@Totalcost", TextBox6.Text)
        mycommand.Parameters.AddWithValue("@gender", ComboBox6.Text)


        Try
            Dim deletequery As String = "delete from busroute where busno=@busno "
            Dim del As New OleDbCommand(deletequery, myconnection)
            del.Parameters.AddWithValue("@busno", TextBox11.Text)
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Saved")



            myconnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' Dim deletequery As String = "delete from busroute where busno= " & TextBox11.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bookedticket.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busroute", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView2.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetInt32(6))
            newlistviewitem.SubItems.Add(myreader.GetInt32(7))
            ListView2.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        ListView1.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busreserve Where busno LIKE @busno", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox9.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



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

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        ListView3.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busreserve Where busno LIKE @busno", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox8.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()


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
            ListView3.Items.Add(newlistviewitem)
        End While
        myconnection.Close()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busreserve", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView3.Items.Clear()
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
          

            ListView3.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (ListView3.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView3.SelectedItems
                'Select each of the selected items
                ListView3.Items.Remove(i)

                'from database
                Dim myconnection As New OleDbConnection(myConnString)
                myconnection.Open()
                Dim mycommand As New OleDbCommand("DELETE FROM  busreserve WHERE busno=@busno", myconnection)
                mycommand.Parameters.AddWithValue("@busno", i.Text)
                mycommand.ExecuteNonQuery()
                myconnection.Close()

            Next

        Else
            MessageBox.Show("Please Select an Item to delete")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox6.Text = TextBox12.Text * TextBox16.Text
    End Sub

    Private Sub ListView2_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseClick
        Dim routeno As String = ListView2.SelectedItems(0).SubItems(0).Text
        Dim cost As String = ListView2.SelectedItems(0).SubItems(6).Text
        Dim ffrom As String = ListView2.SelectedItems(0).SubItems(4).Text
        Dim tto As String = ListView2.SelectedItems(0).SubItems(5).Text
        Dim busno As String = ListView2.SelectedItems(0).SubItems(1).Text
        Dim bustype As String = ListView2.SelectedItems(0).SubItems(3).Text
        Dim seat As String = ListView2.SelectedItems(0).SubItems(7).Text
        TextBox10.Text = routeno
        TextBox12.Text = cost
        TextBox13.Text = ffrom
        TextBox14.Text = tto
        TextBox11.Text = busno
        TextBox15.Text = bustype
        TextBox7.Text = seat
    End Sub

    
   
End Class