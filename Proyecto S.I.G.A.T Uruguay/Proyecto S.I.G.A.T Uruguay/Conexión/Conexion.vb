Public Class Conexion
    Private Sub ConexionBD(ByVal sender As System.Ojbect, ByVal e As System.EventArgs)
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.Connection()
    End Sub

End Class
