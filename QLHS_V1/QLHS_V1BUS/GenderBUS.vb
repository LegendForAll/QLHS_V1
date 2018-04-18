Imports QLHS_V1DAL
Imports QLHS_V1DTO
Imports Utility

Public Class GenderBUS
    Private lhsDAL As GenderDAL
    Public Sub New()
        lhsDAL = New GenderDAL()
    End Sub
    Public Sub New(connectionString As String)
        lhsDAL = New GenderDAL(connectionString)
    End Sub
    Public Function isValidName(lhs As GenderDTO) As Boolean

        If (lhs.gender1.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(lhs As GenderDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.insert(lhs)
    End Function
    Public Function update(lhs As GenderDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.update(lhs)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiHS As List(Of GenderDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.selectALL(listLoaiHS)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lhsDAL.getNextID(nextID)
    End Function

End Class
