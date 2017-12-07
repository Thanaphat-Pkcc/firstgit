<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sale_price
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
        Me.rdb_hot = New System.Windows.Forms.RadioButton()
        Me.rdb_cool = New System.Windows.Forms.RadioButton()
        Me.rdb_spin = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_hot = New System.Windows.Forms.Label()
        Me.lbl_cool = New System.Windows.Forms.Label()
        Me.lbl_spin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdb_hot
        '
        Me.rdb_hot.AutoSize = True
        Me.rdb_hot.Location = New System.Drawing.Point(29, 21)
        Me.rdb_hot.Name = "rdb_hot"
        Me.rdb_hot.Size = New System.Drawing.Size(98, 36)
        Me.rdb_hot.TabIndex = 0
        Me.rdb_hot.TabStop = True
        Me.rdb_hot.Text = "ร้อน"
        Me.rdb_hot.UseVisualStyleBackColor = True
        '
        'rdb_cool
        '
        Me.rdb_cool.AutoSize = True
        Me.rdb_cool.Location = New System.Drawing.Point(29, 103)
        Me.rdb_cool.Name = "rdb_cool"
        Me.rdb_cool.Size = New System.Drawing.Size(91, 36)
        Me.rdb_cool.TabIndex = 1
        Me.rdb_cool.TabStop = True
        Me.rdb_cool.Text = "เย็น"
        Me.rdb_cool.UseVisualStyleBackColor = True
        '
        'rdb_spin
        '
        Me.rdb_spin.AutoSize = True
        Me.rdb_spin.Location = New System.Drawing.Point(29, 195)
        Me.rdb_spin.Name = "rdb_spin"
        Me.rdb_spin.Size = New System.Drawing.Size(85, 36)
        Me.rdb_spin.TabIndex = 2
        Me.rdb_spin.TabStop = True
        Me.rdb_spin.Text = "ปั่น"
        Me.rdb_spin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 637)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "จำนวน"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(296, 631)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(231, 38)
        Me.txt_qty.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 731)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(371, 81)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "เลือก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_hot
        '
        Me.lbl_hot.AutoSize = True
        Me.lbl_hot.Location = New System.Drawing.Point(295, 24)
        Me.lbl_hot.Name = "lbl_hot"
        Me.lbl_hot.Size = New System.Drawing.Size(31, 32)
        Me.lbl_hot.TabIndex = 6
        Me.lbl_hot.Text = "0"
        '
        'lbl_cool
        '
        Me.lbl_cool.AutoSize = True
        Me.lbl_cool.Location = New System.Drawing.Point(295, 103)
        Me.lbl_cool.Name = "lbl_cool"
        Me.lbl_cool.Size = New System.Drawing.Size(31, 32)
        Me.lbl_cool.TabIndex = 7
        Me.lbl_cool.Text = "0"
        '
        'lbl_spin
        '
        Me.lbl_spin.AutoSize = True
        Me.lbl_spin.Location = New System.Drawing.Point(295, 198)
        Me.lbl_spin.Name = "lbl_spin"
        Me.lbl_spin.Size = New System.Drawing.Size(31, 32)
        Me.lbl_spin.TabIndex = 8
        Me.lbl_spin.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_spin)
        Me.Panel1.Controls.Add(Me.lbl_cool)
        Me.Panel1.Controls.Add(Me.lbl_hot)
        Me.Panel1.Controls.Add(Me.rdb_spin)
        Me.Panel1.Controls.Add(Me.rdb_cool)
        Me.Panel1.Controls.Add(Me.rdb_hot)
        Me.Panel1.Location = New System.Drawing.Point(192, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 279)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "รหัส"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "รายการ"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(414, 140)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(31, 32)
        Me.lbl_name.TabIndex = 12
        Me.lbl_name.Text = "0"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(414, 49)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(31, 32)
        Me.lbl_id.TabIndex = 13
        Me.lbl_id.Text = "0"
        '
        'frm_sale_price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(752, 856)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_sale_price"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกราคา"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdb_hot As RadioButton
    Friend WithEvents rdb_cool As RadioButton
    Friend WithEvents rdb_spin As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_hot As Label
    Friend WithEvents lbl_cool As Label
    Friend WithEvents lbl_spin As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
End Class
