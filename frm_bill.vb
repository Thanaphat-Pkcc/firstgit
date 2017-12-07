Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_bill
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub txt_recive_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_recive.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not IsNumeric(txt_recive.Text) Then
                MsgBox("กรอกเป็นตัวเลขเท่านั้น")
                txt_recive.Text = ""
                txt_recive.Select()
                Return

            End If

            If Val(txt_recive.Text) < Val(txt_total.Text) Then
                MsgBox("เงินรับมาน้อยกว่าเงินที่ต้องชำระ")
                txt_recive.Text = ""
                txt_recive.Select()
                Return
            End If

            Dim total As Double = txt_total.Text
            Dim recive As Double = txt_recive.Text
            Dim refund As Double = recive - total
            txt_refund.Text = refund
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        Dim date_sale As String = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
        sql = "insert into sale_detail_table(sale_full_id, sale_total_bill,sale_date) values(@sale_full_id,@sale_total_bill,@sale_date)"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("sale_full_id", frm_sale.lbl_sale_id.Text)
        cmd.Parameters.AddWithValue("sale_total_bill", txt_total.Text)
        cmd.Parameters.AddWithValue("sale_date", date_sale)
        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("ไม่สามารถบันทึกได้")
        Else
            MsgBox("บันทึกสำเร็จ")

            Dim i As Integer = frm_sale.listview_sale.Items.Count - 1
        For j As Integer = 0 To i
            Dim coffee_id As String = frm_sale.listview_sale.Items(j).SubItems(1).Text
            Dim coffee_qty As Integer = frm_sale.listview_sale.Items(j).SubItems(4).Text
            Dim coffee_total As Integer = frm_sale.listview_sale.Items(j).SubItems(6).Text
            'Dim date_sale As String = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day
            sql = "insert into sale_table( sale_full_id,coffee_id, coffee_qty, coffee_total) values( @sale_full_id,@coffee_id, @coffee_qty, @coffee_total)"
            'sql = "insert into sale_table( sale_full_id,coffee_id, coffee_qty, coffee_total,date_sale) values( @sale_full_id,@coffee_id, @coffee_qty, @coffee_total, @date_sale)"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("sale_full_id", frm_sale.lbl_sale_id.Text)
            cmd.Parameters.AddWithValue("coffee_id", coffee_id)
            cmd.Parameters.AddWithValue("coffee_qty", coffee_qty)
            cmd.Parameters.AddWithValue("coffee_total", coffee_total)
            cmd.ExecuteNonQuery()
        Next

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            Me.Close()
            With frm_sale
                .listview_sale.Items.Clear()
                .txt_total.Text = "0.00"
                .get_date()
                .set_sale_id()
                .Show()
            End With
        End If




    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'กำหนดระยะห่างแนวแกน X
        Dim col(8) As Integer
        col(1) = 10
        col(2) = 100
        col(3) = 190
        col(4) = 320
        col(5) = 420
        col(6) = 520
        col(7) = 620

        Dim font As New Font("Crodia New", 16)
        Dim font_head As New Font("Crodia New", 24)
        'กำหนดระยะห่างแนวแกน Y
        Dim line As Integer = 150
        e.Graphics.DrawString("ร้านกาแฟ ดร.อัคเดช คาเฟ่", font_head, Brushes.Red, col(1), 30)
        'สี , x1,y1 ถึง x2,y2
        e.Graphics.DrawLine(Pens.Black, col(1), 80, col(6) + 200, 80)
        e.Graphics.DrawString("เลขที่บิล   " & frm_sale.lbl_sale_id.Text & "    วันที่" & frm_sale.lbl_sale_date.Text & "", font, Brushes.Black, col(1), 100)
        'ข้อมูลที่จะพิม , font , สี , ตำแหน่ง
        e.Graphics.DrawString("ลำดับ", font, Brushes.Black, col(1), line)
        e.Graphics.DrawString("รหัส", font, Brushes.Black, col(2), line)
        e.Graphics.DrawString("รายการ", font, Brushes.Black, col(3), line)
        e.Graphics.DrawString("หน่วย", font, Brushes.Black, col(4), line)
        e.Graphics.DrawString("จำนวน", font, Brushes.Black, col(5), line)
        e.Graphics.DrawString("ราคา", font, Brushes.Black, col(6), line)
        e.Graphics.DrawString("ราคารวม", font, Brushes.Black, col(7), line)

        For i As Integer = 0 To frm_sale.listview_sale.Items.Count - 1
            line = line + 50
            Dim print(8) As String
            With frm_sale.listview_sale
                print(1) = .Items(i).SubItems(0).Text
                print(2) = .Items(i).SubItems(1).Text
                print(3) = .Items(i).SubItems(2).Text
                print(4) = .Items(i).SubItems(3).Text
                print(5) = .Items(i).SubItems(4).Text
                print(6) = .Items(i).SubItems(5).Text
                print(7) = .Items(i).SubItems(6).Text

            End With

            e.Graphics.DrawString(print(1), font, Brushes.Black, col(1), line)
            e.Graphics.DrawString(print(2), font, Brushes.Black, col(2), line)
            e.Graphics.DrawString(print(3), font, Brushes.Black, col(3), line)
            e.Graphics.DrawString(print(4), font, Brushes.Black, col(4), line)
            e.Graphics.DrawString(print(5), font, Brushes.Black, col(5), line)
            e.Graphics.DrawString(print(6), font, Brushes.Black, col(6), line)
            e.Graphics.DrawString(print(7), font, Brushes.Black, col(7), line)

        Next

        line = line + 80
        e.Graphics.DrawString("ราคารวม  " & frm_sale.txt_total.Text & " บาท", font, Brushes.Black, col(1), line)
        e.Graphics.DrawString("รับเงินมา  " & txt_recive.Text & " บาท", font, Brushes.Black, col(1), line + 40)
        e.Graphics.DrawString("เงินทอน   " & txt_refund.Text & " บาท", font, Brushes.Black, col(1), line + 80)

    End Sub

    Private Sub frm_bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()
    End Sub
End Class