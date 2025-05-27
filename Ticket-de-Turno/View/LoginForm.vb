Public Class LoginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub toClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        If theGlobal.Instance.login(TxtPassword.Text) Then
            MessageBox.Show("Login successful!")
            theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Menu)
        Else
            MessageBox.Show("Invalid credentials.")
        End If

    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        theGlobal.Instance.setInformation("ID", TxtID.Text)
    End Sub

    Private Sub BtnGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Tickets)
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        theGlobal.Instance.setInformation("Contrasena", TxtID.Text)
    End Sub
End Class
