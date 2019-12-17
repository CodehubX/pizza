Public Class Form6
    Dim countTab As Integer = 1
    Dim maxTab As Integer

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = WindowState.Maximized
        Label3.Text = Form3.txtName.Text
        maxTab = TabControl1.TabCount

        'ListView1.Scrollable = True
        'Columns.Count -1

        For i As Integer = 0 To ListView1.Columns.Count - 1
            ListView1.Columns(i).Width = -2
        Next i

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
        Me.WindowState = WindowState.Minimized
        Form3.txtUsername.Text = ""
        Form3.txtPassword.Text = ""
        Form4.txtPassword.Text = ""
        Form4.txtUsername.Text = ""
        Form4.txtStaffName.Text = ""
        Label3.Text = ""

        txtHw.Clear()
        txtRop.Clear()
        lblTotalPay.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = Form3.txtName.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2, num3 As Double


        num1 = Val(txtRop.Text)
        num2 = Val(txtHw.Text)
        num3 = num1 * num2

        lblTotalPay.Text = num3
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtHw.Clear()
        txtRop.Clear()
        lblTotalPay.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label3.Text = Form3.txtName.Text
    End Sub

    Private Sub btn_NextPage_Click(sender As Object, e As EventArgs) Handles btn_NextPage.Click
        Dim currentTabs As Integer = 0

        currentTabs = TabControl1.SelectedIndex
        currentTabs = currentTabs + 1

        If (currentTabs < TabControl1.TabCount) Then
            TabControl1.SelectedIndex = currentTabs

        ElseIf currentTabs = TabControl1.TabCount Then
            TabControl1.SelectedIndex = 0

        End If


    End Sub

    Private Sub btn_PreviousPage_Click(sender As Object, e As EventArgs) Handles btn_PreviousPage.Click
        Dim currentTabs As Integer = 0

        currentTabs = TabControl1.SelectedIndex
        currentTabs = currentTabs - 1

        If (currentTabs > -1) Then
            TabControl1.SelectedIndex = currentTabs
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click




        Dim TotalSum As Double = 0


        For Each lvItem As ListViewItem In Form2.ListView2.Items

            TotalSum = CDbl(lvItem.SubItems.Item(8).Text)



        Next
        MsgBox("Total Pizza amount of money taken is: £" & TotalSum)




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '6,7,8

        Dim TotalSum As Integer = 0
        Dim sum1 As Integer
        Dim sum2 As Integer
        Dim sum3 As Integer

        For Each lvItem As ListViewItem In Form2.ListView2.Items
            sum1 = CDbl(Val(lvItem.SubItems.Item(9).Text))
            sum2 = CDbl(Val(lvItem.SubItems.Item(10).Text))
            sum3 = CDbl(Val(lvItem.SubItems.Item(11).Text))
            'ListView1.Items(n).SubItems(1).Text, tmp
            TotalSum = sum1 + sum2 + sum3

        Next
        MsgBox("Total Pizza sold is: " & TotalSum)
    End Sub






    'Private Sub Invalid_char(sender As Object, e As KeyPressEventArgs) Handles txtRop.KeyPress, txtHw.KeyPress, MyBase.KeyPress
    'If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
    '       e.Handled = True
    '      MsgBox("Please enter a valid number", MessageBoxIcon.Warning, "Number Warning")
    'End If
    'End Sub
End Class