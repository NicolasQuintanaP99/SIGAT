Public Class UsuarioLogeado
    Private _Login As String
    Private _Password As String
    Private _FechaYHora As Date
    Private _IP As String

    Public Property Login() As String
        Get
            Return _Login
        End Get
        Set(ByVal value As String)
            _Login = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property FechaYHora() As Date
        Get
            Return _FechaYHora
        End Get
        Set(ByVal value As Date)
            _FechaYHora = value
        End Set
    End Property

    Public Property IP() As String
        Get
            Return _IP
        End Get
        Set(ByVal value As String)
            _IP = value
        End Set
    End Property

    Public Sub Rellenar(ByVal usuariologeado As UsuarioLogeado, ByVal login As String, ByVal password As String, ByVal fechayhora As Date, ByVal ip As String)
        usuariologeado.Login = login
        usuariologeado.Password = password
        usuariologeado.FechaYHora = fechayhora
        usuariologeado.IP = ip
    End Sub
End Class
