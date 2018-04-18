Public Class ClassStudentDTO
    Private id_class As Integer
    Private str_Id As String
    'Private iMaHocKy As Integer

    Public Sub New()
        id_class = 0
        str_Id = String.Empty
    End Sub
    Public Sub New(iMaLop As Integer, strMSHS As String)
        Me.id_class = iMaLop
        Me.str_Id = strMSHS
        'Me.iMaHocKy = iMaHocKy
    End Sub
    'Public Sub New(iMaLop As Integer, strMSHS As String, iMaHocKy As Integer)
    '    Me.iMaLop = iMaLop
    '    Me.strMSHS = strMSHS
    '    Me.iMaHocKy = iMaHocKy
    'End Sub
    Public Property MaLop As Integer
        Get
            Return id_class
        End Get
        Set(value As Integer)
            id_class = value
        End Set
    End Property

    Public Property MSHS As String
        Get
            Return str_Id
        End Get
        Set(value As String)
            str_Id = value
        End Set
    End Property
End Class
