<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierMgmtForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliercompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meds_supplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet = New WindowsApp1.pharmaDataSet()
        Me.Meds_supplierTableAdapter = New WindowsApp1.pharmaDataSetTableAdapters.meds_supplierTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.sup_addbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.suppIDtxbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.supNametxbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.supPhonetxbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.supCompTxbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.supDelTxbx = New System.Windows.Forms.TextBox()
        Me.supp_delBTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meds_supplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(257, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "SUPPLIER MANAGEMENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(226, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(-1, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 22)
        Me.Panel2.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 75)
        Me.Panel1.TabIndex = 45
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SIDDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.SuppliercompanyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Meds_supplierBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 353)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(669, 163)
        Me.DataGridView1.TabIndex = 47
        '
        'SIDDataGridViewTextBoxColumn
        '
        Me.SIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.HeaderText = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "S_name"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "S_name"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'SuppliercompanyDataGridViewTextBoxColumn
        '
        Me.SuppliercompanyDataGridViewTextBoxColumn.DataPropertyName = "supplier_company"
        Me.SuppliercompanyDataGridViewTextBoxColumn.HeaderText = "supplier_company"
        Me.SuppliercompanyDataGridViewTextBoxColumn.Name = "SuppliercompanyDataGridViewTextBoxColumn"
        '
        'Meds_supplierBindingSource
        '
        Me.Meds_supplierBindingSource.DataMember = "meds_supplier"
        Me.Meds_supplierBindingSource.DataSource = Me.PharmaDataSet
        '
        'PharmaDataSet
        '
        Me.PharmaDataSet.DataSetName = "pharmaDataSet"
        Me.PharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Meds_supplierTableAdapter
        '
        Me.Meds_supplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.meds_inventoryTableAdapter = Nothing
        Me.TableAdapterManager.meds_orderTableAdapter = Nothing
        Me.TableAdapterManager.meds_supplierTableAdapter = Me.Meds_supplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(352, 255)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 28)
        Me.Button8.TabIndex = 88
        Me.Button8.Text = "RESET"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'sup_addbtn
        '
        Me.sup_addbtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.sup_addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sup_addbtn.Location = New System.Drawing.Point(262, 255)
        Me.sup_addbtn.Name = "sup_addbtn"
        Me.sup_addbtn.Size = New System.Drawing.Size(84, 28)
        Me.sup_addbtn.TabIndex = 87
        Me.sup_addbtn.Text = "ADD"
        Me.sup_addbtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Supplier ID : "
        '
        'suppIDtxbx
        '
        Me.suppIDtxbx.Location = New System.Drawing.Point(236, 96)
        Me.suppIDtxbx.Name = "suppIDtxbx"
        Me.suppIDtxbx.Size = New System.Drawing.Size(228, 20)
        Me.suppIDtxbx.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Supplier Name : "
        '
        'supNametxbx
        '
        Me.supNametxbx.Location = New System.Drawing.Point(236, 137)
        Me.supNametxbx.Name = "supNametxbx"
        Me.supNametxbx.Size = New System.Drawing.Size(228, 20)
        Me.supNametxbx.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Supplier Contact : "
        '
        'supPhonetxbx
        '
        Me.supPhonetxbx.Location = New System.Drawing.Point(236, 178)
        Me.supPhonetxbx.Name = "supPhonetxbx"
        Me.supPhonetxbx.Size = New System.Drawing.Size(228, 20)
        Me.supPhonetxbx.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(102, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Supplie Company : "
        '
        'supCompTxbx
        '
        Me.supCompTxbx.Location = New System.Drawing.Point(237, 219)
        Me.supCompTxbx.Name = "supCompTxbx"
        Me.supCompTxbx.Size = New System.Drawing.Size(228, 20)
        Me.supCompTxbx.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Supplier ID : "
        '
        'supDelTxbx
        '
        Me.supDelTxbx.Location = New System.Drawing.Point(236, 309)
        Me.supDelTxbx.Name = "supDelTxbx"
        Me.supDelTxbx.Size = New System.Drawing.Size(228, 20)
        Me.supDelTxbx.TabIndex = 95
        '
        'supp_delBTN
        '
        Me.supp_delBTN.BackColor = System.Drawing.Color.LightCoral
        Me.supp_delBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.supp_delBTN.Location = New System.Drawing.Point(482, 304)
        Me.supp_delBTN.Name = "supp_delBTN"
        Me.supp_delBTN.Size = New System.Drawing.Size(84, 28)
        Me.supp_delBTN.TabIndex = 97
        Me.supp_delBTN.Text = "DELETE"
        Me.supp_delBTN.UseVisualStyleBackColor = False
        '
        'supplierMgmtForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(690, 561)
        Me.Controls.Add(Me.supp_delBTN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.supDelTxbx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.supCompTxbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.supPhonetxbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.supNametxbx)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.sup_addbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.suppIDtxbx)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "supplierMgmtForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "supplierMgmtForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meds_supplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PharmaDataSet As pharmaDataSet
    Friend WithEvents Meds_supplierBindingSource As BindingSource
    Friend WithEvents Meds_supplierTableAdapter As pharmaDataSetTableAdapters.meds_supplierTableAdapter
    Friend WithEvents TableAdapterManager As pharmaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppliercompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents sup_addbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents suppIDtxbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents supNametxbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents supPhonetxbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents supCompTxbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents supDelTxbx As TextBox
    Friend WithEvents supp_delBTN As Button
End Class
