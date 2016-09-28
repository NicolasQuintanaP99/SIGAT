Public Class Ordeñe
    Private _RP As Integer
    Private _Litros As Double
    Private _Grasas As String
    Private _Proteinas As String
    Private _CelSomaticas As String
    Private _FechaYHora As Date
    Private _Encargado As String

    Public Property RP() As Integer
        Get
            Return _RP
        End Get
        Set(ByVal value As Integer)
            _RP = value
        End Set
    End Property

    Public Property Litros() As Double
        Get
            Return _Litros
        End Get
        Set(ByVal value As Double)
            _Litros = value
        End Set
    End Property

    Public Property Grasas() As String
        Get
            Return _Grasas
        End Get
        Set(ByVal value As String)
            _Grasas = value
        End Set
    End Property

    Public Property Proteinas() As String
        Get
            Return _Proteinas
        End Get
        Set(ByVal value As String)
            _Proteinas = value
        End Set
    End Property

    Public Property CelSomaticas() As String
        Get
            Return _CelSomaticas
        End Get
        Set(ByVal value As String)
            _CelSomaticas = value
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

    Public Property Encargado() As String
        Get
            Return _Encargado
        End Get
        Set(ByVal value As String)
            _Encargado = value
        End Set
    End Property

    Public Sub Rellenar(ByVal ordeñe As Ordeñe, ByVal rp As Integer, ByVal litros As Double, ByVal grasas As String, ByVal proteinas As String, ByVal celsomaticas As String, ByVal fechayhora As Date, ByVal encargado As String)
        ordeñe.RP = rp
        ordeñe.Litros = litros
        ordeñe.Grasas = grasas
        ordeñe.Proteinas = proteinas
        ordeñe.CelSomaticas = celsomaticas
        ordeñe.FechaYHora = fechayhora
        ordeñe.Encargado = encargado
    End Sub
End Class
