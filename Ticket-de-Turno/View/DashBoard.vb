Public Class DashBoard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        theGlobal.Instance.changeForm(Me, theGlobal.FORMS.Menu)
    End Sub

    Private Sub toClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        theGlobal.Instance.logout(Me)
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar el combobox de municipios
        CargarMunicipios()

        ' Cargar datos iniciales (todas las solicitudes)
        ActualizarGrafica()
    End Sub

    Private Sub CargarMunicipios()
        ' Agregar opción para mostrar todos los municipios
        CBMunicipio.Items.Add("Todos")

        ' Cargar lista de municipios desde la base de datos
        Dim municipios As List(Of String) = theGlobal.Instance.getColumnsOfTable("Municipio", "Nombre")
        For Each municipio As String In municipios
            CBMunicipio.Items.Add(municipio)
        Next

        ' Seleccionar "Todos" por defecto
        CBMunicipio.SelectedIndex = 0
    End Sub

    Private Sub ActualizarGrafica()
        Try
            ' Limpiar series existentes
            Chart1.Series.Clear()

            ' Crear nueva serie para el gráfico
            Dim serie As New DataVisualization.Charting.Series("Solicitudes")
            serie.ChartType = DataVisualization.Charting.SeriesChartType.Pie

            ' Agregar la serie al gráfico
            Chart1.Series.Add(serie)

            ' Obtener los datos según el filtro seleccionado usando el modelo
            Dim municipioSeleccionado As String = CBMunicipio.SelectedItem.ToString()
            Dim estadisticas As DashboardModel.EstadisticasModel = DashboardModel.ObtenerEstadisticasPorFiltro(municipioSeleccionado)

            ' Agregar datos al gráfico
            serie.Points.AddXY("Pendientes", estadisticas.Pendientes)
            serie.Points(0).Color = Color.Red
            serie.Points(0).LegendText = "Pendientes: " & estadisticas.Pendientes

            serie.Points.AddXY("Resueltos", estadisticas.Resueltos)
            serie.Points(1).Color = Color.Green
            serie.Points(1).LegendText = "Resueltos: " & estadisticas.Resueltos

            ' Personalizar apariencia del gráfico
            Chart1.Titles.Clear()
            Dim titulo As String = "Estatus de Solicitudes"
            If municipioSeleccionado <> "Todos" Then
                titulo &= " - " & municipioSeleccionado
            End If
            Chart1.Titles.Add(titulo)

            ' Actualizar la leyenda
            Chart1.Legends(0).Docking = DataVisualization.Charting.Docking.Bottom

            ' Habilitar etiquetas de datos con porcentajes
            serie.IsValueShownAsLabel = True
            serie.LabelFormat = "#.##'%'"

            ' Mostrar porcentajes usando los métodos del modelo
            If estadisticas.Total > 0 Then
                serie.Points(0).SetCustomProperty("PieLabelStyle", "Outside")
                serie.Points(0).Label = estadisticas.PorcentajePendientes() & "%"
                serie.Points(1).SetCustomProperty("PieLabelStyle", "Outside")
                serie.Points(1).Label = estadisticas.PorcentajeResueltos() & "%"
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la gráfica: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CBMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMunicipio.SelectedIndexChanged
        ' Actualizar gráfica cuando cambia la selección del municipio
        ActualizarGrafica()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        ' No es necesario implementar acción al hacer clic en el gráfico
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class