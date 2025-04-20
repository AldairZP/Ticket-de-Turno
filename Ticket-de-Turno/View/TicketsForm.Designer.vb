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
        Me.TXTcurp = New System.Windows.Forms.TextBox()
        Me.TXTnum = New System.Windows.Forms.TextBox()
        Me.BTNleer = New System.Windows.Forms.Button()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.BTNcrear = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BTNborrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBtramite = New System.Windows.Forms.ComboBox()
        Me.CBstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTfecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TXTcurp
        '
        Me.TXTcurp.Location = New System.Drawing.Point(88, 46)
        Me.TXTcurp.Name = "TXTcurp"
        Me.TXTcurp.Size = New System.Drawing.Size(100, 20)
        Me.TXTcurp.TabIndex = 0
        '
        'TXTnum
        '
        Me.TXTnum.Location = New System.Drawing.Point(256, 47)
        Me.TXTnum.Name = "TXTnum"
        Me.TXTnum.Size = New System.Drawing.Size(100, 20)
        Me.TXTnum.TabIndex = 1
        '
        'BTNleer
        '
        Me.BTNleer.Location = New System.Drawing.Point(172, 82)
        Me.BTNleer.Name = "BTNleer"
        Me.BTNleer.Size = New System.Drawing.Size(75, 23)
        Me.BTNleer.TabIndex = 2
        Me.BTNleer.Text = "Leer"
        Me.BTNleer.UseVisualStyleBackColor = True
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(88, 191)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(100, 20)
        Me.txtAsunto.TabIndex = 4
        '
        'BTNcrear
        '
        Me.BTNcrear.Location = New System.Drawing.Point(52, 289)
        Me.BTNcrear.Name = "BTNcrear"
        Me.BTNcrear.Size = New System.Drawing.Size(75, 23)
        Me.BTNcrear.TabIndex = 7
        Me.BTNcrear.Text = "Crear"
        Me.BTNcrear.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(172, 289)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 8
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BTNborrar
        '
        Me.BTNborrar.Location = New System.Drawing.Point(281, 289)
        Me.BTNborrar.Name = "BTNborrar"
        Me.BTNborrar.Size = New System.Drawing.Size(75, 23)
        Me.BTNborrar.TabIndex = 9
        Me.BTNborrar.Text = "Borrar"
        Me.BTNborrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Label2"
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
        Me.Label6.Location = New System.Drawing.Point(43, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Asunto"
        '
        'CBtramite
        '
        Me.CBtramite.FormattingEnabled = True
        Me.CBtramite.Location = New System.Drawing.Point(84, 139)
        Me.CBtramite.Name = "CBtramite"
        Me.CBtramite.Size = New System.Drawing.Size(104, 21)
        Me.CBtramite.TabIndex = 17
        '
        'CBstatus
        '
        Me.CBstatus.FormattingEnabled = True
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
        Me.DTfecha.Location = New System.Drawing.Point(252, 191)
        Me.DTfecha.Name = "DTfecha"
        Me.DTfecha.Size = New System.Drawing.Size(122, 20)
        Me.DTfecha.TabIndex = 19
        '
        'TicketsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 351)
        Me.Controls.Add(Me.DTfecha)
        Me.Controls.Add(Me.CBstatus)
        Me.Controls.Add(Me.CBtramite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNborrar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BTNcrear)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.BTNleer)
        Me.Controls.Add(Me.TXTnum)
        Me.Controls.Add(Me.TXTcurp)
        Me.Name = "TicketsForm"
        Me.Text = "TicketsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTcurp As TextBox
    Friend WithEvents TXTnum As TextBox
    Friend WithEvents BTNleer As Button
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents BTNcrear As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BTNborrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBtramite As ComboBox
    Friend WithEvents CBstatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTfecha As DateTimePicker
End Class
