Imports System.Data.OleDb

Public Class Solicitud
    Inherits TableInfo
    Public Sub New()
        table.Add("ID", "")
        table.Add("CURP_Alumno", "")
        table.Add("QuienTramita", "")
        table.Add("Asunto", "")
        table.Add("Estatus", "")
        table.Add("FechaRegistro", "")


    End Sub
    Public Overrides Function createTable() As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Solicitud (ID, CURP_Alumno, QuienTramita, Asunto, Estatus, FechaRegistro) " &
                          "VALUES (?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("ID"))
                cmd.Parameters.AddWithValue("?", table("CURP_Alumno"))
                cmd.Parameters.AddWithValue("?", table("QuienTramita"))
                cmd.Parameters.AddWithValue("?", table("Asunto"))
                cmd.Parameters.AddWithValue("?", table("Estatus"))
                cmd.Parameters.AddWithValue("?", table("FechaRegistro"))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error inserting request: " & ex.Message)
            Dim result As String = String.Join(Environment.NewLine, table.Select(Function(kv) $"{kv.Key}: {kv.Value}"))
            MessageBox.Show(result)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Overrides Function delateTable() As Boolean
        Try
            OpenConnection()
            Dim query As String = "DELETE FROM Solicitud WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("ID"))
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error deleting request: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Overrides Function getTable() As Dictionary(Of String, String)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Solicitud WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("ID"))

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        table("CURP_Alumno") = reader("CURP_Alumno").ToString()
                        table("QuienTramita") = reader("QuienTramita").ToString()
                        table("Asunto") = reader("Asunto").ToString()
                        table("Estatus") = reader("Estatus").ToString()
                        table("FechaRegistro") = reader("FechaRegistro").ToString()
                        Return New Dictionary(Of String, String)(table)
                    Else
                        MessageBox.Show("Error fetching request: Solicitud no encontrada")
                        Return Nothing
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching request: " & ex.Message)
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function

    Public Overrides Function setTable() As Boolean
        Try
            OpenConnection()
            Dim query As String = "UPDATE Solicitud SET CURP_Alumno = ?, QuienTramita = ?, Asunto = ?, " &
                      "Estatus = ?, FechaRegistro = ? WHERE ID = ?"

            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("CURP_Alumno"))
                cmd.Parameters.AddWithValue("?", table("QuienTramita"))
                cmd.Parameters.AddWithValue("?", table("Asunto"))
                cmd.Parameters.AddWithValue("?", table("Estatus"))
                cmd.Parameters.AddWithValue("?", table("FechaRegistro"))
                cmd.Parameters.AddWithValue("?", table("ID"))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating request: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try


        Return True
    End Function

    Public Overrides Sub setInformation(key As String, value As String)
        If key = "ID" Then
            If value.Contains("-") Then
                table(key) = value
                Return
            End If
            Try
                OpenConnection()
                Dim query As String = "SELECT COUNT(*) AS TotalRegistros FROM Solicitud WHERE ID LIKE ?"
                Using cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("?", $"{value}-%")
                    Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    table(key) = $"{value}-{total}"

                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching Ticket wowow: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        ElseIf key = "CURP_Alumno" Then
            Try
                OpenConnection()
                Dim query As String = "SELECT * FROM Alumno WHERE Curp = ?"
                Using cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("?", value)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim curp As String = reader("Curp").ToString()
                            Dim municipioID As String = reader("MunicipioID").ToString()

                            table(key) = curp

                            If String.IsNullOrEmpty(table("ID")) Or table("ID") = "-" Then
                                MessageBox.Show("Miku: ")
                                setInformation("ID", municipioID)
                                MessageBox.Show("romas: ")

                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching Ticket asf: " & ex.Message)

            Finally
                CloseConnection()
            End Try
        Else
            table(key) = value
        End If
    End Sub
End Class
