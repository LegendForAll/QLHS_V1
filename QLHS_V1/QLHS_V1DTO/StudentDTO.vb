Public Class StudentDTO
    Private str_Id As String
    Private i_Gender As Integer
    Private str_Name As String
    Private str_Address As String
    Private day_Birthday As DateTime

    Public Sub New()

    End Sub

    Public Sub New(str_Id As String, i_Gender As Integer, str_Name As String, str_Address As String, day_Brithday As DateTime)
        Me.str_Id = str_Id
        Me.i_Gender = i_Gender
        Me.str_Name = str_Name
        Me.str_Address = str_Address
        Me.day_Birthday = day_Brithday

    End Sub

    Property ID_student() As String
        Get
            Return str_Id
        End Get
        Set(ByVal Value As String)
            str_Id = Value
        End Set
    End Property

    Property Gender() As Integer
        Get
            Return i_Gender
        End Get
        Set(ByVal Value As Integer)
            i_Gender = Value
        End Set
    End Property

    Property Student_Name() As String
        Get
            Return str_Name
        End Get
        Set(ByVal Value As String)
            str_Name = Value
        End Set
    End Property

    Property Address() As String
        Get
            Return str_Address
        End Get
        Set(ByVal Value As String)
            str_Address = Value
        End Set
    End Property

    Property DateTime() As DateTime
        Get
            Return day_Birthday
        End Get
        Set(ByVal Value As DateTime)
            day_Birthday = Value
        End Set
    End Property
End Class
