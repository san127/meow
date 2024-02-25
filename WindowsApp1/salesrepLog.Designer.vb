<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesrepLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesrepLog))
        Me.salerep_reset = New System.Windows.Forms.Button()
        Me.salerep_Sumbit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.salerep_back_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.salesrep_txbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'salerep_reset
        '
        Me.salerep_reset.BackColor = System.Drawing.Color.LightSkyBlue
        Me.salerep_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salerep_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salerep_reset.Location = New System.Drawing.Point(219, 386)
        Me.salerep_reset.Name = "salerep_reset"
        Me.salerep_reset.Size = New System.Drawing.Size(129, 31)
        Me.salerep_reset.TabIndex = 39
        Me.salerep_reset.Text = "RESET"
        Me.salerep_reset.UseVisualStyleBackColor = False
        '
        'salerep_Sumbit
        '
        Me.salerep_Sumbit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.salerep_Sumbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.salerep_Sumbit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salerep_Sumbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salerep_Sumbit.Location = New System.Drawing.Point(74, 386)
        Me.salerep_Sumbit.Name = "salerep_Sumbit"
        Me.salerep_Sumbit.Size = New System.Drawing.Size(129, 31)
        Me.salerep_Sumbit.TabIndex = 38
        Me.salerep_Sumbit.Text = "SUBMIT"
        Me.salerep_Sumbit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.salerep_back_btn)
        Me.Panel2.Location = New System.Drawing.Point(-3, 442)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 22)
        Me.Panel2.TabIndex = 37
        '
        'salerep_back_btn
        '
        Me.salerep_back_btn.BackColor = System.Drawing.Color.SkyBlue
        Me.salerep_back_btn.Location = New System.Drawing.Point(175, -2)
        Me.salerep_back_btn.Name = "salerep_back_btn"
        Me.salerep_back_btn.Size = New System.Drawing.Size(75, 22)
        Me.salerep_back_btn.TabIndex = 24
        Me.salerep_back_btn.Text = "Back"
        Me.salerep_back_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(112, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 25)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Enter your password"
        '
        'salesrep_txbx
        '
        Me.salesrep_txbx.Location = New System.Drawing.Point(98, 351)
        Me.salesrep_txbx.Name = "salesrep_txbx"
        Me.salesrep_txbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.salesrep_txbx.Size = New System.Drawing.Size(227, 20)
        Me.salesrep_txbx.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(33, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 31)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "SALES REPRESENTATIVE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 75)
        Me.Panel1.TabIndex = 32
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
        'salesrepLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(420, 464)
        Me.Controls.Add(Me.salerep_reset)
        Me.Controls.Add(Me.salerep_Sumbit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.salesrep_txbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "salesrepLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "salesrepLog"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salerep_reset As Button
    Friend WithEvents salerep_Sumbit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents salerep_back_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents salesrep_txbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
