<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AddStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbx_Student_name = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbx_Gender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtp_Brithday = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbx_Address = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbx_Student_ID = New System.Windows.Forms.TextBox()
        Me.btn_Enter = New System.Windows.Forms.Button()
        Me.btn_EnterClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbx_Student_name
        '
        Me.tbx_Student_name.Location = New System.Drawing.Point(116, 13)
        Me.tbx_Student_name.Name = "tbx_Student_name"
        Me.tbx_Student_name.Size = New System.Drawing.Size(212, 20)
        Me.tbx_Student_name.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbx_Student_name)
        Me.Panel1.Location = New System.Drawing.Point(30, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 44)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student name: "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbx_Gender)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(30, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 44)
        Me.Panel2.TabIndex = 2
        '
        'cbx_Gender
        '
        Me.cbx_Gender.FormattingEnabled = True
        Me.cbx_Gender.Location = New System.Drawing.Point(207, 13)
        Me.cbx_Gender.Name = "cbx_Gender"
        Me.cbx_Gender.Size = New System.Drawing.Size(121, 21)
        Me.cbx_Gender.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student gender:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtp_Brithday)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(30, 187)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(337, 44)
        Me.Panel3.TabIndex = 3
        '
        'dtp_Brithday
        '
        Me.dtp_Brithday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Brithday.Location = New System.Drawing.Point(116, 10)
        Me.dtp_Brithday.Name = "dtp_Brithday"
        Me.dtp_Brithday.Size = New System.Drawing.Size(212, 20)
        Me.dtp_Brithday.TabIndex = 6
        Me.dtp_Brithday.Value = New Date(2018, 4, 20, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Birthday:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.tbx_Address)
        Me.Panel4.Location = New System.Drawing.Point(30, 237)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(337, 44)
        Me.Panel4.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Address:"
        '
        'tbx_Address
        '
        Me.tbx_Address.Location = New System.Drawing.Point(116, 13)
        Me.tbx_Address.Name = "tbx_Address"
        Me.tbx_Address.Size = New System.Drawing.Size(212, 20)
        Me.tbx_Address.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.tbx_Student_ID)
        Me.Panel5.Location = New System.Drawing.Point(30, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(337, 44)
        Me.Panel5.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Student ID: "
        '
        'tbx_Student_ID
        '
        Me.tbx_Student_ID.BackColor = System.Drawing.SystemColors.Control
        Me.tbx_Student_ID.Location = New System.Drawing.Point(116, 13)
        Me.tbx_Student_ID.Name = "tbx_Student_ID"
        Me.tbx_Student_ID.ReadOnly = True
        Me.tbx_Student_ID.Size = New System.Drawing.Size(212, 20)
        Me.tbx_Student_ID.TabIndex = 0
        '
        'btn_Enter
        '
        Me.btn_Enter.Location = New System.Drawing.Point(167, 295)
        Me.btn_Enter.Name = "btn_Enter"
        Me.btn_Enter.Size = New System.Drawing.Size(75, 23)
        Me.btn_Enter.TabIndex = 6
        Me.btn_Enter.Text = "Enter"
        Me.btn_Enter.UseVisualStyleBackColor = True
        '
        'btn_EnterClose
        '
        Me.btn_EnterClose.Location = New System.Drawing.Point(261, 295)
        Me.btn_EnterClose.Name = "btn_EnterClose"
        Me.btn_EnterClose.Size = New System.Drawing.Size(106, 23)
        Me.btn_EnterClose.TabIndex = 7
        Me.btn_EnterClose.Text = "Enter and Close"
        Me.btn_EnterClose.UseVisualStyleBackColor = True
        '
        'Frm_AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 330)
        Me.Controls.Add(Me.btn_EnterClose)
        Me.Controls.Add(Me.btn_Enter)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_AddStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbx_Student_name As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbx_Gender As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtp_Brithday As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents tbx_Address As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents tbx_Student_ID As TextBox
    Friend WithEvents btn_Enter As Button
    Friend WithEvents btn_EnterClose As Button
End Class
