Public Class Usuario
    Private _Login As String
    Private _Password As String
    Private _CI As Integer
    Private _Cargo As String

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

    Public Property CI() As Integer
        Get
            Return _CI
        End Get
        Set(ByVal value As Integer)
            _CI = value
        End Set
    End Property
    Public Property Cargo() As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property

    Public Sub Rellenar(ByVal usuario As Usuario, ByVal login As String, ByVal password As String, ByVal ci As Integer, ByVal cargo As String)
        usuario.Login = login
        usuario.Password = password
        usuario.CI = ci
        usuario.Cargo = cargo
    End Sub
End Class
