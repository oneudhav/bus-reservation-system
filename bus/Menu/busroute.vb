Imports System.Data.OleDb

Public Class busroute
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "‪F:\College\newbus\Menu\newdatabase.accdb"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
       
        Dim mycommand As New OleDbCommand("INSERT INTO busroute(Busno,Routeno,Routename,Bustype,[From],[To],Reservedcost,totalseat) VALUES (?,?,?,?,?,?,?,?)", myconnection)
        mycommand.Parameters.AddWithValue("@BusNo", TextBox4.Text)
        mycommand.Parameters.AddWithValue("@RouteNo", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@RouteName", TextBox9.Text)
        mycommand.Parameters.AddWithValue("@BusType", TextBox6.Text)
        mycommand.Parameters.AddWithValue("@From", TextBox8.Text)
        mycommand.Parameters.AddWithValue("@To", TextBox10.Text)
        mycommand.Parameters.AddWithValue("@Reservedcost", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@TotalSeat", TextBox7.Text)

        Try
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Saved")
            'TextBox1.Text = vbEmptyss
            ' ComboBox5.Text = vbEmpty
            ' ComboBox1.Text = vbEmpty
            ' ComboBox2.Text = vbEmpty
            ' ComboBox3.Text = vbEmpty
            'ComboBox4.Text = vbEmpty
            'ComboBox6.Text = vbEmpty
            'ComboBox7.Text() = vbEmpty 

            myconnection.Close()

        Catch ex As Exception
            MessageBox.Show("Same Bus in more route")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        busroutedetail.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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
            newlistviewitem.SubItems.Add(myreader.GetInt32(7))
            ListView1.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("UPDATE busroute SET Busno=@Busno,routeno=@routeno,routename=@routename,BusType=@bustype,[from]=@from,[to]=@to,reservedcost=@reservedcost,totalseat=@totalseat WHERE BusNo=@BusNo", myconnection)
        mycommand.Parameters.AddWithValue("@BusNo", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@RouteNo", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@RouteName", TextBox9.Text)
        mycommand.Parameters.AddWithValue("@BusType", TextBox6.Text)
        mycommand.Parameters.AddWithValue("@From", TextBox8.Text)
        mycommand.Parameters.AddWithValue("@To", TextBox10.Text)
        mycommand.Parameters.AddWithValue("@Reservedcost", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@TotalSeat", TextBox7.Text)
        mycommand.ExecuteNonQuery()
        myconnection.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ListView1.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busroute WHERE Busno LIKE @Buso", myconnection)
        mycommand.Parameters.AddWithValue("@BusNo", TextBox2.Text)
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
            newlistviewitem.SubItems.Add(myreader.GetInt32(7))
            ListView1.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ListView2.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM busroute WHERE BusNo LIKE @BusNo", myconnection)
        mycommand.Parameters.AddWithValue("@BusNo", TextBox5.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView2.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetInt32(1))
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (ListView1.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView1.SelectedItems
                'Select each of the selected items
                ListView1.Items.Remove(i)

                'from database
                Dim myconnection As New OleDbConnection(myConnString)
                myconnection.Open()
                Dim mycommand As New OleDbCommand("DELETE FROM  busroute WHERE Busno=@Busno", myconnection)
                mycommand.Parameters.AddWithValue("@busno", i.Text)
                mycommand.ExecuteNonQuery()
                myconnection.Close()
            Next
        Else
            MessageBox.Show("Please Select an Item to delete")
        End If


    End Sub

    Private Sub busroute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM bus", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView3.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetInt32(3))

            ListView3.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM route", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView4.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))


            ListView4.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub ListView3_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView3.MouseClick
        Dim busno As String = ListView3.SelectedItems(0).SubItems(0).Text
        Dim bustype As String = ListView3.SelectedItems(0).SubItems(2).Text
        Dim seat As String = ListView3.SelectedItems(0).SubItems(3).Text
        TextBox4.Text = busno
        TextBox6.Text = bustype
        TextBox7.Text = seat



    End Sub

   
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub ListView4_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView4.MouseClick
        Dim routeno As String = ListView4.SelectedItems(0).SubItems(0).Text
        Dim routename As String = ListView4.SelectedItems(0).SubItems(1).Text
        Dim ffrom As String = ListView4.SelectedItems(0).SubItems(2).Text
        Dim tto As String = ListView4.SelectedItems(0).SubItems(3).Text
        TextBox3.Text = routeno
        TextBox9.Text = routename
        TextBox8.Text = ffrom
        TextBox10.Text = tto
    End Sub

   
    
End Class
