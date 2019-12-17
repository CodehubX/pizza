Public Class Form2

    Dim op As String
    Dim firstNumber As Double
    Dim secondNumber As Double
    Dim Answer As Double
    Dim value As Integer = CInt(Int((124321 * Rnd() * 432)))
    Dim orderNumber As Integer
    Dim newOrder As Integer
    Dim smallPizzaPrice As Double
    Dim mediumPizzaPrice As Double
    Dim largePizzaPrice As Double
    Dim orderCost As Double
    Dim orderGrandTotal As Double



    'btn show total


    'small
    Dim smallAmount As Integer
    Dim smallOrderTotal As Integer
    'medium
    Dim mediumAmount As Integer
    Dim mediumOrderTotal As Integer
    'large
    Dim largeAmount As Integer
    Dim largeOrderTotal As Integer
    'for discount
    Dim discount As Decimal
    'for txtTotal
    Dim integer1 As Double
    'for txtDiscount
    Dim integer2 As Double
    'for txtTotal
    Dim Newcost As Double


    Private Sub Form2_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load




        For i As Integer = 0 To ListView2.Columns.Count - 1
            ListView2.Columns(i).Width = -2
        Next i

        txtOrderNumber.Text = value
        txtCustomerName = txtCustomerName
        orderNumber = value
        Me.WindowState = WindowState.Maximized
        orderNumber = Val(txtOrderNumber.Text)
        txtOrderTime.Text = TimeOfDay
        txtOrderDate.Text = Today
        txtAttendantName.Text = Form4.txtStaffName.Text

        'locks all of the textboxes to do with pizza size
        txtPizzaSizeSmall.Enabled = False
        txtPizzaSizeMedium.Enabled = False
        txtPizzaSizeLarge.Enabled = False

        'locks the other textboxes

        txtOrderDate.Enabled = False
        txtOrderNumber.Enabled = False
        txtOrderTime.Enabled = False
        txtAttendantName.Enabled = False
        txtTotal.Enabled = False
        txtDiscount.Enabled = False
        txtCost.Enabled = False

        txtDiscount.Text = "0"
        txtTotal.Text = "0"
        txtCost.Text = "0"

        'Pizza Prices
        smallPizzaPrice = 6
        mediumPizzaPrice = 8
        largePizzaPrice = 10


        Label13.Text = Form4.txtStaffName.Text


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
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_Click_1(sender As Object, e As EventArgs) Handles Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button15.Click, Button14.Click, Button13.Click, Button11.Click, Button10.Click
        Dim b As Button = sender
        If lblDisplay.Text = "0" Then
            lblDisplay.Text = b.Text
        Else
            lblDisplay.Text = lblDisplay.Text + b.Text
        End If
    End Sub

    Private Sub arith_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub arith_operators(sender As Object, e As EventArgs) Handles TabPage1.Click, Button20.Click, Button19.Click, Button18.Click, Button17.Click
        Dim ops As Button = sender
        firstNumber = lblDisplay.Text
        lblShowCal.Text = lblDisplay.Text
        lblDisplay.Text = ""
        op = ops.Text
        lblShowCal.Text = lblShowCal.Text + "" + op
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        lblDisplay.Text = "0"
        lblShowCal.Text = ""
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If InStr(lblDisplay.Text, ".") = 0 Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lblDisplay.Text.Length > 0 Then
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1)
        End If
        If lblDisplay.Text = "" Then
            lblDisplay.Text = "0"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        secondNumber = lblDisplay.Text
        If op = "+" Then
            Answer = firstNumber + secondNumber
            lblDisplay.Text = Answer
            lblShowCal.Text = ""


        ElseIf op = "-" Then
            Answer = firstNumber - secondNumber
            lblDisplay.Text = Answer
            lblShowCal.Text = ""


        ElseIf op = "*" Then
            Answer = firstNumber * secondNumber
            lblDisplay.Text = Answer
            lblShowCal.Text = ""


        ElseIf op = "/" Then
            Answer = firstNumber / secondNumber
            lblDisplay.Text = Answer
            lblShowCal.Text = ""



        End If
    End Sub

    Private Sub Button3_TextChanged(sender As Object, e As EventArgs) Handles Button3.TextChanged
        If lblDisplay.Text = "" Then
            lblDisplay.Text = "0"
        End If
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click


        'receipt clearing
        TxtReceipt.Clear()

        txtOrderTime.Text = TimeOfDay
        txtOrderDate.Text = Today
        txtAttendantName.Text = Form4.txtStaffName.Text

        txtAdditionalComments.Clear()
        txtCost.Text = "0"
        txtCustomerName.Clear()
        txtDiscount.Text = "0"

        txtPizzaSizeLarge.Clear()
        txtPizzaSizeMedium.Clear()
        txtPizzaSizeSmall.Clear()
        txtTotal.Text = "0"

        'Check boxes'
        ChkSizeSmall.Checked = False
        ChkSizeMedium.Checked = False
        ChkSizeLarge.Checked = False
        chkExtraToppingNT.Checked = False
        chkExtraToppingDC.Checked = False
        chkExtraToppingRV.Checked = False
        chkExtraToppingSS.Checked = False


        'textboxes for pizza size becoming locked again'
        txtPizzaSizeSmall.Enabled = False
        txtPizzaSizeMedium.Enabled = False
        txtPizzaSizeLarge.Enabled = False


    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim CustomerName As String
        Dim test1 As String
        CustomerName = txtCustomerName.Text
        orderNumber = Val(txtOrderNumber.Text)

        If ListView2.Items.Count = 0 Then


            'Dim item1 As ListViewItem


            GlobalVariables.item1 = ListView2.Items.Add(txtOrderNumber.Text)
            GlobalVariables.item1.SubItems.Add(txtCustomerName.Text)
            GlobalVariables.item1.SubItems.Add(txtOrderDate.Text)
            GlobalVariables.item1.SubItems.Add(txtOrderTime.Text)
            GlobalVariables.item1.SubItems.Add(txtAttendantName.Text)
            GlobalVariables.item1.SubItems.Add(txtAdditionalComments.Text)

            GlobalVariables.item1.SubItems.Add(txtTotal.Text)
            GlobalVariables.item1.SubItems.Add(txtDiscount.Text)
            GlobalVariables.item1.SubItems.Add(txtCost.Text)
            GlobalVariables.item1.SubItems.Add(txtPizzaSizeSmall.Text)
            GlobalVariables.item1.SubItems.Add(txtPizzaSizeMedium.Text)
            GlobalVariables.item1.SubItems.Add(txtPizzaSizeLarge.Text)

            'check boxes
            If chkExtraToppingDC.Checked = True Then
                GlobalVariables.item1.SubItems.Add("Yes")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")



            ElseIf chkExtraToppingRV.Checked = True Then

                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("Yes")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")


            ElseIf chkExtraToppingSS.Checked = True Then
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("Yes")
                GlobalVariables.item1.SubItems.Add("No")

            ElseIf chkExtraToppingNT.Checked = True Then
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("Yes")

            ElseIf chkExtraToppingNT.Checked = False And
                    chkExtraToppingDC.Checked = False AndAlso
                    chkExtraToppingRV.Checked = False AndAlso
                    chkExtraToppingSS.Checked = False Then
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")


            End If

            GlobalVariables.item1 = Nothing

        Else
            With ListView2
                Dim Checker As ListViewItem
                'Dim i As DialogResult
                orderNumber = Val(txtOrderNumber.Text)
                'Dim num1 As Integer
                Checker = .FindItemWithText(txtOrderNumber.Text, True, 0, True)
                If Not Checker Is Nothing Then


                    If MsgBox("The Order Number: " & txtOrderNumber.Text & " has already been served. 
 Would you like to generate a new Order Number?", MsgBoxStyle.YesNo Or MessageBoxIcon.Warning, "Verify Order Number") = DialogResult.Yes Then
                        txtOrderNumber.Clear()
                        txtOrderNumber.Text = CInt(Int((13200 * Rnd() + 1)))
                        MsgBox("A new order number has been generated", MessageBoxIcon.Information, "New order number notifier")

                        'If (i = DialogResult.No) Then
                        '   txtOrderNumber.Clear()
                        '  txtOrderNumber.Text = CInt(Int((13200 * Rnd() + 1)))
                        ' MsgBox("A new order number has been generated", "New order number notifier", MessageBoxIcon.Information)
                    End If

                Else 'Dim item1 As ListViewItem

                    GlobalVariables.item1 = ListView2.Items.Add(txtOrderNumber.Text)
                    GlobalVariables.item1.SubItems.Add(txtCustomerName.Text)
                    GlobalVariables.item1.SubItems.Add(txtOrderDate.Text)
                    GlobalVariables.item1.SubItems.Add(txtOrderTime.Text)
                    GlobalVariables.item1.SubItems.Add(txtAttendantName.Text)
                    GlobalVariables.item1.SubItems.Add(txtAdditionalComments.Text)

                    GlobalVariables.item1.SubItems.Add(txtTotal.Text)
                    GlobalVariables.item1.SubItems.Add(txtDiscount.Text)
                    GlobalVariables.item1.SubItems.Add(txtCost.Text)
                    GlobalVariables.item1.SubItems.Add(txtPizzaSizeSmall.Text)
                    GlobalVariables.item1.SubItems.Add(txtPizzaSizeMedium.Text)
                    GlobalVariables.item1.SubItems.Add(txtPizzaSizeLarge.Text)

                    'check boxes
                    If chkExtraToppingDC.Checked = True Then
                        GlobalVariables.item1.SubItems.Add("Yes")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")



                    ElseIf chkExtraToppingRV.Checked = True Then

                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("Yes")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")


                    ElseIf chkExtraToppingSS.Checked = True Then
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("Yes")
                        GlobalVariables.item1.SubItems.Add("No")

                    ElseIf chkExtraToppingNT.Checked = True Then
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("Yes")

                    ElseIf chkExtraToppingNT.Checked = False And
                            chkExtraToppingDC.Checked = False AndAlso
                            chkExtraToppingRV.Checked = False AndAlso
                            chkExtraToppingSS.Checked = False Then
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")


                    End If

                    GlobalVariables.item1 = Nothing

                End If
            End With


        End If


        'for manager's account
        For Each item1 As ListViewItem In ListView2.Items
            Form6.ListView1.Items.Add(item1.Clone)
        Next










        '#------------------------------------------------------
        'Prompt to enter pizza amount


        If ChkSizeSmall.Checked = True AndAlso
                txtPizzaSizeSmall.Text = "" Or
                ChkSizeMedium.Checked = True AndAlso
                txtPizzaSizeMedium.Text = "" Or
                ChkSizeLarge.Checked = True AndAlso
                txtPizzaSizeLarge.Text = "" Then
            MsgBox("please enter amount of pizza
in the text box", MessageBoxIcon.Warning, "Empty Pizza Amount")
            '#------------------------------------------------------
            'End of Prompt to enter pizza amount


        ElseIf txtCustomerName.Text = "" Then
            MsgBox("Please enter customer's name", MessageBoxIcon.Warning)



            'ordering just the toppings
        ElseIf chkExtraToppingNT.Checked = True And
                ChkSizeSmall.Checked = False And
                ChkSizeMedium.Checked = False And
                ChkSizeLarge.Checked = False Then
            MsgBox("You cannot order Extra-Toppings without a pizza", MessageBoxIcon.Warning)

        ElseIf chkExtraToppingDC.Checked = True And
               ChkSizeSmall.Checked = False And
               ChkSizeMedium.Checked = False And
               ChkSizeLarge.Checked = False Then
            MsgBox("You cannot order Extra-Toppings without a pizza", MessageBoxIcon.Warning)

        ElseIf chkExtraToppingRV.Checked = True And
                ChkSizeSmall.Checked = False And
                ChkSizeMedium.Checked = False And
                ChkSizeLarge.Checked = False Then
            MsgBox("You cannot order Extra-Toppings without a pizza", MessageBoxIcon.Warning)

        ElseIf chkExtraToppingSS.Checked = True And
               ChkSizeSmall.Checked = False And
               ChkSizeMedium.Checked = False And
               ChkSizeLarge.Checked = False Then
            MsgBox("You cannot order Extra-Toppings without a pizza", MessageBoxIcon.Warning)

        




        Else
            On Error GoTo SaveErr

            '----------------------------------------------------pizza sizes------------------------------------------------------------

            If ChkSizeSmall.Checked = True Then
                smallAmount = Val(txtPizzaSizeSmall.Text)
                smallOrderTotal = (smallAmount * 6)

            End If

            If ChkSizeMedium.Checked = True Then
                mediumAmount = Val(txtPizzaSizeMedium.Text)
                mediumOrderTotal = (mediumAmount * 8)

            End If

            If ChkSizeLarge.Checked = True Then
                largeAmount = Val(txtPizzaSizeLarge.Text)
                largeOrderTotal = (largeAmount * 10)

            End If

            '--------------------------------------------------pizza sizes end-----------------------------------------------------------

            'total price for all three pizza sizes is saved in OrderGrandTotal
            '**note** even of only on1 check box is ticked, the rest would be marked as 0
            orderGrandTotal = smallOrderTotal + mediumOrderTotal + largeOrderTotal

            '---------------------------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------------------
            'FOR EXTRA TOPPINGS
            '---------------------------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------------------

            'for extra topping cost 
            If chkExtraToppingDC.Checked = True Or
            chkExtraToppingRV.Checked = True Or
            chkExtraToppingSS.Checked = True Then
                orderGrandTotal = (orderGrandTotal + 1.5)

            Else
                If chkExtraToppingNT.Checked = True Then
                    orderGrandTotal = (orderGrandTotal + 0)
                End If


            End If

            '---------------------------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------------------
            'FOR EXTRA TOPPING END
            '---------------------------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------------------

            txtTotal.Text = orderGrandTotal

            'for txtTotal
            integer1 = Val(txtTotal.Text)


            'for txtDiscount
            integer2 = Val(txtDiscount.Text)


            'getting discount 
            If orderGrandTotal >= 20 Then
                discount = orderGrandTotal * 5 / 100
                Newcost = integer1 - discount
                txtCost.Text = ("£" & Newcost)
                txtDiscount.Text = "-£ " & discount
            Else
                If orderGrandTotal <= 19 Then
                    txtCost.Text = "£" & orderGrandTotal
                    txtDiscount.Text = "0"
                End If
            End If


            '#------------------------------------------------------
            'Should be in place order button too
            'Prompt to enter pizza amount
            If ChkSizeSmall.Checked = True AndAlso
        txtPizzaSizeSmall.Text = "" Or
        ChkSizeMedium.Checked = True AndAlso
        txtPizzaSizeMedium.Text = "" Or
        ChkSizeLarge.Checked = True AndAlso
        txtPizzaSizeLarge.Text = "" Then
                MsgBox("please enter amount of pizza
in the text box", MessageBoxIcon.Warning, "Empty Pizza Amount")
            End If
            '#------------------------------------------------------
            'End of Prompt to enter pizza amount


            'receipt Showing
            TabControl1.SelectedTab = TabPage3
            Me.TabControl1.SelectedTab = TabPage2
            Me.TabPage2.Select()

            'message
            TxtReceipt.AppendText(vbTab + vbTab + "             Your Shopping Receipt")
            TxtReceipt.AppendText(vbTab + vbTab + vbTab & "===========================================================" + vbNewLine)
            TxtReceipt.AppendText(" " + vbNewLine)

            'details
            TxtReceipt.AppendText("Name: " + vbTab + txtCustomerName.Text + vbTab + "Order No: " & txtOrderNumber.Text + vbTab + "Name Of Att.: " & Label13.Text + vbNewLine)
            TxtReceipt.AppendText(vbNewLine + "Order Date: " + vbTab & txtOrderDate.Text + vbTab + "Order Time: " + vbTab & txtOrderTime.Text + vbNewLine)

            'purchased items
            TxtReceipt.AppendText(vbNewLine + "Item Type" + vbTab + vbTab + "Qty" + vbTab + vbTab & "Unit Price" + vbTab + vbTab & "Sub-Total " + vbNewLine)
            TxtReceipt.AppendText(vbNewLine + "Small Pizza" + vbTab & txtPizzaSizeSmall.Text + vbTab + vbTab & "£6")
            TxtReceipt.AppendText(vbNewLine + "Medium Pizza" + vbTab & txtPizzaSizeMedium.Text + vbTab + vbTab & "£8")
            TxtReceipt.AppendText(vbNewLine + "large Pizza" + vbTab & txtPizzaSizeLarge.Text + vbTab + vbTab & "£10" + vbNewLine)

            'total, discounts, toppings and costs after discount
            TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Cost of Topping: " + vbTab & "£1.50")
            TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Total of Order: " + vbTab & txtTotal.Text)
            TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Discount on Order: " + vbTab & txtDiscount.Text)
            TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Cost of Order: " + vbTab & txtCost.Text)

            'bottom Message
            TxtReceipt.AppendText(vbTab + vbTab + vbTab & "===========================================================" + vbNewLine)
            TxtReceipt.AppendText(vbTab + vbTab & "     Thanks for Shoppping With Us")




            'from show total button
            If MsgBox("Customer name: " & CustomerName & " with order number " & orderNumber &
            " has been served ", MessageBoxIcon.Information Or MsgBoxStyle.OkCancel, "Customer Served!") = DialogResult.OK Then
                Me.TabControl1.SelectedTab = TabPage3
                Me.TabPage3.Select()

                'Everything Resetting
                txtOrderNumber.Text = CInt(Int((100000 * Rnd() + 1)))
                txtOrderTime.Text = TimeOfDay
                txtOrderDate.Text = Today
                txtAttendantName.Text = Form4.txtStaffName.Text

                'receipt clearing
                TxtReceipt.Clear()

                'right hand bar
                txtAdditionalComments.Clear()
                txtCost.Text= "0"
                txtCustomerName.Clear()
                txtDiscount.Text = "0"
                txtTotal.Text = "0"

                'pizza size text box'
                txtPizzaSizeLarge.Clear()
                txtPizzaSizeMedium.Clear()
                txtPizzaSizeSmall.Clear()

                'Check boxes'
                ChkSizeSmall.Checked = False
                ChkSizeMedium.Checked = False
                ChkSizeLarge.Checked = False
                chkExtraToppingNT.Checked = False
                chkExtraToppingDC.Checked = False
                chkExtraToppingRV.Checked = False
                chkExtraToppingSS.Checked = False


                'textboxes for pizza size becoming locked again'
                txtPizzaSizeSmall.Enabled = False
                txtPizzaSizeMedium.Enabled = False
                txtPizzaSizeLarge.Enabled = False

SaveErr:
                Exit Sub



            End If
        End If


    End Sub

    Private Sub txtOrderDate_TextChanged(sender As Object, e As EventArgs) Handles txtOrderDate.TextChanged
        txtOrderDate.Text = Today

    End Sub

    Private Sub txtOrderTime_TextChanged(sender As Object, e As EventArgs) Handles txtOrderTime.TextChanged
        txtOrderTime.Text = TimeOfDay
    End Sub

    Private Sub txtOrderNumber_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click

        txtOrderNumber.Text = CInt(Int((100000 * Rnd() + 1)))
        txtAdditionalComments.Text = ""
        TxtReceipt.Clear()

    End Sub

    Private Sub txtAttendantName_TextChanged(sender As Object, e As EventArgs) Handles txtAttendantName.TextChanged
        txtAttendantName.Refresh()
        txtAttendantName.Text = Form4.txtStaffName.Text
    End Sub

    Private Sub ChkSizeSmall_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub chkExtraToppingDC_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkSizeSmall_MouseClick(sender As Object, e As MouseEventArgs) Handles ChkSizeSmall.MouseClick
        If ChkSizeSmall.Checked = True Then
            txtPizzaSizeSmall.Enabled = True

        ElseIf ChkSizeSmall.Checked = False Then
            txtPizzaSizeSmall.Clear()
            txtPizzaSizeSmall.Enabled = False

        End If
    End Sub

    Private Sub ChkSizeMedium_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkSizeMedium_MouseMove(sender As Object, e As MouseEventArgs) Handles ChkSizeMedium.MouseMove
        If ChkSizeMedium.Checked = True Then
            txtPizzaSizeMedium.Enabled = True

        ElseIf ChkSizeMedium.Checked = False Then
            txtPizzaSizeMedium.Clear()
            txtPizzaSizeMedium.Enabled = False

        End If
    End Sub

    Private Sub ChkSizeLarge_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSizeLarge.CheckedChanged
        If ChkSizeLarge.Checked = True Then
            txtPizzaSizeLarge.Enabled = True

        ElseIf ChkSizeLarge.Checked = False Then
            txtPizzaSizeLarge.Clear()
            txtPizzaSizeLarge.Enabled = False

        End If
    End Sub


    Private Sub txtPizzaSizeMedium_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPizzaSizeSmall_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PizzaSize(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnshowTotal_Click(sender As Object, e As EventArgs) Handles btnshowTotal.Click
        If ChkSizeSmall.Checked = False Then
            txtPizzaSizeSmall.Text = "0"
        End If

        If ChkSizeMedium.Checked = False Then
            txtPizzaSizeMedium.Text = "0"
        End If

        If ChkSizeLarge.Checked = False Then
            txtPizzaSizeLarge.Text = "0"
        End If
        '----------------------------------------------------pizza sizes------------------------------------------------------------

        If ChkSizeSmall.Checked = True Then
            smallAmount = Val(txtPizzaSizeSmall.Text)
            smallOrderTotal = (smallAmount * 6)

        End If

        If ChkSizeMedium.Checked = True Then
            mediumAmount = Val(txtPizzaSizeMedium.Text)
            mediumOrderTotal = (mediumAmount * 8)

        End If

        If ChkSizeLarge.Checked = True Then
            largeAmount = Val(txtPizzaSizeLarge.Text)
            largeOrderTotal = (largeAmount * 10)

        End If

        '--------------------------------------------------pizza sizes end-----------------------------------------------------------

        'total price for all three pizza sizes is saved in OrderGrandTotal
        '**note** even of only on1 check box is ticked, the rest would be marked as 0
        orderGrandTotal = smallOrderTotal + mediumOrderTotal + largeOrderTotal

        '---------------------------------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------------------------------
        'FOR EXTRA TOPPINGS
        '---------------------------------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------------------------------

        'for extra topping cost 
        If chkExtraToppingDC.Checked = True Or
            chkExtraToppingRV.Checked = True Or
            chkExtraToppingSS.Checked = True Then
            orderGrandTotal = (orderGrandTotal + 1.5)

        Else
            If chkExtraToppingNT.Checked = True Then
                orderGrandTotal = (orderGrandTotal + 0)
            End If


        End If

        '---------------------------------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------------------------------
        'FOR EXTRA TOPPING END
        '---------------------------------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------------------------------

        txtTotal.Text = orderGrandTotal

        'for txtTotal
        integer1 = Val(txtTotal.Text)


        'for txtDiscount
        integer2 = Val(txtDiscount.Text)


        'getting discount 
        If orderGrandTotal >= 20 Then
            discount = orderGrandTotal * 5 / 100
            Newcost = integer1 - discount
            txtCost.Text = ("£" & Newcost)
            txtDiscount.Text = "-£ " & discount
        Else
            If orderGrandTotal <= 19 Then
                txtCost.Text = "£" & orderGrandTotal
                txtDiscount.Text = "0"
            End If
        End If


        '#------------------------------------------------------
        'Should be in place order button too
        'Prompt to enter pizza amount
        If ChkSizeSmall.Checked = True AndAlso
        txtPizzaSizeSmall.Text = "" Or
        ChkSizeMedium.Checked = True AndAlso
        txtPizzaSizeMedium.Text = "" Or
        ChkSizeLarge.Checked = True AndAlso
        txtPizzaSizeLarge.Text = "" Then
            MsgBox("please enter amount of pizza
in the text box", MessageBoxIcon.Warning, "Empty Pizza Amount")
        End If
        '#------------------------------------------------------
        'End of Prompt to enter pizza amount




    End Sub

    Private Sub managerApproval(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAppendOrder_Click(sender As Object, e As EventArgs)
        Dim item1 As ListViewItem


        item1 = ListView2.Items.Add(txtOrderNumber.Text)
        item1.SubItems.Add(txtCustomerName.Text)
        item1.SubItems.Add(txtOrderDate.Text)
        item1.SubItems.Add(txtOrderTime.Text)
        item1.SubItems.Add(txtAttendantName.Text)
        item1.SubItems.Add(txtAdditionalComments.Text)

        item1.SubItems.Add(txtTotal.Text)
        item1.SubItems.Add(txtDiscount.Text)
        item1.SubItems.Add(txtCost.Text)
        item1.SubItems.Add(txtPizzaSizeSmall.Text)
        item1.SubItems.Add(txtPizzaSizeMedium.Text)
        item1.SubItems.Add(txtPizzaSizeLarge.Text)

        'check boxes
        If chkExtraToppingDC.Checked = True Then
            item1.SubItems.Add("Yes")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")



        ElseIf chkExtraToppingRV.Checked = True Then

            item1.SubItems.Add("No")
            item1.SubItems.Add("Yes")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")


        ElseIf chkExtraToppingSS.Checked = True Then
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("Yes")
            item1.SubItems.Add("No")

        ElseIf chkExtraToppingNT.Checked = True Then
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("Yes")

        ElseIf chkExtraToppingNT.Checked = False And
                chkExtraToppingDC.Checked = False AndAlso
                chkExtraToppingRV.Checked = False AndAlso
                chkExtraToppingSS.Checked = False Then
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")


        End If

        'form6 list view1


        item1 = Form6.ListView1.Items.Add(txtOrderNumber.Text)
        item1.SubItems.Add(txtCustomerName.Text)
        item1.SubItems.Add(txtOrderDate.Text)
        item1.SubItems.Add(txtOrderTime.Text)
        item1.SubItems.Add(txtAttendantName.Text)
        item1.SubItems.Add(txtAdditionalComments.Text)


        item1.SubItems.Add(txtTotal.Text)
        item1.SubItems.Add(txtDiscount.Text)
        item1.SubItems.Add(txtCost.Text)
        item1.SubItems.Add(txtPizzaSizeSmall.Text)
        item1.SubItems.Add(txtPizzaSizeMedium.Text)
        item1.SubItems.Add(txtPizzaSizeLarge.Text)

        'check boxes
        If chkExtraToppingDC.Checked = True Then
            item1.SubItems.Add("Yes")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")



        ElseIf chkExtraToppingRV.Checked = True Then

            item1.SubItems.Add("No")
            item1.SubItems.Add("Yes")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")


        ElseIf chkExtraToppingSS.Checked = True Then
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("Yes")
            item1.SubItems.Add("No")

        ElseIf chkExtraToppingNT.Checked = True Then
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("Yes")

        ElseIf chkExtraToppingNT.Checked = False And
                chkExtraToppingDC.Checked = False AndAlso
                chkExtraToppingRV.Checked = False AndAlso
                chkExtraToppingSS.Checked = False Then
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")
            item1.SubItems.Add("No")


        End If



        'right hand bar
        txtAdditionalComments.Clear()

        'pizza size text box'
        txtPizzaSizeLarge.Clear()
        txtPizzaSizeMedium.Clear()
        txtPizzaSizeSmall.Clear()


        'Check boxes'
        ChkSizeSmall.Checked = False
        ChkSizeMedium.Checked = False
        ChkSizeLarge.Checked = False
        chkExtraToppingNT.Checked = False
        chkExtraToppingDC.Checked = False
        chkExtraToppingRV.Checked = False
        chkExtraToppingSS.Checked = False


        'textboxes for pizza size becoming locked again'
        txtPizzaSizeSmall.Enabled = False
        txtPizzaSizeMedium.Enabled = False
        txtPizzaSizeLarge.Enabled = False
    End Sub

    Private Sub morethanone(sender As Object, e As EventArgs) Handles MyBase.Click, chkExtraToppingSS.Click, chkExtraToppingRV.Click, chkExtraToppingNT.Click, chkExtraToppingDC.Click

        '#--------------------------------#no topping checkbox
        If chkExtraToppingNT.Checked = True Then
            chkExtraToppingDC.Checked = False
        End If

        If chkExtraToppingNT.Checked = True Then
            chkExtraToppingRV.Checked = False
        End If

        If chkExtraToppingNT.Checked = True Then
            chkExtraToppingSS.Checked = False
        End If
        '#--------------------------------#end of no topping checkbox

        If chkExtraToppingDC.Checked = True Then
            chkExtraToppingRV.Checked = False And
                chkExtraToppingSS.Checked = False And
                chkExtraToppingNT.Checked = False
        End If

        If chkExtraToppingRV.Checked = True Then
            chkExtraToppingSS.Checked = False And
                chkExtraToppingDC.Checked = False And
                chkExtraToppingNT.Checked = False
        End If

        If chkExtraToppingSS.Checked = True Then
            chkExtraToppingDC.Checked = False And
                chkExtraToppingRV.Checked = False And
                chkExtraToppingNT.Checked = False
        End If

    End Sub

    Private Sub ChkSizeMedium_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkSizeMedium.CheckedChanged

    End Sub

    Private Sub ChkSizeSmall_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkSizeSmall.CheckedChanged

    End Sub

    Private Sub prompt_To_Enter_Amount(sender As Object, e As EventArgs) Handles txtPizzaSizeSmall.Click, txtPizzaSizeMedium.Click, txtPizzaSizeLarge.Click, ChkSizeSmall.Click, ChkSizeMedium.Click, ChkSizeLarge.Click

    End Sub

    Private Sub only_numbers(sender As Object, e As KeyPressEventArgs) Handles txtPizzaSizeSmall.KeyPress, txtPizzaSizeMedium.KeyPress, txtPizzaSizeLarge.KeyPress, ChkSizeSmall.KeyPress, ChkSizeMedium.KeyPress, ChkSizeLarge.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Please enter a valid number", MessageBoxIcon.Warning, "Number Warning")
        End If
    End Sub

    Private Sub chkExtraToppingRV_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtraToppingRV.CheckedChanged

    End Sub

    Private Sub chkExtraToppingDC_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkExtraToppingDC.CheckedChanged

    End Sub

    Private Sub chkExtraToppingSS_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtraToppingSS.CheckedChanged

    End Sub

    Private Sub chkExtraToppingNT_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtraToppingNT.CheckedChanged

    End Sub

    Private Sub Display_Total(sender As Object, e As EventArgs) Handles txtTotal.TextChanged, txtPizzaSizeSmall.TextChanged, txtPizzaSizeMedium.TextChanged, txtPizzaSizeLarge.TextChanged, txtDiscount.TextChanged, txtCost.TextChanged, MyBase.TextChanged, ChkSizeSmall.TextChanged, ChkSizeMedium.TextChanged, ChkSizeLarge.TextChanged, chkExtraToppingSS.TextChanged, chkExtraToppingRV.TextChanged, chkExtraToppingNT.TextChanged, chkExtraToppingDC.TextChanged
        Dim num1, num2, num3, total1 As Integer

        num1 = Val(txtPizzaSizeSmall.Text)
        num2 = Val(txtPizzaSizeMedium.Text)
        num3 = Val(txtPizzaSizeLarge.Text)

        total1 = num1 + num2 + num3

        If total1 >= 15 Then
            MsgBox("This order needs verification
        Get the Manager", MessageBoxIcon.Warning)
            Me.Hide()
            Me.WindowState = WindowState.Minimized
            Form8.Show()

        End If



    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label13.Text = Form4.txtStaffName.Text
        txtAttendantName.Refresh()
        txtAttendantName.Text = Form4.txtStaffName.Text
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Label13.Text = Form4.txtStaffName.Text
        txtAttendantName.Refresh()
        txtAttendantName.Text = Form4.txtStaffName.Text
    End Sub

    Public Class GlobalVariables
        Public Shared item1 As ListViewItem
    End Class

    Private Sub btn_SaveData_Click(sender As Object, e As EventArgs)

        If ListView2.Items.Count = 0 Then


            'Dim item1 As ListViewItem


            GlobalVariables.item1 = ListView2.Items.Add(txtOrderNumber.Text)
            GlobalVariables.item1.SubItems.Add(txtCustomerName.Text)
            GlobalVariables.item1.SubItems.Add(txtOrderDate.Text)
            GlobalVariables.item1.SubItems.Add(txtOrderTime.Text)
            GlobalVariables.item1.SubItems.Add(txtAttendantName.Text)
            GlobalVariables.item1.SubItems.Add(txtAdditionalComments.Text)

            GlobalVariables.item1.SubItems.Add(txtTotal.Text)
            GlobalVariables.item1.SubItems.Add(txtDiscount.Text)
            GlobalVariables.item1.SubItems.Add(txtCost.Text)
            GlobalVariables.item1.SubItems.Add(txtPizzaSizeSmall.Text)
            GlobalVariables.item1.SubItems.Add(txtPizzaSizeMedium.Text)
            GlobalVariables.item1.SubItems.Add(txtPizzaSizeLarge.Text)

            'check boxes
            If chkExtraToppingDC.Checked = True Then
                GlobalVariables.item1.SubItems.Add("Yes")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")



            ElseIf chkExtraToppingRV.Checked = True Then

                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("Yes")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")


            ElseIf chkExtraToppingSS.Checked = True Then
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("Yes")
                GlobalVariables.item1.SubItems.Add("No")

            ElseIf chkExtraToppingNT.Checked = True Then
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("Yes")

            ElseIf chkExtraToppingNT.Checked = False And
                    chkExtraToppingDC.Checked = False AndAlso
                    chkExtraToppingRV.Checked = False AndAlso
                    chkExtraToppingSS.Checked = False Then
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")
                GlobalVariables.item1.SubItems.Add("No")


            End If

            GlobalVariables.item1 = Nothing

        Else
            With ListView2
                Dim Checker As ListViewItem
                'Dim i As DialogResult
                orderNumber = Val(txtOrderNumber.Text)
                'Dim num1 As Integer
                Checker = .FindItemWithText(txtOrderNumber.Text, True, 0, True)
                If Not Checker Is Nothing Then


                    If MsgBox("The Order Number: " & txtOrderNumber.Text & " has already been served. 
 Would you like to generate a new Order Number?", MsgBoxStyle.YesNo Or MessageBoxIcon.Warning, "Verify Order Number") = DialogResult.Yes Then
                        txtOrderNumber.Clear()
                        txtOrderNumber.Text = CInt(Int((13200 * Rnd() + 1)))
                        MsgBox("A new order number has been generated", MessageBoxIcon.Information, "New order number notifier")

                        'If (i = DialogResult.No) Then
                        '   txtOrderNumber.Clear()
                        '  txtOrderNumber.Text = CInt(Int((13200 * Rnd() + 1)))
                        ' MsgBox("A new order number has been generated", "New order number notifier", MessageBoxIcon.Information)
                    End If

                Else 'Dim item1 As ListViewItem

                    GlobalVariables.item1 = ListView2.Items.Add(txtOrderNumber.Text)
                    GlobalVariables.item1.SubItems.Add(txtCustomerName.Text)
                    GlobalVariables.item1.SubItems.Add(txtOrderDate.Text)
                    GlobalVariables.item1.SubItems.Add(txtOrderTime.Text)
                    GlobalVariables.item1.SubItems.Add(txtAttendantName.Text)
                    GlobalVariables.item1.SubItems.Add(txtAdditionalComments.Text)

                    GlobalVariables.item1.SubItems.Add(txtTotal.Text)
                    GlobalVariables.item1.SubItems.Add(txtDiscount.Text)
                    GlobalVariables.item1.SubItems.Add(txtCost.Text)
                    GlobalVariables.item1.SubItems.Add(txtPizzaSizeSmall.Text)
                    GlobalVariables.item1.SubItems.Add(txtPizzaSizeMedium.Text)
                    GlobalVariables.item1.SubItems.Add(txtPizzaSizeLarge.Text)

                    'check boxes
                    If chkExtraToppingDC.Checked = True Then
                        GlobalVariables.item1.SubItems.Add("Yes")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")



                    ElseIf chkExtraToppingRV.Checked = True Then

                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("Yes")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")


                    ElseIf chkExtraToppingSS.Checked = True Then
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("Yes")
                        GlobalVariables.item1.SubItems.Add("No")

                    ElseIf chkExtraToppingNT.Checked = True Then
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("Yes")

                    ElseIf chkExtraToppingNT.Checked = False And
                            chkExtraToppingDC.Checked = False AndAlso
                            chkExtraToppingRV.Checked = False AndAlso
                            chkExtraToppingSS.Checked = False Then
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")
                        GlobalVariables.item1.SubItems.Add("No")


                    End If

                    GlobalVariables.item1 = Nothing

                End If
            End With


        End If


        'for manager's account
        For Each item1 As ListViewItem In ListView2.Items
            Form6.ListView1.Items.Add(item1.Clone)
        Next

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = TabPage3

        'message
        TxtReceipt.AppendText(vbTab + vbTab & "     Thanks for Shoppping With Us")
        TxtReceipt.AppendText(vbTab + vbTab + vbTab & "===========================================================" + vbNewLine)
        TxtReceipt.AppendText(" " + vbNewLine)

        'details
        TxtReceipt.AppendText("Name: " + vbTab + txtCustomerName.Text + vbTab + "Order No: " & txtOrderNumber.Text + vbNewLine)
        TxtReceipt.AppendText(vbNewLine + "Order Date: " + vbTab & txtOrderDate.Text + vbTab + "Order Time: " + vbTab & txtOrderTime.Text + vbNewLine)

        'purchased items
        TxtReceipt.AppendText(vbNewLine + "Item Type" + vbTab + vbTab + "Qty" + vbTab + vbTab & "Unit Price" + vbTab + vbTab & "Sub-Total " + vbNewLine)
        TxtReceipt.AppendText(vbNewLine + "Small Pizza" + vbTab & txtPizzaSizeSmall.Text + vbTab + vbTab & "£6")
        TxtReceipt.AppendText(vbNewLine + "Medium Pizza" + vbTab & txtPizzaSizeMedium.Text + vbTab + vbTab & "£8")
        TxtReceipt.AppendText(vbNewLine + "large Pizza" + vbTab & txtPizzaSizeLarge.Text + vbTab + vbTab & "£10" + vbNewLine)

        'total, discounts, toppings and costs after discount
        TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Cost of Topping: " + vbTab & "£1.50")
        TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Total of Order: " + vbTab & txtTotal.Text)
        TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Discount on Order: " + vbTab & txtDiscount.Text)
        TxtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab + vbTab & "Cost of Order: " + vbTab & txtCost.Text)

        'bottom Message
        TxtReceipt.AppendText(vbTab + vbTab + vbTab & "===========================================================" + vbNewLine)
        TxtReceipt.AppendText(vbTab + vbTab + "        Your Shopping Receipt")
    End Sub

    Private Sub TxtReceipt_TextChanged(sender As Object, e As EventArgs) Handles TxtReceipt.TextChanged

    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
End Class