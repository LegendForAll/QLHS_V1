Public Class GenderDTO
    Private id_gender As Integer
    Private gender As String

    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String)
        id_gender = ml
        gender = tl
    End Sub
    Property id_gender1() As Integer
        Get
            Return id_gender
        End Get
        Set(ByVal Value As Integer)
            id_gender = Value
        End Set
    End Property
    Property gender1() As String
        Get
            Return gender
        End Get
        Set(ByVal Value As String)
            gender = Value
        End Set
    End Property
End Class
