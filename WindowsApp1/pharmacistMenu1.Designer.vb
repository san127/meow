<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pharmacistMenu1
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.adminMenu_back = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.medCategory_combx = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.medQty_txbx = New System.Windows.Forms.TextBox()
        Me.medPrice_txbx = New System.Windows.Forms.TextBox()
        Me.expDate_txbx = New System.Windows.Forms.TextBox()
        Me.medName_txbx = New System.Windows.Forms.TextBox()
        Me.medId_txbx = New System.Windows.Forms.TextBox()
        Me.addmed_datagrid = New System.Windows.Forms.DataGridView()
        Me.MedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meds_inventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet = New WindowsApp1.pharmaDataSet()
        Me.add_inventBtn = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Meds_inventoryTableAdapter = New WindowsApp1.pharmaDataSetTableAdapters.meds_inventoryTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.addmed_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.adminMenu_back)
        Me.Panel2.Location = New System.Drawing.Point(0, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 22)
        Me.Panel2.TabIndex = 44
        '
        'adminMenu_back
        '
        Me.adminMenu_back.BackColor = System.Drawing.Color.SkyBlue
        Me.adminMenu_back.Location = New System.Drawing.Point(309, -2)
        Me.adminMenu_back.Name = "adminMenu_back"
        Me.adminMenu_back.Size = New System.Drawing.Size(75, 22)
        Me.adminMenu_back.TabIndex = 24
        Me.adminMenu_back.Text = "Back"
        Me.adminMenu_back.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 75)
        Me.Panel1.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(286, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "ADD MEDICINES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(227, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'medCategory_combx
        '
        Me.medCategory_combx.FormattingEnabled = True
        Me.medCategory_combx.Items.AddRange(New Object() {"Pain Killer", "Anti-Depression"})
        Me.medCategory_combx.Location = New System.Drawing.Point(244, 156)
        Me.medCategory_combx.Name = "medCategory_combx"
        Me.medCategory_combx.Size = New System.Drawing.Size(227, 21)
        Me.medCategory_combx.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Quantity : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Price : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Expiry Date : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Category : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Medicine Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Medicine ID : "
        '
        'medQty_txbx
        '
        Me.medQty_txbx.Location = New System.Drawing.Point(244, 259)
        Me.medQty_txbx.Name = "medQty_txbx"
        Me.medQty_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medQty_txbx.TabIndex = 74
        '
        'medPrice_txbx
        '
        Me.medPrice_txbx.Location = New System.Drawing.Point(244, 225)
        Me.medPrice_txbx.Name = "medPrice_txbx"
        Me.medPrice_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medPrice_txbx.TabIndex = 73
        '
        'expDate_txbx
        '
        Me.expDate_txbx.Location = New System.Drawing.Point(244, 191)
        Me.expDate_txbx.Name = "expDate_txbx"
        Me.expDate_txbx.Size = New System.Drawing.Size(228, 20)
        Me.expDate_txbx.TabIndex = 72
        '
        'medName_txbx
        '
        Me.medName_txbx.Location = New System.Drawing.Point(244, 123)
        Me.medName_txbx.Name = "medName_txbx"
        Me.medName_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medName_txbx.TabIndex = 71
        '
        'medId_txbx
        '
        Me.medId_txbx.Location = New System.Drawing.Point(243, 89)
        Me.medId_txbx.Name = "medId_txbx"
        Me.medId_txbx.Size = New System.Drawing.Size(228, 20)
        Me.medId_txbx.TabIndex = 68
        '
        'addmed_datagrid
        '
        Me.addmed_datagrid.AutoGenerateColumns = False
        Me.addmed_datagrid.BackgroundColor = System.Drawing.Color.LightCyan
        Me.addmed_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.addmed_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedIDDataGridViewTextBoxColumn, Me.MedicineDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.ExpirationdateDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.addmed_datagrid.DataSource = Me.Meds_inventoryBindingSource
        Me.addmed_datagrid.Location = New System.Drawing.Point(13, 324)
        Me.addmed_datagrid.Name = "addmed_datagrid"
        Me.addmed_datagrid.Size = New System.Drawing.Size(667, 197)
        Me.addmed_datagrid.TabIndex = 82
        '
        'MedIDDataGridViewTextBoxColumn
        '
        Me.MedIDDataGridViewTextBoxColumn.DataPropertyName = "Med_ID"
        Me.MedIDDataGridViewTextBoxColumn.HeaderText = "Med_ID"
        Me.MedIDDataGridViewTextBoxColumn.Name = "MedIDDataGridViewTextBoxColumn"
        '
        'MedicineDataGridViewTextBoxColumn
        '
        Me.MedicineDataGridViewTextBoxColumn.DataPropertyName = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.HeaderText = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.Name = "MedicineDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'ExpirationdateDataGridViewTextBoxColumn
        '
        Me.ExpirationdateDataGridViewTextBoxColumn.DataPropertyName = "expiration_date"
        Me.ExpirationdateDataGridViewTextBoxColumn.HeaderText = "expiration_date"
        Me.ExpirationdateDataGridViewTextBoxColumn.Name = "ExpirationdateDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'Meds_inventoryBindingSource
        '
        Me.Meds_inventoryBindingSource.DataMember = "meds_inventory"
        Me.Meds_inventoryBindingSource.DataSource = Me.PharmaDataSet
        '
        'PharmaDataSet
        '
        Me.PharmaDataSet.DataSetName = "pharmaDataSet"
        Me.PharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'add_inventBtn
        '
        Me.add_inventBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.add_inventBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_inventBtn.Location = New System.Drawing.Point(261, 289)
        Me.add_inventBtn.Name = "add_inventBtn"
        Me.add_inventBtn.Size = New System.Drawing.Size(84, 28)
        Me.add_inventBtn.TabIndex = 83
        Me.add_inventBtn.Text = "ADD"
        Me.add_inventBtn.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(366, 289)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 28)
        Me.Button8.TabIndex = 84
        Me.Button8.Text = "RESET"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Meds_inventoryTableAdapter
        '
        Me.Meds_inventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.meds_inventoryTableAdapter = Me.Meds_inventoryTableAdapter
        Me.TableAdapterManager.meds_orderTableAdapter = Nothing
        Me.TableAdapterManager.meds_supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'pharmacistMenu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(690, 561)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.add_inventBtn)
        Me.Controls.Add(Me.addmed_datagrid)
        Me.Controls.Add(Me.medCategory_combx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.medQty_txbx)
        Me.Controls.Add(Me.medPrice_txbx)
        Me.Controls.Add(Me.expDate_txbx)
        Me.Controls.Add(Me.medName_txbx)
        Me.Controls.Add(Me.medId_txbx)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pharmacistMenu1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pharmacistMenu1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.addmed_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents adminMenu_back As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents medCategory_combx As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents medQty_txbx As TextBox
    Friend WithEvents medPrice_txbx As TextBox
    Friend WithEvents expDate_txbx As TextBox
    Friend WithEvents medName_txbx As TextBox
    Friend WithEvents medId_txbx As TextBox
    Friend WithEvents addmed_datagrid As DataGridView
    Friend WithEvents add_inventBtn As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PharmaDataSet As pharmaDataSet
    Friend WithEvents Meds_inventoryBindingSource As BindingSource
    Friend WithEvents Meds_inventoryTableAdapter As pharmaDataSetTableAdapters.meds_inventoryTableAdapter
    Friend WithEvents TableAdapterManager As pharmaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpirationdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
