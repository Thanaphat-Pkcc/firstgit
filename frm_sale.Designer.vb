<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sale))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.listview_coffee = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.listview_sale = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btm_money = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_sale_date = New System.Windows.Forms.Label()
        Me.lbl_sale_id = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.da = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.listview_coffee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1283, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 1103)
        Me.Panel1.TabIndex = 0
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(-123, 253)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(85, 36)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "ปั่น"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 156)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ค้นหา"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(228, 61)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(571, 38)
        Me.txt_search.TabIndex = 0
        '
        'listview_coffee
        '
        Me.listview_coffee.LargeImageList = Me.ImageList1
        Me.listview_coffee.Location = New System.Drawing.Point(35, 266)
        Me.listview_coffee.Name = "listview_coffee"
        Me.listview_coffee.Size = New System.Drawing.Size(900, 701)
        Me.listview_coffee.TabIndex = 0
        Me.listview_coffee.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "coffee icon.jpg")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_total)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1283, 190)
        Me.Panel3.TabIndex = 1
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Black
        Me.txt_total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Lime
        Me.txt_total.Location = New System.Drawing.Point(0, 0)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(1283, 189)
        Me.txt_total.TabIndex = 0
        Me.txt_total.Text = "0.00"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'listview_sale
        '
        Me.listview_sale.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.listview_sale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listview_sale.GridLines = True
        Me.listview_sale.Location = New System.Drawing.Point(0, 325)
        Me.listview_sale.Name = "listview_sale"
        Me.listview_sale.Size = New System.Drawing.Size(1283, 690)
        Me.listview_sale.TabIndex = 2
        Me.listview_sale.UseCompatibleStateImageBehavior = False
        Me.listview_sale.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "*"
        Me.ColumnHeader1.Width = 64
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "รหัสสินค้า"
        Me.ColumnHeader2.Width = 135
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "รายการ"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "หน่วย"
        Me.ColumnHeader4.Width = 111
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "จำนวน"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ราคา"
        Me.ColumnHeader6.Width = 105
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ราคารวม"
        Me.ColumnHeader7.Width = 442
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(10, 13)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(223, 61)
        Me.btn_del.TabIndex = 6
        Me.btn_del.Text = "ลบทั้งหมด"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 1015)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1283, 88)
        Me.Panel5.TabIndex = 16
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(1016, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 88)
        Me.Panel7.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 55)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ออก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btn_del)
        Me.Panel6.Controls.Add(Me.btm_money)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(553, 88)
        Me.Panel6.TabIndex = 7
        '
        'btm_money
        '
        Me.btm_money.Location = New System.Drawing.Point(277, 15)
        Me.btm_money.Name = "btm_money"
        Me.btm_money.Size = New System.Drawing.Size(223, 61)
        Me.btm_money.TabIndex = 5
        Me.btm_money.Text = "คิดเงิน"
        Me.btm_money.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_sale_date)
        Me.Panel4.Controls.Add(Me.lbl_sale_id)
        Me.Panel4.Controls.Add(Me.lbl)
        Me.Panel4.Controls.Add(Me.da)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 190)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1283, 135)
        Me.Panel4.TabIndex = 15
        '
        'lbl_sale_date
        '
        Me.lbl_sale_date.AutoSize = True
        Me.lbl_sale_date.Location = New System.Drawing.Point(724, 57)
        Me.lbl_sale_date.Name = "lbl_sale_date"
        Me.lbl_sale_date.Size = New System.Drawing.Size(39, 32)
        Me.lbl_sale_date.TabIndex = 3
        Me.lbl_sale_date.Text = "..."
        '
        'lbl_sale_id
        '
        Me.lbl_sale_id.AutoSize = True
        Me.lbl_sale_id.Location = New System.Drawing.Point(259, 57)
        Me.lbl_sale_id.Name = "lbl_sale_id"
        Me.lbl_sale_id.Size = New System.Drawing.Size(39, 32)
        Me.lbl_sale_id.TabIndex = 2
        Me.lbl_sale_id.Text = "..."
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(56, 57)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(131, 32)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "รหัสใบขาย"
        '
        'da
        '
        Me.da.AutoSize = True
        Me.da.Location = New System.Drawing.Point(520, 57)
        Me.da.Name = "da"
        Me.da.Size = New System.Drawing.Size(134, 32)
        Me.da.TabIndex = 0
        Me.da.Text = "วัน/เดือน/ปี"
        '
        'frm_sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2221, 1103)
        Me.Controls.Add(Me.listview_sale)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ขายสินค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents listview_coffee As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_total As TextBox
    Friend WithEvents listview_sale As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btn_del As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btm_money As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_sale_date As Label
    Friend WithEvents lbl_sale_id As Label
    Friend WithEvents lbl As Label
    Friend WithEvents da As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
End Class
