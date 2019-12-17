Public Class Form4
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtStaffName.Focus()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim AdminUsername, AdminPassword As String


        AdminUsername = "Ridwan"
        AdminPassword = "Ridwan1"

        If txtUsername.Text = "" Or
                txtStaffName.Text = "" Or
                txtPassword.Text = "" Then
            MsgBox("Please input some values", MessageBoxIcon.Warning, "Input Warning")

        Else
            If txtUsername.Text = AdminUsername AndAlso
                txtPassword.Text = AdminPassword Then

                MsgBox("Access Granted", MsgBoxStyle.Information, "System Verifier")
                Me.Hide()
                Form7.Show()

            ElseIf txtUsername.Text = My.Settings.Username AndAlso
                    txtStaffName.Text = My.Settings.Name AndAlso
                    txtPassword.Text = My.Settings.Password Then
                MsgBox("Access Granted", MsgBoxStyle.Information, "System Verifier")
                Form2.txtAttendantName.Refresh()
                Form2.txtAttendantName.Text = txtStaffName.Text
                Me.Hide()
                Form7.Show()

            Else
                MsgBox("Access Denied
Check Your Details     ", MessageBoxIcon.Warning, "System Verifier")

            End If


        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStaffName.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form10.Show()

    End Sub
End Class