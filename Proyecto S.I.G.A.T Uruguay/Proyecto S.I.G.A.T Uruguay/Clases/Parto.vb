Public Class Parto
    Private _RPHembra As Integer
    Private _RPMacho As Integer
    Private _FechaParto As Date
    Private _SexoCria As String
    Private _NombreCria As String
    Private _RPCria As Integer
    Private _Aborto As Boolean

    Public Property RPHembra() As Integer
        Get
            Return _RPHembra
        End Get
        Set(ByVal value As Integer)
            _RPHembra = value
        End Set
    End Property

    Public Property RPMacho() As Integer
        Get
            Return _RPMacho
        End Get
        Set(ByVal value As Integer)
            _RPMacho = value
        End Set
    End Property

    Public Property FechaParto() As Date
        Get
            Return _FechaParto
        End Get
        Set(ByVal value As Date)
            _FechaParto = value
        End Set
    End Property

    Public Property SexoCria() As String
        Get
            Return _SexoCria
        End Get
        Set(ByVal value As String)
            _SexoCria = value
        End Set
    End Property

    Public Property NombreCria() As String
        Get
            Return _NombreCria
        End Get
        Set(ByVal value As String)
            _NombreCria = value
        End Set
    End Property

    Public Property RPCria() As Integer
        Get
            Return _RPCria
        End Get
        Set(ByVal value As Integer)
            _RPCria = value
        End Set
    End Property

    Public Property Aborto() As Boolean
        Get
            Return _Aborto
        End Get
        Set(ByVal value As Boolean)
            _Aborto = value
        End Set
    End Property

    Public Sub Rellenar(ByVal parto As Parto, ByVal rphembra As Integer, ByVal rpmacho As Integer, ByVal fechaparto As Date, ByVal sexocria As String, ByVal nombrecria As String, ByVal rpcria As Integer, ByVal aborto As Boolean)
        parto.RPHembra = rphembra
        parto.RPMacho = rpmacho
        parto.FechaParto = fechaparto
        parto.SexoCria = sexocria
        parto.RPCria = rpcria
        parto.NombreCria = nombrecria
        parto.Aborto = aborto
    End Sub
End Class
