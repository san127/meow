<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderMgmtForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PharmaDataSet = New WindowsApp1.pharmaDataSet()
        Me.Meds_orderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Meds_orderTableAdapter = New WindowsApp1.pharmaDataSetTableAdapters.meds_orderTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MednameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ord_resetBTN = New System.Windows.Forms.Button()
        Me.order_addBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.medPrice_txbx = New System.Windows.Forms.TextBox()
        Me.expDate_txbx = New System.Windows.Forms.TextBox()
        Me.medName_txbx = New System.Windows.Forms.TextBox()
        Me.medId_txbx = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meds_orderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 75)
        Me.Panel1.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(210, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "ORDER MANAGEMENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(172, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(-1, 532)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 22)
        Me.Panel2.TabIndex = 48
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.MednameDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.SIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Meds_orderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 312)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(565, 201)
        Me.DataGridView1.TabIndex = 49
        '
        'PharmaDataSet
        '
        Me.PharmaDataSet.DataSetName = "pharmaDataSet"
        Me.PharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Meds_orderBindingSource
        '
        Me.Meds_orderBindingSource.DataMember = "meds_order"
        Me.Meds_orderBindingSource.DataSource = Me.PharmaDataSet
        '
        'Meds_orderTableAdapter
        '
        Me.Meds_orderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.meds_inventoryTableAdapter = Nothing
        Me.TableAdapterManager.meds_orderTableAdapter = Me.Meds_orderTableAdapter
        Me.TableAdapterManager.meds_supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        '
        'MednameDataGridViewTextBoxColumn
        '
        Me.MednameDataGridViewTextBoxColumn.DataPropertyName = "med_name"
        Me.MednameDataGridViewTextBoxColumn.HeaderText = "med_name"
        Me.MednameDataGridViewTextBoxColumn.Name = "MednameDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'SIDDataGridViewTextBoxColumn
        '
        Me.SIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.HeaderText = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
        '
        'ord_resetBTN
        '
        Me.ord_resetBTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ord_resetBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ord_resetBTN.Location = New System.Drawing.Point(307, 251)
        Me.ord_resetBTN.Name = "ord_resetBTN"
        Me.ord_resetBTN.Size = New System.Drawing.Size(84, 28)
        Me.ord_resetBTN.TabIndex = 94
        Me.ord_resetBTN.Text = "RESET"
        Me.ord_resetBTN.UseVisualStyleBackColor = False
        '
        'order_addBtn
        '
        Me.order_addBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.order_addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.order_addBtn.Location = New System.Drawing.Point(202, 251)
        Me.order_addBtn.Name = "order_addBtn"
        Me.order_addBtn.Size = New System.Drawing.Size(84, 28)
        Me.order_addBtn.TabIndex = 93
        Me.order_addBtn.Text = "ADD"
        Me.order_addBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Supplier ID : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Quantity : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Medicine Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Order ID : "
        '
        'medPrice_txbx
        '
        Me.medPrice_txbx.Location = New System.Drawing.Point(182, 212)
        Me.medPrice_txbx.Name = "medPrice_txbx"
        Me.medPrice_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medPrice_txbx.TabIndex = 88
        '
        'expDate_txbx
        '
        Me.expDate_txbx.Location = New System.Drawing.Point(182, 177)
        Me.expDate_txbx.Name = "expDate_txbx"
        Me.expDate_txbx.Size = New System.Drawing.Size(228, 20)
        Me.expDate_txbx.TabIndex = 87
        '
        'medName_txbx
        '
        Me.medName_txbx.Location = New System.Drawing.Point(182, 142)
        Me.medName_txbx.Name = "medName_txbx"
        Me.medName_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medName_txbx.TabIndex = 86
        '
        'medId_txbx
        '
        Me.medId_txbx.Location = New System.Drawing.Point(182, 107)
        Me.medId_txbx.Name = "medId_txbx"
        Me.medId_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medId_txbx.TabIndex = 85
        '
        'orderMgmtForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(582, 561)
        Me.Controls.Add(Me.ord_resetBTN)
        Me.Controls.Add(Me.order_addBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.medPrice_txbx)
        Me.Controls.Add(Me.expDate_txbx)
        Me.Controls.Add(Me.medName_txbx)
        Me.Controls.Add(Me.medId_txbx)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "orderMgmtForm"
        Me.Text = "orderMgmtForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meds_orderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PharmaDataSet As pharmaDataSet
    Friend WithEvents Meds_orderBindingSource As BindingSource
    Friend WithEvents Meds_orderTableAdapter As pharmaDataSetTableAdapters.meds_orderTableAdapter
    Friend WithEvents TableAdapterManager As pharmaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MednameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ord_resetBTN As Button
    Friend WithEvents order_addBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents medPrice_txbx As TextBox
    Friend WithEvents expDate_txbx As TextBox
    Friend WithEvents medName_txbx As TextBox
    Friend WithEvents medId_txbx As TextBox
End Class
