Public Class CURPValidator
    ' Lista de códigos de entidades federativas válidos
    Private Shared ReadOnly entidadesFederativas As String() = {"AS", "BC", "BS", "CC", "CL", "CM", "CS", "CH", "DF", "DG", "GT", "GR", "HG", "JC", "MC", "MN", "MS", "NT", "NL", "OC", "PL", "QT", "QR", "SP", "SL", "SR", "TC", "TS", "TL", "VZ", "YN", "ZS", "NE"}

    ' Valida si la CURP tiene el formato correcto
    Public Shared Function Validar(curp As String) As Boolean
        ' Si es null o vacío, no es válido
        If String.IsNullOrEmpty(curp) Then
            Return False
        End If

        ' Debe tener 18 caracteres
        If curp.Length <> 18 Then
            Return False
        End If

        ' Convertir a mayúsculas para facilitar la comparación
        curp = curp.ToUpper()

        ' Verificar el formato general usando expresión regular
        ' Formato: LETRAS(4) + LETRAS(2) + LETRAS(2) + NUMEROS(6) + H/M + ENTIDAD(2) + CONSONANTES(3) + ALFANUMERICO(1)
        Dim formatoValido As Boolean = System.Text.RegularExpressions.Regex.IsMatch(curp, "^[A-Z]{4}[A-Z]{2}[A-Z]{2}[0-9]{6}[HM][A-Z]{2}[A-Z0-9]{3}[0-9A-Z]$")
        If Not formatoValido Then
            Return False
        End If

        ' Validar fecha (posiciones 8-13)
        Dim fechaString As String = curp.Substring(8, 6)
        Dim año As Integer
        Dim mes As Integer
        Dim dia As Integer

        Try
            año = Integer.Parse(fechaString.Substring(0, 2))
            mes = Integer.Parse(fechaString.Substring(2, 2))
            dia = Integer.Parse(fechaString.Substring(4, 2))

            ' Ajustar el año considerando el siglo
            If año < 20 Then
                año += 2000
            Else
                año += 1900
            End If

            ' Validar que sea una fecha válida
            Dim fecha As New Date(año, mes, dia)

            ' La fecha no debe ser futura
            If fecha > Date.Today Then
                Return False
            End If
        Catch ex As Exception
            ' Si hay error al convertir, la fecha es inválida
            Return False
        End Try

        ' Validar entidad federativa (posiciones 16-17)
        Dim entidad As String = curp.Substring(11, 2)
        If Not Array.Exists(entidadesFederativas, Function(e) e = entidad) Then
            Return False
        End If

        ' Si llegamos hasta aquí, la CURP es válida
        Return True
    End Function

    ' Método para mostrar errores específicos de validación
    Public Shared Function ValidarConMensaje(curp As String) As (Valido As Boolean, Mensaje As String)
        ' Si es null o vacío, no es válido
        If String.IsNullOrEmpty(curp) Then
            Return (False, "La CURP no puede estar vacía.")
        End If

        ' Debe tener 18 caracteres
        If curp.Length <> 18 Then
            Return (False, "La CURP debe tener 18 caracteres.")
        End If

        ' Convertir a mayúsculas para facilitar la comparación
        curp = curp.ToUpper()

        ' Verificar el formato general usando expresión regular
        Dim formatoValido As Boolean = System.Text.RegularExpressions.Regex.IsMatch(curp, "^[A-Z]{4}[A-Z]{2}[A-Z]{2}[0-9]{6}[HM][A-Z]{2}[A-Z0-9]{3}[0-9A-Z]$")
        If Not formatoValido Then
            Return (False, "Formato de CURP incorrecto.")
        End If

        ' Validar fecha (posiciones 8-13)
        Dim fechaString As String = curp.Substring(8, 6)
        Dim año As Integer
        Dim mes As Integer
        Dim dia As Integer

        Try
            año = Integer.Parse(fechaString.Substring(0, 2))
            mes = Integer.Parse(fechaString.Substring(2, 2))
            dia = Integer.Parse(fechaString.Substring(4, 2))

            ' Ajustar el año considerando el siglo
            If año < 20 Then
                año += 2000
            Else
                año += 1900
            End If

            ' Validar que sea una fecha válida
            Dim fecha As New Date(año, mes, dia)

            ' La fecha no debe ser futura
            If fecha > Date.Today Then
                Return (False, "La fecha de nacimiento no puede ser futura.")
            End If
        Catch ex As Exception
            ' Si hay error al convertir, la fecha es inválida
            Return (False, "La fecha en la CURP es inválida.")
        End Try

        ' Validar entidad federativa (posiciones 16-17)
        Dim entidad As String = curp.Substring(11, 2)
        If Not Array.Exists(entidadesFederativas, Function(e) e = entidad) Then
            Return (False, "La entidad federativa en la CURP es inválida.")
        End If

        ' Si llegamos hasta aquí, la CURP es válida
        Return (True, "CURP válida")
    End Function
End Class
