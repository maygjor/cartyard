<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.admin_rbtn = New System.Windows.Forms.RadioButton()
        Me.user_rbtn = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'admin_rbtn
        '
        Me.admin_rbtn.AutoSize = True
        Me.admin_rbtn.Location = New System.Drawing.Point(373, 305)
        Me.admin_rbtn.Name = "admin_rbtn"
        Me.admin_rbtn.Size = New System.Drawing.Size(53, 17)
        Me.admin_rbtn.TabIndex = 18
        Me.admin_rbtn.TabStop = True
        Me.admin_rbtn.Text = "admin"
        Me.admin_rbtn.UseVisualStyleBackColor = True
        '
        'user_rbtn
        '
        Me.user_rbtn.AutoSize = True
        Me.user_rbtn.Location = New System.Drawing.Point(186, 307)
        Me.user_rbtn.Name = "user_rbtn"
        Me.user_rbtn.Size = New System.Drawing.Size(91, 17)
        Me.user_rbtn.TabIndex = 17
        Me.user_rbtn.TabStop = True
        Me.user_rbtn.Text = "customer user"
        Me.user_rbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ok_btn
        '
        Me.ok_btn.Location = New System.Drawing.Point(306, 182)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(120, 23)
        Me.ok_btn.TabIndex = 15
        Me.ok_btn.Text = "OK"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(290, 147)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(136, 20)
        Me.pass_txt.TabIndex = 14
        '
        'name_txt
        '
        Me.name_txt.Location = New System.Drawing.Point(290, 110)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(136, 20)
        Me.name_txt.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "USERNAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "USER TYPE"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(629, 336)
        Me.Controls.Add(Me.admin_rbtn)
        Me.Controls.Add(Me.user_rbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.pass_txt)
        Me.Controls.Add(Me.name_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "CARTRADE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents admin_rbtn As RadioButton
    Friend WithEvents user_rbtn As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents ok_btn As Button
    Friend WithEvents pass_txt As TextBox
    Friend WithEvents name_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
