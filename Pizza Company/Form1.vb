Public Class Form1

    Dim orderNumber As New Random

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = WindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.txtUsername.Text = ""
        Form3.txtName.Text = ""
        Form3.txtPassword.Text = ""
        Form4.txtPassword.Text = ""
        Form4.txtUsername.Text = ""
        Form4.txtStaffName.Text = ""
        Form5.txtUsername.Text = ""
        Form5.txtPassword.Text = ""


        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form3.txtUsername.Text = ""
        Form3.txtName.Text = ""
        Form3.txtPassword.Text = ""
        Form4.txtPassword.Text = ""
        Form4.txtUsername.Text = ""
        Form4.txtStaffName.Text = ""
        Form5.txtUsername.Text = ""
        Form5.txtPassword.Text = ""

        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form11.Show()
    End Sub
End Class
'messagebox.show(orderNumber.Next(0, 1000))