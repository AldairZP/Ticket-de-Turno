Imports System.Data.OleDb

Public Class Administrador
    Inherits TableInfo


    Public Sub New()
        table.Add("ID", "")
        table.Add("Usuario", "")
        table.Add("Contrasena", "")


    End Sub


    Public Overrides Function createTable() As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function delateTable() As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function getTable() As Dictionary(Of String, String)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Administrador WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", table("ID"))
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        table("Usuario") = reader("Usuario").ToString()
                        table("Contrasena") = reader("Contrasena").ToString()

                        Return New Dictionary(Of String, String)(table)

                    Else
                        
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
        Throw New NotImplementedException()
    End Function


End Class
