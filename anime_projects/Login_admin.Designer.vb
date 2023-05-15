<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.cbpass = New System.Windows.Forms.CheckBox()
        Me.password_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.username_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 132)
        Me.Panel1.TabIndex = 16
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Crimson
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_back.Location = New System.Drawing.Point(814, 41)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(141, 48)
        Me.btn_back.TabIndex = 24
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(222, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO SAMAHEDAKU APP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 560)
        Me.Panel2.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(108, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "WELCOME ADMIN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Crimson
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_login.Location = New System.Drawing.Point(638, 489)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(141, 48)
        Me.btn_login.TabIndex = 18
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'cbpass
        '
        Me.cbpass.AutoSize = True
        Me.cbpass.BackColor = System.Drawing.Color.Crimson
        Me.cbpass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpass.ForeColor = System.Drawing.Color.Cornsilk
        Me.cbpass.Location = New System.Drawing.Point(520, 425)
        Me.cbpass.Name = "cbpass"
        Me.cbpass.Size = New System.Drawing.Size(199, 29)
        Me.cbpass.TabIndex = 23
        Me.cbpass.Text = "SHOW PASSWORD"
        Me.cbpass.UseVisualStyleBackColor = False
        '
        'password_TXT
        '
        Me.password_TXT.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_TXT.Location = New System.Drawing.Point(520, 366)
        Me.password_TXT.Name = "password_TXT"
        Me.password_TXT.Size = New System.Drawing.Size(365, 45)
        Me.password_TXT.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label4.Location = New System.Drawing.Point(520, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 45)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "PASSWORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'username_TXT
        '
        Me.username_TXT.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_TXT.Location = New System.Drawing.Point(520, 227)
        Me.username_TXT.Name = "username_TXT"
        Me.username_TXT.Size = New System.Drawing.Size(365, 45)
        Me.username_TXT.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(520, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 45)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "USERNAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(978, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.cbpass)
        Me.Controls.Add(Me.password_TXT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.username_TXT)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_admin"
        Me.Text = "Login_admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents cbpass As CheckBox
    Friend WithEvents password_TXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents username_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_back As Button
End Class
