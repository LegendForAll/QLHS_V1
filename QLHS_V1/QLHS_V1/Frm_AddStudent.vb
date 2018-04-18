Imports QLHS_V1BUS
Imports QLHS_V1DTO
Imports Utility

Public Class Frm_AddStudent
    Private hsBus As StudentBUS
    Private lhsBus As GenderBUS

    Private Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        Dim Student As StudentDTO
        Student = New StudentDTO()

        '1. Mapping data from GUI control
        Student.ID_student = tbx_Student_ID.Text
        Student.Student_Name = tbx_Student_name.Text
        Student.Address = tbx_Address.Text
        Student.DateTime = dtp_Brithday.Value
        Student.Gender = Convert.ToInt32(cbx_Gender.SelectedValue)

        '2. Business .....
        If (hsBus.isValidName(Student) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            tbx_Student_name.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = hsBus.insert(Student)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMshs = "1"
            result = hsBus.buildMSHS(nextMshs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            tbx_Student_ID.Text = nextMshs
            tbx_Address.Text = String.Empty
            tbx_Student_name.Text = String.Empty

        Else
            MessageBox.Show("Thêm Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Frm_AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hsBus = New StudentBUS()
        lhsBus = New GenderBUS()

        ' Load LoaiHocSinh list
        Dim listLoaiHocSinh = New List(Of GenderDTO)
        Dim result As Result
        result = lhsBus.selectAll(listLoaiHocSinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbx_Gender.DataSource = New BindingSource(listLoaiHocSinh, String.Empty)
        cbx_Gender.DisplayMember = "gender1"
        cbx_Gender.ValueMember = "id_gender1"

        'set MSSH auto
        Dim nextMshs = "1"
        result = hsBus.buildMSHS(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        tbx_Student_ID.Text = nextMshs
    End Sub

    Private Sub btn_EnterClose_Click(sender As Object, e As EventArgs) Handles btn_EnterClose.Click
        Dim hocsinh As StudentDTO
        hocsinh = New StudentDTO()

        '1. Mapping data from GUI control
        hocsinh.ID_student = tbx_Student_ID.Text
        hocsinh.Student_Name = tbx_Student_ID.Text
        hocsinh.Address = tbx_Address.Text
        hocsinh.DateTime = dtp_Brithday.Value
        hocsinh.Gender = Convert.ToInt32(cbx_Gender.SelectedValue)

        '2. Business .....
        If (hsBus.isValidName(hocsinh) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            tbx_Student_name.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = hsBus.insert(hocsinh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class