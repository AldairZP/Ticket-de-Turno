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

    Public Function InsertAdministrator(username As String, password As String) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Administrador (Usuario, Contraseña) VALUES (?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", username)
                cmd.Parameters.AddWithValue("?", password)
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

    ' ------------------ CRUD: STUDENT ------------------

    Public Function InsertStudent(curp As String, firstName As String, lastName1 As String, lastName2 As String,
                                  phone As String, email As String, educationLevel As String, municipalityId As Integer) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Alumno (Curp, Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Correo, NivelEscolar, MunicipioID) " &
                                  "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", curp)
                cmd.Parameters.AddWithValue("?", firstName)
                cmd.Parameters.AddWithValue("?", lastName1)
                cmd.Parameters.AddWithValue("?", lastName2)
                cmd.Parameters.AddWithValue("?", phone)
                cmd.Parameters.AddWithValue("?", email)
                cmd.Parameters.AddWithValue("?", educationLevel)
                cmd.Parameters.AddWithValue("?", municipalityId)
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

    Public Function GetAllStudents() As DataTable
        Dim table As New DataTable()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Alumno"
            Using cmd As New OleDbCommand(query, connection)
                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching students: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return table
    End Function

    ' ------------------ CRUD: MUNICIPALITY ------------------

    Public Function InsertMunicipality(name As String) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Municipio (Nombre) VALUES (?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", name)
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

    Public Function GetAllMunicipalities() As DataTable
        Dim table As New DataTable()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Municipio"
            Using cmd As New OleDbCommand(query, connection)
                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching municipalities: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return table
    End Function

    ' ------------------ CRUD: REQUEST ------------------

    Public Function InsertRequest(curpStudent As String, requestedBy As String, subject As String,
                                  status As String, turnNumber As Integer, registrationDate As Date) As Boolean
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO Solicitud (CurpAlumno, QuienTramita, Asunto, Status, NumeroTurno, FechaRegistro) " &
                                  "VALUES (?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("?", curpStudent)
                cmd.Parameters.AddWithValue("?", requestedBy)
                cmd.Parameters.AddWithValue("?", subject)
                cmd.Parameters.AddWithValue("?", status)
                cmd.Parameters.AddWithValue("?", turnNumber)
                cmd.Parameters.AddWithValue("?", registrationDate)
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

    Public Function GetAllRequests() As DataTable
        Dim table As New DataTable()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Solicitud"
            Using cmd As New OleDbCommand(query, connection)
                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching requests: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return table
    End Function
End Class
