<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock
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
        Me.dgv_stock = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.num_exit = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cutoff = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.num_enter = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_low = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_add_qty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_add_cost = New System.Windows.Forms.TextBox()
        Me.btn_add_new = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.txt_add_id = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.edit_cost = New System.Windows.Forms.TextBox()
        Me.btn_save_edit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.edit_name = New System.Windows.Forms.TextBox()
        Me.edit_id = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.txt_confrim = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.num_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.num_enter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_low, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_stock
        '
        Me.dgv_stock.AllowUserToAddRows = False
        Me.dgv_stock.AllowUserToDeleteRows = False
        Me.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_stock.Location = New System.Drawing.Point(0, 0)
        Me.dgv_stock.MultiSelect = False
        Me.dgv_stock.Name = "dgv_stock"
        Me.dgv_stock.ReadOnly = True
        Me.dgv_stock.RowHeadersVisible = False
        Me.dgv_stock.RowTemplate.Height = 40
        Me.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_stock.Size = New System.Drawing.Size(1071, 958)
        Me.dgv_stock.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1169, 958)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.num_exit)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btn_cutoff)
        Me.TabPage1.Location = New System.Drawing.Point(10, 48)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1149, 900)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "จำหน่ายออก"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'num_exit
        '
        Me.num_exit.AutoSize = True
        Me.num_exit.Location = New System.Drawing.Point(451, 395)
        Me.num_exit.Name = "num_exit"
        Me.num_exit.Size = New System.Drawing.Size(277, 38)
        Me.num_exit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ระบุจำนวนสินค้าออก"
        '
        'btn_cutoff
        '
        Me.btn_cutoff.AutoSize = True
        Me.btn_cutoff.Location = New System.Drawing.Point(474, 580)
        Me.btn_cutoff.Name = "btn_cutoff"
        Me.btn_cutoff.Size = New System.Drawing.Size(230, 65)
        Me.btn_cutoff.TabIndex = 0
        Me.btn_cutoff.Text = "จำหน่ายออก"
        Me.btn_cutoff.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.num_enter)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btn_enter)
        Me.TabPage2.Location = New System.Drawing.Point(10, 48)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1149, 900)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "รับสินค้าเข้า"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'num_enter
        '
        Me.num_enter.AutoSize = True
        Me.num_enter.Location = New System.Drawing.Point(454, 389)
        Me.num_enter.Name = "num_enter"
        Me.num_enter.Size = New System.Drawing.Size(277, 38)
        Me.num_enter.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(335, 55)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ระบุจำนวนรับเข้า"
        '
        'btn_enter
        '
        Me.btn_enter.AutoSize = True
        Me.btn_enter.Location = New System.Drawing.Point(477, 560)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(230, 65)
        Me.btn_enter.TabIndex = 4
        Me.btn_enter.Text = "รับสินค้าเข้า"
        Me.btn_enter.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.dgv_low)
        Me.TabPage3.Location = New System.Drawing.Point(10, 48)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1149, 900)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "สินค้าใกล้หมด"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(368, 61)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "จำนวนสินค้า < 5"
        '
        'dgv_low
        '
        Me.dgv_low.AllowUserToAddRows = False
        Me.dgv_low.AllowUserToDeleteRows = False
        Me.dgv_low.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_low.Location = New System.Drawing.Point(82, 155)
        Me.dgv_low.Name = "dgv_low"
        Me.dgv_low.ReadOnly = True
        Me.dgv_low.RowHeadersVisible = False
        Me.dgv_low.RowTemplate.Height = 40
        Me.dgv_low.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_low.Size = New System.Drawing.Size(1033, 705)
        Me.dgv_low.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.txt_add_qty)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.txt_add_cost)
        Me.TabPage4.Controls.Add(Me.btn_add_new)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.txt_add_name)
        Me.TabPage4.Controls.Add(Me.txt_add_id)
        Me.TabPage4.Location = New System.Drawing.Point(10, 48)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1149, 900)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "เพิ่มสินค้า"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 517)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "จำนวน"
        '
        'txt_add_qty
        '
        Me.txt_add_qty.Location = New System.Drawing.Point(523, 511)
        Me.txt_add_qty.Name = "txt_add_qty"
        Me.txt_add_qty.Size = New System.Drawing.Size(329, 38)
        Me.txt_add_qty.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 32)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ราคาต้นทุน"
        '
        'txt_add_cost
        '
        Me.txt_add_cost.Location = New System.Drawing.Point(523, 381)
        Me.txt_add_cost.Name = "txt_add_cost"
        Me.txt_add_cost.Size = New System.Drawing.Size(329, 38)
        Me.txt_add_cost.TabIndex = 16
        '
        'btn_add_new
        '
        Me.btn_add_new.Location = New System.Drawing.Point(459, 713)
        Me.btn_add_new.Name = "btn_add_new"
        Me.btn_add_new.Size = New System.Drawing.Size(270, 106)
        Me.btn_add_new.TabIndex = 15
        Me.btn_add_new.Text = "บันทึก"
        Me.btn_add_new.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ชื่อสินค้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 32)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "รหัส"
        '
        'txt_add_name
        '
        Me.txt_add_name.Location = New System.Drawing.Point(523, 235)
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(329, 38)
        Me.txt_add_name.TabIndex = 10
        '
        'txt_add_id
        '
        Me.txt_add_id.Location = New System.Drawing.Point(523, 111)
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.Size = New System.Drawing.Size(329, 38)
        Me.txt_add_id.TabIndex = 9
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.edit_cost)
        Me.TabPage5.Controls.Add(Me.btn_save_edit)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.edit_name)
        Me.TabPage5.Controls.Add(Me.edit_id)
        Me.TabPage5.Location = New System.Drawing.Point(10, 48)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1149, 900)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "แก้ไขสินค้า"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 32)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "ราคาทุนสินค้า"
        '
        'edit_cost
        '
        Me.edit_cost.Location = New System.Drawing.Point(517, 331)
        Me.edit_cost.Name = "edit_cost"
        Me.edit_cost.Size = New System.Drawing.Size(329, 38)
        Me.edit_cost.TabIndex = 27
        '
        'btn_save_edit
        '
        Me.btn_save_edit.Location = New System.Drawing.Point(448, 575)
        Me.btn_save_edit.Name = "btn_save_edit"
        Me.btn_save_edit.Size = New System.Drawing.Size(270, 106)
        Me.btn_save_edit.TabIndex = 26
        Me.btn_save_edit.Text = "แก้ไข"
        Me.btn_save_edit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(302, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 32)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "ชื่อสินค้า"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(302, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 32)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "รหัส"
        '
        'edit_name
        '
        Me.edit_name.Location = New System.Drawing.Point(517, 210)
        Me.edit_name.Name = "edit_name"
        Me.edit_name.Size = New System.Drawing.Size(329, 38)
        Me.edit_name.TabIndex = 22
        '
        'edit_id
        '
        Me.edit_id.Location = New System.Drawing.Point(517, 96)
        Me.edit_id.Name = "edit_id"
        Me.edit_id.ReadOnly = True
        Me.edit_id.Size = New System.Drawing.Size(329, 38)
        Me.edit_id.TabIndex = 21
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txt_confrim)
        Me.TabPage6.Controls.Add(Me.btn_delete)
        Me.TabPage6.Controls.Add(Me.Label12)
        Me.TabPage6.Location = New System.Drawing.Point(10, 48)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1149, 900)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "ลบสินค้า"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'txt_confrim
        '
        Me.txt_confrim.Location = New System.Drawing.Point(356, 309)
        Me.txt_confrim.Name = "txt_confrim"
        Me.txt_confrim.Size = New System.Drawing.Size(453, 38)
        Me.txt_confrim.TabIndex = 5
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(455, 457)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(271, 116)
        Me.btn_delete.TabIndex = 4
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(388, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(390, 32)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "พิมพ์ ""ยืนยันการลบ"" ในช่องด้านล่าง"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(1990, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 85)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ออก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 958)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2240, 85)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1071, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1169, 958)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_stock)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1071, 958)
        Me.Panel3.TabIndex = 5
        '
        'frm_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2240, 1043)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "คลังสินค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.num_exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.num_enter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgv_low, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_stock As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents num_exit As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cutoff As Button
    Friend WithEvents num_enter As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_enter As Button
    Friend WithEvents dgv_low As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents txt_add_id As TextBox
    Friend WithEvents btn_add_new As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_add_cost As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_add_qty As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txt_confrim As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents edit_cost As TextBox
    Friend WithEvents btn_save_edit As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents edit_name As TextBox
    Friend WithEvents edit_id As TextBox
End Class
