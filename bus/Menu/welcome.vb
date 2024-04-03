Public Class welcome
     
    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 25
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Left += 5
    End Sub

    Private Sub PictureBox2_LocationChanged(sender As Object, e As EventArgs) Handles PictureBox2.LocationChanged
        If PictureBox2.Left >= Me.Width Then
            PictureBox2.Left = 0 - PictureBox2.Width
        End If
    End Sub

End Class