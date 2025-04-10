Public Class AlumnoFormCRUD

    Private Sub BTNleer_Click(sender As Object, e As EventArgs) Handles BTNleer.Click
        ' Validar que se haya ingresado una CURP
        If String.IsNullOrEmpty(TBcurp.Text) Then
            MessageBox.Show("Por favor ingrese una CURP para buscar.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buscar el alumno por CURP
        Dim alumno As Alumno = DBManager.Instance.GetStudentByCURP(TBcurp.Text)

        If alumno IsNot Nothing Then
            ' Mostrar los datos del alumno en los campos
            TBnombre.Text = alumno.Nombre
            TBpaterno.Text = alumno.ApellidoPaterno
            TBmaterno.Text = alumno.ApellidoMaterno
            TBtelefono.Text = alumno.Telefono
            TBcorreo.Text = alumno.Correo
            CBnivelEscolar.Text = alumno.NivelEscolar
            TBidMunicipio.Text = alumno.MunicipioID.ToString()

            MessageBox.Show("Alumno encontrado.", "Búsqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se encontró ningún alumno con esa CURP.", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Limpiar los campos excepto la CURP
            LimpiarCamposExceptoCURP()
        End If
    End Sub

    Private Sub BTNactualizar_Click(sender As Object, e As EventArgs) Handles BTNactualizar.Click
        ' Validar que todos los campos necesarios estén llenos
        If CamposVacios() Then
            MessageBox.Show("Por favor complete todos los campos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Crear un objeto Alumno con los datos de los campos
            Dim alumno As New Alumno()
            alumno.CURP = TBcurp.Text
            alumno.Nombre = TBnombre.Text
            alumno.ApellidoPaterno = TBpaterno.Text
            alumno.ApellidoMaterno = TBmaterno.Text
            alumno.Telefono = TBtelefono.Text
            alumno.Correo = TBcorreo.Text
            alumno.NivelEscolar = CBnivelEscolar.Text
            alumno.MunicipioID = Integer.Parse(TBidMunicipio.Text)

            ' Actualizar el alumno en la base de datos
            If DBManager.Instance.UpdateStudent(alumno) Then
                MessageBox.Show("Alumno actualizado correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            Else
                MessageBox.Show("No se pudo actualizar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As ArgumentException
            MessageBox.Show("Error de validación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNborrar_Click(sender As Object, e As EventArgs) Handles BTNborrar.Click
        ' Validar que se haya ingresado una CURP
        If String.IsNullOrEmpty(TBcurp.Text) Then
            MessageBox.Show("Por favor ingrese una CURP para borrar.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmar la eliminación
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este alumno?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            ' Borrar el alumno
            If DBManager.Instance.DeleteStudent(TBcurp.Text) Then
                MessageBox.Show("Alumno eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            Else
                MessageBox.Show("No se pudo eliminar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BTNcrear_Click(sender As Object, e As EventArgs) Handles BTNcrear.Click
        ' Validar que todos los campos necesarios estén llenos
        If CamposVacios() Then
            MessageBox.Show("Por favor complete todos los campos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Crear un objeto Alumno con los datos de los campos
            Dim alumno As New Alumno()
            alumno.CURP = TBcurp.Text
            alumno.Nombre = TBnombre.Text
            alumno.ApellidoPaterno = TBpaterno.Text
            alumno.ApellidoMaterno = TBmaterno.Text
            alumno.Telefono = TBtelefono.Text
            alumno.Correo = TBcorreo.Text
            alumno.NivelEscolar = CBnivelEscolar.Text
            alumno.MunicipioID = Integer.Parse(TBidMunicipio.Text)

            ' Guardar el alumno en la base de datos
            If DBManager.Instance.InsertStudent(alumno) Then
                MessageBox.Show("Alumno creado correctamente.", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            Else
                MessageBox.Show("No se pudo crear el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As ArgumentException
            MessageBox.Show("Error de validación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al crear: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Método auxiliar para verificar si hay campos vacíos
    Private Function CamposVacios() As Boolean
        Return String.IsNullOrEmpty(TBcurp.Text) OrElse
               String.IsNullOrEmpty(TBnombre.Text) OrElse
               String.IsNullOrEmpty(TBpaterno.Text) OrElse
               String.IsNullOrEmpty(TBmaterno.Text) OrElse
               String.IsNullOrEmpty(TBtelefono.Text) OrElse
               String.IsNullOrEmpty(TBcorreo.Text) OrElse
               String.IsNullOrEmpty(CBnivelEscolar.Text) OrElse
               String.IsNullOrEmpty(TBidMunicipio.Text)
    End Function

    ' Método auxiliar para limpiar todos los campos del formulario
    Private Sub LimpiarCampos()
        TBcurp.Clear()
        TBnombre.Clear()
        TBpaterno.Clear()
        TBmaterno.Clear()
        TBtelefono.Clear()
        TBcorreo.Clear()
        CBnivelEscolar.SelectedIndex = -1
        TBidMunicipio.Clear()
    End Sub

    ' Método auxiliar para limpiar todos los campos excepto CURP
    Private Sub LimpiarCamposExceptoCURP()
        TBnombre.Clear()
        TBpaterno.Clear()
        TBmaterno.Clear()
        TBtelefono.Clear()
        TBcorreo.Clear()
        CBnivelEscolar.SelectedIndex = -1
        TBidMunicipio.Clear()
    End Sub
End Class