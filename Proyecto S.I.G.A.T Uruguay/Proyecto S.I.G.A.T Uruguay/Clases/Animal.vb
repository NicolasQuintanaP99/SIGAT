Public Class Animal
    Private _RP As Integer
    Private _Tipo As String
    Private _Nombre As String
    Private _Raza As String
    Private _Estado As String
    Private _Sexo As String
    Private _Peso As Double
    Private _Lote As String
    Private _Fecha As Date

    Public Property RP() As Integer
        Get
            Return _RP
        End Get
        Set(ByVal value As Integer)
            _RP = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Raza() As String
        Get
            Return _Raza
        End Get
        Set(ByVal value As String)
            _Raza = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

    Public Property Peso() As Double
        Get
            Return _Peso
        End Get
        Set(ByVal value As Double)
            _Peso = value
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return _Lote
        End Get
        Set(ByVal value As String)
            _Lote = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Public Sub Rellenar(ByVal animal As Animal, ByVal rp As Integer, ByVal tipo As String, ByVal nombre As String, ByVal raza As String, ByVal estado As String, ByVal sexo As String, ByVal peso As Double, ByVal lote As String, ByVal fecha As Date)
        animal.RP = rp
        animal.Tipo = tipo
        animal.Nombre = nombre
        animal.Raza = raza
        animal.Estado = estado
        animal.Sexo = sexo
        animal.Peso = peso
        animal.Lote = lote
        animal.Fecha = fecha
    End Sub

End Class
