Public Class AlumnoFormCRUD



    Private Sub BTNleer_Click(sender As Object, e As EventArgs) Handles BTNleer.Click
        Try

            Dim info As Dictionary(Of String, String) = theGlobal.Instance.getTable()

            TBcurp.Text = info("Curp")
            TBnombre.Text = info("Nombre")
            TBpaterno.Text = info("ApellidoPaterno")
            TBmaterno.Text = info("ApellidoMaterno")
            TBtelefono.Text = info("Telefono")
            TBcorreo.Text = info("Correo")
            CBnivelEscolar.Text = info("NivelEscolar")
            CBMunicipio.Text = theGlobal.Instance.getInformation("MunicipioID")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub

    Private Sub BTNactualizar_Click(sender As Object, e As EventArgs) Handles BTNactualizar.Click
        If theGlobal.Instance.setTable() Then
            MessageBox.Show("Alumno guardado exitosamiente")
        Else
            MessageBox.Show("Alumno no encontrado")
        End If

    End Sub

    Private Sub BTNborrar_Click(sender As Object, e As EventArgs) Handles BTNborrar.Click
        If theGlobal.Instance.delateTable() Then
            MessageBox.Show("Alumno Borrado exitosamiente")
            LimpiarCampos()
        Else
            MessageBox.Show("Alumno no encontrado")
        End If
    End Sub

    Private Sub BTNcrear_Click(sender As Object, e As EventArgs) Handles BTNcrear.Click
        If theGlobal.Instance.createTable() Then
            MessageBox.Show("Alumno creado exitosamiente")
        End If

    End Sub

    ' Método auxiliar para verificar si hay campos vacíos

    ' Método auxiliar para limpiar todos los campos del formulario
    Private Sub LimpiarCampos()
        TBcurp.Clear()
        TBnombre.Clear()
        TBpaterno.Clear()
        TBmaterno.Clear()
        TBtelefono.Clear()
        TBcorreo.Clear()
        CBnivelEscolar.SelectedIndex = -1
        CBMunicipio.SelectedIndex = -1
    End Sub



    Private Sub TBcurp_TextChanged(sender As Object, e As EventArgs) Handles TBcurp.TextChanged
        theGlobal.Instance.setInformation("Curp", TBcurp.Text)

    End Sub

    Private Sub TBnombre_TextChanged(sender As Object, e As EventArgs) Handles TBnombre.TextChanged
        theGlobal.Instance.setInformation("Nombre", TBnombre.Text)
    End Sub

    Private Sub TBpaterno_TextChanged(sender As Object, e As EventArgs) Handles TBpaterno.TextChanged
        theGlobal.Instance.setInformation("ApellidoPaterno", TBpaterno.Text)
    End Sub

    Private Sub TBmaterno_TextChanged(sender As Object, e As EventArgs) Handles TBmaterno.TextChanged
        theGlobal.Instance.setInformation("ApellidoMaterno", TBmaterno.Text)
    End Sub

    Private Sub TBtelefono_TextChanged(sender As Object, e As EventArgs) Handles TBtelefono.TextChanged
        theGlobal.Instance.setInformation("Telefono", TBtelefono.Text)
    End Sub

    Private Sub TBcorreo_TextChanged(sender As Object, e As EventArgs) Handles TBcorreo.TextChanged
        theGlobal.Instance.setInformation("Correo", TBcorreo.Text)
    End Sub

    Private Sub CBnivelEscolar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBnivelEscolar.SelectedIndexChanged
        theGlobal.Instance.setInformation("NivelEscolar", CBnivelEscolar.Text)
    End Sub



    Private Sub CBMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMunicipio.SelectedIndexChanged
        theGlobal.Instance.setInformation("MunicipioID", CBMunicipio.Text)
    End Sub

    Private Sub AlumnoFormCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBMunicipio.Items.Clear()
        CBMunicipio.Items.AddRange(theGlobal.Instance.getColumnsOfTable("Municipio", "Nombre").ToArray())
  
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Menu)
    End Sub
    Private Sub toClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        theGlobal.Instance.logout(Me)
    End Sub
End Class