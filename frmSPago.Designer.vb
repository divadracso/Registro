<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FooterDescription1 As C1.Win.C1FlexGrid.FooterDescription = New C1.Win.C1FlexGrid.FooterDescription()
        Dim AggregateDefinition1 As C1.Win.C1FlexGrid.AggregateDefinition = New C1.Win.C1FlexGrid.AggregateDefinition()
        Dim AggregateDefinition2 As C1.Win.C1FlexGrid.AggregateDefinition = New C1.Win.C1FlexGrid.AggregateDefinition()
        Dim FooterDescription2 As C1.Win.C1FlexGrid.FooterDescription = New C1.Win.C1FlexGrid.FooterDescription()
        Dim AggregateDefinition3 As C1.Win.C1FlexGrid.AggregateDefinition = New C1.Win.C1FlexGrid.AggregateDefinition()
        Dim FooterDescription3 As C1.Win.C1FlexGrid.FooterDescription = New C1.Win.C1FlexGrid.FooterDescription()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSPago))
        Me.C1FlexGridGroupPanel1 = New C1.Win.C1FlexGrid.C1FlexGridGroupPanel()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1FlexGridSearchPanel1 = New C1.Win.C1FlexGrid.C1FlexGridSearchPanel()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProDSet = New Registro.ProDSet()
        Me.RegistroTableAdapter = New Registro.ProDSetTableAdapters.RegistroTableAdapter()
        Me.ContactoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactoTableAdapter = New Registro.ProDSetTableAdapters.ContactoTableAdapter()
        Me.TableAdapterManager = New Registro.ProDSetTableAdapters.TableAdapterManager()
        Me.ContactoDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGridGroupPanel1
        '
        Me.C1FlexGridGroupPanel1.FlexGrid = Me.C1FlexGrid1
        Me.C1FlexGridGroupPanel1.Location = New System.Drawing.Point(554, 316)
        Me.C1FlexGridGroupPanel1.Name = "C1FlexGridGroupPanel1"
        Me.C1FlexGridGroupPanel1.Size = New System.Drawing.Size(243, 122)
        Me.C1FlexGridGroupPanel1.TabIndex = 0
        Me.C1FlexGridGroupPanel1.Text = "C1FlexGridGroupPanel1"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowAddNew = True
        Me.C1FlexGrid1.AllowDelete = True
        Me.C1FlexGrid1.AllowFiltering = True
        Me.C1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(Me.C1FlexGrid1, Me.C1FlexGridSearchPanel1)
        Me.C1FlexGrid1.ColumnInfo = "16,1,0,0,0,-1,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Aggregate:Count;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Aggregate:Count;}" & Global.Microsoft.VisualBasic.ChrW(9) & "6{Aggr" &
    "egate:Count;}" & Global.Microsoft.VisualBasic.ChrW(9) & "14{Aggregate:Sum;}" & Global.Microsoft.VisualBasic.ChrW(9) & "15{Visible:False;AllowEditing:False;}" & Global.Microsoft.VisualBasic.ChrW(9)
        AggregateDefinition1.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Count
        AggregateDefinition1.Column = 1
        AggregateDefinition2.Column = 2
        FooterDescription1.Aggregates.Add(AggregateDefinition1)
        FooterDescription1.Aggregates.Add(AggregateDefinition2)
        AggregateDefinition3.Caption = "hola"
        AggregateDefinition3.Column = 2
        AggregateDefinition3.Expression = "3+3"
        FooterDescription2.Aggregates.Add(AggregateDefinition3)
        Me.C1FlexGrid1.Footers.Descriptions.Add(FooterDescription1)
        Me.C1FlexGrid1.Footers.Descriptions.Add(FooterDescription2)
        Me.C1FlexGrid1.Footers.Descriptions.Add(FooterDescription3)
        Me.C1FlexGrid1.IgnoreDiacritics = True
        Me.C1FlexGrid1.Location = New System.Drawing.Point(286, 205)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 4
        Me.C1FlexGrid1.Size = New System.Drawing.Size(173, 183)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 1
        Me.C1FlexGrid1.Tree.Column = 0
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1FlexGridSearchPanel1
        '
        Me.C1FlexGridSearchPanel1.AutoScroll = True
        Me.C1FlexGridSearchPanel1.Location = New System.Drawing.Point(506, 255)
        Me.C1FlexGridSearchPanel1.Name = "C1FlexGridSearchPanel1"
        Me.C1FlexGridSearchPanel1.SearchMode = C1.Win.C1FlexGrid.SearchMode.Always
        Me.C1FlexGridSearchPanel1.Size = New System.Drawing.Size(299, 296)
        Me.C1FlexGridSearchPanel1.TabIndex = 3
        Me.C1FlexGridSearchPanel1.Watermark = "Entre texto a buscar..."
        '
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(498, 386)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(75, 23)
        Me.C1Button1.TabIndex = 4
        Me.C1Button1.Text = "C1Button1"
        Me.C1Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(465, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(181, 118)
        Me.DataGridView1.TabIndex = 5
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "Registro"
        Me.RegistroBindingSource.DataSource = Me.ProDSet
        '
        'ProDSet
        '
        Me.ProDSet.DataSetName = "ProDSet"
        Me.ProDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'ContactoBindingSource
        '
        Me.ContactoBindingSource.DataMember = "Contacto"
        Me.ContactoBindingSource.DataSource = Me.ProDSet
        '
        'ContactoTableAdapter
        '
        Me.ContactoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ContactoTableAdapter = Me.ContactoTableAdapter
        Me.TableAdapterManager.ListadoTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NotasTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Nothing
        Me.TableAdapterManager.TelefonoTableAdapter = Nothing
        Me.TableAdapterManager.TipoAvaTableAdapter = Nothing
        Me.TableAdapterManager.TipoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Registro.ProDSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ContactoDataGridView
        '
        Me.ContactoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactoDataGridView.Location = New System.Drawing.Point(9, 15)
        Me.ContactoDataGridView.Name = "ContactoDataGridView"
        Me.ContactoDataGridView.Size = New System.Drawing.Size(395, 148)
        Me.ContactoDataGridView.TabIndex = 5
        '
        'frmSPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 688)
        Me.Controls.Add(Me.ContactoDataGridView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1FlexGridGroupPanel1)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.C1FlexGridSearchPanel1)
        Me.Name = "frmSPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSPago"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProDSet As ProDSet
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As ProDSetTableAdapters.RegistroTableAdapter
    Friend WithEvents C1FlexGridGroupPanel1 As C1.Win.C1FlexGrid.C1FlexGridGroupPanel
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGridSearchPanel1 As C1.Win.C1FlexGrid.C1FlexGridSearchPanel
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContactoBindingSource As BindingSource
    Friend WithEvents ContactoTableAdapter As ProDSetTableAdapters.ContactoTableAdapter
    Friend WithEvents TableAdapterManager As ProDSetTableAdapters.TableAdapterManager
    Friend WithEvents ContactoDataGridView As DataGridView
End Class
