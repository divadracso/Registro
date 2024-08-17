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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSPago))
        Dim FooterDescription13 As C1.Win.C1FlexGrid.FooterDescription = New C1.Win.C1FlexGrid.FooterDescription()
        Dim AggregateDefinition13 As C1.Win.C1FlexGrid.AggregateDefinition = New C1.Win.C1FlexGrid.AggregateDefinition()
        Dim AggregateDefinition14 As C1.Win.C1FlexGrid.AggregateDefinition = New C1.Win.C1FlexGrid.AggregateDefinition()
        Dim FooterDescription14 As C1.Win.C1FlexGrid.FooterDescription = New C1.Win.C1FlexGrid.FooterDescription()
        Dim AggregateDefinition15 As C1.Win.C1FlexGrid.AggregateDefinition = New C1.Win.C1FlexGrid.AggregateDefinition()
        Dim FooterDescription15 As C1.Win.C1FlexGrid.FooterDescription = New C1.Win.C1FlexGrid.FooterDescription()
        Me.C1FlexReg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProDSet = New Registro.ProDSet()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.RegistroTableAdapter = New Registro.ProDSetTableAdapters.RegistroTableAdapter()
        Me.ContactoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactoTableAdapter = New Registro.ProDSetTableAdapters.ContactoTableAdapter()
        Me.TableAdapterManager = New Registro.ProDSetTableAdapters.TableAdapterManager()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosTableAdapter = New Registro.ProDSetTableAdapters.PagosTableAdapter()
        CType(Me.C1FlexReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexReg
        '
        Me.C1FlexReg.AllowAddNew = True
        Me.C1FlexReg.AllowDelete = True
        Me.C1FlexReg.AllowFiltering = True
        Me.C1FlexReg.ColumnInfo = resources.GetString("C1FlexReg.ColumnInfo")
        Me.C1FlexReg.DataSource = Me.RegistroBindingSource
        AggregateDefinition13.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Count
        AggregateDefinition13.Column = 1
        AggregateDefinition14.Column = 2
        FooterDescription13.Aggregates.Add(AggregateDefinition13)
        FooterDescription13.Aggregates.Add(AggregateDefinition14)
        AggregateDefinition15.Caption = "hola"
        AggregateDefinition15.Column = 2
        AggregateDefinition15.Expression = "3+3"
        FooterDescription14.Aggregates.Add(AggregateDefinition15)
        Me.C1FlexReg.Footers.Descriptions.Add(FooterDescription13)
        Me.C1FlexReg.Footers.Descriptions.Add(FooterDescription14)
        Me.C1FlexReg.Footers.Descriptions.Add(FooterDescription15)
        Me.C1FlexReg.IgnoreDiacritics = True
        Me.C1FlexReg.Location = New System.Drawing.Point(3, 242)
        Me.C1FlexReg.Name = "C1FlexReg"
        Me.C1FlexReg.Rows.Count = 4
        Me.C1FlexReg.Size = New System.Drawing.Size(810, 183)
        Me.C1FlexReg.StyleInfo = resources.GetString("C1FlexReg.StyleInfo")
        Me.C1FlexReg.TabIndex = 1
        Me.C1FlexReg.Tree.Column = 0
        Me.C1FlexReg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
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
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(12, 97)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(75, 23)
        Me.C1Button1.TabIndex = 4
        Me.C1Button1.Text = "C1Button1"
        Me.C1Button1.UseVisualStyleBackColor = True
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
        'C1Combo1
        '
        Me.C1Combo1.AllowColSelect = True
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnWidth = 100
        Me.C1Combo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactoBindingSource, "Contacto", True))
        Me.C1Combo1.DataSource = Me.ContactoBindingSource
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.DisplayMember = "Contacto"
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.Images.Add(CType(resources.GetObject("C1Combo1.Images"), System.Drawing.Image))
        Me.C1Combo1.Location = New System.Drawing.Point(12, 45)
        Me.C1Combo1.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.Size = New System.Drawing.Size(121, 21)
        Me.C1Combo1.TabIndex = 5
        Me.C1Combo1.Text = "C1Combo1"
        Me.C1Combo1.ValueMember = "id"
        Me.C1Combo1.VisualStyle = C1.Win.C1List.VisualStyle.Office2010Blue
        Me.C1Combo1.PropBag = resources.GetString("C1Combo1.PropBag")
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.PagosBindingSource
        Me.C1FlexGrid1.Location = New System.Drawing.Point(269, 19)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Size = New System.Drawing.Size(503, 134)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 6
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.ProDSet
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'frmSPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 688)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1Combo1)
        Me.Controls.Add(Me.C1FlexReg)
        Me.Controls.Add(Me.C1Button1)
        Me.Name = "frmSPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSPago"
        CType(Me.C1FlexReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProDSet As ProDSet
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As ProDSetTableAdapters.RegistroTableAdapter
    Friend WithEvents C1FlexReg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents ContactoBindingSource As BindingSource
    Friend WithEvents ContactoTableAdapter As ProDSetTableAdapters.ContactoTableAdapter
    Friend WithEvents TableAdapterManager As ProDSetTableAdapters.TableAdapterManager
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As ProDSetTableAdapters.PagosTableAdapter
End Class
