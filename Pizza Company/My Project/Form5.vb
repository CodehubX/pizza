Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please input some values", MessageBoxIcon.Warning, "Input")
            'msgBox("")'
        Else
            My.Settings.Name = txtName.Text
            My.Settings.Username = txtUsername.Text
            My.Settings.Password = txtPassword.Text
            My.Settings.Save()
            MsgBox("Successfully Registered", MsgBoxStyle.Information, "Create")
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class