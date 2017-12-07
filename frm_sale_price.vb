Public Class frm_sale_price
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_hot.CheckedChanged
        txt_qty.Select()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_cool.CheckedChanged
        txt_qty.Select()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_spin.CheckedChanged
        txt_qty.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_qty.Text = "" Or Not IsNumeric(txt_qty.Text) Then
            MsgBox("กรุณากรอกตัวเลข")
            Return
        End If

        Dim array_item(7) As String
        With frm_sale
            array_item(0) = .listview_sale.Items.Count + 1
            array_item(1) = lbl_id.Text
            array_item(2) = lbl_name.Text
            array_item(3) = "แก้ว"
            array_item(4) = txt_qty.Text

            Dim price As Integer = 0
            If rdb_hot.Checked = True Then
                price = lbl_hot.Text
            ElseIf rdb_cool.Checked = True Then
                price = lbl_cool.Text
            ElseIf rdb_spin.Checked = True Then
                price = lbl_spin.Text

            End If

            array_item(5) = price
            array_item(6) = array_item(4) * array_item(5)


        End With
        Dim itm As New ListViewItem(array_item)
        frm_sale.listview_sale.Items.Add(itm)
        Me.Hide()
        frm_sale.total_price()
    End Sub




End Class