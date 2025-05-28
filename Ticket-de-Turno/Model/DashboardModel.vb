Imports System.Data.OleDb

Public Class DashboardModel
    Private Shared ReadOnly connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=tickets.mdb;"

    Public Structure EstadisticasModel
        Public Pendientes As Integer
        Public Resueltos As Integer
        Public Total As Integer

        Public Function PorcentajePendientes() As Double
            If Total > 0 Then
                Return Math.Round((Pendientes / Total) * 100, 2)
            End If
            Return 0
        End Function

        Public Function PorcentajeResueltos() As Double
            If Total > 0 Then
                Return Math.Round((Resueltos / Total) * 100, 2)
            End If
            Return 0
        End Function
    End Structure

    ''' <summary>
    ''' Obtiene las estadísticas totales de todas las solicitudes
    ''' </summary>
    ''' <returns>Estructura con las estadísticas</returns>
    Public Shared Function ObtenerEstadisticasTotales() As EstadisticasModel
        Dim estadisticas As New EstadisticasModel()

        Try
            Using conexion As New OleDbConnection(connectionString)
                conexion.Open()

                ' Consulta para contar solicitudes pendientes
                Dim queryPendientes As String = "SELECT COUNT(*) FROM Solicitud WHERE Estatus = 'Pendiente'"
                Using cmdPendientes As New OleDbCommand(queryPendientes, conexion)
                    estadisticas.Pendientes = Convert.ToInt32(cmdPendientes.ExecuteScalar())
                End Using

                ' Consulta para contar solicitudes resueltas
                Dim queryResueltos As String = "SELECT COUNT(*) FROM Solicitud WHERE Estatus = 'Resuelto'"
                Using cmdResueltos As New OleDbCommand(queryResueltos, conexion)
                    estadisticas.Resueltos = Convert.ToInt32(cmdResueltos.ExecuteScalar())
                End Using

                estadisticas.Total = estadisticas.Pendientes + estadisticas.Resueltos
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener estadísticas totales: " & ex.Message)
        End Try

        Return estadisticas
    End Function

    ''' <summary>
    ''' Obtiene las estadísticas de solicitudes por municipio específico
    ''' </summary>
    ''' <param name="municipioID">ID del municipio</param>
    ''' <returns>Estructura con las estadísticas</returns>
    Public Shared Function ObtenerEstadisticasPorMunicipio(municipioID As String) As EstadisticasModel
        Dim estadisticas As New EstadisticasModel()

        Try
            Using conexion As New OleDbConnection(connectionString)
                conexion.Open()

                ' Consulta para contar solicitudes pendientes por municipio
                Dim queryPendientes As String = "SELECT COUNT(*) FROM Solicitud s " &
                                               "INNER JOIN Alumno a ON s.CURP_Alumno = a.Curp " &
                                               "WHERE a.MunicipioID = ? AND s.Estatus = 'Pendiente'"
                Using cmdPendientes As New OleDbCommand(queryPendientes, conexion)
                    cmdPendientes.Parameters.AddWithValue("?", municipioID)
                    estadisticas.Pendientes = Convert.ToInt32(cmdPendientes.ExecuteScalar())
                End Using

                ' Consulta para contar solicitudes resueltas por municipio
                Dim queryResueltos As String = "SELECT COUNT(*) FROM Solicitud s " &
                                              "INNER JOIN Alumno a ON s.CURP_Alumno = a.Curp " &
                                              "WHERE a.MunicipioID = ? AND s.Estatus = 'Resuelto'"
                Using cmdResueltos As New OleDbCommand(queryResueltos, conexion)
                    cmdResueltos.Parameters.AddWithValue("?", municipioID)
                    estadisticas.Resueltos = Convert.ToInt32(cmdResueltos.ExecuteScalar())
                End Using

                estadisticas.Total = estadisticas.Pendientes + estadisticas.Resueltos
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener estadísticas por municipio: " & ex.Message)
        End Try

        Return estadisticas
    End Function

    ''' <summary>
    ''' Obtiene el ID de un municipio por su nombre
    ''' </summary>
    ''' <param name="nombreMunicipio">Nombre del municipio</param>
    ''' <returns>ID del municipio</returns>
    Public Shared Function ObtenerMunicipioID(nombreMunicipio As String) As String
        Dim municipioID As String = "1" ' Valor predeterminado

        Try
            Using conexion As New OleDbConnection(connectionString)
                conexion.Open()

                Dim query As String = "SELECT ID FROM Municipio WHERE Nombre = ?"
                Using cmd As New OleDbCommand(query, conexion)
                    cmd.Parameters.AddWithValue("?", nombreMunicipio)
                    Dim resultado As Object = cmd.ExecuteScalar()

                    If resultado IsNot Nothing Then
                        municipioID = resultado.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener ID de municipio: " & ex.Message)
        End Try

        Return municipioID
    End Function

    ''' <summary>
    ''' Obtiene las estadísticas según el filtro de municipio
    ''' </summary>
    ''' <param name="municipioSeleccionado">Nombre del municipio o "Todos"</param>
    ''' <returns>Estructura con las estadísticas</returns>
    Public Shared Function ObtenerEstadisticasPorFiltro(municipioSeleccionado As String) As EstadisticasModel
        If municipioSeleccionado = "Todos" Then
            Return ObtenerEstadisticasTotales()
        Else
            Dim municipioID As String = ObtenerMunicipioID(municipioSeleccionado)
            Return ObtenerEstadisticasPorMunicipio(municipioID)
        End If
    End Function
End Class
