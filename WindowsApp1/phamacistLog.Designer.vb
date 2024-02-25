<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phamacistLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(phamacistLog))
        Me.pharma_reset = New System.Windows.Forms.Button()
        Me.pharma_Sumbit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.phrm_back_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pharma_txbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pharma_reset
        '
        Me.pharma_reset.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pharma_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pharma_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharma_reset.Location = New System.Drawing.Point(225, 384)
        Me.pharma_reset.Name = "pharma_reset"
        Me.pharma_reset.Size = New System.Drawing.Size(129, 31)
        Me.pharma_reset.TabIndex = 23
        Me.pharma_reset.Text = "RESET"
        Me.pharma_reset.UseVisualStyleBackColor = False
        '
        'pharma_Sumbit
        '
        Me.pharma_Sumbit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pharma_Sumbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pharma_Sumbit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pharma_Sumbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharma_Sumbit.Location = New System.Drawing.Point(72, 384)
        Me.pharma_Sumbit.Name = "pharma_Sumbit"
        Me.pharma_Sumbit.Size = New System.Drawing.Size(129, 31)
        Me.pharma_Sumbit.TabIndex = 22
        Me.pharma_Sumbit.Text = "SUBMIT"
        Me.pharma_Sumbit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.phrm_back_btn)
        Me.Panel2.Location = New System.Drawing.Point(-2, 441)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 22)
        Me.Panel2.TabIndex = 21
        '
        'phrm_back_btn
        '
        Me.phrm_back_btn.BackColor = System.Drawing.Color.SkyBlue
        Me.phrm_back_btn.Location = New System.Drawing.Point(173, -2)
        Me.phrm_back_btn.Name = "phrm_back_btn"
        Me.phrm_back_btn.Size = New System.Drawing.Size(75, 22)
        Me.phrm_back_btn.TabIndex = 24
        Me.phrm_back_btn.Text = "Back"
        Me.phrm_back_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(112, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Enter your password"
        '
        'pharma_txbx
        '
        Me.pharma_txbx.Location = New System.Drawing.Point(98, 350)
        Me.pharma_txbx.Name = "pharma_txbx"
        Me.pharma_txbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pharma_txbx.Size = New System.Drawing.Size(227, 20)
        Me.pharma_txbx.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(115, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 31)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "PHARMACIST"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(136, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 75)
        Me.Panel1.TabIndex = 16
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
        'phamacistLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(420, 464)
        Me.Controls.Add(Me.pharma_reset)
        Me.Controls.Add(Me.pharma_Sumbit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pharma_txbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "phamacistLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "phamacistLog"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pharma_reset As Button
    Friend WithEvents pharma_Sumbit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pharma_txbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents phrm_back_btn As Button
End Class
