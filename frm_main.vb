Public Class frm_main


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If confirm("ต้องการออกจากโปรแกรมหรือไม่") = vbYes Then

            Me.Close()
            End

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Form_managecoffee.Show()

    End Sub


    Private Sub sale_Click(sender As Object, e As EventArgs) Handles sale.Click
        frm_sale.Show()


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frm_report.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frm_stock.Show()
    End Sub
End Class
