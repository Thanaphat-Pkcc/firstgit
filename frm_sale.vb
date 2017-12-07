Public Class frm_sale
    Public Sub get_date()
        lbl_sale_date.Text = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
    End Sub
    Public Sub set_sale_id()
        Try
            sql = "select max(count) from sale_detail_table"
            Dim i As Integer = cmd_excuteScalar() + 1
            lbl_sale_id.Text = "ABC-" & Date.Now.Year & "/" & i.ToString.PadLeft(5, "0")
        Catch ex As Exception
            lbl_sale_id.Text = "ABC-" & Date.Now.Year & "/00001"
        End Try
    End Sub
    Private Sub frm_sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
        set_sale_id()
        get_date()

    End Sub

    Public Sub total_price()
        txt_total.Text = Sum_Column_Currency(listview_sale, 6)
    End Sub

    Public Sub refresh_coffee()
        sql = "select coffee_id,coffee_name from coffee"
        Dim data_table As DataTable = cmd_excuteToDataTable()
        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.defualt_cooffee, "coffee_id", "coffee_name")
    End Sub

    Public Sub search_coffee()
        sql = "select coffee_id,coffee_name from coffee where coffee_id like '%" & txt_search.Text & "%' or coffee_name like '%" & txt_search.Text & "%'"
        Dim data_table As DataTable = cmd_excuteToDataTable()
        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.defualt_cooffee, "coffee_id", "coffee_name")
    End Sub


    Private Sub listview_coffee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_coffee.SelectedIndexChanged
        Dim select_coffee As String = listview_coffee.FocusedItem.Text
        Dim coffee_split() As String = select_coffee.Split("|")
        coffee_split(0) = coffee_split(0).ToString.Trim

        sql = "select * from coffee where coffee_id= '" & coffee_split(0) & "'"
        Dim data_table As DataTable = cmd_excuteToDataTable()
        Dim id As String
        Dim name As String
        Dim hot As Integer
        Dim cool As Integer
        Dim spin As Integer

        id = data_table.Rows(0)("coffee_id")
        name = data_table.Rows(0)("coffee_name")
        hot = data_table.Rows(0)("coffee_hot")
        cool = data_table.Rows(0)("coffee_cool")
        spin = data_table.Rows(0)("coffee_spin")



        With frm_sale_price
            .lbl_id.Text = id
            .lbl_name.Text = name
            .lbl_hot.Text = hot
            .lbl_cool.Text = cool
            .lbl_spin.Text = spin
        End With

        frm_sale_price.TopMost = True
        frm_sale_price.Show()
        frm_sale_price.txt_qty.Text = ""


    End Sub



    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If confirm("ต้องการลบรายการหรือไม่ ?") = vbYes Then
            listview_sale.Items.Clear()
            txt_total.Text = "0.00"
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        search_coffee()
    End Sub

    Private Sub btm_money_Click(sender As Object, e As EventArgs) Handles btm_money.Click
        With frm_bill

            .txt_total.Text = txt_total.Text
            .txt_recive.Text = ""
            .txt_refund.Text = ""
            .Show()
            .Activate()


        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class