Public Class Solicitud
    Private _id As Integer
    Private _curpAlumno As String
    Private _quienTramita As String
    Private _asunto As String
    Private _estatus As String
    Private _numeroTurno As String
    Private _fechaRegistro As Date

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property CURP_Alumno() As String
        Get
            Return _curpAlumno
        End Get
        Set(value As String)
            _curpAlumno = value
        End Set
    End Property

    Public Property QuienTramita() As String
        Get
            Return _quienTramita
        End Get
        Set(value As String)
            _quienTramita = value
        End Set
    End Property

    Public Property Asunto() As String
        Get
            Return _asunto
        End Get
        Set(value As String)
            _asunto = value
        End Set
    End Property

    Public Property Estatus() As String
        Get
            Return _estatus
        End Get
        Set(value As String)
            _estatus = value
        End Set
    End Property

    Public Property NumeroTurno() As String
        Get
            Return _numeroTurno
        End Get
        Set(value As String)
            _numeroTurno = value
        End Set
    End Property

    Public Property FechaRegistro() As Date
        Get
            Return _fechaRegistro
        End Get
        Set(value As Date)
            _fechaRegistro = value
        End Set
    End Property
End Class
