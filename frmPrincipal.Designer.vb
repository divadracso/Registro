<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Status_del_avalúoLabel As System.Windows.Forms.Label
        Dim Status_del_pagoLabel As System.Windows.Forms.Label
        Dim Campo10Label As System.Windows.Forms.Label
        Dim FolioLabel As System.Windows.Forms.Label
        Dim Fecha_ingr_a_catastro_o_de_auorizaciónLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Nombre_clienteLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim Solicitado_porLabel As System.Windows.Forms.Label
        Dim MunicipioLabel As System.Windows.Forms.Label
        Dim Núm_escr_o_de_clienteLabel As System.Windows.Forms.Label
        Dim Tipo_de_avalúoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.GpoPrincipal = New System.Windows.Forms.GroupBox()
        Me.C1txtCosto = New C1.Win.C1Input.C1TextBox()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProDSet = New Registro.ProDSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1CboMun = New C1.Win.C1List.C1Combo()
        Me.MunicipioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1CboTipo = New C1.Win.C1List.C1Combo()
        Me.TipoAvaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1CboCli = New C1.Win.C1List.C1Combo()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1CboSol = New C1.Win.C1List.C1Combo()
        Me.ContactoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1TextBox9 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox8 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox7 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox5 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1DateSol = New C1.Win.Calendar.C1DateEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnComentar = New C1.Win.C1Input.C1Button()
        Me.C1txtNotas = New C1.Win.C1Input.C1TextBox()
        Me.NotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1FlexGridSearchPanel1 = New C1.Win.C1FlexGrid.C1FlexGridSearchPanel()
        Me.RegistroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.GpoStatus = New System.Windows.Forms.GroupBox()
        Me.rbtnCancel = New System.Windows.Forms.RadioButton()
        Me.rbtnProceso = New System.Windows.Forms.RadioButton()
        Me.rbtnSolicitado = New System.Windows.Forms.RadioButton()
        Me.rbtnTerminado = New System.Windows.Forms.RadioButton()
        Me.rbtnAuto = New System.Windows.Forms.RadioButton()
        Me.rbtnCorre = New System.Windows.Forms.RadioButton()
        Me.rbtnListoEn = New System.Windows.Forms.RadioButton()
        Me.rbtnEnCe = New System.Windows.Forms.RadioButton()
        Me.txtPagos = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1FlexGridGroupPanel1 = New C1.Win.C1FlexGrid.C1FlexGridGroupPanel()
        Me.C1SplitterPanel3 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1FlexPagos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.RegistroPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.miniToolStrip = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.RegistroTableAdapter = New Registro.ProDSetTableAdapters.RegistroTableAdapter()
        Me.TableAdapterManager = New Registro.ProDSetTableAdapters.TableAdapterManager()
        Me.NotasTableAdapter = New Registro.ProDSetTableAdapters.NotasTableAdapter()
        Me.PagosTableAdapter = New Registro.ProDSetTableAdapters.PagosTableAdapter()
        Me.TipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoTableAdapter = New Registro.ProDSetTableAdapters.TipoTableAdapter()
        Me.ClienteTableAdapter = New Registro.ProDSetTableAdapters.ClienteTableAdapter()
        Me.TipoAvaTableAdapter = New Registro.ProDSetTableAdapters.TipoAvaTableAdapter()
        Me.MunicipioTableAdapter = New Registro.ProDSetTableAdapters.MunicipioTableAdapter()
        Me.ContactoTableAdapter = New Registro.ProDSetTableAdapters.ContactoTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        Status_del_avalúoLabel = New System.Windows.Forms.Label()
        Status_del_pagoLabel = New System.Windows.Forms.Label()
        Campo10Label = New System.Windows.Forms.Label()
        FolioLabel = New System.Windows.Forms.Label()
        Fecha_ingr_a_catastro_o_de_auorizaciónLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Nombre_clienteLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        Solicitado_porLabel = New System.Windows.Forms.Label()
        MunicipioLabel = New System.Windows.Forms.Label()
        Núm_escr_o_de_clienteLabel = New System.Windows.Forms.Label()
        Tipo_de_avalúoLabel = New System.Windows.Forms.Label()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        Me.GpoPrincipal.SuspendLayout()
        CType(Me.C1txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CboMun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoAvaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CboCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CboSol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateSol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnComentar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1txtNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistroBindingNavigator.SuspendLayout()
        Me.GpoStatus.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel3.SuspendLayout()
        CType(Me.C1FlexPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.miniToolStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(38, 41)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 99
        IdLabel.Text = "Id:"
        '
        'Status_del_avalúoLabel
        '
        Status_del_avalúoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Status_del_avalúoLabel.AutoSize = True
        Status_del_avalúoLabel.Location = New System.Drawing.Point(2, 5)
        Status_del_avalúoLabel.Name = "Status_del_avalúoLabel"
        Status_del_avalúoLabel.Size = New System.Drawing.Size(92, 13)
        Status_del_avalúoLabel.TabIndex = 25
        Status_del_avalúoLabel.Text = "Status del avalúo:"
        '
        'Status_del_pagoLabel
        '
        Status_del_pagoLabel.AutoSize = True
        Status_del_pagoLabel.Location = New System.Drawing.Point(0, 232)
        Status_del_pagoLabel.Name = "Status_del_pagoLabel"
        Status_del_pagoLabel.Size = New System.Drawing.Size(67, 13)
        Status_del_pagoLabel.TabIndex = 89
        Status_del_pagoLabel.Text = "Status pago:"
        '
        'Campo10Label
        '
        Campo10Label.AutoSize = True
        Campo10Label.Location = New System.Drawing.Point(0, 212)
        Campo10Label.Name = "Campo10Label"
        Campo10Label.Size = New System.Drawing.Size(55, 13)
        Campo10Label.TabIndex = 88
        Campo10Label.Text = "Campo10:"
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Location = New System.Drawing.Point(0, 35)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(32, 13)
        FolioLabel.TabIndex = 74
        FolioLabel.Text = "Folio:"
        '
        'Fecha_ingr_a_catastro_o_de_auorizaciónLabel
        '
        Fecha_ingr_a_catastro_o_de_auorizaciónLabel.AutoSize = True
        Fecha_ingr_a_catastro_o_de_auorizaciónLabel.Location = New System.Drawing.Point(0, 194)
        Fecha_ingr_a_catastro_o_de_auorizaciónLabel.Name = "Fecha_ingr_a_catastro_o_de_auorizaciónLabel"
        Fecha_ingr_a_catastro_o_de_auorizaciónLabel.Size = New System.Drawing.Size(191, 13)
        Fecha_ingr_a_catastro_o_de_auorizaciónLabel.TabIndex = 87
        Fecha_ingr_a_catastro_o_de_auorizaciónLabel.Text = "Fecha ingr a catastro o de auorización:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(0, 55)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 76
        FechaLabel.Text = "Fecha:"
        '
        'Nombre_clienteLabel
        '
        Nombre_clienteLabel.AutoSize = True
        Nombre_clienteLabel.Location = New System.Drawing.Point(0, 175)
        Nombre_clienteLabel.Name = "Nombre_clienteLabel"
        Nombre_clienteLabel.Size = New System.Drawing.Size(42, 13)
        Nombre_clienteLabel.TabIndex = 86
        Nombre_clienteLabel.Text = "Cliente:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(0, 72)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioLabel.TabIndex = 78
        DomicilioLabel.Text = "Domicilio:"
        '
        'Solicitado_porLabel
        '
        Solicitado_porLabel.AutoSize = True
        Solicitado_porLabel.Location = New System.Drawing.Point(0, 155)
        Solicitado_porLabel.Name = "Solicitado_porLabel"
        Solicitado_porLabel.Size = New System.Drawing.Size(44, 13)
        Solicitado_porLabel.TabIndex = 85
        Solicitado_porLabel.Text = "Solicitó:"
        '
        'MunicipioLabel
        '
        MunicipioLabel.AutoSize = True
        MunicipioLabel.Location = New System.Drawing.Point(0, 95)
        MunicipioLabel.Name = "MunicipioLabel"
        MunicipioLabel.Size = New System.Drawing.Size(55, 13)
        MunicipioLabel.TabIndex = 79
        MunicipioLabel.Text = "Municipio:"
        '
        'Núm_escr_o_de_clienteLabel
        '
        Núm_escr_o_de_clienteLabel.AutoSize = True
        Núm_escr_o_de_clienteLabel.Location = New System.Drawing.Point(0, 134)
        Núm_escr_o_de_clienteLabel.Name = "Núm_escr_o_de_clienteLabel"
        Núm_escr_o_de_clienteLabel.Size = New System.Drawing.Size(113, 13)
        Núm_escr_o_de_clienteLabel.TabIndex = 84
        Núm_escr_o_de_clienteLabel.Text = "Núm escr o de cliente:"
        '
        'Tipo_de_avalúoLabel
        '
        Tipo_de_avalúoLabel.AutoSize = True
        Tipo_de_avalúoLabel.Location = New System.Drawing.Point(0, 117)
        Tipo_de_avalúoLabel.Name = "Tipo_de_avalúoLabel"
        Tipo_de_avalúoLabel.Size = New System.Drawing.Size(53, 13)
        Tipo_de_avalúoLabel.TabIndex = 82
        Tipo_de_avalúoLabel.Text = "T. Avalúo"
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.EnlargeCollapsingHandle = True
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel3)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(764, 526)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.TabIndex = 38
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.C1SplitContainer1.UseParentVisualStyle = False
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.AutoScroll = True
        Me.C1SplitterPanel1.Collapsible = True
        Me.C1SplitterPanel1.Controls.Add(Me.GpoPrincipal)
        Me.C1SplitterPanel1.Controls.Add(Me.BindingNavigator1)
        Me.C1SplitterPanel1.Height = 322
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.ResizeWhileDragging = True
        Me.C1SplitterPanel1.ShowCloseButton = True
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(764, 311)
        Me.C1SplitterPanel1.SizeRatio = 61.686R
        Me.C1SplitterPanel1.TabIndex = 0
        '
        'GpoPrincipal
        '
        Me.GpoPrincipal.Controls.Add(Me.C1txtCosto)
        Me.GpoPrincipal.Controls.Add(Me.Button1)
        Me.GpoPrincipal.Controls.Add(Me.C1CboMun)
        Me.GpoPrincipal.Controls.Add(Me.C1CboTipo)
        Me.GpoPrincipal.Controls.Add(Me.C1CboCli)
        Me.GpoPrincipal.Controls.Add(Me.C1CboSol)
        Me.GpoPrincipal.Controls.Add(Me.C1TextBox9)
        Me.GpoPrincipal.Controls.Add(Me.C1TextBox8)
        Me.GpoPrincipal.Controls.Add(Me.C1TextBox7)
        Me.GpoPrincipal.Controls.Add(Me.C1TextBox5)
        Me.GpoPrincipal.Controls.Add(Me.C1TextBox2)
        Me.GpoPrincipal.Controls.Add(Me.C1TextBox1)
        Me.GpoPrincipal.Controls.Add(Me.C1DateSol)
        Me.GpoPrincipal.Controls.Add(Fecha_ingr_a_catastro_o_de_auorizaciónLabel)
        Me.GpoPrincipal.Controls.Add(Me.Panel1)
        Me.GpoPrincipal.Controls.Add(Me.C1FlexGridSearchPanel1)
        Me.GpoPrincipal.Controls.Add(IdLabel)
        Me.GpoPrincipal.Controls.Add(Me.RegistroBindingNavigator)
        Me.GpoPrincipal.Controls.Add(Me.IdTextBox)
        Me.GpoPrincipal.Controls.Add(Me.GpoStatus)
        Me.GpoPrincipal.Controls.Add(Me.txtPagos)
        Me.GpoPrincipal.Controls.Add(Status_del_pagoLabel)
        Me.GpoPrincipal.Controls.Add(Campo10Label)
        Me.GpoPrincipal.Controls.Add(FolioLabel)
        Me.GpoPrincipal.Controls.Add(FechaLabel)
        Me.GpoPrincipal.Controls.Add(Nombre_clienteLabel)
        Me.GpoPrincipal.Controls.Add(DomicilioLabel)
        Me.GpoPrincipal.Controls.Add(Solicitado_porLabel)
        Me.GpoPrincipal.Controls.Add(MunicipioLabel)
        Me.GpoPrincipal.Controls.Add(Núm_escr_o_de_clienteLabel)
        Me.GpoPrincipal.Controls.Add(Tipo_de_avalúoLabel)
        Me.GpoPrincipal.Location = New System.Drawing.Point(3, 6)
        Me.GpoPrincipal.Name = "GpoPrincipal"
        Me.GpoPrincipal.Size = New System.Drawing.Size(758, 253)
        Me.GpoPrincipal.TabIndex = 63
        Me.GpoPrincipal.TabStop = False
        '
        'C1txtCosto
        '
        Me.C1txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Costo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.C1txtCosto.DataType = GetType(Decimal)
        Me.C1txtCosto.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1txtCosto.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1txtCosto.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1txtCosto.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1txtCosto.Location = New System.Drawing.Point(654, 230)
        Me.C1txtCosto.Name = "C1txtCosto"
        Me.C1txtCosto.Size = New System.Drawing.Size(107, 18)
        Me.C1txtCosto.TabIndex = 101
        Me.C1txtCosto.Tag = Nothing
        Me.C1txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.C1txtCosto.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1txtCosto.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'C1CboMun
        '
        Me.C1CboMun.AllowColSelect = True
        Me.C1CboMun.AutoSize = False
        Me.C1CboMun.Caption = ""
        Me.C1CboMun.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1CboMun.ColumnHeaders = False
        Me.C1CboMun.ColumnWidth = 100
        Me.C1CboMun.ContentHeight = 11
        Me.C1CboMun.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Municipio", True))
        Me.C1CboMun.DataSource = Me.MunicipioBindingSource
        Me.C1CboMun.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1CboMun.DisplayMember = "Municipio"
        Me.C1CboMun.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1CboMun.ExtendRightColumn = True
        Me.C1CboMun.FlatStyle = C1.Win.C1List.FlatModeEnum.Standard
        Me.C1CboMun.Images.Add(CType(resources.GetObject("C1CboMun.Images"), System.Drawing.Image))
        Me.C1CboMun.ItemHeight = 13
        Me.C1CboMun.Location = New System.Drawing.Point(161, 93)
        Me.C1CboMun.MatchEntryTimeout = CType(2000, Long)
        Me.C1CboMun.MaxDropDownItems = CType(5, Short)
        Me.C1CboMun.MaxLength = 32767
        Me.C1CboMun.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1CboMun.Name = "C1CboMun"
        Me.C1CboMun.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1CboMun.Size = New System.Drawing.Size(200, 17)
        Me.C1CboMun.TabIndex = 97
        Me.C1CboMun.Tag = "Municipio"
        Me.C1CboMun.ValueMember = "Municipio"
        Me.C1CboMun.VisualStyle = C1.Win.C1List.VisualStyle.Office2010Blue
        Me.C1CboMun.PropBag = resources.GetString("C1CboMun.PropBag")
        '
        'MunicipioBindingSource
        '
        Me.MunicipioBindingSource.DataMember = "Municipio"
        Me.MunicipioBindingSource.DataSource = Me.ProDSet
        '
        'C1CboTipo
        '
        Me.C1CboTipo.AllowColSelect = True
        Me.C1CboTipo.AutoSize = False
        Me.C1CboTipo.Caption = ""
        Me.C1CboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1CboTipo.ColumnHeaders = False
        Me.C1CboTipo.ColumnWidth = 100
        Me.C1CboTipo.ContentHeight = 11
        Me.C1CboTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "tipo de avalúo", True))
        Me.C1CboTipo.DataSource = Me.TipoAvaBindingSource
        Me.C1CboTipo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1CboTipo.DisplayMember = "TipoAva"
        Me.C1CboTipo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1CboTipo.ExtendRightColumn = True
        Me.C1CboTipo.FlatStyle = C1.Win.C1List.FlatModeEnum.Standard
        Me.C1CboTipo.Images.Add(CType(resources.GetObject("C1CboTipo.Images"), System.Drawing.Image))
        Me.C1CboTipo.ItemHeight = 13
        Me.C1CboTipo.Location = New System.Drawing.Point(161, 113)
        Me.C1CboTipo.MatchEntryTimeout = CType(2000, Long)
        Me.C1CboTipo.MaxDropDownItems = CType(5, Short)
        Me.C1CboTipo.MaxLength = 32767
        Me.C1CboTipo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1CboTipo.Name = "C1CboTipo"
        Me.C1CboTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1CboTipo.Size = New System.Drawing.Size(200, 17)
        Me.C1CboTipo.TabIndex = 96
        Me.C1CboTipo.Tag = "TipoAva"
        Me.C1CboTipo.ValueMember = "TipoAva"
        Me.C1CboTipo.PropBag = resources.GetString("C1CboTipo.PropBag")
        '
        'TipoAvaBindingSource
        '
        Me.TipoAvaBindingSource.DataMember = "TipoAva"
        Me.TipoAvaBindingSource.DataSource = Me.ProDSet
        '
        'C1CboCli
        '
        Me.C1CboCli.AllowColSelect = True
        Me.C1CboCli.AutoSize = False
        Me.C1CboCli.Caption = ""
        Me.C1CboCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1CboCli.ColumnHeaders = False
        Me.C1CboCli.ColumnWidth = 100
        Me.C1CboCli.ContentHeight = 11
        Me.C1CboCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Nombre cliente", True))
        Me.C1CboCli.DataSource = Me.ClienteBindingSource
        Me.C1CboCli.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1CboCli.DisplayMember = "Cliente"
        Me.C1CboCli.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1CboCli.ExtendRightColumn = True
        Me.C1CboCli.FlatStyle = C1.Win.C1List.FlatModeEnum.Standard
        Me.C1CboCli.Images.Add(CType(resources.GetObject("C1CboCli.Images"), System.Drawing.Image))
        Me.C1CboCli.ItemHeight = 13
        Me.C1CboCli.Location = New System.Drawing.Point(161, 171)
        Me.C1CboCli.MatchEntryTimeout = CType(2000, Long)
        Me.C1CboCli.MaxDropDownItems = CType(5, Short)
        Me.C1CboCli.MaxLength = 32767
        Me.C1CboCli.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1CboCli.Name = "C1CboCli"
        Me.C1CboCli.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1CboCli.Size = New System.Drawing.Size(200, 17)
        Me.C1CboCli.TabIndex = 95
        Me.C1CboCli.Tag = "Cliente"
        Me.C1CboCli.ValueMember = "Cliente"
        Me.C1CboCli.PropBag = resources.GetString("C1CboCli.PropBag")
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.ProDSet
        '
        'C1CboSol
        '
        Me.C1CboSol.AllowColSelect = True
        Me.C1CboSol.AutoCompletion = True
        Me.C1CboSol.AutoDropDown = True
        Me.C1CboSol.AutoSelect = True
        Me.C1CboSol.AutoSize = False
        Me.C1CboSol.Caption = ""
        Me.C1CboSol.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1CboSol.ColumnHeaders = False
        Me.C1CboSol.ColumnWidth = 100
        Me.C1CboSol.ContentHeight = 11
        Me.C1CboSol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Solicitado por", True))
        Me.C1CboSol.DataSource = Me.ContactoBindingSource
        Me.C1CboSol.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1CboSol.DisplayMember = "Contacto"
        Me.C1CboSol.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1CboSol.ExtendRightColumn = True
        Me.C1CboSol.FlatStyle = C1.Win.C1List.FlatModeEnum.Standard
        Me.C1CboSol.Images.Add(CType(resources.GetObject("C1CboSol.Images"), System.Drawing.Image))
        Me.C1CboSol.ItemHeight = 13
        Me.C1CboSol.Location = New System.Drawing.Point(161, 152)
        Me.C1CboSol.MatchEntryTimeout = CType(2000, Long)
        Me.C1CboSol.MaxDropDownItems = CType(5, Short)
        Me.C1CboSol.MaxLength = 32767
        Me.C1CboSol.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1CboSol.Name = "C1CboSol"
        Me.C1CboSol.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1CboSol.Size = New System.Drawing.Size(200, 17)
        Me.C1CboSol.TabIndex = 92
        Me.C1CboSol.Tag = "Contacto"
        Me.C1CboSol.ValueMember = "Contacto"
        Me.C1CboSol.PropBag = resources.GetString("C1CboSol.PropBag")
        '
        'ContactoBindingSource
        '
        Me.ContactoBindingSource.DataMember = "Contacto"
        Me.ContactoBindingSource.DataSource = Me.ProDSet
        '
        'C1TextBox9
        '
        Me.C1TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Status del pago", True))
        Me.C1TextBox9.Location = New System.Drawing.Point(161, 230)
        Me.C1TextBox9.Name = "C1TextBox9"
        Me.C1TextBox9.Size = New System.Drawing.Size(200, 18)
        Me.C1TextBox9.TabIndex = 83
        Me.C1TextBox9.Tag = Nothing
        Me.C1TextBox9.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1TextBox9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox8
        '
        Me.C1TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Campo10", True))
        Me.C1TextBox8.Location = New System.Drawing.Point(161, 210)
        Me.C1TextBox8.Name = "C1TextBox8"
        Me.C1TextBox8.Size = New System.Drawing.Size(200, 18)
        Me.C1TextBox8.TabIndex = 81
        Me.C1TextBox8.Tag = Nothing
        Me.C1TextBox8.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1TextBox8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox7
        '
        Me.C1TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Fecha ingr a catastro o de auorización", True))
        Me.C1TextBox7.Location = New System.Drawing.Point(161, 190)
        Me.C1TextBox7.Name = "C1TextBox7"
        Me.C1TextBox7.Size = New System.Drawing.Size(200, 18)
        Me.C1TextBox7.TabIndex = 80
        Me.C1TextBox7.Tag = Nothing
        Me.C1TextBox7.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1TextBox7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox5
        '
        Me.C1TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Núm escr o de cliente", True))
        Me.C1TextBox5.DataType = GetType(Double)
        Me.C1TextBox5.Location = New System.Drawing.Point(161, 132)
        Me.C1TextBox5.Name = "C1TextBox5"
        Me.C1TextBox5.Size = New System.Drawing.Size(200, 18)
        Me.C1TextBox5.TabIndex = 77
        Me.C1TextBox5.Tag = Nothing
        Me.C1TextBox5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1TextBox5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox2
        '
        Me.C1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Domicilio", True))
        Me.C1TextBox2.Location = New System.Drawing.Point(161, 73)
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.Size = New System.Drawing.Size(190, 18)
        Me.C1TextBox2.TabIndex = 75
        Me.C1TextBox2.Tag = Nothing
        Me.C1TextBox2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1TextBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox1
        '
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Folio", True))
        Me.C1TextBox1.DataType = GetType(Double)
        Me.C1TextBox1.DisplayFormat.CustomFormat = "000"
        Me.C1TextBox1.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1TextBox1.EditFormat.CustomFormat = "000"
        Me.C1TextBox1.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1TextBox1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1TextBox1.Location = New System.Drawing.Point(161, 33)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(77, 18)
        Me.C1TextBox1.TabIndex = 72
        Me.C1TextBox1.Tag = Nothing
        Me.C1TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.C1TextBox1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1DateSol
        '
        Me.C1DateSol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DateSol.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.C1DateSol.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1DateSol.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1DateSol.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Fecha", True))
        Me.C1DateSol.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.C1DateSol.GapHeight = 0
        Me.C1DateSol.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1DateSol.Location = New System.Drawing.Point(161, 53)
        Me.C1DateSol.Name = "C1DateSol"
        Me.C1DateSol.Size = New System.Drawing.Size(99, 18)
        Me.C1DateSol.TabIndex = 73
        Me.C1DateSol.Tag = Nothing
        Me.C1DateSol.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.C1DateSol.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1DateSol.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnComentar)
        Me.Panel1.Controls.Add(Me.C1txtNotas)
        Me.Panel1.Location = New System.Drawing.Point(372, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 136)
        Me.Panel1.TabIndex = 91
        '
        'btnComentar
        '
        Me.btnComentar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComentar.Location = New System.Drawing.Point(294, 111)
        Me.btnComentar.Name = "btnComentar"
        Me.btnComentar.Size = New System.Drawing.Size(75, 23)
        Me.btnComentar.TabIndex = 36
        Me.btnComentar.Text = "Comentario"
        Me.btnComentar.UseVisualStyleBackColor = True
        Me.btnComentar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1txtNotas
        '
        Me.C1txtNotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.C1txtNotas.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.C1txtNotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1txtNotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.C1txtNotas.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NotasBindingSource, "Notas", True))
        Me.C1txtNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1txtNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1txtNotas.ForeColor = System.Drawing.Color.Gray
        Me.C1txtNotas.Location = New System.Drawing.Point(0, 0)
        Me.C1txtNotas.Multiline = True
        Me.C1txtNotas.Name = "C1txtNotas"
        Me.C1txtNotas.ReadOnly = True
        Me.C1txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.C1txtNotas.ShowFocusRectangle = True
        Me.C1txtNotas.Size = New System.Drawing.Size(385, 134)
        Me.C1txtNotas.TabIndex = 35
        Me.C1txtNotas.Tag = Nothing
        Me.C1txtNotas.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'NotasBindingSource
        '
        Me.NotasBindingSource.DataMember = "Registro_Notas"
        Me.NotasBindingSource.DataSource = Me.RegistroBindingSource
        '
        'C1FlexGridSearchPanel1
        '
        Me.C1FlexGridSearchPanel1.Location = New System.Drawing.Point(408, -11)
        Me.C1FlexGridSearchPanel1.Name = "C1FlexGridSearchPanel1"
        Me.C1FlexGridSearchPanel1.SearchDelay = 500
        Me.C1FlexGridSearchPanel1.SearchMode = C1.Win.C1FlexGrid.SearchMode.Always
        Me.C1FlexGridSearchPanel1.Size = New System.Drawing.Size(232, 41)
        Me.C1FlexGridSearchPanel1.TabIndex = 50
        Me.C1FlexGridSearchPanel1.Watermark = "Entre texto a buscar..."
        '
        'RegistroBindingNavigator
        '
        Me.RegistroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistroBindingNavigator.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RegistroBindingNavigator.BindingSource = Me.RegistroBindingSource
        Me.RegistroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistroBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.RegistroBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RegistroBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RegistroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistroBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1})
        Me.RegistroBindingNavigator.Location = New System.Drawing.Point(134, 0)
        Me.RegistroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistroBindingNavigator.Name = "RegistroBindingNavigator"
        Me.RegistroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistroBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.RegistroBindingNavigator.Size = New System.Drawing.Size(417, 25)
        Me.RegistroBindingNavigator.TabIndex = 0
        Me.RegistroBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RegistroBindingNavigatorSaveItem
        '
        Me.RegistroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistroBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistroBindingNavigatorSaveItem.Name = "RegistroBindingNavigatorSaveItem"
        Me.RegistroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegistroBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel1.Text = "Buscar"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(63, 38)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(58, 20)
        Me.IdTextBox.TabIndex = 100
        '
        'GpoStatus
        '
        Me.GpoStatus.BackColor = System.Drawing.Color.Transparent
        Me.GpoStatus.Controls.Add(Me.rbtnCancel)
        Me.GpoStatus.Controls.Add(Status_del_avalúoLabel)
        Me.GpoStatus.Controls.Add(Me.rbtnProceso)
        Me.GpoStatus.Controls.Add(Me.rbtnSolicitado)
        Me.GpoStatus.Controls.Add(Me.rbtnTerminado)
        Me.GpoStatus.Controls.Add(Me.rbtnAuto)
        Me.GpoStatus.Controls.Add(Me.rbtnCorre)
        Me.GpoStatus.Controls.Add(Me.rbtnListoEn)
        Me.GpoStatus.Controls.Add(Me.rbtnEnCe)
        Me.GpoStatus.Location = New System.Drawing.Point(372, 167)
        Me.GpoStatus.Name = "GpoStatus"
        Me.GpoStatus.Size = New System.Drawing.Size(229, 85)
        Me.GpoStatus.TabIndex = 94
        Me.GpoStatus.TabStop = False
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCancel.AutoSize = True
        Me.rbtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnCancel.Location = New System.Drawing.Point(109, 66)
        Me.rbtnCancel.Name = "rbtnCancel"
        Me.rbtnCancel.Size = New System.Drawing.Size(75, 17)
        Me.rbtnCancel.TabIndex = 19
        Me.rbtnCancel.TabStop = True
        Me.rbtnCancel.Text = "Cancelado"
        Me.rbtnCancel.UseVisualStyleBackColor = True
        '
        'rbtnProceso
        '
        Me.rbtnProceso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnProceso.AutoSize = True
        Me.rbtnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnProceso.Location = New System.Drawing.Point(5, 36)
        Me.rbtnProceso.Name = "rbtnProceso"
        Me.rbtnProceso.Size = New System.Drawing.Size(79, 17)
        Me.rbtnProceso.TabIndex = 13
        Me.rbtnProceso.TabStop = True
        Me.rbtnProceso.Text = "En Proceso"
        Me.rbtnProceso.UseVisualStyleBackColor = True
        '
        'rbtnSolicitado
        '
        Me.rbtnSolicitado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnSolicitado.AutoSize = True
        Me.rbtnSolicitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnSolicitado.Location = New System.Drawing.Point(5, 21)
        Me.rbtnSolicitado.Name = "rbtnSolicitado"
        Me.rbtnSolicitado.Size = New System.Drawing.Size(70, 17)
        Me.rbtnSolicitado.TabIndex = 12
        Me.rbtnSolicitado.TabStop = True
        Me.rbtnSolicitado.Text = "Solicitado"
        Me.rbtnSolicitado.UseVisualStyleBackColor = True
        '
        'rbtnTerminado
        '
        Me.rbtnTerminado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnTerminado.AutoSize = True
        Me.rbtnTerminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnTerminado.Location = New System.Drawing.Point(5, 51)
        Me.rbtnTerminado.Name = "rbtnTerminado"
        Me.rbtnTerminado.Size = New System.Drawing.Size(74, 17)
        Me.rbtnTerminado.TabIndex = 14
        Me.rbtnTerminado.TabStop = True
        Me.rbtnTerminado.Text = "Terminado"
        Me.rbtnTerminado.UseVisualStyleBackColor = True
        '
        'rbtnAuto
        '
        Me.rbtnAuto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnAuto.AutoSize = True
        Me.rbtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnAuto.Location = New System.Drawing.Point(5, 66)
        Me.rbtnAuto.Name = "rbtnAuto"
        Me.rbtnAuto.Size = New System.Drawing.Size(98, 17)
        Me.rbtnAuto.TabIndex = 15
        Me.rbtnAuto.TabStop = True
        Me.rbtnAuto.Text = "En Autorización"
        Me.rbtnAuto.UseVisualStyleBackColor = True
        '
        'rbtnCorre
        '
        Me.rbtnCorre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCorre.AutoSize = True
        Me.rbtnCorre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnCorre.Location = New System.Drawing.Point(109, 21)
        Me.rbtnCorre.Name = "rbtnCorre"
        Me.rbtnCorre.Size = New System.Drawing.Size(75, 17)
        Me.rbtnCorre.TabIndex = 16
        Me.rbtnCorre.TabStop = True
        Me.rbtnCorre.Text = "Corrección"
        Me.rbtnCorre.UseVisualStyleBackColor = True
        '
        'rbtnListoEn
        '
        Me.rbtnListoEn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnListoEn.AutoSize = True
        Me.rbtnListoEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnListoEn.Location = New System.Drawing.Point(109, 36)
        Me.rbtnListoEn.Name = "rbtnListoEn"
        Me.rbtnListoEn.Size = New System.Drawing.Size(110, 17)
        Me.rbtnListoEn.TabIndex = 17
        Me.rbtnListoEn.TabStop = True
        Me.rbtnListoEn.Text = "Listo para Entrega"
        Me.rbtnListoEn.UseVisualStyleBackColor = True
        '
        'rbtnEnCe
        '
        Me.rbtnEnCe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnEnCe.AutoSize = True
        Me.rbtnEnCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnEnCe.Location = New System.Drawing.Point(109, 51)
        Me.rbtnEnCe.Name = "rbtnEnCe"
        Me.rbtnEnCe.Size = New System.Drawing.Size(121, 17)
        Me.rbtnEnCe.TabIndex = 18
        Me.rbtnEnCe.TabStop = True
        Me.rbtnEnCe.Text = "Entregado y Cerrado"
        Me.rbtnEnCe.UseVisualStyleBackColor = True
        '
        'txtPagos
        '
        Me.txtPagos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "pagos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtPagos.Location = New System.Drawing.Point(607, 187)
        Me.txtPagos.Name = "txtPagos"
        Me.txtPagos.Size = New System.Drawing.Size(75, 20)
        Me.txtPagos.TabIndex = 90
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.NotasBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BindingNavigator1.Location = New System.Drawing.Point(644, 213)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(255, 25)
        Me.BindingNavigator1.TabIndex = 62
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.AutoScroll = True
        Me.C1SplitterPanel2.Collapsible = True
        Me.C1SplitterPanel2.Controls.Add(Me.C1FlexGrid1)
        Me.C1SplitterPanel2.Controls.Add(Me.C1FlexGridGroupPanel1)
        Me.C1SplitterPanel2.Height = 156
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 347)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(764, 124)
        Me.C1SplitterPanel2.SizeRatio = 79.592R
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "Listado de Registros"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDelete = True
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1FlexGrid1.AllowFiltering = True
        Me.C1FlexGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1FlexGrid1.AutoResize = True
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.RegistroBindingSource
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 44)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 16
        Me.C1FlexGrid1.ShowCellLabels = True
        Me.C1FlexGrid1.Size = New System.Drawing.Size(764, 80)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 48
        Me.C1FlexGrid1.Tree.Column = 0
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1FlexGridGroupPanel1
        '
        Me.C1FlexGridGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGridGroupPanel1.FlexGrid = Me.C1FlexGrid1
        Me.C1FlexGridGroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGridGroupPanel1.Name = "C1FlexGridGroupPanel1"
        Me.C1FlexGridGroupPanel1.Size = New System.Drawing.Size(764, 124)
        Me.C1FlexGridGroupPanel1.TabIndex = 49
        Me.C1FlexGridGroupPanel1.Text = "Filtros"
        '
        'C1SplitterPanel3
        '
        Me.C1SplitterPanel3.AutoScroll = True
        Me.C1SplitterPanel3.Controls.Add(Me.C1FlexPagos)
        Me.C1SplitterPanel3.Controls.Add(Me.ContactoDataGridView)
        Me.C1SplitterPanel3.Height = 40
        Me.C1SplitterPanel3.Location = New System.Drawing.Point(0, 507)
        Me.C1SplitterPanel3.Name = "C1SplitterPanel3"
        Me.C1SplitterPanel3.Size = New System.Drawing.Size(764, 19)
        Me.C1SplitterPanel3.TabIndex = 2
        Me.C1SplitterPanel3.Text = "Panel 3"
        '
        'C1FlexPagos
        '
        Me.C1FlexPagos.AllowAddNew = True
        Me.C1FlexPagos.AllowDelete = True
        Me.C1FlexPagos.ColumnInfo = resources.GetString("C1FlexPagos.ColumnInfo")
        Me.C1FlexPagos.DataSource = Me.RegistroPagosBindingSource
        Me.C1FlexPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.C1FlexPagos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1FlexPagos.Location = New System.Drawing.Point(341, 89)
        Me.C1FlexPagos.Name = "C1FlexPagos"
        Me.C1FlexPagos.Rows.Count = 1
        Me.C1FlexPagos.Rows.DefaultSize = 16
        Me.C1FlexPagos.Size = New System.Drawing.Size(393, 73)
        Me.C1FlexPagos.StyleInfo = resources.GetString("C1FlexPagos.StyleInfo")
        Me.C1FlexPagos.TabIndex = 2
        Me.C1FlexPagos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom
        '
        'RegistroPagosBindingSource
        '
        Me.RegistroPagosBindingSource.DataMember = "Registro_Pagos"
        Me.RegistroPagosBindingSource.DataSource = Me.RegistroBindingSource
        '
        'ContactoDataGridView
        '
        Me.ContactoDataGridView.AutoGenerateColumns = False
        Me.ContactoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.IdRegistroDataGridViewTextBoxColumn, Me.ContactoDataGridViewTextBoxColumn})
        Me.ContactoDataGridView.DataSource = Me.ContactoBindingSource
        Me.ContactoDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.ContactoDataGridView.Name = "ContactoDataGridView"
        Me.ContactoDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ContactoDataGridView.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'IdRegistroDataGridViewTextBoxColumn
        '
        Me.IdRegistroDataGridViewTextBoxColumn.DataPropertyName = "idRegistro"
        Me.IdRegistroDataGridViewTextBoxColumn.HeaderText = "idRegistro"
        Me.IdRegistroDataGridViewTextBoxColumn.Name = "IdRegistroDataGridViewTextBoxColumn"
        '
        'ContactoDataGridViewTextBoxColumn
        '
        Me.ContactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto"
        Me.ContactoDataGridViewTextBoxColumn.HeaderText = "Contacto"
        Me.ContactoDataGridViewTextBoxColumn.Name = "ContactoDataGridViewTextBoxColumn"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.ProDSet
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AccessibleName = "Selección de nuevo elemento"
        Me.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.miniToolStrip.AddNewItem = Nothing
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.CountItem = Nothing
        Me.miniToolStrip.DeleteItem = Nothing
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(254, 3)
        Me.miniToolStrip.MoveFirstItem = Nothing
        Me.miniToolStrip.MoveLastItem = Nothing
        Me.miniToolStrip.MoveNextItem = Nothing
        Me.miniToolStrip.MovePreviousItem = Nothing
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.PositionItem = Nothing
        Me.miniToolStrip.Size = New System.Drawing.Size(257, 25)
        Me.miniToolStrip.TabIndex = 47
        Me.miniToolStrip.Visible = False
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ContactoTableAdapter = Nothing
        Me.TableAdapterManager.ListadoTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NotasTableAdapter = Me.NotasTableAdapter
        Me.TableAdapterManager.PagosTableAdapter = Me.PagosTableAdapter
        Me.TableAdapterManager.RegistroTableAdapter = Me.RegistroTableAdapter
        Me.TableAdapterManager.TelefonoTableAdapter = Nothing
        Me.TableAdapterManager.TipoAvaTableAdapter = Nothing
        Me.TableAdapterManager.TipoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Registro.ProDSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'NotasTableAdapter
        '
        Me.NotasTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'TipoBindingSource
        '
        Me.TipoBindingSource.DataMember = "Tipo"
        Me.TipoBindingSource.DataSource = Me.ProDSet
        '
        'TipoTableAdapter
        '
        Me.TipoTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TipoAvaTableAdapter
        '
        Me.TipoAvaTableAdapter.ClearBeforeFill = True
        '
        'MunicipioTableAdapter
        '
        Me.MunicipioTableAdapter.ClearBeforeFill = True
        '
        'ContactoTableAdapter
        '
        Me.ContactoTableAdapter.ClearBeforeFill = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(764, 526)
        Me.Controls.Add(Me.C1SplitContainer1)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración"
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel1.PerformLayout()
        Me.GpoPrincipal.ResumeLayout(False)
        Me.GpoPrincipal.PerformLayout()
        CType(Me.C1txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProDSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CboMun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CboTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoAvaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CboCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CboSol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateSol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnComentar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1txtNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistroBindingNavigator.ResumeLayout(False)
        Me.RegistroBindingNavigator.PerformLayout()
        Me.GpoStatus.ResumeLayout(False)
        Me.GpoStatus.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.C1SplitterPanel2.ResumeLayout(False)
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel3.ResumeLayout(False)
        CType(Me.C1FlexPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.miniToolStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProDSet As ProDSet
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As ProDSetTableAdapters.RegistroTableAdapter
    Friend WithEvents TableAdapterManager As ProDSetTableAdapters.TableAdapterManager
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents NotasBindingSource As BindingSource
    Friend WithEvents NotasTableAdapter As ProDSetTableAdapters.NotasTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents RegistroBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RegistroBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents miniToolStrip As BindingNavigator
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents TipoBindingSource As BindingSource
    Friend WithEvents TipoTableAdapter As ProDSetTableAdapters.TipoTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As ProDSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TipoAvaBindingSource As BindingSource
    Friend WithEvents TipoAvaTableAdapter As ProDSetTableAdapters.TipoAvaTableAdapter
    Friend WithEvents MunicipioBindingSource As BindingSource
    Friend WithEvents MunicipioTableAdapter As ProDSetTableAdapters.MunicipioTableAdapter
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGridSearchPanel1 As C1.Win.C1FlexGrid.C1FlexGridSearchPanel
    Friend WithEvents C1FlexGridGroupPanel1 As C1.Win.C1FlexGrid.C1FlexGridGroupPanel
    Friend WithEvents C1SplitterPanel3 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents ContactoBindingSource As BindingSource
    Friend WithEvents ContactoTableAdapter As ProDSetTableAdapters.ContactoTableAdapter
    Friend WithEvents ContactoDataGridView As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdRegistroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As ProDSetTableAdapters.PagosTableAdapter
    Friend WithEvents RegistroPagosBindingSource As BindingSource
    Friend WithEvents C1FlexPagos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GpoPrincipal As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnComentar As C1.Win.C1Input.C1Button
    Friend WithEvents C1txtNotas As C1.Win.C1Input.C1TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents C1CboMun As C1.Win.C1List.C1Combo
    Friend WithEvents C1CboTipo As C1.Win.C1List.C1Combo
    Friend WithEvents C1CboCli As C1.Win.C1List.C1Combo
    Friend WithEvents GpoStatus As GroupBox
    Friend WithEvents rbtnCancel As RadioButton
    Friend WithEvents rbtnProceso As RadioButton
    Friend WithEvents rbtnSolicitado As RadioButton
    Friend WithEvents rbtnTerminado As RadioButton
    Friend WithEvents rbtnAuto As RadioButton
    Friend WithEvents rbtnCorre As RadioButton
    Friend WithEvents rbtnListoEn As RadioButton
    Friend WithEvents rbtnEnCe As RadioButton
    Friend WithEvents C1CboSol As C1.Win.C1List.C1Combo
    Friend WithEvents C1TextBox9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1DateSol As C1.Win.Calendar.C1DateEdit
    Friend WithEvents txtPagos As TextBox
    Friend WithEvents C1txtCosto As C1.Win.C1Input.C1TextBox
End Class
