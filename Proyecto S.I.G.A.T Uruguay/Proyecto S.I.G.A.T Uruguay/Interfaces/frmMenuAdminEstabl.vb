Imports System.Data.Odbc

Public Class frmMenuAdminEstabl




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

    'El botón ingresar verifica que no existan campos vacíos, y de no ser el caso, envía la información
    'a la base de datos
    Private Sub BtnNAIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNAIngresar.Click
        Dim Animal As Animal = New Animal
        Dim Conexion_Animal As Conexion_animal = New Conexion_animal
        Animal.Rellenar(Animal, TxtNARP.Text, CmbNATipo.Text, TxtNANombre.Text, CmbNARaza.Text, CmbNAEstadoVaca.Text, CmbNASexo.Text, TxtNAPeso.Text, CmbNALote.Text, TxtNAFecha.Text)
        Conexion_Animal.Conectar(Animal)

    End Sub

    'El botón Nuevo limpia los campos utilizados
    Private Sub BtnNANuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNANuevo.Click
        TxtNARP.Text = ""
        CmbNATipo.Text = Nothing
        TxtNANombre.Text = ""
        CmbNARaza.Text = Nothing
        TxtNAPeso.Text = ""
        CmbNASexo.Text = Nothing
        CmbNALote.Text = Nothing
        TxtNAFecha.Text = Today
        CmbNAEstadoVaca.Text = Nothing
    End Sub

    'El botón cancelar limpia los campos utilizados y 'esconde' el control Panel de cada menú
    Private Sub BtnNACancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNACancelar.Click
        TxtNARP.Text = ""
        CmbNATipo.Text = Nothing
        TxtNANombre.Text = ""
        CmbNARaza.Text = Nothing
        TxtNAPeso.Text = ""
        CmbNASexo.Text = Nothing
        CmbNALote.Text = Nothing
        CmbNAEstadoVaca.Text = Nothing
        TxtNAFecha.Text = Today
        PanelNAnimal.Hide()
        GpbNAcción.Text = "Seleccionar acción"
    End Sub

    'Si el texto del ComboBox es "Vaca", entonces se habilitan controles y campos adicionales
    Private Sub CmbNATipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNATipo.SelectedIndexChanged
        If CmbNATipo.Text = "Vaca" Then
            LblNAEstado.Show()
            CmbNAEstadoVaca.Show()
        Else : LblNAEstado.Hide()
            CmbNAEstadoVaca.Hide()
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

    Private Sub BtnMANuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMANuevo.Click
        TxtMARP.Clear()
        CmbMATipo.Text = Nothing
        TxtMANombre.Clear()
        CmbMARaza.Text = Nothing
        CmbMAEstadoVaca.Text = Nothing
        CmbMASexo.Text = Nothing
        TxtMAPeso.Text = ""
        CmbMALote.Text = Nothing
        TxtMAFnac.Text = Today
    End Sub

    Private Sub BtnMACancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMACancelar.Click
        CmbMATipo.Text = Nothing
        TxtMANombre.Clear()
        CmbMARaza.Text = Nothing
        CmbMAEstadoVaca.Text = Nothing
        CmbMASexo.Text = Nothing
        TxtMAPeso.Text = ""
        CmbMALote.Text = Nothing
        TxtMAFnac.Text = Today
        BtnMAModificar.Enabled = False
        PanelMAnimal.Hide()
        GpbNAcción.Text = "Seleccionar acción"
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

    
    Private Sub BtnEANuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEANuevo.Click
        TxtEARP.Clear()
        CmbEATipo.Text = Nothing
        TxtEANombre.Clear()
        CmbEARaza.Text = Nothing
        CmbEAEstadoVaca.Text = Nothing
        CmbEASexo.Text = Nothing
        TxtEAPeso.Text = ""
        CmbEALote.Text = Nothing
        DtpEAFnac.Text = Today
    End Sub

    Private Sub BtnEACancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEACancelar.Click
        TxtEARP.Clear()
        CmbEATipo.Text = Nothing
        TxtEANombre.Clear()
        CmbEARaza.Text = Nothing
        CmbEAEstadoVaca.Text = Nothing
        CmbEASexo.Text = Nothing
        TxtEAPeso.Text = ""
        CmbEALote.Text = Nothing
        DtpEAFnac.Text = Today
        PanelEAnimal.Hide()
        GpbNAcción.Text = "Sleccionar acción"
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
        GpbNAcción.Text = "Seleccionar acción"
    End Sub

    Private Sub BtnAgregarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarAnimal.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(0)
        PanelNAnimal.Show()
        PanelNGenetica.Hide()
        PanelMAnimal.Hide()
        PanelEAnimal.Hide()
        PanelEGenética.Hide()
        GpbNAcción.Text = "Ingresar animal"

    End Sub

    Private Sub BtnEliminarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarAnimal.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(0)
        PanelNAnimal.Hide()
        PanelNGenetica.Hide()
        PanelMAnimal.Hide()
        PanelEAnimal.Show()
        PanelEGenética.Hide()
        GpbNAcción.Text = "Eliminar animal"
    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(2)

        GpbNAcción.Text = "Consultar"
    End Sub
    Private Sub BtnAlertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlertas.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(3)
    End Sub
    Private Sub BtnParámetros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParámetros.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(4)
        GpbNAcción.Text = "Preferencias"
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

    Private Sub TxtNAPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNAPeso.KeyPress
        If Char.IsNumber(e.KeyChar) Then
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

    Private Sub TxtMAPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMAPeso.KeyPress
        If Char.IsDigit(e.KeyChar) Then
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
    Private Sub BtnAAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAAñadir.Click
        PanelNAnimal.Show()
        PanelNGenetica.Hide()
        PanelMAnimal.Hide()
        PanelEAnimal.Hide()
        PanelEGenética.Hide()
        GpbNAcción.Text = "Añadir animal"
    End Sub

    Private Sub BtnAGenetica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAGenetica.Click
        PanelNAnimal.Hide()
        PanelNGenetica.Show()
        PanelMAnimal.Hide()
        PanelEAnimal.Hide()
        PanelEGenética.Hide()
        GpbNAcción.Text = "Añadir genética"
    End Sub

    Private Sub BtnAModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAModificar.Click
        PanelNAnimal.Hide()
        PanelNGenetica.Hide()
        PanelMAnimal.Show()
        PanelEAnimal.Hide()
        PanelEGenética.Hide()
        GpbNAcción.Text = "Modificar animal"
    End Sub

    Private Sub BtnAEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAEliminar.Click
        PanelNAnimal.Hide()
        PanelNGenetica.Hide()
        PanelMAnimal.Hide()
        PanelEAnimal.Show()
        PanelEGenética.Hide()
        GpbNAcción.Text = "Eliminar animal"
    End Sub

    Private Sub BtnAEliminarGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAEliminarGen.Click
        PanelNAnimal.Hide()
        PanelNGenetica.Hide()
        PanelMAnimal.Hide()
        PanelEAnimal.Hide()
        PanelEGenética.Show()
        GpbNAcción.Text = "Eliminar genética"
    End Sub

    Private Sub BtnGordeñe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGordeñe.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Hide()
        PanelGInsem.Hide()
        PanelGParto.Hide()
        GpbGOOrdeñe1.Show()
        GpbGOOrdeñe2.Show()
        GpbGAcción.Text = "Añadir ordeñe"
    End Sub

    Private Sub BtnGParto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGParto.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Hide()
        PanelGInsem.Hide()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Show()
        GpbGAcción.Text = "Añadir parto"
    End Sub

    Private Sub BtnGInsem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGInsem.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Hide()
        PanelGInsem.Show()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Hide()
        GpbGAcción.Text = "Añadir inseminación"
    End Sub

    Private Sub BtnGDiag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGDiag.Click
        PanelGDiagnostico.Show()
        PanelGTratar.Hide()
        PanelGInsem.Hide()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Hide()
        GpbGAcción.Text = "Añadir diagnóstico"
    End Sub

    Private Sub BtnGTrat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGTrat.Click
        PanelGDiagnostico.Hide()
        PanelGTratar.Show()
        PanelGInsem.Hide()
        GpbGOOrdeñe1.Hide()
        GpbGOOrdeñe2.Hide()
        PanelGParto.Hide()
        GpbGAcción.Text = "Añadir tratamiento"
    End Sub

    Private Sub CmbMATipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMATipo.SelectedIndexChanged
        If CmbMATipo.Text = "Vaca" Then
            LblMAEstado.Show()
            CmbMAEstadoVaca.Show()
        Else : LblMAEstado.Hide()
            CmbMAEstadoVaca.Hide()
        End If
    End Sub

    Private Sub BtnLogout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        If MessageBox.Show("¿Desea cerrar la sesión actual?", "S.I.G.A.T.", _
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
      = DialogResult.Yes Then
            frmInicio.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub TxtNAPeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNAPeso.TextChanged

    End Sub

    Private Sub TxtGOGrasas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGOGrasas.TextChanged

    End Sub

    Private Sub BtnGOAñadir2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnGOAñadir2.KeyDown

    End Sub

    Private Sub BtnGOAñadir2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BtnGOAñadir2.KeyPress

    End Sub
End Class
