Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form_managecoffee
    Public Sub clear_form()
        txt_add_id.Text = ""
        txt_add_name.Text = ""
        txt_add_hot.Text = ""
        txt_add_cool.Text = ""
        txt_add_spin.Text = ""
    End Sub
    Public Sub refresh_coffee()
        sql = "select * from coffee"
        datagrid_coffee.DataSource = cmd_excuteToDataTable()
    End Sub

    Private Sub btn_add_new_Click(sender As Object, e As EventArgs) Handles btn_add_new.Click

        If txt_add_id.Text = "" Or txt_add_name.Text = "" Or txt_add_hot.Text = "" Or txt_add_hot.Text = "" Or txt_add_cool.Text = "" Or txt_add_spin.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return

        End If

        If Not IsNumeric(txt_add_hot.Text) Or Not IsNumeric(txt_add_cool.Text) Or Not IsNumeric(txt_add_spin.Text) Then
            MsgBox("กรุณากรอกราคาเป็นตัวเลขเท่านั้น")
            Return
        End If

        sql = "insert into coffee (coffee_id ,coffee_name, coffee_hot, coffee_cool, coffee_spin) values(@coffee_id, @coffee_name, @coffee_hot, @coffee_cool,@coffee_spin)"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@coffee_id", txt_add_id.Text)
        cmd.Parameters.AddWithValue("@coffee_name", txt_add_name.Text)
        cmd.Parameters.AddWithValue("@coffee_hot", txt_add_hot.Text)
        cmd.Parameters.AddWithValue("@coffee_cool", txt_add_cool.Text)
        cmd.Parameters.AddWithValue("@coffee_spin", txt_add_spin.Text)





        If cmd.ExecuteNonQuery() = 0 Then

            MsgBox("ล้มเหลว")
        Else
            MsgBox("สำเร็จ")
            refresh_coffee()
            clear_form()
        End If


    End Sub



    Private Sub Form_managecoffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        sql = "select coffee_id,coffee_name from coffee where coffee_id like '%" & txt_search.Text & "%' or coffee_name like '%" & txt_search.Text & "%'"
        datagrid_coffee.DataSource = cmd_excuteToDataTable()
    End Sub

    Private Sub datagrid_coffee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_coffee.CellClick
        Dim select_row As Integer = datagrid_coffee.CurrentRow.Index
        Dim coffee_id As String = datagrid_coffee.Item(0, select_row).Value
        sql = "select * from coffee where coffee_id='" & coffee_id & "'"
        Dim data_keep As DataTable = cmd_excuteToDataTable()
        edit_id.Text = data_keep.Rows(0)("coffee_id")
        edit_name.Text = data_keep.Rows(0)("coffee_name")
        edit_hot.Text = data_keep.Rows(0)("coffee_hot")
        edit_cool.Text = data_keep.Rows(0)("coffee_cool")
        edit_spin.Text = data_keep.Rows(0)("coffee_spin")
    End Sub

    Private Sub btn_save_edit_Click(sender As Object, e As EventArgs) Handles btn_save_edit.Click


        If Not IsNumeric(edit_hot.Text) Or Not IsNumeric(edit_cool.Text) Or Not IsNumeric(edit_spin.Text) Then
            MsgBox("กรุณากรอกราคาเป็นตัวเลขเท่านั้น")
            Return
        End If

        sql = "update coffee set coffee_name=@name, coffee_hot=@hot, coffee_cool=@cool, coffee_spin=@spin where coffee_id=@id"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", edit_id.Text)
        cmd.Parameters.AddWithValue("name", edit_name.Text)
        cmd.Parameters.AddWithValue("hot", edit_hot.Text)
        cmd.Parameters.AddWithValue("cool", edit_cool.Text)
        cmd.Parameters.AddWithValue("spin", edit_spin.Text)

        If cmd.ExecuteNonQuery() = 0 Then
            MsgBox("แก้ไขล้มเหลว")
        Else
            MsgBox("แกไขสำเร็จ")
            refresh_coffee()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_confrim.Text <> "ยืนยันการลบ" Then
            MsgBox("กรุณาพิมพ์ คำว่า ยืนยันการลบ ในช่องว่างอีกครั้ง")
            txt_confrim.Text = ""
            txt_confrim.Select()
            Return
        End If

        Dim select_row As Integer = datagrid_coffee.CurrentRow.Index
        Dim coffee_id As String = datagrid_coffee.Item(0, select_row).Value

        sql = "delete from coffee where coffee_id='" & coffee_id & "'"
        If cmd_excuteNonquery() = 0 Then
            MsgBox("ลบไม่สำเร็จ")
        Else
            MsgBox("ลบสำเร็จ")
            refresh_coffee()
            txt_confrim.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txt_confrim_TextChanged(sender As Object, e As EventArgs) Handles txt_confrim.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class