<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchmanger_log
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchmanger_log))
        Me.purchman_reset = New System.Windows.Forms.Button()
        Me.purchman_Sumbit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.purchman_back_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.purchman_txbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'purchman_reset
        '
        Me.purchman_reset.BackColor = System.Drawing.Color.LightSkyBlue
        Me.purchman_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purchman_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchman_reset.Location = New System.Drawing.Point(219, 386)
        Me.purchman_reset.Name = "purchman_reset"
        Me.purchman_reset.Size = New System.Drawing.Size(129, 31)
        Me.purchman_reset.TabIndex = 31
        Me.purchman_reset.Text = "RESET"
        Me.purchman_reset.UseVisualStyleBackColor = False
        '
        'purchman_Sumbit
        '
        Me.purchman_Sumbit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.purchman_Sumbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.purchman_Sumbit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purchman_Sumbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchman_Sumbit.Location = New System.Drawing.Point(74, 386)
        Me.purchman_Sumbit.Name = "purchman_Sumbit"
        Me.purchman_Sumbit.Size = New System.Drawing.Size(129, 31)
        Me.purchman_Sumbit.TabIndex = 30
        Me.purchman_Sumbit.Text = "SUBMIT"
        Me.purchman_Sumbit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.purchman_back_btn)
        Me.Panel2.Location = New System.Drawing.Point(-3, 442)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 22)
        Me.Panel2.TabIndex = 29
        '
        'purchman_back_btn
        '
        Me.purchman_back_btn.BackColor = System.Drawing.Color.SkyBlue
        Me.purchman_back_btn.Location = New System.Drawing.Point(172, -2)
        Me.purchman_back_btn.Name = "purchman_back_btn"
        Me.purchman_back_btn.Size = New System.Drawing.Size(75, 22)
        Me.purchman_back_btn.TabIndex = 24
        Me.purchman_back_btn.Text = "Back"
        Me.purchman_back_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(112, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Enter your password"
        '
        'purchman_txbx
        '
        Me.purchman_txbx.Location = New System.Drawing.Point(98, 351)
        Me.purchman_txbx.Name = "purchman_txbx"
        Me.purchman_txbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.purchman_txbx.Size = New System.Drawing.Size(227, 20)
        Me.purchman_txbx.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(41, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 31)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "PURCHASING MANAGER"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(136, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 75)
        Me.Panel1.TabIndex = 24
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
        'purchmanger_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(420, 464)
        Me.Controls.Add(Me.purchman_reset)
        Me.Controls.Add(Me.purchman_Sumbit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.purchman_txbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "purchmanger_log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "purchmanger_log"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents purchman_reset As Button
    Friend WithEvents purchman_Sumbit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents purchman_back_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents purchman_txbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
