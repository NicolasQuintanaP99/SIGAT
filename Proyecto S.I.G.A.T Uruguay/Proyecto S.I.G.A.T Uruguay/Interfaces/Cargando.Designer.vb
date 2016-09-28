<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargando))
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry
        Me.LblTitulo3 = New System.Windows.Forms.Label
        Me.LblTitulo2 = New System.Windows.Forms.Label
        Me.LblTitulo1 = New System.Windows.Forms.Label
        Me.PtbVaca = New System.Windows.Forms.PictureBox
        Me.PgbCargando = New System.Windows.Forms.ProgressBar
        Me.LblEmpresa = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblCargando = New System.Windows.Forms.Label
        CType(Me.PtbVaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo3
        '
        Me.LblTitulo3.AutoSize = True
        Me.LblTitulo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo3.Location = New System.Drawing.Point(44, 150)
        Me.LblTitulo3.Name = "LblTitulo3"
        Me.LblTitulo3.Size = New System.Drawing.Size(358, 16)
        Me.LblTitulo3.TabIndex = 17
        Me.LblTitulo3.Text = "Sistema informático de gestión y administración de tambos"
        '
        'LblTitulo2
        '
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo2.Location = New System.Drawing.Point(34, 64)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(315, 73)
        Me.LblTitulo2.TabIndex = 16
        Me.LblTitulo2.Text = "S.I.G.A.T."
        '
        'LblTitulo1
        '
        Me.LblTitulo1.AutoSize = True
        Me.LblTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo1.Location = New System.Drawing.Point(43, 21)
        Me.LblTitulo1.Name = "LblTitulo1"
        Me.LblTitulo1.Size = New System.Drawing.Size(84, 24)
        Me.LblTitulo1.TabIndex = 15
        Me.LblTitulo1.Text = "Proyecto"
        Me.LblTitulo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PtbVaca
        '
        Me.PtbVaca.BackgroundImage = CType(resources.GetObject("PtbVaca.BackgroundImage"), System.Drawing.Image)
        Me.PtbVaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PtbVaca.Location = New System.Drawing.Point(341, 64)
        Me.PtbVaca.Name = "PtbVaca"
        Me.PtbVaca.Size = New System.Drawing.Size(100, 73)
        Me.PtbVaca.TabIndex = 18
        Me.PtbVaca.TabStop = False
        '
        'PgbCargando
        '
        Me.PgbCargando.Location = New System.Drawing.Point(47, 202)
        Me.PgbCargando.Maximum = 50
        Me.PgbCargando.Name = "PgbCargando"
        Me.PgbCargando.Size = New System.Drawing.Size(355, 23)
        Me.PgbCargando.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PgbCargando.TabIndex = 19
        '
        'LblEmpresa
        '
        Me.LblEmpresa.AutoSize = True
        Me.LblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpresa.Location = New System.Drawing.Point(334, 21)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(107, 24)
        Me.LblEmpresa.TabIndex = 20
        Me.LblEmpresa.Text = "Nova Forza"
        Me.LblEmpresa.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'LblCargando
        '
        Me.LblCargando.AutoSize = True
        Me.LblCargando.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargando.Location = New System.Drawing.Point(44, 183)
        Me.LblCargando.Name = "LblCargando"
        Me.LblCargando.Size = New System.Drawing.Size(77, 16)
        Me.LblCargando.TabIndex = 21
        Me.LblCargando.Text = "Cargando..."
        '
        'Cargando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblCargando)
        Me.Controls.Add(Me.LblEmpresa)
        Me.Controls.Add(Me.PgbCargando)
        Me.Controls.Add(Me.PtbVaca)
        Me.Controls.Add(Me.LblTitulo3)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblTitulo1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cargando"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PtbVaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents LblTitulo3 As System.Windows.Forms.Label
    Friend WithEvents LblTitulo2 As System.Windows.Forms.Label
    Friend WithEvents LblTitulo1 As System.Windows.Forms.Label
    Friend WithEvents PtbVaca As System.Windows.Forms.PictureBox
    Friend WithEvents PgbCargando As System.Windows.Forms.ProgressBar
    Friend WithEvents LblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblCargando As System.Windows.Forms.Label
End Class
