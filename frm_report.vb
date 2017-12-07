Public Class frm_report

    Public Sub re_datagrid()
        ' sql = "select sale_table.sale_full_id, sale_detail_table.sale_date, sale_table.coffee_id, sale_table.coffee_qty,sale_table.coffee_total from sale_table,sale_detail_table where sale_table.sale_full_id = sale_detail_table.sale_full_id"
        sql = "select sale_table.sale_full_id, sale_detail_table.sale_date, sale_table.coffee_id, coffee.coffee_name,sale_table.coffee_qty,sale_table.coffee_total from coffee,sale_table,sale_detail_table where sale_table.sale_full_id = sale_detail_table.sale_full_id AND sale_table.coffee_id = coffee.coffee_id"
        dgv_report.DataSource = cmd_excuteToDataTable()
        sql = "select * from sale_detail_table "
        datagrid_report.DataSource = cmd_excuteToDataTable()
    End Sub

    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        re_datagrid()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        'sql = String.Format("select sale_full_id, date_sale, coffee_id, coffee_qty, coffee_total from sale_table where sale_full_id like '%" & txt_search.Text & "%' or date_sale like '%" & txt_search.Text & "%'")
        sql = String.Format("select sale_table.sale_full_id, sale_detail_table.sale_date, sale_table.coffee_id,coffee.coffee_name, sale_table.coffee_qty, sale_table.coffee_total 
                from sale_table, sale_detail_table ,coffee
                where         
                sale_table.sale_full_id like '%" & txt_search.Text & "%' AND sale_table.sale_full_id = sale_detail_table.sale_full_id
                AND sale_table.coffee_id = coffee.coffee_id
                or sale_detail_table.sale_date like '%" & txt_search.Text & "%' AND sale_table.sale_full_id = sale_detail_table.sale_full_id
                AND sale_table.coffee_id = coffee.coffee_id")

        dgv_report.DataSource = cmd_excuteToDataTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        sql = String.Format("select * from  sale_detail_table where  sale_full_id like '%" & TextBox1.Text & "%' or sale_date like '%" & TextBox1.Text & "%'")
        datagrid_report.DataSource = cmd_excuteToDataTable()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim col(8) As Integer
        col(1) = 10
        col(2) = 200
        col(3) = 350
        col(4) = 450
        col(5) = 550
        col(6) = 650
        'Dim coffee_id As String = datagrid_report.Item(0, 0).Value


        Dim font As New Font("Crodia New", 16)
        Dim font_head As New Font("Crodia New", 24)
        'กำหนดระยะห่างแนวแกน Y
        Dim line As Integer = 150
        e.Graphics.DrawString("รายงาน รายการขายกาแฟ", font_head, Brushes.Red, col(1), 30)
        'สี , x1,y1 ถึง x2,y2

        Dim date_report As String = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year


        e.Graphics.DrawLine(Pens.Black, 0, 80, col(6) + 200, 80)
        e.Graphics.DrawString("วันที่  " & date_report & "", font, Brushes.Black, col(1), 100)
        'ข้อมูลที่จะพิม , font , สี , ตำแหน่ง
        e.Graphics.DrawString("รหัสใบเสร็จ", font, Brushes.Black, col(1), line)
        e.Graphics.DrawString("วันที่", font, Brushes.Black, col(2), line)
        e.Graphics.DrawString("รหัสกาแฟ", font, Brushes.Black, col(3), line)
        e.Graphics.DrawString("ชื่อกาแฟ", font, Brushes.Black, col(4), line)
        e.Graphics.DrawString("จำนวน", font, Brushes.Black, col(5), line)
        e.Graphics.DrawString("ราคารวม", font, Brushes.Black, col(6), line)

        If txt_search.Text = "" Then
            sql = String.Format("select sale_table.sale_full_id, sale_detail_table.sale_date, sale_table.coffee_id,coffee.coffee_name, sale_table.coffee_qty, sale_table.coffee_total 
                from sale_table, sale_detail_table ,coffee
                where  sale_table.sale_full_id = sale_detail_table.sale_full_id AND sale_table.coffee_id = coffee.coffee_id")
        Else
            sql = String.Format("select sale_table.sale_full_id, sale_detail_table.sale_date, sale_table.coffee_id,coffee.coffee_name, sale_table.coffee_qty, sale_table.coffee_total 
                from sale_table, sale_detail_table ,coffee
                where  
                sale_table.sale_full_id like '%" & txt_search.Text & "%' AND sale_table.sale_full_id = sale_detail_table.sale_full_id    
                or sale_detail_table.sale_date like '%" & txt_search.Text & "%' AND sale_table.sale_full_id = sale_detail_table.sale_full_id
                AND sale_table.coffee_id = coffee.coffee_id")
        End If
        Dim data_keep As DataTable = cmd_excuteToDataTable()
        Dim count As Integer
        If txt_search.Text = "" Then
            sql = String.Format("select count(*) 
                from sale_table, sale_detail_table ,coffee
                where  sale_table.sale_full_id = sale_detail_table.sale_full_id AND sale_table.coffee_id = coffee.coffee_id")
            count = cmd_excuteScalar()

        Else
            sql = String.Format("select count(*) 
                from sale_table, sale_detail_table ,coffee
                where  
                sale_table.sale_full_id like '%" & txt_search.Text & "%' AND sale_table.sale_full_id = sale_detail_table.sale_full_id    
                or sale_detail_table.sale_date like '%" & txt_search.Text & "%' AND sale_table.sale_full_id = sale_detail_table.sale_full_id
                AND sale_table.coffee_id = coffee.coffee_id")
            count = cmd_excuteScalar()
        End If

        Dim print(8) As String
        For i As Integer = 0 To count - 1
            line = line + 50
            print(1) = data_keep.Rows(i)("sale_full_id")
            print(2) = data_keep.Rows(i)("sale_date")
            print(3) = data_keep.Rows(i)("coffee_id")
            print(4) = data_keep.Rows(i)("coffee_name")
            print(5) = data_keep.Rows(i)("coffee_qty")
            print(6) = data_keep.Rows(i)("coffee_total")

            e.Graphics.DrawString(print(1), font, Brushes.Black, col(1), line)
            e.Graphics.DrawString(print(2), font, Brushes.Black, col(2), line)
            e.Graphics.DrawString(print(3), font, Brushes.Black, col(3), line)
            e.Graphics.DrawString(print(4), font, Brushes.Black, col(4), line)
            e.Graphics.DrawString(print(5), font, Brushes.Black, col(5) + 20, line)
            e.Graphics.DrawString(print(6), font, Brushes.Black, col(6), line)

        Next



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.ShowDialog()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim col(3) As Integer
        col(1) = 10
        col(2) = 200
        col(3) = 350




        Dim font As New Font("Crodia New", 16)
        Dim font_head As New Font("Crodia New", 24)
        'กำหนดระยะห่างแนวแกน Y
        Dim line As Integer = 150
        e.Graphics.DrawString("รายงาน ยอดอรวมการขายกาแฟ", font_head, Brushes.Red, col(1), 30)
        'สี , x1,y1 ถึง x2,y2
        Dim date_report As String = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year


        e.Graphics.DrawLine(Pens.Black, 0, 70, 900, 70)
        e.Graphics.DrawString("วันที่  " & date_report & "", font, Brushes.Black, col(1), 100)
        'ข้อมูลที่จะพิม , font , สี , ตำแหน่ง
        e.Graphics.DrawString("รหัสใบเสร็จ", font, Brushes.Black, col(1), line)
        e.Graphics.DrawString("วันที่", font, Brushes.Black, col(2), line)
        e.Graphics.DrawString("ราคาบิลรวม", font, Brushes.Black, col(3), line)

        If TextBox1.Text = "" Then
            sql = "select sale_full_id , sale_date , sale_total_bill from  sale_detail_table"
        Else
            sql = String.Format("select sale_full_id , sale_date , sale_total_bill from  sale_detail_table where  sale_full_id like '%" & TextBox1.Text & "%' or sale_date like '%" & TextBox1.Text & "%'")
        End If
        Dim data_keep As DataTable = cmd_excuteToDataTable()
        Dim count As Integer
        If TextBox1.Text = "" Then
            sql = "select count(*) from sale_detail_table "
            count = cmd_excuteScalar()

        Else
            sql = String.Format("select count(*) from  sale_detail_table where  sale_full_id like '%" & TextBox1.Text & "%' or sale_date like '%" & TextBox1.Text & "%'")
            count = cmd_excuteScalar()
        End If


        Dim print(4) As String
        For i As Integer = 0 To count - 1
            line = line + 50
            print(1) = data_keep.Rows(i)("sale_full_id")
            print(2) = data_keep.Rows(i)("sale_date")
            print(3) = data_keep.Rows(i)("sale_total_bill")


            e.Graphics.DrawString(print(1), font, Brushes.Black, col(1), line)
            e.Graphics.DrawString(print(2), font, Brushes.Black, col(2), line)
            e.Graphics.DrawString(print(3), font, Brushes.Black, col(3), line)

        Next




    End Sub
End Class