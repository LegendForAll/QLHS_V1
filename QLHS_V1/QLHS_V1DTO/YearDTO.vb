Public Class YearDTO
    Private id_year_semester As Integer
    Private name_year As String
    Private other_year As Integer
    Public Sub New()
        id_year_semester = 0
        name_year = String.Empty
    End Sub
    Public Sub New(id_year_semester As Integer, name_year As String, other_year As Integer)
        Me.id_year_semester = id_year_semester
        Me.name_year = name_year
        Me.other_year = other_year
    End Sub
    Public Property MaNamHoc As Integer
        Get
            Return id_year_semester
        End Get
        Set(value As Integer)
            id_year_semester = value
        End Set
    End Property

    Public Property NamHoc As String
        Get
            Return name_year
        End Get
        Set(value As String)
            name_year = value
        End Set
    End Property

    Public Property TTNamHoc As Integer
        Get
            Return other_year
        End Get
        Set(value As Integer)
            other_year = value
        End Set
    End Property
End Class
