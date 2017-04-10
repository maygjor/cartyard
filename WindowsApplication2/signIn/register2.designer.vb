<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register2
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
        Me.btn_save = New System.Windows.Forms.Button()
        Me.custate_txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cucity_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cupincode_txt = New System.Windows.Forms.TextBox()
        Me.culandmark_txt = New System.Windows.Forms.TextBox()
        Me.cuphone_txt = New System.Windows.Forms.TextBox()
        Me.cuaddress_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cuname_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(209, 163)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 74
        Me.btn_save.Text = "save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'custate_txt
        '
        Me.custate_txt.Location = New System.Drawing.Point(537, 124)
        Me.custate_txt.Name = "custate_txt"
        Me.custate_txt.Size = New System.Drawing.Size(100, 20)
        Me.custate_txt.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(473, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "state"
        '
        'cucity_txt
        '
        Me.cucity_txt.Location = New System.Drawing.Point(537, 85)
        Me.cucity_txt.Name = "cucity_txt"
        Me.cucity_txt.Size = New System.Drawing.Size(100, 20)
        Me.cucity_txt.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(471, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "city"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(471, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "pin code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "landmark"
        '
        'cupincode_txt
        '
        Me.cupincode_txt.Location = New System.Drawing.Point(537, 48)
        Me.cupincode_txt.Name = "cupincode_txt"
        Me.cupincode_txt.Size = New System.Drawing.Size(100, 20)
        Me.cupincode_txt.TabIndex = 67
        '
        'culandmark_txt
        '
        Me.culandmark_txt.Location = New System.Drawing.Point(91, 126)
        Me.culandmark_txt.Name = "culandmark_txt"
        Me.culandmark_txt.Size = New System.Drawing.Size(256, 20)
        Me.culandmark_txt.TabIndex = 66
        '
        'cuphone_txt
        '
        Me.cuphone_txt.Location = New System.Drawing.Point(537, 160)
        Me.cuphone_txt.Name = "cuphone_txt"
        Me.cuphone_txt.Size = New System.Drawing.Size(100, 20)
        Me.cuphone_txt.TabIndex = 65
        '
        'cuaddress_txt
        '
        Me.cuaddress_txt.Location = New System.Drawing.Point(91, 90)
        Me.cuaddress_txt.Multiline = True
        Me.cuaddress_txt.Name = "cuaddress_txt"
        Me.cuaddress_txt.Size = New System.Drawing.Size(256, 30)
        Me.cuaddress_txt.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(471, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = " name"
        '
        'cuname_txt
        '
        Me.cuname_txt.Location = New System.Drawing.Point(91, 52)
        Me.cuname_txt.Name = "cuname_txt"
        Me.cuname_txt.Size = New System.Drawing.Size(100, 20)
        Me.cuname_txt.TabIndex = 60
        '
        'register2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 226)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.custate_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cucity_txt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cupincode_txt)
        Me.Controls.Add(Me.culandmark_txt)
        Me.Controls.Add(Me.cuphone_txt)
        Me.Controls.Add(Me.cuaddress_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cuname_txt)
        Me.Name = "register2"
        Me.Text = "register2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_save As Button
    Friend WithEvents custate_txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cucity_txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cupincode_txt As TextBox
    Friend WithEvents culandmark_txt As TextBox
    Friend WithEvents cuphone_txt As TextBox
    Friend WithEvents cuaddress_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cuname_txt As TextBox
End Class
