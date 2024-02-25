<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.admin_txbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.adm_back_btn = New System.Windows.Forms.Button()
        Me.adm_reset = New System.Windows.Forms.Button()
        Me.adm_Sumbit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 75)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(86, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(159, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ADMIN"
        '
        'admin_txbx
        '
        Me.admin_txbx.Location = New System.Drawing.Point(97, 350)
        Me.admin_txbx.Name = "admin_txbx"
        Me.admin_txbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.admin_txbx.Size = New System.Drawing.Size(227, 20)
        Me.admin_txbx.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(111, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Enter your password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.adm_back_btn)
        Me.Panel2.Location = New System.Drawing.Point(0, 439)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(421, 22)
        Me.Panel2.TabIndex = 13
        '
        'adm_back_btn
        '
        Me.adm_back_btn.BackColor = System.Drawing.Color.SkyBlue
        Me.adm_back_btn.Location = New System.Drawing.Point(163, -2)
        Me.adm_back_btn.Name = "adm_back_btn"
        Me.adm_back_btn.Size = New System.Drawing.Size(75, 22)
        Me.adm_back_btn.TabIndex = 25
        Me.adm_back_btn.Text = "Back"
        Me.adm_back_btn.UseVisualStyleBackColor = False
        '
        'adm_reset
        '
        Me.adm_reset.BackColor = System.Drawing.Color.LightSkyBlue
        Me.adm_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.adm_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adm_reset.Location = New System.Drawing.Point(219, 384)
        Me.adm_reset.Name = "adm_reset"
        Me.adm_reset.Size = New System.Drawing.Size(129, 31)
        Me.adm_reset.TabIndex = 15
        Me.adm_reset.Text = "RESET"
        Me.adm_reset.UseVisualStyleBackColor = False
        '
        'adm_Sumbit
        '
        Me.adm_Sumbit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.adm_Sumbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.adm_Sumbit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.adm_Sumbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adm_Sumbit.Location = New System.Drawing.Point(62, 384)
        Me.adm_Sumbit.Name = "adm_Sumbit"
        Me.adm_Sumbit.Size = New System.Drawing.Size(129, 31)
        Me.adm_Sumbit.TabIndex = 14
        Me.adm_Sumbit.Text = "SUBMIT"
        Me.adm_Sumbit.UseVisualStyleBackColor = False
        '
        'adminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(420, 464)
        Me.Controls.Add(Me.adm_reset)
        Me.Controls.Add(Me.adm_Sumbit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.admin_txbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents admin_txbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents adm_reset As Button
    Friend WithEvents adm_Sumbit As Button
    Friend WithEvents adm_back_btn As Button
End Class
