Imports System.Data.Odbc
Public Class frmMenuRoot

    'Declaración de la opción desplegable "Añadir usuario" en un control MenuStrip
    Private Sub AñadirUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirUsuarioToolStripMenuItem.Click
        PanelNGenetica.Hide()
        PanelNAnimal.Hide()
        PanelNUsuario.Show()
        GpbNAcción.Text = "Añadir usuario"
    End Sub

    'Declaración de la opción desplegable "Añadir animal" en un control MenuStrip
    Private Sub AñadirAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirAnimalToolStripMenuItem.Click
        PanelNGenetica.Hide()
        PanelNUsuario.Hide()
        PanelNAnimal.Show()
        GpbNAcción.Text = "Añadir animal"
    End Sub

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
        Else : MessageBox.Show("El/la " + CmbNUCargo.Text + " " + TxtNUNombre.Text + " " + TxtNUApellido.Text + ", cédula " + TxtNUCI.Text + ", ha sido ingresado al sistema.", "S.I.G.A.T.", _
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
        PanelNUsuario.Hide()
        GpbNAcción.Text = "Seleccionar acción"
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
    Private Sub TxtNARP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNARP.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNANombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNANombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNARPMadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNARPMadre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNARPPadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNARPPadre.KeyPress
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
    Private Sub BtnNAIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNAIngresar.Click
        If TxtNARP.Text = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbNATipo.Text = "" Then
            MessageBox.Show("Seleccione un tipo por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNANombre.Text = "" Then
            MessageBox.Show("Ingrese un nombre por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbNARaza.Text = "" Then
            MessageBox.Show("Seleccione una raza por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("El/la " + CmbNATipo.Text + " " + TxtNANombre.Text + " de raza " + CmbNARaza.Text + ", RP " + TxtNARP.Text + " y nacido el " + DtpNANacimiento.Text + ", ha sido ingresado al sistema.", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    'El botón Nuevo limpia los campos utilizados
    Private Sub BtnNANuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNANuevo.Click
        TxtNARP.Text = ""
        CmbNATipo.Text = Nothing
        TxtNANombre.Text = ""
        CmbNARaza.Text = Nothing
        TxtNARPMadre.Text = ""
        TxtNARPPadre.Text = ""
        CmbNALote.Text = Nothing
        DtpNANacimiento.Text = Today
    End Sub

    'El botón cancelar limpia los campos utilizados y 'esconde' el control Panel de cada menú
    Private Sub BtnNACancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNACancelar.Click
        TxtNARP.Text = ""
        CmbNATipo.Text = Nothing
        TxtNANombre.Text = ""
        CmbNARaza.Text = Nothing
        TxtNARPMadre.Text = ""
        TxtNARPPadre.Text = ""
        CmbNALote.Text = Nothing
        DtpNANacimiento.Text = Today
        PanelNAnimal.Hide()
        GpbNAcción.Text = "Seleccionar acción"
    End Sub

    ' Al hacer click en un ítem del MenuStrip, se esconden todos los Paneles excepto el correspondiente
    ' a la función solicitada
    Private Sub InseminaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenéticaToolStripMenuItem.Click
        PanelNUsuario.Hide()
        PanelNAnimal.Hide()
        PanelNGenetica.Show()
        GpbNAcción.Text = "Añadir recurso genético"
    End Sub

    'Si el texto del ComboBox es "Vaca", entonces se habilitan controles y campos adicionales
    Private Sub CmbNATipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNATipo.SelectedIndexChanged
        If CmbNATipo.Text = "Vaca" Then
            LblNAEstado.Show()
            RdbLactando.Show()
            RdbPreñada.Show()
            RdbSeca.Show()
            RdbPreLac.Show()
            RdbPreSec.Show()
        Else : LblNAEstado.Hide()
            RdbLactando.Hide()
            RdbPreñada.Hide()
            RdbSeca.Hide()
            RdbPreLac.Hide()
            RdbPreSec.Hide()
        End If
    End Sub

    Private Sub TxtNGRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNGRP.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub


    Private Sub TxtNGNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNGNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If

    End Sub



    Private Sub TxtNGNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNGNom.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNGRPMadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNGRPMadre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtNGRPPadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNGRPPadre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub
    Private Sub TxtNGLitros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNGLitros.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    'Si el texto del ComboBox es "Esperma" se hablitan nuevos campos pertinentes
    Private Sub CmbNGTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNGTipo.SelectedIndexChanged
        If CmbNGTipo.Text = "Esperma" Then
            TxtNGLitros.Enabled = True
        Else : TxtNGLitros.Enabled = False
            TxtNGLitros.Text = ""
        End If
    End Sub

    'El botón ingresar verifica que no existan campos vacíos, y de no ser el caso, envía la información
    'a la base de datos
    Private Sub BtnNGIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNGIngresar.Click
        If TxtNGRP.Text = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNGNombre.Text = "" Then
            MessageBox.Show("Ingrese un nombre por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtNGNom.Text = "" Then
            MessageBox.Show("Ingrese un nombre corto por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbNGTipo.Text = "" Then
            MessageBox.Show("Seleccione un tipo por favor", "S.I.G.A.T.", _
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbNGTipo.Text = "Esperma" And TxtNGLitros.Text = "" Then
            MessageBox.Show("Ingrese litros por favor", "S.I.G.A.T.", _
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If CmbNGTipo.Text = "Toro" Then
                MessageBox.Show("El toro " + TxtNGNombre.Text + ", RP " + TxtNGRP.Text + _
 " y nacido el " + DtpNGFnac.Text + ", ha sido ingresado al sistema.", "S.I.G.A.T.", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else : MessageBox.Show("" + TxtNGLitros.Text + " litros de esperma del toro " + TxtNGNombre.Text + ", RP " + TxtNGRP.Text + _
                " y nacido el " + DtpNGFnac.Text + ", han sido ingresados al sistema.", "S.I.G.A.T.", _
                           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If

        End If
    End Sub

    'El botón Nuevo limpia los campos utilizados
    Private Sub BtnNGNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNGNuevo.Click
        TxtNGRP.Clear()
        TxtNGNombre.Clear()
        TxtNGNom.Clear()
        CmbNGTipo.Text = Nothing
        TxtNGLitros.Clear()
        TxtNGRPMadre.Clear()
        TxtNGRPPadre.Clear()
        DtpNGFnac.Text = Today

    End Sub

    'El botón cancelar limpia los campos utilizados y 'esconde' el control Panel de cada menú
    Private Sub BtnNGCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNGCancelar.Click
        TxtNGRP.Clear()
        TxtNGNombre.Clear()
        TxtNGNom.Clear()
        CmbNGTipo.Text = Nothing
        TxtNGLitros.Clear()
        TxtNGRPMadre.Clear()
        TxtNGRPPadre.Clear()
        DtpNGFnac.Text = Today
        PanelNGenetica.Hide()
        GpbNAcción.Text = "Seleccionar acción"
    End Sub

    Private Sub TxtMUCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMUCI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMUNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMUNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMUApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMUApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnMUBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMUBuscar.Click
        'Consulta en la base de datos y trae los datos asociados al número RP ingresado.
        If TxtMUCI.Text = "" Then
            MessageBox.Show("Ingrese C.I por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : TxtMUNombre.Enabled = True
            TxtMUApellido.Enabled = True
            CmbMUCargo.Enabled = True
            BtnMUModificar.Enabled = True
        End If


    End Sub

    Private Sub BtnMUModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMUModificar.Click
        If TxtMUCI.Text = "" Then
            MessageBox.Show("Ingrese un número C.I", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("El/a " + CmbMUCargo.Text + " " + TxtMUNombre.Text + " ha sido modificado", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnMUNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMUNuevo.Click
        TxtMUCI.Clear()
        TxtMUNombre.Clear()
        TxtMUApellido.Clear()
        CmbMUCargo.Text = Nothing

    End Sub

    Private Sub BtnMUCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMUCancelar.Click
        TxtMUCI.Clear()
        TxtMUNombre.Clear()
        TxtMUApellido.Clear()
        CmbMUCargo.Text = Nothing
        PanelMUsuario.Hide()
        GpbMAcción.Text = "Seleccionar acción"
    End Sub

    Private Sub ModUsuarioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModUsuarioToolStripMenuItem1.Click
        PanelMAnimal.Hide()
        PanelMUsuario.Show()
        GpbMAcción.Text = "Modificar usuario"
    End Sub

    Private Sub BtnMABuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMABuscar.Click
        'Consulta en la base de datos y trae los datos asociados al número RP ingresado.
        If TxtMARP.Text = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : CmbMATipo.Enabled = True
            TxtMANombre.Enabled = True
            CmbMARaza.Enabled = True
            RdbMAPreñ.Enabled = True
            RdbMALac.Enabled = True
            RdbMASec.Enabled = True
            RdbMAPreñLac.Enabled = True
            RdbMAPreñSec.Enabled = True
            TxtMARPMadre.Enabled = True
            TxtMARPPadre.Enabled = True
            CmbMALote.Enabled = True
            DtpMAFnac.Enabled = True
            BtnMAModificar.Enabled = True

        End If
    End Sub

    Private Sub BtnMAModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMAModificar.Click
        If TxtMARP.Text = "" Then
            MessageBox.Show("Ingrese un número RP", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("El/a " + CmbMATipo.Text + " " + TxtMANombre.Text + ", RP " + TxtMARP.Text + " ha sido modificado", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnMANuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMANuevo.Click
        TxtMARP.Clear()
        CmbMATipo.Text = Nothing
        TxtMANombre.Clear()
        CmbMARaza.Text = Nothing
        RdbMAPreñ.Checked = False
        RdbMALac.Checked = False
        RdbMASec.Checked = False
        RdbMAPreñLac.Checked = False
        RdbMAPreñSec.Checked = False
        TxtMARPMadre.Clear()
        TxtMARPPadre.Clear()
        CmbMALote.Text = Nothing
        DtpMAFnac.Text = Today
    End Sub

    Private Sub BtnMACancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMACancelar.Click
        CmbMATipo.Text = Nothing
        TxtMANombre.Clear()
        CmbMARaza.Text = Nothing
        RdbMAPreñ.Checked = False
        RdbMALac.Checked = False
        RdbMASec.Checked = False
        RdbMAPreñLac.Checked = False
        RdbMAPreñSec.Checked = False
        TxtMARPMadre.Clear()
        TxtMARPPadre.Clear()
        CmbMALote.Text = Nothing
        DtpMAFnac.Text = Today
        BtnMAModificar.Enabled = False
        PanelMAnimal.Hide()
        GpbMAcción.Text = "Seleccionar acción"
    End Sub

    Private Sub ModAnimalToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModAnimalToolStripMenuItem2.Click
        PanelMUsuario.Hide()
        PanelMAnimal.Show()
        GpbMAcción.Text = "Modificar animal"
    End Sub

    Private Sub TxtMARP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMARP.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMANombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMANombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtMARPMadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMARPMadre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub


    Private Sub TxtMARPPadre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMARPPadre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtEUCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEUCI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnEUBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEUBuscar.Click
        'Muestra la información asociada en los campos
        If TxtEUCI.Text = "" Then
            MessageBox.Show("Ingrese C.I por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else 'Muestra información
        End If
    End Sub

    Private Sub BtnEUEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEUEliminar.Click
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

    Private Sub BtnEUNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEUNuevo.Click
        TxtEUCI.Clear()
        TxtEUNombre.Clear()
        TxtEUApellido.Clear()
        CmbEUCargo.Text = Nothing

    End Sub

    Private Sub BtnEUCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEUCancelar.Click
        TxtEUCI.Clear()
        TxtEUNombre.Clear()
        TxtEUApellido.Clear()
        CmbEUCargo.Text = Nothing
        PanelEUsuario.Hide()
        GpbEAcción.Text = "Sleccionar acción"
    End Sub

    Private Sub DelUsuarioToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelUsuarioToolStripMenuItem3.Click
        PanelEGenética.Hide()
        PanelEAnimal.Hide()
        PanelEUsuario.Show()
        GpbEAcción.Text = "Eliminar usuario"
    End Sub

    Private Sub TxtEARP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEARP.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnEABuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEABuscar.Click
        'Muestra la información asociada en los campos
        If TxtEARP.Text = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else 'Muestra información
        End If
    End Sub

    Private Sub BtnEAEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEAEliminar.Click
        If TxtEARP.Text = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : Dim resultado As String = MsgBox("¿Eliminar ANIMAL?", vbOKCancel, "Confirmación")
            If resultado = vbOK Then
                'Eliminar animal
                MessageBox.Show("Animal eliminado del sistema", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtEARP.Clear()
                CmbEATipo.Text = Nothing
                TxtEANombre.Clear()
                CmbEARaza.Text = Nothing
                RdbEAPreñ.Checked = False
                RdbEALac.Checked = False
                RdbEASec.Checked = False
                RdbEAPreñLac.Checked = False
                RdbEAPreñSec.Checked = False
                TxtEARPMadre.Clear()
                TxtEARPPadre.Clear()
                CmbEALote.Text = Nothing
                DtpEAFnac.Text = Today
            Else

            End If
        End If
    End Sub

    Private Sub BtnEANuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEANuevo.Click
        TxtEARP.Clear()
        CmbEATipo.Text = Nothing
        TxtEANombre.Clear()
        CmbEARaza.Text = Nothing
        RdbEAPreñ.Checked = False
        RdbEALac.Checked = False
        RdbEASec.Checked = False
        RdbEAPreñLac.Checked = False
        RdbEAPreñSec.Checked = False
        TxtEARPMadre.Clear()
        TxtEARPPadre.Clear()
        CmbEALote.Text = Nothing
        DtpEAFnac.Text = Today
    End Sub

    Private Sub BtnEACancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEACancelar.Click
        TxtEARP.Clear()
        CmbEATipo.Text = Nothing
        TxtEANombre.Clear()
        CmbEARaza.Text = Nothing
        RdbEAPreñ.Checked = False
        RdbEALac.Checked = False
        RdbEASec.Checked = False
        RdbEAPreñLac.Checked = False
        RdbEAPreñSec.Checked = False
        TxtEARPMadre.Clear()
        TxtEARPPadre.Clear()
        CmbEALote.Text = Nothing
        DtpEAFnac.Text = Today
        PanelEAnimal.Hide()
        GpbEAcción.Text = "Sleccionar acción"
    End Sub

    Private Sub DelAnimalToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelAnimalToolStripMenuItem4.Click
        PanelEGenética.Hide()
        PanelEUsuario.Hide()
        PanelEAnimal.Show()
        GpbEAcción.Text = "Eliminar animal"
    End Sub

    Private Sub TxtEGRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEGRP.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnEGBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEGBuscar.Click
        'Muestra la información asociada en los campos
        If TxtEGRP.Text = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else 'Muestra información
        End If
    End Sub

    Private Sub BtnEGEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEGEliminar.Click
        If TxtEGRP.Text = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : Dim resultado As String = MsgBox("¿Eliminar recurso genético?", vbOKCancel, "Confirmación")
            If resultado = vbOK Then
                'Eliminar animal
                MessageBox.Show("Recurso genético eliminado del sistema", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtEGRP.Clear()
                CmbEGTipo.Text = Nothing
                TxtEGNombre.Clear()
                TxtEGNom.Clear()
                TxtEGRPMadre.Clear()
                TxtEGRPPadre.Clear()
                TxtEGLitros.Text = Nothing
                DtpEAFnac.Text = Today
            Else

            End If
        End If
    End Sub

    Private Sub BtnEGNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEGNuevo.Click
        TxtEGRP.Clear()
        CmbEGTipo.Text = Nothing
        TxtEGNombre.Clear()
        TxtEGNom.Clear()
        TxtEGRPMadre.Clear()
        TxtEGRPPadre.Clear()
        TxtEGLitros.Text = Nothing
        DtpEAFnac.Text = Today
    End Sub

    Private Sub BtnEGCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEGCancelar.Click
        TxtEGRP.Clear()
        CmbEGTipo.Text = Nothing
        TxtEGNombre.Clear()
        TxtEGNom.Clear()
        TxtEGRPMadre.Clear()
        TxtEGRPPadre.Clear()
        TxtEGLitros.Text = Nothing
        DtpEAFnac.Text = Today
        PanelEGenética.Hide()
        GpbEAcción.Text = "Seleccionar acción"
    End Sub

    Private Sub DelGeneticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelGeneticaToolStripMenuItem.Click
        PanelEUsuario.Hide()
        PanelEAnimal.Hide()
        PanelEGenética.Show()
        GpbEAcción.Text = "Eliminar recurso genético"
    End Sub
    Private Sub BtnResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResumen.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(0)
    End Sub
    Private Sub BtnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarUsuario.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(1)
        PanelNAnimal.Hide()
        PanelNGenetica.Hide()
        PanelNUsuario.Show()
        GpbNAcción.Text = "Ingresar usuario"

    End Sub

    Private Sub BtnEliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarUsuario.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(3)
        PanelEAnimal.Hide()
        PanelEGenética.Hide()
        PanelEUsuario.Show()
        GpbEAcción.Text = "Eliminar usuario"
    End Sub

    Private Sub BtnAgregarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarAnimal.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(1)
        PanelNUsuario.Hide()
        PanelNGenetica.Hide()
        PanelNAnimal.Show()
        GpbNAcción.Text = "Ingresar animal"

    End Sub

    Private Sub BtnEliminarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarAnimal.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(3)
        PanelEUsuario.Hide()
        PanelEGenética.Hide()
        PanelEAnimal.Show()
        GpbEAcción.Text = "Eliminar animal"
    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(5)
        PanelEUsuario.Hide()
        PanelEGenética.Hide()
        PanelEAnimal.Show()
        GpbEAcción.Text = "Consultar"
    End Sub
    Private Sub BtnAlertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlertas.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(6)
    End Sub
    Private Sub BtnParámetros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParámetros.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(7)
        PanelEUsuario.Hide()
        PanelEGenética.Hide()
        PanelEAnimal.Show()
        GpbEAcción.Text = "Preferencias"
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("¿Salir del programa?", "S.I.G.A.T.", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnGOAñadir1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGOAñadir1.Click
        If CmbGOEncargado.Text = "" Then
            MessageBox.Show("Seleccione un encargado por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("Ordeñe realizado el " + DtpGOFechaHora.Text + " y a cargo de " + CmbGOEncargado.Text + " ha sido ingresado al sistema", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ' Envía datos a B.D
        End If
    End Sub

    Private Sub BtnGONuevo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGONuevo2.Click
        DtpGOFechaHora.Text = Today
        CmbGOEncargado.Text = Nothing
    End Sub

    Private Sub GestOrdeñeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestOrdeñeToolStripMenuItem1.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Hide()
        PanelGInsem.Hide()
        PanelGParto.Hide()
        GpbGOOrdeñe1.Show()
        GpbGOOrdeñe2.Show()
        GpbGAcción.Text = "Añadir ordeñe"
    End Sub

    Private Sub BtnGOAñadir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGOAñadir2.Click
        If LsbGOOrdeñes.SelectedItem = "" Then
            MessageBox.Show("Seleccione un ordeñe de la lista por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGORP.Text = "" Then
            MessageBox.Show("Ingrese un número RP por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGOLitros.Text = "" Then
            MessageBox.Show("Ingrese un número de litros por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGOGrasas.Text = "" Then
            MessageBox.Show("Ingrese un número de grasas por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGOProteínas.Text = "" Then
            MessageBox.Show("Ingrese un número de proteínas por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGOCelSom.Text = "" Then
            MessageBox.Show("Ingrese un número de células somáticas por favor", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show(TxtGOLitros.Text + " litros de leche del animal " + TxtGORP.Text + " NOMBRE han sido ingresados", "S.I.G.A.T.", _
          MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub TxtGORP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGORP.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGOLitros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOLitros.KeyPress
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

    Private Sub TxtGOGrasas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOGrasas.KeyPress
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

    Private Sub TxtGOProteínas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOProteínas.KeyPress
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

    Private Sub TxtGOCelSom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOCelSom.KeyPress
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

    Private Sub BtnGONuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGONuevo.Click
        TxtGORP.Clear()
        TxtGOLitros.Clear()
        TxtGOGrasas.Clear()
        TxtGOProteínas.Clear()
        TxtGOCelSom.Clear()
        LsbGOOrdeñes.SelectedItem = Nothing
    End Sub
    Private Sub BtnGOCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGOCancelar.Click
        TxtGORP.Clear()
        TxtGOLitros.Clear()
        TxtGOGrasas.Clear()
        TxtGOProteínas.Clear()
        TxtGOCelSom.Clear()
        LsbGOOrdeñes.SelectedItem = Nothing
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        GpbGAcción.Text = "Seleccionar acción"
    End Sub

    Private Sub GestPartoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestPartoToolStripMenuItem2.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Hide()
        PanelGInsem.Hide()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Show()
        GpbGAcción.Text = "Añadir parto"
    End Sub

    Private Sub TxtGPBúsqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGPBúsqueda.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGPRP.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPRPC1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGPRPC1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPNombre1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGPNombreCría1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPRPC2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGPRPC2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGPNombreCría2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGPNombreCría2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub


    Private Sub BtnGPIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGPIngresar.Click
        If TxtGPBúsqueda.Text = "" Then
            MessageBox.Show("Ingrese RP de búsqueda por favor", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGPRP.Text = "" Then
            MessageBox.Show("Ingrese RP de hembra por favor", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbGPMacho.Text = "" Then
            MessageBox.Show("Seleccione un macho de la lista por favor", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbGPSexo1.Text = "" Then
            MessageBox.Show("Seleccione sexo de la primer cría por favor", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGPRPC1.Text = "" Then
            MessageBox.Show("Ingrese RP de primer cría por favor", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf TxtGPNombreCría1.Text = "" Then
            MessageBox.Show("Ingrese nombre de primer cría por favor", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else ' se ingresan los datos
            MessageBox.Show("Parto añadido el " + DtpGPFechaParto.Text, "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnGPNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGPNuevo.Click
        LsbGOOrdeñes.SelectedItem = ""
        TxtGPBúsqueda.Text = ""
        TxtGPRP.Text = ""
        CmbGPMacho.Text = Nothing
        CmbGPSexo1.Text = ""
        TxtGPRPC1.Text = ""
        TxtGPNombreCría1.Text = ""
        CmbGPSexo2.Text = Nothing
        TxtGPRPC2.Text = ""
        TxtGPNombreCría2.Text = ""
        CkbGPAborto.Checked = False
    End Sub

    Private Sub BtnGPCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGPCancelar.Click
        LsbGOOrdeñes.SelectedItem = ""
        TxtGPBúsqueda.Text = ""
        TxtGPRP.Text = ""
        CmbGPMacho.Text = Nothing
        CmbGPSexo1.Text = ""
        TxtGPRPC1.Text = ""
        TxtGPNombreCría1.Text = ""
        CmbGPSexo2.Text = Nothing
        TxtGPRPC2.Text = ""
        TxtGPNombreCría2.Text = ""
        CkbGPAborto.Checked = False
        GpbGAcción.Text = "Seleccionar acción"
        PanelGParto.Hide()
    End Sub

    Private Sub BtnGIIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGIIngresar.Click
        If TxtGIRP.Text = "" Then
            MessageBox.Show("Ingrese RP de la hembra por favor", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbGIMacho.Text = "" Then
            MessageBox.Show("Seleccione un macho por favor", "S.I.G.A.T.", _
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf CmbGIMétodo.Text = "" Then
            MessageBox.Show("Seleccione un método de reproducción por favor", "S.I.G.A.T.", _
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("Servicio de reproducción " + CmbGIMétodo.Text + " a la hembra " + TxtGIRP.Text + " registrado", "S.I.G.A.T.", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnGINuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGINuevo.Click
        TxtGIRP.Clear()
        CmbGIMacho.Text = Nothing
        DtpGIFecha.Text = Today
        CmbGIMétodo.Text = Nothing
    End Sub

    Private Sub BtnGICancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGICancelar.Click
        TxtGIRP.Clear()
        CmbGIMacho.Text = Nothing
        DtpGIFecha.Text = Today
        CmbGIMétodo.Text = Nothing
        PanelGInsem.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestInsemToolStripMenuItem1.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Hide()
        PanelGInsem.Show()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Hide()
        GpbGAcción.Text = "Añadir inseminación"
    End Sub

    Private Sub GestDiagToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestDiagToolStripMenuItem2.Click
        PanelGDiagnostico.Show()
        PanelGTratar.Hide()
        PanelGInsem.Hide()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Hide()
        GpbGAcción.Text = "Añadir diagnóstico"
    End Sub

    Private Sub CmbGDAnimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbGDAnimal.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDEnfermedad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGDEnfermedad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDMedico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGDMedico.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDDenticion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGDDenticion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDCIMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGDCIMed.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGDCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGDCosto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub BtnGDNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGDNuevo.Click
        CmbGDAnimal.Text = ""
        DtpGDFecha.Value = Today
        TxtGDEnfermedad.Text = ""
        TxtGDDenticion.Text = ""
        TxtGDMedico.Text = ""
        TxtGDCIMed.Text = ""
        TxtGDObs.Text = ""
        TxtGDCosto.Text = ""

    End Sub

    Private Sub BtnGTNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGTNuevo.Click
        CmbGTAnimal.Text = ""
        TxtGTEnfermedad.Text = ""
        TxtGTMedico.Text = ""
        TxtGTCIMedico.Text = ""
        TxtGTTratamiento.Text = ""
        CmbGTMedicacion.Text = ""

    End Sub

    Private Sub CmbGTAnimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbGTAnimal.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTEnfermedad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGTEnfermedad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTMedico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGTMedico.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTCIMedico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGTCIMedico.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub TxtGTTratamiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGTTratamiento.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub

    Private Sub CmbGTMedicacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbGTMedicacion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True
        End If
    End Sub
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestTratarToolStripMenuItem3.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Show()
        PanelGInsem.Hide()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Hide()
        GpbGAcción.Text = "Añadir tratamiento"
    End Sub

    Private Sub frmMenuRoot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      

    End Sub


End Class
