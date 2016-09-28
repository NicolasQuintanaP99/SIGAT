Imports System.Data.Odbc

Public Class frmMenuAdminSyst
    Dim cx As New Odbc.OdbcConnection
    Dim cm As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New Data.DataSet
    Dim lector As OdbcDataReader
    ' Validaciones de evento KeyPress de datos en campos de texto
    Private Sub TxtUNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNUNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub
    Private Sub TxtUApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNUApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub
    Private Sub TxtUCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNUCI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    'El botón ingresar verifica que no existan campos vacíos, y de no ser el caso, envía la información
    'a la base de datos
    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNUIngresar.Click
        If TxtNUNombre.Text = "" Then
            MessageBox.Show("Ingrese un nombre por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNUApellido.Text = "" Then
            MessageBox.Show("Ingrese un apellido por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNUCI.Text = "" Then
            MessageBox.Show("Ingrese una cédula por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbNUCargo.Text = "" Then
            MessageBox.Show("Ingrese un cargo por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNUTel.Text = "" Then
            MessageBox.Show("Ingrese un teléfono por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNUCel.Text = "" Then
            MessageBox.Show("Ingrese un celular por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNULogin.Text = "" Then
            MessageBox.Show("Ingrese un login por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNUPass.Text = "" Then
            MessageBox.Show("Ingrese un password por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("El/la " + CmbNUCargo.Text + " " + TxtNUNombre.Text + " " + TxtNUApellido.Text + ", cédula " + TxtNUCI.Text + ", login " + TxtNULogin.Text + ", ha sido ingresado al sistema.", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    'El botón Nuevo limpia los campos utilizados
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNUNuevo.Click
        TxtNUNombre.Text = ""
        TxtNUApellido.Text = ""
        TxtNUCI.Text = ""
        CmbNUCargo.Text = Nothing
    End Sub

    'El botón cancelar limpia los campos utilizados y 'esconde' el control Panel de cada menú,
    'que se utiliza en este programa para mostrar y esconder de forma dinámica el conjunto de controles de cada sección
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNUCancelar.Click
        TxtNUNombre.Text = ""
        TxtNUApellido.Text = ""
        TxtNUCI.Text = ""
        CmbNUCargo.Text = Nothing
        PanelUNuevo.Hide()
        GpbUAccion.Text = "Seleccionar acción"
    End Sub

    Private Sub TxtUNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNUNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNUApellido.Focus()

        End If
    End Sub

    Private Sub TxtUApellido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNUApellido.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNUCI.Focus()

        End If
    End Sub

    Private Sub TxtUCI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNUCI.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbNUCargo.Focus()

        End If
    End Sub

    'Validaciones de datos
    Private Sub TxtNARP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNANombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNARPMadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNARPPadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNGRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub


    Private Sub TxtNGNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If

    End Sub



    Private Sub TxtNGNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNGRPMadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNGRPPadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub
    Private Sub TxtNGLitros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMUCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMUNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMUApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnMUBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Consulta en la base de datos y trae los datos asociados al número RP ingresado.
        If TxtMUBCI.Text = "" Then
            MessageBox.Show("Ingrese C.I por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : TxtMUNombre.Enabled = True
            TxtMUApellido.Enabled = True
            CmbMUCargo.Enabled = True
            BtnMUModificar.Enabled = True
        End If


    End Sub

    Private Sub BtnMUModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMUBCI.Text = "" Then
            MessageBox.Show("Ingrese un número C.I", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("El/a " + CmbMUCargo.Text + " " + TxtMUNombre.Text + " ha sido modificado", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnMUNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMUBCI.Clear()
        TxtMUNombre.Clear()
        TxtMUApellido.Clear()
        CmbMUCargo.Text = Nothing

    End Sub

    Private Sub BtnMUCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMUBCI.Clear()
        TxtMUNombre.Clear()
        TxtMUApellido.Clear()
        CmbMUCargo.Text = Nothing
        PanelUModificar.Hide()
        GpbUAccion.Text = "Seleccionar acción"
    End Sub

    Private Sub TxtMARP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMANombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMARPMadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub


    Private Sub TxtMARPPadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtEUCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnEUBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Muestra la información asociada en los campos
        If TxtEUCI.Text = "" Then
            MessageBox.Show("Ingrese C.I por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else 'Muestra información
        End If
    End Sub

    Private Sub BtnEUEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtEUCI.Text = "" Then
            MessageBox.Show("Ingrese C.I por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : Dim resultado As String = MsgBox("¿Eliminar USUARIO?", vbOKCancel, "Confirmación")
            If resultado = vbOK Then
                'Eliminar usuario
                MessageBox.Show("Usuario eliminado del sistema", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtEUCI.Clear()
                TxtEUNombre.Clear()
                TxtEUApellido.Clear()
                CmbEUCargo.Text = Nothing
            Else

            End If
        End If

    End Sub

    Private Sub BtnEUNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtEUCI.Clear()
        TxtEUNombre.Clear()
        TxtEUApellido.Clear()
        CmbEUCargo.Text = Nothing

    End Sub

    Private Sub BtnEUCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtEUCI.Clear()
        TxtEUNombre.Clear()
        TxtEUApellido.Clear()
        CmbEUCargo.Text = Nothing
        PanelUEliminar.Hide()
        GpbUAccion.Text = "Sleccionar acción"
    End Sub

    Private Sub TxtEARP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtEGRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnAlertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TbcMenu.SelectedTab = TbcMenu.TabPages(6)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("¿Salir del programa?", "S.I.G.A.T.", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TxtGORP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGOLitros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGOGrasas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGOProteínas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGOCelSom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPBúsqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPRPC1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPNombre1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPRPC2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPNombreCría2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub CmbGDAnimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDEnfermedad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDMedico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDDenticion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDCIMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub CmbGTAnimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTEnfermedad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTMedico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTCIMedico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTTratamiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub CmbGTMedicacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub PanelRAnimales_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub BtnUNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUNuevo.Click
        PanelUEliminar.Hide()
        PanelUModificar.Hide()
        PanelUNuevo.Show()
        GpbUAccion.Text = "Nuevo usuario"
    End Sub

    Private Sub BtnUModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUModificar.Click
        PanelUEliminar.Hide()
        PanelUModificar.Show()
        PanelUNuevo.Hide()
        GpbUAccion.Text = "Modificar usuario"
    End Sub

    Private Sub BtnUEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUEliminar.Click
        PanelUEliminar.Show()
        PanelUModificar.Hide()
        PanelUNuevo.Hide()
        GpbUAccion.Text = "Eliminar usuario"
    End Sub

    Private Sub TxtMUCI_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMUBCI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMUNombre_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMUNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMUApellido_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMUApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnMUNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMUNuevo.Click
        TxtMUBCI.Text = ""
        TxtMUNombre.Text = ""
        TxtMUApellido.Text = ""
        CmbMUCargo.Text = Nothing
    End Sub

    Private Sub BtnMUModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMUModificar.Click
        If TxtMUBCI.Text = "" Then
            MessageBox.Show("Ingrse una cédula por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtMUNombre.Text = "" Then
            MessageBox.Show("Ingrese un nombre por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtMUApellido.Text = "" Then
            MessageBox.Show("Ingrese un apellido por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbMUCargo.Text = Nothing Then
            MessageBox.Show("Seleccione un cargo por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("Usuario modificado", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    Private Sub BtnMUCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMUCancelar.Click
        TxtMUBCI.Text = ""
        TxtMUNombre.Text = ""
        TxtMUApellido.Text = ""
        CmbMUCargo.Text = Nothing
        PanelUModificar.Hide()
        GpbUAccion.Text = "Seleccione acción"
    End Sub
    Private Sub TxtEUCI_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEUCI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtEUNombre_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEUNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtEUApellido_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEUApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnEUNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEUNuevo.Click
        TxtEUCI.Text = ""
        TxtEUNombre.Text = ""
        TxtEUApellido.Text = ""
        CmbEUCargo.Text = Nothing
    End Sub

    Private Sub BtnEUCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEUCancelar.Click
        TxtEUCI.Text = ""
        TxtEUNombre.Text = ""
        TxtEUApellido.Text = ""
        CmbEUCargo.Text = Nothing
        PanelUEliminar.Hide()
        GpbUAccion.Text = "Seleccione acción"
    End Sub

    Private Sub BtnEUEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEUEliminar.Click
        If TxtEUCI.Text = "" Then
            MessageBox.Show("Ingrese una cédula por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("Usuario eliminado", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarUsuario.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(0)
        PanelUNuevo.Show()
        PanelUEliminar.Hide()
        PanelUModificar.Hide()
        GpbUAccion.Text = "Nuevo usuario"
    End Sub

    Private Sub BtnEliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarUsuario.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(0)
        PanelUNuevo.Hide()
        PanelUEliminar.Show()
        PanelUModificar.Hide()
        GpbUAccion.Text = "Eliminar usuario"
    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConPersonal.Click
        
        cm.CommandText = "SELECT * FROM personal"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "personal")
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("personal")
    End Sub


    Private Sub BtnConUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConUsers.Click

        cm.CommandText = "SELECT login FROM usuario"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "usuario")
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("usuario")
    End Sub

    Private Sub TxtNUTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNUTel.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNUCel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNUCel.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNULogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNULogin.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNUPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNUPass.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub frmMenuAdminSyst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cx.ConnectionString = "FileDsn=C:\Users\Alumno\Desktop\Proyecto S.I.G.A.T Uruguay\bdnf.dsn;UID=lpalermo;PWD=manilubru16"
            cx.Open()
            cm.Connection = cx
            MsgBox("Conexión exitosa", vbInformation, "Conectado")
        Catch ex As Exception ' En caso de que no se pueda acceder a la base de datos:
            If cx.State = ConnectionState.Closed Then
                MsgBox("Error al conectarse con la Base de datos", vbExclamation, "Error")
            Else : MsgBox("Error desconocido", vbExclamation, "Error")
            End If
                End Try
    End Sub
End Class
