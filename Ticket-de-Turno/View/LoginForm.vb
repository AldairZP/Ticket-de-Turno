Public Class LoginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        If DBManager.Instance.LoginAdministrator(TxtID.Text, TxtPassword.Text) Then
            MessageBox.Show("Login successful!")
            Dim MenuForm As New MenuForm()
            MenuForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials.")
        End If

    End Sub
End Class
