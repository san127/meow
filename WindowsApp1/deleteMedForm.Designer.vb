<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteMedForm
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
        Me.delMed_datagrid = New System.Windows.Forms.DataGridView()
        Me.MedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meds_inventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet = New WindowsApp1.pharmaDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.adminMenu_back = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.deleteMed_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.delMed_txbx = New System.Windows.Forms.TextBox()
        Me.Meds_inventoryTableAdapter = New WindowsApp1.pharmaDataSetTableAdapters.meds_inventoryTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.pharmaDataSetTableAdapters.TableAdapterManager()
        CType(Me.delMed_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(271, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "DELETE MEDICINES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(221, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PharmExcel"
        '
        'delMed_datagrid
        '
        Me.delMed_datagrid.AutoGenerateColumns = False
        Me.delMed_datagrid.BackgroundColor = System.Drawing.Color.LightCyan
        Me.delMed_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.delMed_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedIDDataGridViewTextBoxColumn, Me.MedicineDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.ExpirationdateDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.delMed_datagrid.DataSource = Me.Meds_inventoryBindingSource
        Me.delMed_datagrid.Location = New System.Drawing.Point(12, 203)
        Me.delMed_datagrid.Name = "delMed_datagrid"
        Me.delMed_datagrid.Size = New System.Drawing.Size(657, 179)
        Me.delMed_datagrid.TabIndex = 85
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 75)
        Me.Panel1.TabIndex = 83
        '
        'adminMenu_back
        '
        Me.adminMenu_back.BackColor = System.Drawing.Color.SkyBlue
        Me.adminMenu_back.Location = New System.Drawing.Point(292, -2)
        Me.adminMenu_back.Name = "adminMenu_back"
        Me.adminMenu_back.Size = New System.Drawing.Size(75, 22)
        Me.adminMenu_back.TabIndex = 24
        Me.adminMenu_back.Text = "Back"
        Me.adminMenu_back.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.adminMenu_back)
        Me.Panel2.Location = New System.Drawing.Point(-1, 400)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 22)
        Me.Panel2.TabIndex = 84
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(350, 150)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 28)
        Me.Button8.TabIndex = 89
        Me.Button8.Text = "RESET"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'deleteMed_btn
        '
        Me.deleteMed_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.deleteMed_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteMed_btn.Location = New System.Drawing.Point(243, 150)
        Me.deleteMed_btn.Name = "deleteMed_btn"
        Me.deleteMed_btn.Size = New System.Drawing.Size(84, 28)
        Me.deleteMed_btn.TabIndex = 88
        Me.deleteMed_btn.Text = "DELETE"
        Me.deleteMed_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Medicine ID : "
        '
        'delMed_txbx
        '
        Me.delMed_txbx.Location = New System.Drawing.Point(226, 115)
        Me.delMed_txbx.Name = "delMed_txbx"
        Me.delMed_txbx.Size = New System.Drawing.Size(228, 20)
        Me.delMed_txbx.TabIndex = 86
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
        'deleteMedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(679, 427)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.deleteMed_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.delMed_txbx)
        Me.Controls.Add(Me.delMed_datagrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "deleteMedForm"
        Me.Text = "deleteMedForm"
        CType(Me.delMed_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meds_inventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents delMed_datagrid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents adminMenu_back As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents deleteMed_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents delMed_txbx As TextBox
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
