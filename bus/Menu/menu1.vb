Public Class menu1

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        welcome.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd-MM-yyyy")
        Label3.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles frontmain.Paint
        Timer1.Enabled = True
    End Sub

    Private Sub PassengerListToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem1.Click
        busreg.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem1.Click
        busdetails.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem2.Click
        routereg.Show()

    End Sub

    Private Sub DetailsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem2.Click

    End Sub

    Private Sub BusRouteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusRouteToolStripMenuItem.Click
        busroute.Show()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        ticket.Show()
    End Sub

    Private Sub BookedSeatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookedSeatToolStripMenuItem.Click
        bookedticket.Show()
    End Sub

    Private Sub BusRouteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BusRouteToolStripMenuItem1.Click
        busroutedetail.Show()
    End Sub

    Private Sub RouteDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RouteDetailToolStripMenuItem.Click
        routedetail.Show()
    End Sub

    Private Sub BusDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusDetailsToolStripMenuItem.Click
        busdetails.Show()
    End Sub

    Private Sub RouteDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RouteDetailsToolStripMenuItem.Click
        routedetail.Show()
    End Sub

    Private Sub BusRouteDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusRouteDetailsToolStripMenuItem.Click
        busroutedetail.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click

    End Sub

    Private Sub menu1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
    End Sub

    Private Sub TicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketToolStripMenuItem.Click

    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click

    End Sub

    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class