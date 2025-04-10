Public Class Alumno
    Private _curp As String
    Private _nombre As String
    Private _apellidoPaterno As String
    Private _apellidoMaterno As String
    Private _telefono As String
    Private _correo As String
    Private _nivelEscolar As String
    Private _municipioID As Integer

    Public Property CURP() As String
        Get
            Return _curp
        End Get
        Set(value As String)
            _curp = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property ApellidoPaterno() As String
        Get
            Return _apellidoPaterno
        End Get
        Set(value As String)
            _apellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno() As String
        Get
            Return _apellidoMaterno
        End Get
        Set(value As String)
            _apellidoMaterno = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property NivelEscolar() As String
        Get
            Return _nivelEscolar
        End Get
        Set(value As String)
            _nivelEscolar = value
        End Set
    End Property

    Public Property MunicipioID() As Integer
        Get
            Return _municipioID
        End Get
        Set(value As Integer)
            _municipioID = value
        End Set
    End Property
End Class
