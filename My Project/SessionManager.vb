Public Class SessionManager

    Public _APIKey As String = String.Empty
    Public _SendCount As Integer = 1

    Public _Version As String = String.Empty

    ' Private constructor prevents external instantiation (singleton)
    Private Sub New()
    End Sub

    ' Lazy(Of T) provides thread-safe lazy initialization
    Private Shared ReadOnly _instance As New Lazy(Of SessionManager)(
        Function() New SessionManager()
    )

    ' Public access point
    Public Shared ReadOnly Property Instance As SessionManager
        Get
            Return _instance.Value
        End Get
    End Property

    Public Property APIKey As String
        Get
            Return _APIKey
        End Get
        Set(value As String)
            _APIKey = value
        End Set
    End Property

    Public Property SendCount As Integer
        Get
            Return _SendCount
        End Get
        Set(value As Integer)
            _SendCount = value
        End Set
    End Property

    Public Property Version As String
        Get
            Return _Version
        End Get
        Set(value As String)
            _Version = value
        End Set
    End Property
End Class
