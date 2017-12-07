<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_bill))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_recive = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_refund = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รวมทั้งสิ้น"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Black
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Lime
        Me.txt_total.Location = New System.Drawing.Point(396, 140)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(509, 75)
        Me.txt_total.TabIndex = 1
        '
        'txt_recive
        '
        Me.txt_recive.BackColor = System.Drawing.Color.Black
        Me.txt_recive.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recive.ForeColor = System.Drawing.Color.Lime
        Me.txt_recive.Location = New System.Drawing.Point(396, 296)
        Me.txt_recive.Name = "txt_recive"
        Me.txt_recive.Size = New System.Drawing.Size(509, 75)
        Me.txt_recive.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 69)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "รับมา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 69)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "เงินทอน"
        '
        'txt_refund
        '
        Me.txt_refund.BackColor = System.Drawing.Color.Black
        Me.txt_refund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refund.ForeColor = System.Drawing.Color.Red
        Me.txt_refund.Location = New System.Drawing.Point(396, 441)
        Me.txt_refund.Name = "txt_refund"
        Me.txt_refund.ReadOnly = True
        Me.txt_refund.Size = New System.Drawing.Size(509, 75)
        Me.txt_refund.TabIndex = 5
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(191, 635)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(287, 88)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "ยืนยัน"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(585, 635)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(287, 88)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "ปิด"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frm_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 832)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_refund)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_recive)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "คิดเงิน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_recive As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_refund As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
