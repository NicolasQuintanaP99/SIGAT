Public Class Cargando

    'Timer que controla el avance de la barra de progreso

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PgbCargando.Increment(1)
        If PgbCargando.Value = PgbCargando.Maximum Then
            While Me.Opacity > 0




                Me.Opacity -= 0.00001




            End While
            Me.Close()
        End If
    End Sub

    'Se da inicio al timer en el Load del form

    Private Sub Cargando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()


    End Sub

    Private Sub PtbVaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PtbVaca.Click

    End Sub
End Class