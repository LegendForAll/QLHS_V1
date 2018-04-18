Public Class ClassDTO
    Private id_class As Integer
    Private name_class As String
    Private id_grade As Integer
    Private id_semester As Integer

    Public Sub New()
        id_class = 0
        name_class = String.Empty
        id_grade = 0
        id_semester = 0
    End Sub
    Public Sub New(id_class As Integer, name_class As String, id_grade As Integer, id_semester As Integer)
        Me.id_class = id_class
        Me.name_class = name_class
        Me.id_grade = id_grade
        Me.id_semester = id_semester
    End Sub
    Public Property MaLop As Integer
        Get
            Return id_class
        End Get
        Set(value As Integer)
            id_class = value
        End Set
    End Property

    Public Property TenLop As String
        Get
            Return name_class
        End Get
        Set(value As String)
            name_class = value
        End Set
    End Property
    Public Property MaKhoi As Integer
        Get
            Return id_grade
        End Get
        Set(value As Integer)
            id_grade = value
        End Set
    End Property

    Public Property MaHocKy As Integer
        Get
            Return id_semester
        End Get
        Set(value As Integer)
            id_semester = value
        End Set
    End Property
End Class
