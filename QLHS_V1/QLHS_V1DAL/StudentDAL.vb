Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHS_V1DTO
Imports Utility
Public Class StudentDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildIDStudent(ByRef nextID As String) As Result
        nextID = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextID = x + "000000"


        Dim query As String = String.Empty
        query &= "Select TOP 1 [id_Student] "
        query &= "From [tbl_Student] "
        query &= "Order By [id_Student] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("id_Student")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextID = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextID = nextID + tmp
                        System.Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(hs As StudentDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tbl_Student] ([id_Student], [ID_Gender], [student_name], [address], [brithday])"
        'sai fix
        query &= "VALUES (@id_Student,@ID_Gender,@student_name,@address,@brithday)"

        'get MSHS
        Dim nextID = "1"
        buildIDStudent(nextID)
        hs.ID_student = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id_Student", hs.ID_student)
                    .Parameters.AddWithValue("@ID_Gender", hs.Gender)
                    .Parameters.AddWithValue("@student_name", hs.Student_Name)
                    .Parameters.AddWithValue("@address", hs.Address)
                    .Parameters.AddWithValue("@brithday", hs.DateTime)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listStudent As List(Of StudentDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [id_Student], [ID_Gender], [student_name], [address], [brithday]"
        query &= "FROM [tbl_Student]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listStudent.Clear()
                        While reader.Read()
                            listStudent.Add(New StudentDTO(reader("ID_student"), reader("Gender"), reader("Student_Name"), reader("Address"), reader("DateTime")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listHocSinh As List(Of StudentDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [id_Student], [ID_Gender], [student_name], [address], [brithday] "
        query &= " FROM [tbl_Student] "
        query &= "     ,[tbl_StudentCLASS] "
        query &= " WHERE "
        query &= "     [tbl_Student].[id_Student] = [tbl_StudentCLASS].[id_Student]"
        query &= "     AND [tbl_StudentCLASS].[id_CLASS] = @id_CLASS"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id_CLASS", iMaLop)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHocSinh.Clear()
                        While reader.Read()
                            listHocSinh.Add(New StudentDTO(reader("ID_student"), reader("Gender"), reader("Student_Name"), reader("Address"), reader("DateTime")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Học sinh theo Lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByType(maLoai As Integer, ByRef listHocSinh As List(Of StudentDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [id_Student], [ID_Gender], [student_name], [address], [brithday] "
        query &= "FROM [tbl_Student] "
        query &= "WHERE [ID_Gender] = @ID_Gender "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_Gender", maLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHocSinh.Clear()
                        While reader.Read()
                            listHocSinh.Add(New StudentDTO(reader("ID_student"), reader("Gender"), reader("Student_Name"), reader("Address"), reader("DateTime")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Học sinh theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(hs As StudentDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tbl_Student] SET"
        query &= " [ID_Gender] = @ID_Gender "
        query &= " ,[student_name] = @student_name "
        query &= " ,[address] = @address "
        query &= " ,[brithday] = @brithday "
        query &= " WHERE "
        query &= " [id_Student] = @id_Student "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_Gender", hs.Gender)
                    .Parameters.AddWithValue("@student_name", hs.Student_Name)
                    .Parameters.AddWithValue("@address", hs.Address)
                    .Parameters.AddWithValue("@brithday", hs.DateTime)
                    .Parameters.AddWithValue("@id_Student", hs.ID_student)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maHocSinh As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tbl_Student] "
        query &= " WHERE "
        query &= " [id_Student] = @id_Student "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id_Student", maHocSinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
