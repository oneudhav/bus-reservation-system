Imports System.Data.OleDb
Public Class routereg
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Environment.CurrentDirectory & "\newdatabase.accdb"
    Private Sub routereg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("INSERT INTO route (RouteNo,RouteName,[From],[To]) VALUES (@RouteNo,@RouteName,@From,@To)", myconnection)
        mycommand.Parameters.AddWithValue("@RouteNo", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@RouteName", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@From", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@To", TextBox4.Text)

        Try
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Saved")
            TextBox1.Text = vbEmpty
            TextBox2.Text = vbEmpty
            TextBox3.Text = vbEmpty
            TextBox4.Text = vbEmpty

            myconnection.Close()

        Catch ex As Exception
            MessageBox.Show("Route No is Same Give New ONe")
        End Try

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        routedetail.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListView2.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView2.SelectedItems
                'Select each of the selected items
                ListView2.Items.Remove(i)

                'from database
                Dim myconnection As New OleDbConnection(myConnString)
                myconnection.Open()
                Dim mycommand As New OleDbCommand("DELETE FROM  Route WHERE RouteNo=@RouteNo", myconnection)
                mycommand.Parameters.AddWithValue("@RouteNo", i.Text)
                mycommand.ExecuteNonQuery()
                myconnection.Close()
            Next

        Else
            MessageBox.Show("Please Select an Item to delete")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("UPDATE route SET RouteNo=@RouteNo,RouteName=@RouteName,[From]=@From,[To]=@To WHERE RouteNo=@RouteNo", myconnection)
        mycommand.Parameters.AddWithValue("@RouteNo", Integer.Parse(TextBox6.Text))
        mycommand.Parameters.AddWithValue("@RouteName", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@From", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@To", TextBox4.Text)
        mycommand.ExecuteNonQuery()
        myconnection.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ListView1.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM route Where RouteNo LIKE @RouteNo", myconnection)
        mycommand.Parameters.AddWithValue("@RouteNo", TextBox5.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))

            ListView1.Items.Add(newlistviewitem)


        End While


        myconnection.Close()

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ListView1.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM route Where RouteNo LIKE @RouteNo", myconnection)
        mycommand.Parameters.AddWithValue("@RouteNo", TextBox6.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            '  newlistviewitem.Text = myreader.GetString(4)
            ListView1.Items.Add(newlistviewitem)


        End While


        myconnection.Close()

    End Sub
End Class
   