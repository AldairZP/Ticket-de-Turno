Imports System.Data.OleDb

Public Class Alumno
    Inherits TableInfo

    Public Sub New()
        table.Add("Curp", "")
        table.Add("Nombre", "")
        table.Add("ApellidoPaterno", "")
        table.Add("ApellidoMaterno", "")
        table.Add("Telefono", "")
        table.Add("Correo", "")
        table.Add("NivelEscolar", "")
        table.Add("MunicipioID", "")

    End Sub
    Public Overrides Function createTable() As Boolean

        Dim validacion As ResultadoValidacion = CURPValidator.ValidarConMensaje(table("Curp"))
        If Not validacion.Valido Then
            MessageBox.Show("Error inserting student: " & validacion.Mensaje)
            Return False
        End If
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Alumno (Curp, Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Correo, NivelEscolar, MunicipioID) " &
                                  "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("Curp"))
                cmd.Parameters.AddWithValue("?", table("Nombre"))
                cmd.Parameters.AddWithValue("?", table("ApellidoPaterno"))
                cmd.Parameters.AddWithValue("?", table("ApellidoMaterno"))
                cmd.Parameters.AddWithValue("?", table("Telefono"))
                cmd.Parameters.AddWithValue("?", table("Correo"))
                cmd.Parameters.AddWithValue("?", table("NivelEscolar"))
                cmd.Parameters.AddWithValue("?", Convert.ToInt32(table("MunicipioID")))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error inserting student: " & ex.Message)
            Dim result As String = String.Join(Environment.NewLine, table.Select(Function(kv) $"{kv.Key}: {kv.Value}"))
            MessageBox.Show(result)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Overrides Function getTable() As Dictionary(Of String, String)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Alumno WHERE Curp = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("Curp"))
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        table("Nombre") = reader("Nombre").ToString()
                        table("ApellidoPaterno") = reader("ApellidoPaterno").ToString()
                        table("ApellidoMaterno") = reader("ApellidoMaterno").ToString()
                        table("Telefono") = reader("Telefono").ToString()
                        table("Correo") = reader("Correo").ToString()
                        table("NivelEscolar") = reader("NivelEscolar").ToString()
                        table("MunicipioID") = reader("MunicipioID").ToString()
                        Return New Dictionary(Of String, String)(table)

                    Else
                        MessageBox.Show("Error fetching student: Alumno no encontrado")
                        Return Nothing
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching student: " & ex.Message)
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function

    Public Overrides Function setTable() As Boolean
        Try
            OpenConnection()
            Dim query As String = "UPDATE Alumno SET Nombre = ?, ApellidoPaterno = ?, ApellidoMaterno = ?, " &
                                 "Telefono = ?, Correo = ?, NivelEscolar = ?, MunicipioID = ? WHERE Curp = ?"
            Using cmd As New OleDbCommand(query, connection)

                cmd.Parameters.AddWithValue("?", table("Nombre"))
                cmd.Parameters.AddWithValue("?", table("ApellidoPaterno"))
                cmd.Parameters.AddWithValue("?", table("ApellidoMaterno"))
                cmd.Parameters.AddWithValue("?", table("Telefono"))
                cmd.Parameters.AddWithValue("?", table("Correo"))
                cmd.Parameters.AddWithValue("?", table("NivelEscolar"))
                cmd.Parameters.AddWithValue("?", table("MunicipioID"))
                cmd.Parameters.AddWithValue("?", table("Curp"))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try


        Return True
    End Function

    Public Overrides Function delateTable() As Boolean
        Try
            OpenConnection()
            Dim query As String = "DELETE FROM Alumno WHERE Curp = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("Curp"))
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
    Public Overrides Function getInformation(key As String) As String
        If key = "MunicipioID" Then
            Try
                OpenConnection()
                Dim query As String = "SELECT * FROM Municipio WHERE ID = ?"
                Using cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("?", table(key))
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return reader("Nombre").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching municipality: " & ex.Message)
                Return "Saltillo"
            Finally
                CloseConnection()
            End Try

        Else
            Return table(key)

        End If
        Return ""
    End Function
    Public Overrides Sub setInformation(key As String, value As String)

        If String.IsNullOrEmpty(value) Then
            Return
        End If
        If String.IsNullOrEmpty(key) Then
            Return
        End If
        If key = "MunicipioID" Then
            Try
                OpenConnection()
                Dim query As String = "SELECT * FROM Municipio WHERE Nombre = ?"
                Using cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("?", value)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            table(key) = reader("ID").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching municipality: " & ex.Message)
                table(key) = "1"
            Finally
                CloseConnection()
            End Try







        Else
            table(key) = value
        End If
    End Sub


End Class
