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
        Me.SuspendLayout()
        '
        'BTNleer
        '
        Me.BTNleer.Location = New System.Drawing.Point(133, 267)
        Me.BTNleer.Name = "BTNleer"
        Me.BTNleer.Size = New System.Drawing.Size(75, 23)
        Me.BTNleer.TabIndex = 2
        Me.BTNleer.Text = "Buscar"
        Me.BTNleer.UseVisualStyleBackColor = True
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(84, 191)
        Me.txtAsunto.MinimumSize = New System.Drawing.Size(100, 40)
        Me.txtAsunto.Multiline = True
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(104, 65)
        Me.txtAsunto.TabIndex = 4
        '
        'BTNcrear
        '
        Me.BTNcrear.Location = New System.Drawing.Point(52, 267)
        Me.BTNcrear.Name = "BTNcrear"
        Me.BTNcrear.Size = New System.Drawing.Size(75, 23)
        Me.BTNcrear.TabIndex = 7
        Me.BTNcrear.Text = "Crear"
        Me.BTNcrear.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(214, 267)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 8
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BTNborrar
        '
        Me.BTNborrar.Location = New System.Drawing.Point(295, 267)
        Me.BTNborrar.Name = "BTNborrar"
        Me.BTNborrar.Size = New System.Drawing.Size(75, 23)
        Me.BTNborrar.TabIndex = 9
        Me.BTNborrar.Text = "Borrar"
        Me.BTNborrar.UseVisualStyleBackColor = True
        '
        'LblCurp
        '
        Me.LblCurp.AutoSize = True
        Me.LblCurp.Location = New System.Drawing.Point(43, 50)
        Me.LblCurp.Name = "LblCurp"
        Me.LblCurp.Size = New System.Drawing.Size(32, 13)
        Me.LblCurp.TabIndex = 10
        Me.LblCurp.Text = "Curp:"
        '
        'LblTicket
        '
        Me.LblTicket.AutoSize = True
        Me.LblTicket.Location = New System.Drawing.Point(211, 50)
        Me.LblTicket.Name = "LblTicket"
        Me.LblTicket.Size = New System.Drawing.Size(47, 13)
        Me.LblTicket.TabIndex = 11
        Me.LblTicket.Text = "Número:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Quien tramita"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Asunto"
        '
        'CBtramite
        '
        Me.CBtramite.FormattingEnabled = True
        Me.CBtramite.Items.AddRange(New Object() {"Titular", "Tutor Legal", "Otro"})
        Me.CBtramite.Location = New System.Drawing.Point(84, 139)
        Me.CBtramite.Name = "CBtramite"
        Me.CBtramite.Size = New System.Drawing.Size(104, 21)
        Me.CBtramite.TabIndex = 17
        '
        'CBstatus
        '
        Me.CBstatus.FormattingEnabled = True
        Me.CBstatus.Items.AddRange(New Object() {"Pendiente", "Resuelto"})
        Me.CBstatus.Location = New System.Drawing.Point(252, 139)
        Me.CBstatus.Name = "CBstatus"
        Me.CBstatus.Size = New System.Drawing.Size(104, 21)
        Me.CBstatus.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Fecha"
        '
        'DTfecha
        '
        Me.DTfecha.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTfecha.Location = New System.Drawing.Point(252, 191)
        Me.DTfecha.Name = "DTfecha"
        Me.DTfecha.ShowCheckBox = True
        Me.DTfecha.Size = New System.Drawing.Size(213, 20)
        Me.DTfecha.TabIndex = 19
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(450, 316)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(85, 23)
        Me.BtnBack.TabIndex = 20
        Me.BtnBack.Text = "Volver al menu"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'TicketsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 351)
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
        Me.Name = "TicketsForm"
        Me.Text = "TicketsForm"
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
End Class
