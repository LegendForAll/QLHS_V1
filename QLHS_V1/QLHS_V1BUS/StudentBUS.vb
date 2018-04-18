Imports QLHS_V1DAL
Imports QLHS_V1DTO
Imports Utility

Public Class StudentBUS
    Private hsDAL As StudentDAL
    Public Sub New()
        hsDAL = New StudentDAL()
    End Sub
    Public Sub New(connectionString As String)
        hsDAL = New StudentDAL(connectionString)
    End Sub

    Public Function isValidName(hs As StudentDTO) As Boolean

        If (hs.Student_Name.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(hs As StudentDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hsDAL.insert(hs)
    End Function

    Public Function update(hs As StudentDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hsDAL.update(hs)
    End Function

    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hsDAL.delete(maLoai)
    End Function

    Public Function selectAll(ByRef listLoaiHS As List(Of StudentDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hsDAL.selectALL(listLoaiHS)
    End Function
    Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listHS As List(Of StudentDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hsDAL.selectALL_ByMaLop(iMaLop, listHS)
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef listHS As List(Of StudentDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hsDAL.selectALL_ByType(maLoai, listHS)
    End Function

    Public Function buildMSHS(ByRef nextMshs As Integer) As Result
        Return hsDAL.buildIDStudent(nextMshs)
    End Function
End Class
