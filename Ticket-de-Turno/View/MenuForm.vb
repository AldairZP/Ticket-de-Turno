Public Class MenuForm
    Private Sub BTNalumnoCRUD_Click(sender As Object, e As EventArgs) Handles BTNalumnoCRUD.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.AlumnosCRUD)
    End Sub

    Private Sub BTNtickets_Click(sender As Object, e As EventArgs) Handles BTNtickets.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Tickets)
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        theGlobal.Instance.logout(Me)
    End Sub
    Private Sub toClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        theGlobal.Instance.logout(Me)
    End Sub

    Private Sub BTNdashboard_Click(sender As Object, e As EventArgs) Handles BTNdashboard.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Dashboard)
    End Sub
End Class