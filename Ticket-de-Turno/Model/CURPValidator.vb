Public Class ResultadoValidacion
    Public Property Valido As Boolean
    Public Property Mensaje As String

    Public Sub New(valido As Boolean, mensaje As String)
        Me.Valido = valido
        Me.Mensaje = mensaje
    End Sub
End Class

Public Class CURPValidator
    ' Lista de códigos de entidades federativas válidos
    Private Shared ReadOnly entidadesFederativas As String() = {
        "AS", "BC", "BS", "CC", "CL", "CM", "CS", "CH", "DF", "DG",
        "GT", "GR", "HG", "JC", "MC", "MN", "MS", "NT", "NL", "OC",
        "PL", "QT", "QR", "SP", "SL", "SR", "TC", "TS", "TL", "VZ",
        "YN", "ZS", "NE"
    }

    ' Valida si la CURP tiene el formato correcto
    Public Shared Function Validar(curp As String) As Boolean
        Return ValidarConMensaje(curp).Valido
    End Function

    ' Método para mostrar errores específicos de validación
    Public Shared Function ValidarConMensaje(curp As String) As ResultadoValidacion
        If String.IsNullOrEmpty(curp) Then
            Return New ResultadoValidacion(False, "La CURP no puede estar vacía.")
        End If

        If curp.Length <> 18 Then
            Return New ResultadoValidacion(False, "La CURP debe tener 18 caracteres.")
        End If

        curp = curp.ToUpper()

        ' Expresión regular corregida
        Dim regexCurp As String = "^[A-Z]{4}[0-9]{6}[HM]{1}[A-Z]{2}[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{2}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(curp, regexCurp) Then
            Return New ResultadoValidacion(False, "Formato de CURP incorrecto.")
        End If

        ' Validar fecha
        Dim fechaString As String = curp.Substring(4, 6) ' AAMMDD desde índice 4
        Try
            Dim año As Integer = Integer.Parse(fechaString.Substring(0, 2))
            Dim mes As Integer = Integer.Parse(fechaString.Substring(2, 2))
            Dim dia As Integer = Integer.Parse(fechaString.Substring(4, 2))

            If año < 30 Then
                año += 2000
            Else
                año += 1900
            End If

            Dim fechaNacimiento As New Date(año, mes, dia)
            If fechaNacimiento > Date.Today Then
                Return New ResultadoValidacion(False, "La fecha de nacimiento no puede ser futura.")
            End If
        Catch ex As Exception
            Return New ResultadoValidacion(False, "La fecha en la CURP es inválida.")
        End Try

        ' Validar entidad federativa
        Dim entidad As String = curp.Substring(11, 2)
        If Not Array.Exists(entidadesFederativas, Function(e) e = entidad) Then
            Return New ResultadoValidacion(False, "La entidad federativa en la CURP es inválida.")
        End If

        Return New ResultadoValidacion(True, "CURP válida.")
    End Function
End Class
