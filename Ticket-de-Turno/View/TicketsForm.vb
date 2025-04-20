Public Class TicketsForm
    Private Sub BTNleer_Click(sender As Object, e As EventArgs) Handles BTNleer.Click
        If String.IsNullOrEmpty(TXTcurp.Text) Then
            MessageBox.Show("Por favor ingrese una CURP para buscar.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrEmpty(TXTnum.Text) Then
            MessageBox.Show("Por favor ingrese el número de turno.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim solicitud As Solicitud = DBManager.Instance.GetRequestByCurpNTurn(TXTcurp.Text, TXTnum.Text)
        If solicitud IsNot Nothing Then
            MessageBox.Show("Solicitud encontrada.", "Búsqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se encontró el turno.", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

    End Sub

    Private Sub BTNcrear_Click(sender As Object, e As EventArgs) Handles BTNcrear.Click

    End Sub

    Private Sub BTNborrar_Click(sender As Object, e As EventArgs) Handles BTNborrar.Click

    End Sub
End Class