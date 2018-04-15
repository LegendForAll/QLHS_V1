Public Class Form1
    Private Sub AddStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentsToolStripMenuItem.Click
        Dim frm As Frm_AddStudent = New Frm_AddStudent()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
