Imports System.Data.Odbc

Public Class Conexion_animal
    Dim cx As Odbc.OdbcConnection
    Dim cm As Odbc.OdbcCommand
    Dim da As Odbc.OdbcDataAdapter
    Dim ds As Data.DataSet

    Public Sub Conectar(ByVal animal)
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
        If animal.Nombre = "" Then
            MessageBox.Show("Ingrese número RP por favor", "S.I.G.A.T.", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf animal.Tipo = Nothing Then
            MessageBox.Show("Seleccione un tipo por favor", "S.I.G.A.T.", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf animal.Nombre = "" Then
            MessageBox.Show("Ingrese un nombre por favor", "S.I.G.A.T.", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf animal.Raza = Nothing Then
            MessageBox.Show("Seleccione una raza por favor", "S.I.G.A.T.", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf animal.Peso = "" Then
            MessageBox.Show("Ingrese el peso por favor", "S.I.G.A.T.", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf animal.Sexo = Nothing Then
            MessageBox.Show("Seleccione un sexo por favor", "S.I.G.A.T.", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Try
                cm.CommandType = CommandType.Text
                Dim consulta As String
                consulta = "SELECT * FROM animales WHERE rp='" & animal.RP & "'"
                cm.CommandText = consulta
                Dim hayRecs As Boolean = False
                Dim lector As OdbcDataReader = cm.ExecuteReader
                lector.Close()
                lector = cm.ExecuteReader
                While lector.Read
                    hayRecs = True
                    MsgBox("El animal ya existe", MsgBoxStyle.Exclamation, "Atención")
                End While
                If Not hayRecs Then
                    lector.Close()
                    consulta = "INSERT INTO animales (rp, nombre, foto, raza, peso, sexo, fecha_nac, idest, eliminado) VALUES('" & animal.RP & "','" & animal.Nombre & "','asd','" & animal.Raza & "','" & animal.Peso & "','" & animal.Sexo & "','" & animal.Fecha & "','1','N')"
                    cm.CommandText = consulta
                    cm.ExecuteNonQuery()
                    MessageBox.Show("El/la " + animal.Tipo + " " + animal.Nombre + " de raza " + animal.Raza + ", RP " + animal.RP + " y nacido el " + animal.Fecha + ", ha sido ingresado al sistema.", "S.I.G.A.T.", _
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception ' En caso de que no se pueda acceder a la base de datos:
                If cx.State = ConnectionState.Closed Then
                    MsgBox("Error al conectarse con la Base de datos", vbExclamation, "Error")
                Else : MsgBox("Error desconocido", vbExclamation, "Error")
                End If



            End Try


        End If
    End Sub
End Class
