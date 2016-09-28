Imports System.Data.Odbc

Public Class frmInicio
    Dim cx As New Odbc.OdbcConnection
    Dim cm As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New Data.DataSet
    Dim lector As OdbcDataReader


    ' Timer para la fecha -------------------------------------------------------------------

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contador.Tick
        TxtFecha.Text = Format(Now, "dd/MM/yyyy")
    End Sub
    ' Timer para la hora --------------------------------------------------------------------

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        TxtHora.Text = Format(Now, "hh:mm:ss")
    End Sub
    ' Evento KeyPress donde se validan los datos ingresados en el campo. Estos deben ser letras o dígitos

    Private Sub TxtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContraseña.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If


    End Sub
    ' Evento KeyPress donde se validan los datos ingresados en el campo. Estos deben ser números

    Private Sub TextCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub
    ' Eventos KeyDown, se utilizan para hacer un focus (enfoque) al campo siguiente al presionar ENTER

    Private Sub TxtCI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtContraseña.Focus()

        End If
    End Sub

    Private Sub TxtContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAcceder.Focus()
        End If
    End Sub
    'Botón acceder. Este verificará los datos ingresados de usuario y cotraseña en la base de datos.
    'En esta versión se utiliza la cédula del programador para ingresar provisoriamente.

    

    'El botón salir finaliza el programa mediante la opción "Sí" en un MessageBox

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("¿Quieres salir del programa?", "S.I.G.A.T.", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        cx.ConnectionString = "FileDsn=C:\Proyecto S.I.G.A.T Uruguay\bdnf.dsn;UID=lpalermo;PWD=manilubru16"
        cx.Open()
        cm.Connection = cx
        MsgBox("Conexión exitosa", vbInformation, "Conectado")
        'Catch ex As Exception ' En caso de que no se pueda acceder a la base de datos:
        ' MsgBox("Error al conectarse con la Base de datos", vbExclamation, "Error")
        'End Try
    End Sub

    Private Sub TxtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContraseña.TextChanged

    End Sub
End Class
