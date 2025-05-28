
''' <summary>
''' 
''' </summary>
Public Class theGlobal
    Private Shared dbInstance As theGlobal
    Private Shared ReadOnly lockObj As New Object()
    Private locked As Boolean = True
    Private tablesObjects() As TableInfo = New TableInfo() {New Administrador(), New Solicitud(), New Municipio(), New Alumno()}
    Private currentTable As Integer
    Private Property theTable() As TableInfo
        Get
            Return tablesObjects(currentTable)
        End Get
        Set(value As TableInfo)

        End Set
    End Property

    Enum Tables As Integer
        Administrador = 0
        Solicitud = 1
        Municipio = 2
        Alumno = 3

    End Enum

    Enum FORMS
        LogIn
        Menu
        AlumnosCRUD
        Tickets
        Dashboard
    End Enum



    Public Function getTable() As Dictionary(Of String, String)
        Return theTable.getTable()
    End Function

    Public Function setTable() As Boolean
        Return theTable.setTable()
    End Function

    Public Function delateTable() As Boolean
        Return theTable.delateTable()
    End Function

    Public Function createTable() As Boolean
        Return theTable.createTable()
    End Function

    Public Sub setInformation(key As String, value As String)
        theTable.setInformation(key, value)
    End Sub

    Public Function getInformation(key As String) As String
        Return theTable.getInformation(key)
    End Function

    Public Function isKeyValue(key As String, value As String) As Boolean
        Return theTable.isKeyValue(key, value)
    End Function

    Public Function getColumnsOfTable(theTableName As String, row As String) As List(Of String)
        Return theTable.getColumnsOfTable(theTableName, row)

    End Function



    Public Sub changeForm(from As Form, goingTo As FORMS)
        Dim newForm As Form
        Select Case goingTo
            Case FORMS.LogIn
                tablesObjects(Tables.Administrador) = New Administrador()
                newForm = New LoginForm()
                currentTable = Tables.Administrador
            Case FORMS.AlumnosCRUD
                newForm = New AlumnoFormCRUD()
                tablesObjects(Tables.Alumno) = New Alumno()
                currentTable = Tables.Alumno
            Case FORMS.Menu
                currentTable = Tables.Administrador
                If locked Then
                    changeForm(from, FORMS.LogIn)
                    Return
                End If
                newForm = New MenuForm()

            Case FORMS.Tickets
                newForm = New TicketsForm()
                currentTable = Tables.Solicitud
            Case FORMS.Dashboard
                newForm = New DashBoard()
                currentTable = Tables.Solicitud
            Case Else
                newForm = New LoginForm()
        End Select

        from.Hide()
        newForm.Show()

    End Sub

    Public Function login(password As String) As Boolean
        getTable()
        If String.IsNullOrEmpty(password) Then
            Return False
        End If
        If isKeyValue("Contrasena", password) Then
            locked = False
            Return True
        End If

        Return False
    End Function

    Public Sub logout(from As Form)

        tablesObjects = {New Administrador(), New Solicitud(), New Municipio(), New Alumno()}
        locked = True
        changeForm(from, FORMS.LogIn)
    End Sub

    Public Shared ReadOnly Property Instance As theGlobal
        Get
            If dbInstance Is Nothing Then
                SyncLock lockObj
                    If dbInstance Is Nothing Then
                        dbInstance = New theGlobal()
                    End If
                End SyncLock
            End If
            Return dbInstance
        End Get
    End Property




End Class
