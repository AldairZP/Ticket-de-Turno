<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnoFormCRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBcurp = New System.Windows.Forms.TextBox()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.TBpaterno = New System.Windows.Forms.TextBox()
        Me.TBmaterno = New System.Windows.Forms.TextBox()
        Me.TBtelefono = New System.Windows.Forms.TextBox()
        Me.TBcorreo = New System.Windows.Forms.TextBox()
        Me.TBidMunicipio = New System.Windows.Forms.TextBox()
        Me.CBnivelEscolar = New System.Windows.Forms.ComboBox()
        Me.BTNcrear = New System.Windows.Forms.Button()
        Me.BTNleer = New System.Windows.Forms.Button()
        Me.BTNactualizar = New System.Windows.Forms.Button()
        Me.BTNborrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CURP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nivel Escolar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ID de Municipio:"
        '
        'TBcurp
        '
        Me.TBcurp.Location = New System.Drawing.Point(149, 28)
        Me.TBcurp.Name = "TBcurp"
        Me.TBcurp.Size = New System.Drawing.Size(212, 20)
        Me.TBcurp.TabIndex = 8
        '
        'TBnombre
        '
        Me.TBnombre.Location = New System.Drawing.Point(149, 65)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(212, 20)
        Me.TBnombre.TabIndex = 9
        '
        'TBpaterno
        '
        Me.TBpaterno.Location = New System.Drawing.Point(149, 107)
        Me.TBpaterno.Name = "TBpaterno"
        Me.TBpaterno.Size = New System.Drawing.Size(212, 20)
        Me.TBpaterno.TabIndex = 10
        '
        'TBmaterno
        '
        Me.TBmaterno.Location = New System.Drawing.Point(149, 150)
        Me.TBmaterno.Name = "TBmaterno"
        Me.TBmaterno.Size = New System.Drawing.Size(212, 20)
        Me.TBmaterno.TabIndex = 11
        '
        'TBtelefono
        '
        Me.TBtelefono.Location = New System.Drawing.Point(149, 192)
        Me.TBtelefono.Name = "TBtelefono"
        Me.TBtelefono.Size = New System.Drawing.Size(212, 20)
        Me.TBtelefono.TabIndex = 12
        '
        'TBcorreo
        '
        Me.TBcorreo.Location = New System.Drawing.Point(149, 237)
        Me.TBcorreo.Name = "TBcorreo"
        Me.TBcorreo.Size = New System.Drawing.Size(212, 20)
        Me.TBcorreo.TabIndex = 13
        '
        'TBidMunicipio
        '
        Me.TBidMunicipio.Location = New System.Drawing.Point(149, 333)
        Me.TBidMunicipio.Name = "TBidMunicipio"
        Me.TBidMunicipio.Size = New System.Drawing.Size(212, 20)
        Me.TBidMunicipio.TabIndex = 15
        '
        'CBnivelEscolar
        '
        Me.CBnivelEscolar.FormattingEnabled = True
        Me.CBnivelEscolar.Items.AddRange(New Object() {"Educación Preescolar", "Educación Primaria", "Educación Secundaria", "Educación Media Superior", "Educación Superior"})
        Me.CBnivelEscolar.Location = New System.Drawing.Point(149, 284)
        Me.CBnivelEscolar.Name = "CBnivelEscolar"
        Me.CBnivelEscolar.Size = New System.Drawing.Size(212, 21)
        Me.CBnivelEscolar.TabIndex = 16
        '
        'BTNcrear
        '
        Me.BTNcrear.Location = New System.Drawing.Point(12, 388)
        Me.BTNcrear.Name = "BTNcrear"
        Me.BTNcrear.Size = New System.Drawing.Size(75, 23)
        Me.BTNcrear.TabIndex = 17
        Me.BTNcrear.Text = "Crear"
        Me.BTNcrear.UseVisualStyleBackColor = True
        '
        'BTNleer
        '
        Me.BTNleer.Location = New System.Drawing.Point(116, 388)
        Me.BTNleer.Name = "BTNleer"
        Me.BTNleer.Size = New System.Drawing.Size(75, 23)
        Me.BTNleer.TabIndex = 18
        Me.BTNleer.Text = "Leer"
        Me.BTNleer.UseVisualStyleBackColor = True
        '
        'BTNactualizar
        '
        Me.BTNactualizar.Location = New System.Drawing.Point(217, 388)
        Me.BTNactualizar.Name = "BTNactualizar"
        Me.BTNactualizar.Size = New System.Drawing.Size(75, 23)
        Me.BTNactualizar.TabIndex = 19
        Me.BTNactualizar.Text = "Actualizar"
        Me.BTNactualizar.UseVisualStyleBackColor = True
        '
        'BTNborrar
        '
        Me.BTNborrar.Location = New System.Drawing.Point(321, 388)
        Me.BTNborrar.Name = "BTNborrar"
        Me.BTNborrar.Size = New System.Drawing.Size(75, 23)
        Me.BTNborrar.TabIndex = 20
        Me.BTNborrar.Text = "Borrar"
        Me.BTNborrar.UseVisualStyleBackColor = True
        '
        'AlumnoFormCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 443)
        Me.Controls.Add(Me.BTNborrar)
        Me.Controls.Add(Me.BTNactualizar)
        Me.Controls.Add(Me.BTNleer)
        Me.Controls.Add(Me.BTNcrear)
        Me.Controls.Add(Me.CBnivelEscolar)
        Me.Controls.Add(Me.TBidMunicipio)
        Me.Controls.Add(Me.TBcorreo)
        Me.Controls.Add(Me.TBtelefono)
        Me.Controls.Add(Me.TBmaterno)
        Me.Controls.Add(Me.TBpaterno)
        Me.Controls.Add(Me.TBnombre)
        Me.Controls.Add(Me.TBcurp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AlumnoFormCRUD"
        Me.Text = "AlumnoFormCRUD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TBcurp As TextBox
    Friend WithEvents TBnombre As TextBox
    Friend WithEvents TBpaterno As TextBox
    Friend WithEvents TBmaterno As TextBox
    Friend WithEvents TBtelefono As TextBox
    Friend WithEvents TBcorreo As TextBox
    Friend WithEvents TBidMunicipio As TextBox
    Friend WithEvents CBnivelEscolar As ComboBox
    Friend WithEvents BTNcrear As Button
    Friend WithEvents BTNleer As Button
    Friend WithEvents BTNactualizar As Button
    Friend WithEvents BTNborrar As Button
End Class
