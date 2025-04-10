Imports System.Data.OleDb

Public Class DBManager
    Private Shared dbInstance As DBManager
    Private Shared ReadOnly lockObj As New Object()
    Private connection As OleDbConnection

    ' Path to your Access database file
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=tickets.mdb;"

    Private Sub New()
        connection = New OleDbConnection(connectionString)
    End Sub

    Public Shared ReadOnly Property Instance As DBManager
        Get
            If dbInstance Is Nothing Then
                SyncLock lockObj
                    If dbInstance Is Nothing Then
                        dbInstance = New DBManager()
                    End If
                End SyncLock
            End If
            Return dbInstance
        End Get
    End Property

    Public Sub OpenConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' ------------------ CRUD: ADMINISTRATOR ------------------

    Public Function InsertAdministrator(administrador As Administrador) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Administrador (Usuario, Contrasena) VALUES (?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", administrador.Usuario)
                cmd.Parameters.AddWithValue("?", administrador.Contrasena)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error inserting administrator: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function LoginAdministrator(userID As String, password As String) As Boolean
        Try
            OpenConnection()
            Dim query As String = "SELECT COUNT(*) FROM Administrador WHERE ID = ? AND Contrasena = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", userID)
                cmd.Parameters.AddWithValue("?", password)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function GetAllAdministrators() As List(Of Administrador)
        Dim administrators As New List(Of Administrador)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Administrador"
            Using cmd As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim administrador As New Administrador()
                        administrador.ID = Convert.ToInt32(reader("ID"))
                        administrador.Usuario = reader("Usuario").ToString()
                        administrador.Contrasena = reader("Contrasena").ToString()
                        administrators.Add(administrador)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching administrators: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return administrators
    End Function

    Public Function GetAdministratorById(id As Integer) As Administrador
        Dim administrador As Administrador = Nothing
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Administrador WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", id)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        administrador = New Administrador With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Usuario = reader("Usuario").ToString(),
                            .Contrasena = reader("Contrasena").ToString()
                        }
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching administrator: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return administrador
    End Function

    Public Function UpdateAdministrator(administrador As Administrador) As Boolean
        Try
            OpenConnection()
            Dim query As String = "UPDATE Administrador SET Usuario = ?, Contrasena = ? WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", administrador.Usuario)
                cmd.Parameters.AddWithValue("?", administrador.Contrasena)
                cmd.Parameters.AddWithValue("?", administrador.ID)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating administrator: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function DeleteAdministrator(id As Integer) As Boolean
        Try
            OpenConnection()
            Dim query As String = "DELETE FROM Administrador WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", id)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error deleting administrator: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    ' ------------------ CRUD: STUDENT ------------------

    Public Function InsertStudent(alumno As Alumno) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Alumno (Curp, Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Correo, NivelEscolar, MunicipioID) " &
                                  "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", alumno.CURP)
                cmd.Parameters.AddWithValue("?", alumno.Nombre)
                cmd.Parameters.AddWithValue("?", alumno.ApellidoPaterno)
                cmd.Parameters.AddWithValue("?", alumno.ApellidoMaterno)
                cmd.Parameters.AddWithValue("?", alumno.Telefono)
                cmd.Parameters.AddWithValue("?", alumno.Correo)
                cmd.Parameters.AddWithValue("?", alumno.NivelEscolar)
                cmd.Parameters.AddWithValue("?", alumno.MunicipioID)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error inserting student: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function GetAllStudents() As List(Of Alumno)
        Dim students As New List(Of Alumno)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Alumno"
            Using cmd As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim alumno As New Alumno()
                        alumno.CURP = reader("Curp").ToString()
                        alumno.Nombre = reader("Nombre").ToString()
                        alumno.ApellidoPaterno = reader("ApellidoPaterno").ToString()
                        alumno.ApellidoMaterno = reader("ApellidoMaterno").ToString()
                        alumno.Telefono = reader("Telefono").ToString()
                        alumno.Correo = reader("Correo").ToString()
                        alumno.NivelEscolar = reader("NivelEscolar").ToString()
                        alumno.MunicipioID = Convert.ToInt32(reader("MunicipioID"))
                        students.Add(alumno)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching students: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return students
    End Function

    Public Function GetStudentByCURP(curp As String) As Alumno
        Dim alumno As Alumno = Nothing
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Alumno WHERE Curp = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", curp)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        alumno = New Alumno With {
                            .CURP = reader("Curp").ToString(),
                            .Nombre = reader("Nombre").ToString(),
                            .ApellidoPaterno = reader("ApellidoPaterno").ToString(),
                            .ApellidoMaterno = reader("ApellidoMaterno").ToString(),
                            .Telefono = reader("Telefono").ToString(),
                            .Correo = reader("Correo").ToString(),
                            .NivelEscolar = reader("NivelEscolar").ToString(),
                            .MunicipioID = Convert.ToInt32(reader("MunicipioID"))
                        }
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching student: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return alumno
    End Function

    Public Function UpdateStudent(alumno As Alumno) As Boolean
        Try
            OpenConnection()
            Dim query As String = "UPDATE Alumno SET Nombre = ?, ApellidoPaterno = ?, ApellidoMaterno = ?, " &
                                 "Telefono = ?, Correo = ?, NivelEscolar = ?, MunicipioID = ? WHERE Curp = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", alumno.Nombre)
                cmd.Parameters.AddWithValue("?", alumno.ApellidoPaterno)
                cmd.Parameters.AddWithValue("?", alumno.ApellidoMaterno)
                cmd.Parameters.AddWithValue("?", alumno.Telefono)
                cmd.Parameters.AddWithValue("?", alumno.Correo)
                cmd.Parameters.AddWithValue("?", alumno.NivelEscolar)
                cmd.Parameters.AddWithValue("?", alumno.MunicipioID)
                cmd.Parameters.AddWithValue("?", alumno.CURP)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function DeleteStudent(curp As String) As Boolean
        Try
            OpenConnection()
            Dim query As String = "DELETE FROM Alumno WHERE Curp = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", curp)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    ' ------------------ CRUD: MUNICIPALITY ------------------

    Public Function InsertMunicipality(municipio As Municipio) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Municipio (Nombre) VALUES (?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", municipio.Nombre)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error inserting municipality: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function GetAllMunicipalities() As List(Of Municipio)
        Dim municipalities As New List(Of Municipio)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Municipio"
            Using cmd As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim municipio As New Municipio()
                        municipio.ID = Convert.ToInt32(reader("ID"))
                        municipio.Nombre = reader("Nombre").ToString()
                        municipalities.Add(municipio)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching municipalities: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return municipalities
    End Function

    Public Function GetMunicipalityById(id As Integer) As Municipio
        Dim municipio As Municipio = Nothing
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Municipio WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", id)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        municipio = New Municipio With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Nombre = reader("Nombre").ToString()
                        }
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching municipality: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return municipio
    End Function

    Public Function UpdateMunicipality(municipio As Municipio) As Boolean
        Try
            OpenConnection()
            Dim query As String = "UPDATE Municipio SET Nombre = ? WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", municipio.Nombre)
                cmd.Parameters.AddWithValue("?", municipio.ID)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating municipality: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function DeleteMunicipality(id As Integer) As Boolean
        Try
            OpenConnection()
            Dim query As String = "DELETE FROM Municipio WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", id)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error deleting municipality: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    ' ------------------ CRUD: REQUEST ------------------

    Public Function InsertRequest(solicitud As Solicitud) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Solicitud (CurpAlumno, QuienTramita, Asunto, Status, NumeroTurno, FechaRegistro) " &
                                  "VALUES (?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", solicitud.CURP_Alumno)
                cmd.Parameters.AddWithValue("?", solicitud.QuienTramita)
                cmd.Parameters.AddWithValue("?", solicitud.Asunto)
                cmd.Parameters.AddWithValue("?", solicitud.Estatus)
                cmd.Parameters.AddWithValue("?", solicitud.NumeroTurno)
                cmd.Parameters.AddWithValue("?", solicitud.FechaRegistro)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error inserting request: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function GetAllRequests() As List(Of Solicitud)
        Dim requests As New List(Of Solicitud)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Solicitud"
            Using cmd As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim solicitud As New Solicitud()
                        solicitud.ID = Convert.ToInt32(reader("ID"))
                        solicitud.CURP_Alumno = reader("CurpAlumno").ToString()
                        solicitud.QuienTramita = reader("QuienTramita").ToString()
                        solicitud.Asunto = reader("Asunto").ToString()
                        solicitud.Estatus = reader("Status").ToString()
                        solicitud.NumeroTurno = reader("NumeroTurno").ToString()
                        solicitud.FechaRegistro = Convert.ToDateTime(reader("FechaRegistro"))
                        requests.Add(solicitud)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching requests: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return requests
    End Function

    Public Function GetRequestById(id As Integer) As Solicitud
        Dim solicitud As Solicitud = Nothing
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Solicitud WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", id)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        solicitud = New Solicitud With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .CURP_Alumno = reader("CurpAlumno").ToString(),
                            .QuienTramita = reader("QuienTramita").ToString(),
                            .Asunto = reader("Asunto").ToString(),
                            .Estatus = reader("Status").ToString(),
                            .NumeroTurno = reader("NumeroTurno").ToString(),
                            .FechaRegistro = Convert.ToDateTime(reader("FechaRegistro"))
                        }
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching request: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return solicitud
    End Function

    Public Function UpdateRequest(solicitud As Solicitud) As Boolean
        Try
            OpenConnection()
            Dim query As String = "UPDATE Solicitud SET CurpAlumno = ?, QuienTramita = ?, Asunto = ?, " &
                                 "Status = ?, NumeroTurno = ?, FechaRegistro = ? WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", solicitud.CURP_Alumno)
                cmd.Parameters.AddWithValue("?", solicitud.QuienTramita)
                cmd.Parameters.AddWithValue("?", solicitud.Asunto)
                cmd.Parameters.AddWithValue("?", solicitud.Estatus)
                cmd.Parameters.AddWithValue("?", solicitud.NumeroTurno)
                cmd.Parameters.AddWithValue("?", solicitud.FechaRegistro)
                cmd.Parameters.AddWithValue("?", solicitud.ID)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating request: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function DeleteRequest(id As Integer) As Boolean
        Try
            OpenConnection()
            Dim query As String = "DELETE FROM Solicitud WHERE ID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", id)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error deleting request: " & ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    ' ------------------ ADDITIONAL UTILITY METHODS ------------------

    Public Function GetRequestsByStudent(curp As String) As List(Of Solicitud)
        Dim requests As New List(Of Solicitud)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Solicitud WHERE CurpAlumno = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", curp)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim solicitud As New Solicitud With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .CURP_Alumno = reader("CurpAlumno").ToString(),
                            .QuienTramita = reader("QuienTramita").ToString(),
                            .Asunto = reader("Asunto").ToString(),
                            .Estatus = reader("Status").ToString(),
                            .NumeroTurno = reader("NumeroTurno").ToString(),
                            .FechaRegistro = Convert.ToDateTime(reader("FechaRegistro"))
                        }
                        requests.Add(solicitud)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching requests by student: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return requests
    End Function

    Public Function GetStudentsByMunicipality(municipalityId As Integer) As List(Of Alumno)
        Dim students As New List(Of Alumno)
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Alumno WHERE MunicipioID = ?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", municipalityId)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim alumno As New Alumno()
                        alumno.CURP = reader("Curp").ToString()
                        alumno.Nombre = reader("Nombre").ToString()
                        alumno.ApellidoPaterno = reader("ApellidoPaterno").ToString()
                        alumno.ApellidoMaterno = reader("ApellidoMaterno").ToString()
                        alumno.Telefono = reader("Telefono").ToString()
                        alumno.Correo = reader("Correo").ToString()
                        alumno.NivelEscolar = reader("NivelEscolar").ToString()
                        alumno.MunicipioID = Convert.ToInt32(reader("MunicipioID"))
                        students.Add(alumno)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching students by municipality: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return students
    End Function
End Class
