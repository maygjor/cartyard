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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.admin_rbtn = New System.Windows.Forms.RadioButton()
        Me.user_rbtn = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'admin_rbtn
        '
        resources.ApplyResources(Me.admin_rbtn, "admin_rbtn")
        Me.admin_rbtn.Name = "admin_rbtn"
        Me.admin_rbtn.TabStop = True
        Me.admin_rbtn.UseVisualStyleBackColor = True
        Me.admin_rbtn.UseWaitCursor = True
        '
        'user_rbtn
        '
        resources.ApplyResources(Me.user_rbtn, "user_rbtn")
        Me.user_rbtn.Checked = True
        Me.user_rbtn.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.user_rbtn.Name = "user_rbtn"
        Me.user_rbtn.TabStop = True
        Me.user_rbtn.UseVisualStyleBackColor = True
        Me.user_rbtn.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Button1.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'ok_btn
        '
        Me.ok_btn.BackColor = System.Drawing.Color.Honeydew
        resources.ApplyResources(Me.ok_btn, "ok_btn")
        Me.ok_btn.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.ok_btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ok_btn.FlatAppearance.BorderSize = 0
        Me.ok_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ok_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ok_btn.ForeColor = System.Drawing.Color.SpringGreen
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.UseVisualStyleBackColor = False
        '
        'pass_txt
        '
        Me.pass_txt.BackColor = System.Drawing.Color.MintCream
        resources.ApplyResources(Me.pass_txt, "pass_txt")
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.UseWaitCursor = True
        '
        'name_txt
        '
        Me.name_txt.BackColor = System.Drawing.Color.MintCream
        Me.name_txt.Cursor = System.Windows.Forms.Cursors.WaitCursor
        resources.ApplyResources(Me.name_txt, "name_txt")
        Me.name_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.name_txt.Name = "name_txt"
        Me.name_txt.UseWaitCursor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.Label2.UseWaitCursor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.pass_txt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.user_rbtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ok_btn)
        Me.Panel1.Controls.Add(Me.name_txt)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        Me.Panel1.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MintCream
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.ForeColor = System.Drawing.Color.SpringGreen
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AcceptButton = Me.ok_btn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.Lavender
        resources.ApplyResources(Me, "$this")
        Me.CancelButton = Me.Button2
        Me.Controls.Add(Me.admin_rbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.LimeGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UseWaitCursor = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
