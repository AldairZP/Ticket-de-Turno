Public Class TicketsForm


    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If theGlobal.Instance.setTable() Then
            MessageBox.Show("Ticket guardado exitosamiente")
        Else
            MessageBox.Show("Ticket no encontrado")
        End If
    End Sub

    Private Sub BTNcrear_Click(sender As Object, e As EventArgs) Handles BTNcrear.Click

        Dim userInput As String = InputBox("Escribe la curp:", "Crear un Ticket", "")
        If userInput <> "" Then
            theGlobal.Instance.setInformation("ID", "-")
            theGlobal.Instance.setInformation("CURP_Alumno", userInput)
            If theGlobal.Instance.isKeyValue("CURP_Alumno", userInput) Then
                If theGlobal.Instance.createTable() Then
                    MessageBox.Show("Ticket creado exitosamiente")
                    Try

                        Dim info As Dictionary(Of String, String) = theGlobal.Instance.getTable()
                        LblCurp.Text = "Curp: " & info("CURP_Alumno")
                        LblTicket.Text = "Número: " & info("ID")
                        CBtramite.Text = info("QuienTramita")
                        CBstatus.Text = info("Estatus")
                        txtAsunto.Text = info("Asunto")
                        DTfecha.Value = Date.Parse(info("FechaRegistro"))
                    Catch ex As Exception

                    End Try
                Else

                End If

                LblTicket.Text = "Número: " & theGlobal.Instance.getInformation("ID")
                LblCurp.Text = "Curp: " & theGlobal.Instance.getInformation("CURP_Alumno")
            Else
                MessageBox.Show("Error: Curp no valida")
            End If
        End If
    End Sub

    Private Sub BTNborrar_Click(sender As Object, e As EventArgs) Handles BTNborrar.Click
        If theGlobal.Instance.delateTable() Then
            MessageBox.Show("Ticket Borrado exitosamiente")
            LimpiarCampos()
        Else
            MessageBox.Show("Ticket no encontrado")
        End If
    End Sub
    Private Sub LimpiarCampos()
        LblCurp.Text = "Curp: "
        LblTicket.Text = "Número: "
        CBtramite.SelectedIndex = -1
        CBstatus.SelectedIndex = -1
        txtAsunto.Clear()
    End Sub
    Private Sub TicketsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Menu)
    End Sub

    Private Sub toClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        theGlobal.Instance.logout(Me)
    End Sub

    Private Sub CBtramite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBtramite.SelectedIndexChanged
        theGlobal.Instance.setInformation("QuienTramita", CBtramite.Text)
    End Sub

    Private Sub CBstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBstatus.SelectedIndexChanged
        theGlobal.Instance.setInformation("Estatus", CBstatus.Text)
    End Sub

    Private Sub txtAsunto_TextChanged(sender As Object, e As EventArgs) Handles txtAsunto.TextChanged
        theGlobal.Instance.setInformation("Asunto", txtAsunto.Text)
    End Sub

    Private Sub DTfecha_ValueChanged(sender As Object, e As EventArgs) Handles DTfecha.ValueChanged
        theGlobal.Instance.setInformation("FechaRegistro", DTfecha.Value.ToString())
    End Sub

    Private Sub BTNleer_Click(sender As Object, e As EventArgs) Handles BTNleer.Click
        Dim userInput As String = InputBox("Escribe el turno:", "buscar un Ticket", "")
        If userInput <> "" Then
            theGlobal.Instance.setInformation("ID", userInput)
            Try

                Dim info As Dictionary(Of String, String) = theGlobal.Instance.getTable()
                LblCurp.Text = "Curp: " & info("CURP_Alumno")
                LblTicket.Text = "Número: " & info("ID")
                CBtramite.Text = info("QuienTramita")
                CBstatus.Text = info("Estatus")
                txtAsunto.Text = info("Asunto")
                DTfecha.Value = Date.Parse(info("FechaRegistro"))
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub LblCurp_Click(sender As Object, e As EventArgs) Handles LblCurp.Click

    End Sub
End Class