Imports System.Data.Odbc
Public Class frmMenuAuxiliar

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(2)

    End Sub
    Private Sub BtnAlertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlertas.Click
        TbcMenu.SelectedTab = TbcMenu.TabPages(3)
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

    Private Sub frmMenuAdminEstabl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub BtnCEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCEmpleados.Click
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDsn=C:\Users\Usuario\Desktop\Proyecto S.I.G.A.T Uruguay\bdnf.dsn;UID=lpalermo;PWD=manilubru16"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM personal"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "personal")
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("personal")
    End Sub

    Private Sub BtnCAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCAnimales.Click
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDsn=C:\Users\Usuario\Desktop\Proyecto S.I.G.A.T Uruguay\bdnf.dsn;UID=lpalermo;PWD=manilubru16"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM animales"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "animales")
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("animales")
    End Sub

    Private Sub BtnCOrdeñes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCOrdeñes.Click
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDsn=C:\Users\Usuario\Desktop\Proyecto S.I.G.A.T Uruguay\bdnf.dsn;UID=lpalermo;PWD=manilubru16"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM personal"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "personal")
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("personal")
    End Sub
End Class
