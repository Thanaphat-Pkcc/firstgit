Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frm_stock

    Public Sub product_alert()
        sql = "select * from stock_table where product_qty < 5"
        cmd = New SqlCommand(sql, cn)
        dgv_low.DataSource = cmd_excuteToDataTable()
    End Sub
    Public Sub re_stock()
        sql = "select * from stock_table"
        dgv_stock.DataSource = cmd_excuteToDataTable()
    End Sub
    Private Sub frm_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        re_stock()
        product_alert()


    End Sub



    Private Sub dgv_stock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_stock.CellClick
        Dim i As Integer = dgv_stock.CurrentRow.Index
        Dim qty As Integer = dgv_stock.Item(2, i).Value

        num_exit.Maximum = qty
        Dim select_row As Integer = dgv_stock.CurrentRow.Index
        Dim product_id As String = dgv_stock.Item(0, select_row).Value
        sql = "select * from stock_table where product_id='" & product_id & "'"
        Dim data_keep As DataTable = cmd_excuteToDataTable()
        edit_id.Text = data_keep.Rows(0)("product_id")
        edit_name.Text = data_keep.Rows(0)("product_name")
        edit_cost.Text = data_keep.Rows(0)("product_qty")
    End Sub

    Private Sub btn_cutoff_Click(sender As Object, e As EventArgs) Handles btn_cutoff.Click

        Dim product_qty As Integer = dgv_stock.Item(2, dgv_stock.CurrentRow.Index).Value

        product_qty = product_qty - num_exit.Value
        Dim product_id As String = dgv_stock.Item(0, dgv_stock.CurrentRow.Index).Value
        sql = "update stock_table set product_qty=@product_qty WHERE product_id=@product_id"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@product_id", product_id)
        cmd.Parameters.AddWithValue("@product_qty", product_qty)



        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("บันทึกไม่สำเร็จ")
        Else
            MsgBox("บันทึกสำเร็จ")
            re_stock()
            product_alert()
            num_exit.Value = 0
        End If
    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click

        Dim product_qty As Integer = dgv_stock.Item(2, dgv_stock.CurrentRow.Index).Value
        product_qty = product_qty + num_enter.Value
        Dim product_id As String = dgv_stock.Item(0, dgv_stock.CurrentRow.Index).Value
        sql = "update stock_table set product_qty=@product_qty WHERE product_id=@product_id"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@product_id", product_id)
        cmd.Parameters.AddWithValue("@product_qty", product_qty)



        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("บันทึกไม่สำเร็จ")
        Else
            MsgBox("บันทึกสำเร็จ")
            re_stock()
            product_alert()
            num_enter.Value = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_new_Click(sender As Object, e As EventArgs) Handles btn_add_new.Click
        If txt_add_id.Text = "" Or txt_add_name.Text = "" Or txt_add_cost.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return

        End If

        If Not IsNumeric(txt_add_cost.Text) Then
            MsgBox("กรุณากรอกราคาเป็นตัวเลขเท่านั้น")
            Return
        End If

        sql = "insert into stock_table (product_id ,product_name, product_cost,product_qty) values(@product_id, @product_name, @product_cost,@product_qty)"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@product_id", txt_add_id.Text)
        cmd.Parameters.AddWithValue("@product_name", txt_add_name.Text)
        cmd.Parameters.AddWithValue("@product_cost", txt_add_cost.Text)
        cmd.Parameters.AddWithValue("@product_qty", txt_add_qty.Text)






        If cmd.ExecuteNonQuery() = 0 Then

            MsgBox("ล้มเหลว")
        Else
            MsgBox("สำเร็จ")
            re_stock()
            clear_txt()

        End If
    End Sub
    Public Sub clear_txt()
        txt_add_cost.Text = ""
        txt_add_id.Text = ""
        txt_add_name.Text = ""
        txt_add_qty.Text = ""
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_confrim.Text <> "ยืนยันการลบ" Then
            MsgBox("กรุณาพิมพ์ คำว่า ยืนยันการลบ ในช่องว่างอีกครั้ง")
            txt_confrim.Text = ""
            txt_confrim.Select()
            Return
        End If

        Dim select_row As Integer = dgv_stock.CurrentRow.Index
        Dim product_id As String = dgv_stock.Item(0, select_row).Value

        sql = "delete from stock_table where product_id='" & product_id & "'"
        If cmd_excuteNonquery() = 0 Then
            MsgBox("ลบไม่สำเร็จ")
        Else
            MsgBox("ลบสำเร็จ")
            re_stock()
            txt_confrim.Text = ""
        End If
    End Sub

    Private Sub btn_save_edit_Click(sender As Object, e As EventArgs) Handles btn_save_edit.Click
        If edit_name.Text = "" Or edit_cost.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return

        End If

        If Not IsNumeric(edit_cost.Text) Then
            MsgBox("กรุณากรอกราคาเป็นตัวเลขเท่านั้น")
            Return
        End If

        sql = "update stock_table set product_name=@name, product_cost=@cost where product_id=@id"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", edit_id.Text)
        cmd.Parameters.AddWithValue("name", edit_name.Text)
        cmd.Parameters.AddWithValue("cost", edit_cost.Text)


        If cmd.ExecuteNonQuery() = 0 Then
            MsgBox("แก้ไขล้มเหลว")
        Else
            MsgBox("แกไขสำเร็จ")
            re_stock()
            clear_txt()
        End If
    End Sub


End Class