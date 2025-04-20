Public Class MenuForm
    Private Sub BTNalumnoCRUD_Click(sender As Object, e As EventArgs) Handles BTNalumnoCRUD.Click
        Dim AlumnoFormCRUD As New AlumnoFormCRUD()
        AlumnoFormCRUD.Show()
        Me.Close()
    End Sub

    Private Sub BTNtickets_Click(sender As Object, e As EventArgs) Handles BTNtickets.Click
        Dim Ticket As New TicketsForm()
        Ticket.Show()
        Me.Close()
    End Sub
End Class