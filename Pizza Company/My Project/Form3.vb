Public Class Form3

    Dim ownerUsername, managerUsername, ownerPassword, managerPassword As String
    Dim AdminUsername, AdminPassword As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        AdminUsername = "Ridwan"
        AdminPassword = "Ridwan1"

        ownerUsername = "JamilZaman"
        ownerPassword = "Jamil1"

        managerUsername = "AnnaNovak"
        managerPassword = "Anna1"


        'Blank Check'

        If txtUsername.Text = "" Or
                txtName.Text = "" Or
                txtPassword.Text = "" Then
            MsgBox("Please input some values", MessageBoxIcon.Warning, "Input Warning")

        Else
            'Login check for each of the details'
            If txtUsername.Text = AdminUsername AndAlso
                txtPassword.Text = AdminPassword Or txtUsername.Text = managerUsername AndAlso
                txtPassword.Text = managerPassword Or txtUsername.Text = ownerUsername AndAlso
                txtPassword.Text = ownerPassword Then

                MsgBox("Access Granted", MsgBoxStyle.Information, "System Verifier")
                Form6.Label3.Refresh()
                Form6.Label3.Text = txtUsername.Text

                Me.Hide()
                Form6.Show()


            Else
                MsgBox("Access Denied
Check Your Details     ", MessageBoxIcon.Warning, "System Verifier")
            End If


        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
    End Sub
End Class