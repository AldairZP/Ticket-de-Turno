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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlumnoFormCRUD))
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
        Me.CBnivelEscolar = New System.Windows.Forms.ComboBox()
        Me.BTNcrear = New System.Windows.Forms.Button()
        Me.BTNleer = New System.Windows.Forms.Button()
        Me.BTNactualizar = New System.Windows.Forms.Button()
        Me.BTNborrar = New System.Windows.Forms.Button()
        Me.CBMunicipio = New System.Windows.Forms.ComboBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(148, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CURP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(148, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(148, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(148, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(148, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(148, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(148, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nivel Escolar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(148, 456)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ID de Municipio:"
        '
        'TBcurp
        '
        Me.TBcurp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TBcurp.Location = New System.Drawing.Point(339, 148)
        Me.TBcurp.Name = "TBcurp"
        Me.TBcurp.Size = New System.Drawing.Size(339, 28)
        Me.TBcurp.TabIndex = 8
        '
        'TBnombre
        '
        Me.TBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TBnombre.Location = New System.Drawing.Point(339, 185)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(339, 28)
        Me.TBnombre.TabIndex = 9
        '
        'TBpaterno
        '
        Me.TBpaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TBpaterno.Location = New System.Drawing.Point(339, 227)
        Me.TBpaterno.Name = "TBpaterno"
        Me.TBpaterno.Size = New System.Drawing.Size(339, 28)
        Me.TBpaterno.TabIndex = 10
        '
        'TBmaterno
        '
        Me.TBmaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TBmaterno.Location = New System.Drawing.Point(339, 270)
        Me.TBmaterno.Name = "TBmaterno"
        Me.TBmaterno.Size = New System.Drawing.Size(339, 28)
        Me.TBmaterno.TabIndex = 11
        '
        'TBtelefono
        '
        Me.TBtelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TBtelefono.Location = New System.Drawing.Point(339, 312)
        Me.TBtelefono.Name = "TBtelefono"
        Me.TBtelefono.Size = New System.Drawing.Size(339, 28)
        Me.TBtelefono.TabIndex = 12
        '
        'TBcorreo
        '
        Me.TBcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TBcorreo.Location = New System.Drawing.Point(339, 357)
        Me.TBcorreo.Name = "TBcorreo"
        Me.TBcorreo.Size = New System.Drawing.Size(339, 28)
        Me.TBcorreo.TabIndex = 13
        '
        'CBnivelEscolar
        '
        Me.CBnivelEscolar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBnivelEscolar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBnivelEscolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBnivelEscolar.FormattingEnabled = True
        Me.CBnivelEscolar.Items.AddRange(New Object() {"Educación Preescolar", "Educación Primaria", "Educación Secundaria", "Educación Media Superior", "Educación Superior"})
        Me.CBnivelEscolar.Location = New System.Drawing.Point(339, 404)
        Me.CBnivelEscolar.Name = "CBnivelEscolar"
        Me.CBnivelEscolar.Size = New System.Drawing.Size(339, 30)
        Me.CBnivelEscolar.TabIndex = 16
        '
        'BTNcrear
        '
        Me.BTNcrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTNcrear.Location = New System.Drawing.Point(32, 526)
        Me.BTNcrear.Name = "BTNcrear"
        Me.BTNcrear.Size = New System.Drawing.Size(134, 33)
        Me.BTNcrear.TabIndex = 17
        Me.BTNcrear.Text = "Crear"
        Me.BTNcrear.UseVisualStyleBackColor = True
        '
        'BTNleer
        '
        Me.BTNleer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTNleer.Location = New System.Drawing.Point(172, 526)
        Me.BTNleer.Name = "BTNleer"
        Me.BTNleer.Size = New System.Drawing.Size(134, 33)
        Me.BTNleer.TabIndex = 18
        Me.BTNleer.Text = "Leer"
        Me.BTNleer.UseVisualStyleBackColor = True
        '
        'BTNactualizar
        '
        Me.BTNactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTNactualizar.Location = New System.Drawing.Point(312, 526)
        Me.BTNactualizar.Name = "BTNactualizar"
        Me.BTNactualizar.Size = New System.Drawing.Size(134, 33)
        Me.BTNactualizar.TabIndex = 19
        Me.BTNactualizar.Text = "Actualizar"
        Me.BTNactualizar.UseVisualStyleBackColor = True
        '
        'BTNborrar
        '
        Me.BTNborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTNborrar.Location = New System.Drawing.Point(452, 526)
        Me.BTNborrar.Name = "BTNborrar"
        Me.BTNborrar.Size = New System.Drawing.Size(134, 33)
        Me.BTNborrar.TabIndex = 20
        Me.BTNborrar.Text = "Borrar"
        Me.BTNborrar.UseVisualStyleBackColor = True
        '
        'CBMunicipio
        '
        Me.CBMunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBMunicipio.FormattingEnabled = True
        Me.CBMunicipio.Items.AddRange(New Object() {"Educación Preescolar", "Educación Primaria", "Educación Secundaria", "Educación Media Superior", "Educación Superior"})
        Me.CBMunicipio.Location = New System.Drawing.Point(339, 453)
        Me.CBMunicipio.Name = "CBMunicipio"
        Me.CBMunicipio.Size = New System.Drawing.Size(339, 30)
        Me.CBMunicipio.TabIndex = 21
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnBack.Location = New System.Drawing.Point(661, 526)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(153, 33)
        Me.BtnBack.TabIndex = 22
        Me.BtnBack.Text = "Volver al menu"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-63, -128)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1027, 220)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-18, 591)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(923, 259)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(375, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'AlumnoFormCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 659)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.CBMunicipio)
        Me.Controls.Add(Me.BTNborrar)
        Me.Controls.Add(Me.BTNactualizar)
        Me.Controls.Add(Me.BTNleer)
        Me.Controls.Add(Me.BTNcrear)
        Me.Controls.Add(Me.CBnivelEscolar)
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
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "AlumnoFormCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlumnoFormCRUD"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CBnivelEscolar As ComboBox
    Friend WithEvents BTNcrear As Button
    Friend WithEvents BTNleer As Button
    Friend WithEvents BTNactualizar As Button
    Friend WithEvents BTNborrar As Button
    Friend WithEvents CBMunicipio As ComboBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
