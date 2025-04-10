<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.BTNalumnoCRUD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNalumnoCRUD
        '
        Me.BTNalumnoCRUD.Location = New System.Drawing.Point(110, 57)
        Me.BTNalumnoCRUD.Name = "BTNalumnoCRUD"
        Me.BTNalumnoCRUD.Size = New System.Drawing.Size(146, 23)
        Me.BTNalumnoCRUD.TabIndex = 0
        Me.BTNalumnoCRUD.Text = "Alumno CRUD"
        Me.BTNalumnoCRUD.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 331)
        Me.Controls.Add(Me.BTNalumnoCRUD)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNalumnoCRUD As Button
End Class
