Public Class DashBoard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Menu)
    End Sub
    Private Sub toClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        theGlobal.Instance.logout(Me)
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class