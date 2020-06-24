Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

<JsonObject(NamingStrategyType:=GetType(CamelCaseNamingStrategy))> _
Public Class JsonData
    Private _user As User
    Private _projects As Project()

    Public Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            _user = value
        End Set
    End Property

    Public Property Projects() As Project()
        Get
            Return _projects
        End Get
        Set(ByVal value As Project())
            _projects = value
        End Set
    End Property
End Class

<JsonObject(NamingStrategyType:=GetType(CamelCaseNamingStrategy))> _
Public Class User
    Private _id As Integer
    Private _name As String
    Private _age As Integer

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
        End Set
    End Property
End Class

<JsonObject(NamingStrategyType:=GetType(CamelCaseNamingStrategy))> _
Public Class Project
    Private _id As Integer
    Private _name As String
    Private _isActive As Boolean

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            _isActive = value
        End Set
    End Property
End Class
