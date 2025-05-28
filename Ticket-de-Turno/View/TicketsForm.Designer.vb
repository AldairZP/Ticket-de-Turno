<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketsForm))
        Me.BTNleer = New System.Windows.Forms.Button()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.BTNcrear = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BTNborrar = New System.Windows.Forms.Button()
        Me.LblCurp = New System.Windows.Forms.Label()
        Me.LblTicket = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBtramite = New System.Windows.Forms.ComboBox()
        Me.CBstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTfecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNleer
        '
        Me.BTNleer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTNleer.Location = New System.Drawing.Point(133, 441)
        Me.BTNleer.Name = "BTNleer"
        Me.BTNleer.Size = New System.Drawing.Size(113, 30)
        Me.BTNleer.TabIndex = 2
        Me.BTNleer.Text = "Buscar"
        Me.BTNleer.UseVisualStyleBackColor = True
        '
        'txtAsunto
        '
        Me.txtAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAsunto.Location = New System.Drawing.Point(105, 229)
        Me.txtAsunto.MinimumSize = New System.Drawing.Size(100, 40)
        Me.txtAsunto.Multiline = True
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(249, 123)
        Me.txtAsunto.TabIndex = 4
        '
        'BTNcrear
        '
        Me.BTNcrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTNcrear.Location = New System.Drawing.Point(14, 441)
        Me.BTNcrear.Name = "BTNcrear"
        Me.BTNcrear.Size = New System.Drawing.Size(113, 30)
        Me.BTNcrear.TabIndex = 7
        Me.BTNcrear.Text = "Crear"
        Me.BTNcrear.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnActualizar.Location = New System.Drawing.Point(252, 441)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(113, 30)
        Me.BtnActualizar.TabIndex = 8
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BTNborrar
        '
        Me.BTNborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTNborrar.Location = New System.Drawing.Point(371, 441)
        Me.BTNborrar.Name = "BTNborrar"
        Me.BTNborrar.Size = New System.Drawing.Size(113, 30)
        Me.BTNborrar.TabIndex = 9
        Me.BTNborrar.Text = "Borrar"
        Me.BTNborrar.UseVisualStyleBackColor = True
        '
        'LblCurp
        '
        Me.LblCurp.AutoSize = True
        Me.LblCurp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCurp.Location = New System.Drawing.Point(20, 103)
        Me.LblCurp.Name = "LblCurp"
        Me.LblCurp.Size = New System.Drawing.Size(56, 24)
        Me.LblCurp.TabIndex = 10
        Me.LblCurp.Text = "Curp:"
        '
        'LblTicket
        '
        Me.LblTicket.AutoSize = True
        Me.LblTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTicket.Location = New System.Drawing.Point(388, 103)
        Me.LblTicket.Name = "LblTicket"
        Me.LblTicket.Size = New System.Drawing.Size(84, 24)
        Me.LblTicket.TabIndex = 11
        Me.LblTicket.Text = "Número:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(20, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Quien tramita"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(388, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Asunto"
        '
        'CBtramite
        '
        Me.CBtramite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBtramite.FormattingEnabled = True
        Me.CBtramite.Items.AddRange(New Object() {"Titular", "Tutor Legal", "Otro"})
        Me.CBtramite.Location = New System.Drawing.Point(147, 151)
        Me.CBtramite.Name = "CBtramite"
        Me.CBtramite.Size = New System.Drawing.Size(195, 30)
        Me.CBtramite.TabIndex = 17
        '
        'CBstatus
        '
        Me.CBstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBstatus.FormattingEnabled = True
        Me.CBstatus.Items.AddRange(New Object() {"Pendiente", "Resuelto"})
        Me.CBstatus.Location = New System.Drawing.Point(472, 151)
        Me.CBstatus.Name = "CBstatus"
        Me.CBstatus.Size = New System.Drawing.Size(239, 30)
        Me.CBstatus.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(388, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Fecha"
        '
        'DTfecha
        '
        Me.DTfecha.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DTfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTfecha.Location = New System.Drawing.Point(472, 227)
        Me.DTfecha.Name = "DTfecha"
        Me.DTfecha.ShowCheckBox = True
        Me.DTfecha.Size = New System.Drawing.Size(239, 28)
        Me.DTfecha.TabIndex = 19
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnBack.Location = New System.Drawing.Point(548, 441)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(163, 30)
        Me.BtnBack.TabIndex = 20
        Me.BtnBack.Text = "Volver al menu"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-96, -69)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1027, 220)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-115, 391)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1027, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'TicketsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 576)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DTfecha)
        Me.Controls.Add(Me.CBstatus)
        Me.Controls.Add(Me.CBtramite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTicket)
        Me.Controls.Add(Me.LblCurp)
        Me.Controls.Add(Me.BTNborrar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BTNcrear)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.BTNleer)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "TicketsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicketsForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNleer As Button
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents BTNcrear As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BTNborrar As Button
    Friend WithEvents LblCurp As Label
    Friend WithEvents LblTicket As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBtramite As ComboBox
    Friend WithEvents CBstatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTfecha As DateTimePicker
    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
