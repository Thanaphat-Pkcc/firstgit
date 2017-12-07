<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_managecoffee
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
        Me.datagrid_coffee = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_confrim = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.edit_id = New System.Windows.Forms.TextBox()
        Me.edit_name = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.edit_hot = New System.Windows.Forms.TextBox()
        Me.edit_cool = New System.Windows.Forms.TextBox()
        Me.edit_spin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_save_edit = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_add_id = New System.Windows.Forms.TextBox()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_add_hot = New System.Windows.Forms.TextBox()
        Me.txt_add_cool = New System.Windows.Forms.TextBox()
        Me.txt_add_spin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_add_new = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid_coffee
        '
        Me.datagrid_coffee.AllowUserToAddRows = False
        Me.datagrid_coffee.AllowUserToDeleteRows = False
        Me.datagrid_coffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_coffee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_coffee.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_coffee.Name = "datagrid_coffee"
        Me.datagrid_coffee.ReadOnly = True
        Me.datagrid_coffee.RowHeadersVisible = False
        Me.datagrid_coffee.RowTemplate.Height = 40
        Me.datagrid_coffee.Size = New System.Drawing.Size(1505, 896)
        Me.datagrid_coffee.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(217, 64)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(1065, 38)
        Me.txt_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ค้นหา"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(1290, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 80)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ออก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(29, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(706, 941)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_confrim)
        Me.TabPage3.Controls.Add(Me.btn_delete)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(10, 48)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(686, 883)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบกาแฟ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(164, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(390, 32)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "พิมพ์ ""ยืนยันการลบ"" ในช่องด้านล่าง"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(231, 440)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(271, 116)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_confrim
        '
        Me.txt_confrim.Location = New System.Drawing.Point(132, 292)
        Me.txt_confrim.Name = "txt_confrim"
        Me.txt_confrim.Size = New System.Drawing.Size(453, 38)
        Me.txt_confrim.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_save_edit)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.edit_name)
        Me.TabPage2.Controls.Add(Me.edit_id)
        Me.TabPage2.Location = New System.Drawing.Point(10, 48)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(686, 883)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไขกาแฟ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'edit_id
        '
        Me.edit_id.Location = New System.Drawing.Point(286, 87)
        Me.edit_id.Name = "edit_id"
        Me.edit_id.ReadOnly = True
        Me.edit_id.Size = New System.Drawing.Size(329, 38)
        Me.edit_id.TabIndex = 15
        '
        'edit_name
        '
        Me.edit_name.Location = New System.Drawing.Point(286, 131)
        Me.edit_name.Name = "edit_name"
        Me.edit_name.Size = New System.Drawing.Size(329, 38)
        Me.edit_name.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 32)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "รหัส"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 32)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ชื่อกาแฟ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.edit_spin)
        Me.GroupBox2.Controls.Add(Me.edit_cool)
        Me.GroupBox2.Controls.Add(Me.edit_hot)
        Me.GroupBox2.Location = New System.Drawing.Point(77, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 324)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ราคากาแฟ"
        '
        'edit_hot
        '
        Me.edit_hot.Location = New System.Drawing.Point(245, 117)
        Me.edit_hot.Name = "edit_hot"
        Me.edit_hot.Size = New System.Drawing.Size(145, 38)
        Me.edit_hot.TabIndex = 4
        '
        'edit_cool
        '
        Me.edit_cool.Location = New System.Drawing.Point(245, 161)
        Me.edit_cool.Name = "edit_cool"
        Me.edit_cool.Size = New System.Drawing.Size(145, 38)
        Me.edit_cool.TabIndex = 5
        '
        'edit_spin
        '
        Me.edit_spin.Location = New System.Drawing.Point(245, 205)
        Me.edit_spin.Name = "edit_spin"
        Me.edit_spin.Size = New System.Drawing.Size(145, 38)
        Me.edit_spin.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(134, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 32)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ร้อน"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 32)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "เย็น"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 32)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ปั่น"
        '
        'btn_save_edit
        '
        Me.btn_save_edit.Location = New System.Drawing.Point(197, 690)
        Me.btn_save_edit.Name = "btn_save_edit"
        Me.btn_save_edit.Size = New System.Drawing.Size(270, 106)
        Me.btn_save_edit.TabIndex = 20
        Me.btn_save_edit.Text = "แก้ไข"
        Me.btn_save_edit.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_add_new)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_add_name)
        Me.TabPage1.Controls.Add(Me.txt_add_id)
        Me.TabPage1.Location = New System.Drawing.Point(10, 48)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(686, 883)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่มกาแฟ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_add_id
        '
        Me.txt_add_id.Location = New System.Drawing.Point(297, 66)
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.Size = New System.Drawing.Size(329, 38)
        Me.txt_add_id.TabIndex = 2
        '
        'txt_add_name
        '
        Me.txt_add_name.Location = New System.Drawing.Point(297, 110)
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(329, 38)
        Me.txt_add_name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "รหัส"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ชื่อกาแฟ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_add_spin)
        Me.GroupBox1.Controls.Add(Me.txt_add_cool)
        Me.GroupBox1.Controls.Add(Me.txt_add_hot)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 324)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ราคากาแฟ"
        '
        'txt_add_hot
        '
        Me.txt_add_hot.Location = New System.Drawing.Point(245, 117)
        Me.txt_add_hot.Name = "txt_add_hot"
        Me.txt_add_hot.Size = New System.Drawing.Size(145, 38)
        Me.txt_add_hot.TabIndex = 4
        '
        'txt_add_cool
        '
        Me.txt_add_cool.Location = New System.Drawing.Point(245, 161)
        Me.txt_add_cool.Name = "txt_add_cool"
        Me.txt_add_cool.Size = New System.Drawing.Size(145, 38)
        Me.txt_add_cool.TabIndex = 5
        '
        'txt_add_spin
        '
        Me.txt_add_spin.Location = New System.Drawing.Point(245, 205)
        Me.txt_add_spin.Name = "txt_add_spin"
        Me.txt_add_spin.Size = New System.Drawing.Size(145, 38)
        Me.txt_add_spin.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ร้อน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "เย็น"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ปั่น"
        '
        'btn_add_new
        '
        Me.btn_add_new.Location = New System.Drawing.Point(208, 669)
        Me.btn_add_new.Name = "btn_add_new"
        Me.btn_add_new.Size = New System.Drawing.Size(270, 106)
        Me.btn_add_new.TabIndex = 14
        Me.btn_add_new.Text = "บันทึก"
        Me.btn_add_new.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1505, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(738, 1141)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1061)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1505, 80)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1505, 165)
        Me.Panel3.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.datagrid_coffee)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1505, 896)
        Me.Panel4.TabIndex = 8
        '
        'Form_managecoffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(2243, 1141)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_managecoffee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการกาแฟ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagrid_coffee As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_add_new As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_add_spin As TextBox
    Friend WithEvents txt_add_cool As TextBox
    Friend WithEvents txt_add_hot As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents txt_add_id As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_save_edit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents edit_spin As TextBox
    Friend WithEvents edit_cool As TextBox
    Friend WithEvents edit_hot As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents edit_name As TextBox
    Friend WithEvents edit_id As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txt_confrim As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
