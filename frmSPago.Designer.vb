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
        Me.C1FlexReg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProDSet = New Registro.ProDSet()
        Me.c1btnSol = New C1.Win.C1Input.C1Button()
        Me.ContactoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1FlexGrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroTableAdapter = New Registro.ProDSetTableAdapters.RegistroTableAdapter()
        Me.ContactoTableAdapter = New Registro.ProDSetTableAdapters.ContactoTableAdapter()
        Me.TableAdapterManager = New Registro.ProDSetTableAdapters.TableAdapterManager()
        Me.PagosTableAdapter = New Registro.ProDSetTableAdapters.PagosTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        CType(Me.C1FlexReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1btnSol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexReg
        '
        Me.C1FlexReg.AllowDelete = True
        Me.C1FlexReg.AllowFiltering = True
        Me.C1FlexReg.AutoResize = True
        Me.C1FlexReg.ColumnInfo = resources.GetString("C1FlexReg.ColumnInfo")
        Me.C1FlexReg.DataSource = Me.RegistroBindingSource
        Me.C1FlexReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1FlexReg.IgnoreDiacritics = True
        Me.C1FlexReg.Location = New System.Drawing.Point(65, 165)
        Me.C1FlexReg.Name = "C1FlexReg"
        Me.C1FlexReg.Rows.Count = 1
        Me.C1FlexReg.Rows.DefaultSize = 16
        Me.C1FlexReg.Size = New System.Drawing.Size(581, 129)
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
        'c1btnSol
        '
        Me.c1btnSol.Location = New System.Drawing.Point(12, 174)
        Me.c1btnSol.Name = "c1btnSol"
        Me.c1btnSol.Size = New System.Drawing.Size(75, 23)
        Me.c1btnSol.TabIndex = 4
        Me.c1btnSol.Text = "bsd"
        Me.c1btnSol.UseVisualStyleBackColor = True
        Me.c1btnSol.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ContactoBindingSource
        '
        Me.ContactoBindingSource.DataMember = "Contacto"
        Me.ContactoBindingSource.DataSource = Me.ProDSet
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AutoResize = True
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.PagosBindingSource
        Me.C1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1FlexGrid1.Location = New System.Drawing.Point(296, 13)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 16
        Me.C1FlexGrid1.Size = New System.Drawing.Size(493, 134)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 6
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(714, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'C1FlexGrid2
        '
        Me.C1FlexGrid2.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.C1FlexGrid2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1FlexGrid2.Location = New System.Drawing.Point(12, 306)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.Size = New System.Drawing.Size(791, 150)
        Me.C1FlexGrid2.StyleInfo = resources.GetString("C1FlexGrid2.StyleInfo")
        Me.C1FlexGrid2.TabIndex = 8
        Me.C1FlexGrid2.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.ProDSet
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
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
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(663, 212)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 64)
        Me.Panel1.TabIndex = 9
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(801, 688)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.TabIndex = 10
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.C1SplitContainer1.UseParentVisualStyle = False
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.C1Combo1)
        Me.C1SplitterPanel1.Controls.Add(Me.Button1)
        Me.C1SplitterPanel1.Controls.Add(Me.C1FlexGrid2)
        Me.C1SplitterPanel1.Controls.Add(Me.Panel1)
        Me.C1SplitterPanel1.Controls.Add(Me.C1FlexReg)
        Me.C1SplitterPanel1.Controls.Add(Me.C1FlexGrid1)
        Me.C1SplitterPanel1.Controls.Add(Me.c1btnSol)
        Me.C1SplitterPanel1.Height = 688
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(801, 667)
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "Panel 1"
        '
        'C1Combo1
        '
        Me.C1Combo1.AllowColMove = False
        Me.C1Combo1.AllowColSelect = True
        Me.C1Combo1.AllowSort = False
        Me.C1Combo1.AutoCompletion = True
        Me.C1Combo1.AutoDropDown = True
        Me.C1Combo1.Caption = "Contacto"
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnHeaders = False
        Me.C1Combo1.ColumnWidth = 100
        Me.C1Combo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContactoBindingSource, "id", True))
        Me.C1Combo1.DataSource = Me.ContactoBindingSource
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.DisplayMember = "Contacto"
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.ExtendRightColumn = True
        Me.C1Combo1.FlatStyle = C1.Win.C1List.FlatModeEnum.Standard
        Me.C1Combo1.Images.Add(CType(resources.GetObject("C1Combo1.Images"), System.Drawing.Image))
        Me.C1Combo1.LimitToList = True
        Me.C1Combo1.Location = New System.Drawing.Point(65, 14)
        Me.C1Combo1.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.Size = New System.Drawing.Size(225, 21)
        Me.C1Combo1.TabIndex = 10
        Me.C1Combo1.Text = "Clientes"
        Me.C1Combo1.ValueMember = "idRegistro"
        Me.C1Combo1.VisualStyle = C1.Win.C1List.VisualStyle.Office2010Blue
        Me.C1Combo1.PropBag = resources.GetString("C1Combo1.PropBag")
        '
        'frmSPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 688)
        Me.Controls.Add(Me.C1SplitContainer1)
        Me.Name = "frmSPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSPago"
        CType(Me.C1FlexReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1btnSol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel1.PerformLayout()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProDSet As ProDSet
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As ProDSetTableAdapters.RegistroTableAdapter
    Friend WithEvents C1FlexReg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents c1btnSol As C1.Win.C1Input.C1Button
    Friend WithEvents ContactoBindingSource As BindingSource
    Friend WithEvents ContactoTableAdapter As ProDSetTableAdapters.ContactoTableAdapter
    Friend WithEvents TableAdapterManager As ProDSetTableAdapters.TableAdapterManager
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As ProDSetTableAdapters.PagosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents C1FlexGrid2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
End Class
