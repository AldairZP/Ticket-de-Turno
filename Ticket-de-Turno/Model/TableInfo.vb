Imports System.Data.OleDb

Public MustInherit Class TableInfo
    Private Const connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=tickets.mdb;"
    Protected connection As OleDbConnection
    Protected table As Dictionary(Of String, String) = New Dictionary(Of String, String)




    Public Overridable Sub setInformation(key As String, value As String)
        If String.IsNullOrEmpty(value) Then
            Return
        End If
        If String.IsNullOrEmpty(key) Then
            Return
        End If
        table(key) = value
    End Sub
    Public Overridable Function getInformation(key As String) As String
        Return table(key)
    End Function
    Public Overridable Function isKeyValue(key As String, value As String)
        Return table(key) = value
    End Function
    Public MustOverride Function getTable() As Dictionary(Of String, String)


    Public MustOverride Function setTable() As Boolean

    Public MustOverride Function delateTable() As Boolean

    Public MustOverride Function createTable() As Boolean


    Public Function getColumnsOfTable(theTable As String, row As String, Optional tableCondition As String = "", Optional paramValue As String = "") As List(Of String)
        Dim nombres As New List(Of String)

        Using conexion As New OleDbConnection(connectionString)
            Try
                conexion.Open()
                Dim query As String = $"SELECT [{row}] FROM [{theTable}]"

                If tableCondition <> "" AndAlso paramValue <> "" Then
                    query &= $" WHERE [{tableCondition}] = ?"
                End If

                Using cmd As New OleDbCommand(query, conexion)

                    ' Agrega parámetro solo si hay condición y valor
                    If tableCondition <> "" AndAlso paramValue <> "" Then
                        cmd.Parameters.AddWithValue("?", paramValue)
                    End If

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            nombres.Add(reader(row).ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener nombres: " & ex.Message)
            End Try
        End Using

        Return nombres
    End Function


    Protected Sub OpenConnection()
        If IsNothing(connection) Then
            connection = New OleDbConnection(connectionString)
        End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Protected Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
