Public Class Form10
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim AdminUsername, AdminPassword As String


        AdminUsername = "Ridwan"
        AdminPassword = "Ridwan1"

        If txtUsername.Text = "" Or
                txtPassword.Text = "" Then
            MsgBox("Please input some values", MessageBoxIcon.Warning, "Input Warning")

        Else
            If txtUsername.Text = AdminUsername AndAlso
                txtPassword.Text = AdminPassword Then

                MsgBox("You can now Proceed with account creation", MsgBoxStyle.Information, "System Verifier")
                Form5.txtName.Clear()
                Form5.txtPassword.Clear()
                Form5.txtUsername.Clear()
                Me.Close()
                Form5.Show()

            Else
                MsgBox("Access Denied
Check Your Details     ", MessageBoxIcon.Warning, "System Verifier")

            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Application About To Shut Down would you like to proceed?", MsgBoxStyle.OkCancel, "Shutdown Request") = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub
End Class
