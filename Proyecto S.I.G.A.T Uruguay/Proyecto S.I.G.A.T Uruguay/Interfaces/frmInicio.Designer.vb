<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.TxtFecha = New System.Windows.Forms.TextBox
        Me.GpbIngresar = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnAcceder = New System.Windows.Forms.Button
        Me.TxtContraseña = New System.Windows.Forms.TextBox
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.LblContraseña = New System.Windows.Forms.Label
        Me.LblUsuario = New System.Windows.Forms.Label
        Me.LblTitulo3 = New System.Windows.Forms.Label
        Me.Contador = New System.Windows.Forms.Timer(Me.components)
        Me.LblTitulo2 = New System.Windows.Forms.Label
        Me.LblTitulo1 = New System.Windows.Forms.Label
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TxtHora = New System.Windows.Forms.TextBox
        Me.GpbIngresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFecha
        '
        Me.TxtFecha.Enabled = False
        Me.TxtFecha.Location = New System.Drawing.Point(12, 12)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 16
        '
        'GpbIngresar
        '
        Me.GpbIngresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GpbIngresar.Controls.Add(Me.BtnSalir)
        Me.GpbIngresar.Controls.Add(Me.BtnAcceder)
        Me.GpbIngresar.Controls.Add(Me.TxtContraseña)
        Me.GpbIngresar.Controls.Add(Me.TxtUsuario)
        Me.GpbIngresar.Controls.Add(Me.LblContraseña)
        Me.GpbIngresar.Controls.Add(Me.LblUsuario)
        Me.GpbIngresar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GpbIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbIngresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GpbIngresar.Location = New System.Drawing.Point(29, 175)
        Me.GpbIngresar.Name = "GpbIngresar"
        Me.GpbIngresar.Size = New System.Drawing.Size(432, 216)
        Me.GpbIngresar.TabIndex = 15
        Me.GpbIngresar.TabStop = False
        Me.GpbIngresar.Text = "Ingresar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Location = New System.Drawing.Point(216, 154)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAcceder
        '
        Me.BtnAcceder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAcceder.Location = New System.Drawing.Point(122, 154)
        Me.BtnAcceder.Name = "BtnAcceder"
        Me.BtnAcceder.Size = New System.Drawing.Size(75, 23)
        Me.BtnAcceder.TabIndex = 4
        Me.BtnAcceder.Text = " Acceder"
        Me.BtnAcceder.UseVisualStyleBackColor = True
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(122, 103)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtContraseña.Size = New System.Drawing.Size(169, 21)
        Me.TxtContraseña.TabIndex = 3
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(122, 46)
        Me.TxtUsuario.MaxLength = 25
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(169, 21)
        Me.TxtUsuario.TabIndex = 2
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(120, 84)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(80, 16)
        Me.LblContraseña.TabIndex = 1
        Me.LblContraseña.Text = "Contraseña:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(119, 27)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(58, 16)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario:"
        '
        'LblTitulo3
        '
        Me.LblTitulo3.AutoSize = True
        Me.LblTitulo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo3.Location = New System.Drawing.Point(70, 140)
        Me.LblTitulo3.Name = "LblTitulo3"
        Me.LblTitulo3.Size = New System.Drawing.Size(358, 16)
        Me.LblTitulo3.TabIndex = 14
        Me.LblTitulo3.Text = "Sistema informático de gestión y administración de tambos"
        '
        'Contador
        '
        Me.Contador.Enabled = True
        '
        'LblTitulo2
        '
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo2.Location = New System.Drawing.Point(92, 49)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(315, 73)
        Me.LblTitulo2.TabIndex = 13
        Me.LblTitulo2.Text = "S.I.G.A.T."
        '
        'LblTitulo1
        '
        Me.LblTitulo1.AutoSize = True
        Me.LblTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo1.Location = New System.Drawing.Point(194, 25)
        Me.LblTitulo1.Name = "LblTitulo1"
        Me.LblTitulo1.Size = New System.Drawing.Size(84, 24)
        Me.LblTitulo1.TabIndex = 12
        Me.LblTitulo1.Text = "Proyecto"
        Me.LblTitulo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'TxtHora
        '
        Me.TxtHora.Enabled = False
        Me.TxtHora.Location = New System.Drawing.Point(375, 12)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(100, 20)
        Me.TxtHora.TabIndex = 17
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 403)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.GpbIngresar)
        Me.Controls.Add(Me.LblTitulo3)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblTitulo1)
        Me.Controls.Add(Me.TxtHora)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.Text = "S.I.G.A.T."
        Me.GpbIngresar.ResumeLayout(False)
        Me.GpbIngresar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents GpbIngresar As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnAcceder As System.Windows.Forms.Button
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblContraseña As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblTitulo3 As System.Windows.Forms.Label
    Friend WithEvents Contador As System.Windows.Forms.Timer
    Friend WithEvents LblTitulo2 As System.Windows.Forms.Label
    Friend WithEvents LblTitulo1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TxtHora As System.Windows.Forms.TextBox
End Class
