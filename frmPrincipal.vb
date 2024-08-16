Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Reflection.Emit
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports C1.Win
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1Input
Imports Registro.ProDSetTableAdapters

Public Class frmPrincipal

    Private Sub RegistroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegistroBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.RegistroBindingSource.EndEdit()
        'Me.NotasBindingSource.EndEdit()
        ''ContactoTableAdapter.Fill(ProDSet.Contacto)
        'Me.TableAdapterManager.UpdateAll(Me.ProDSet)
        guardar()
        MsgBox("Información Guardada")
        ' Me.RegistroTableAdapter.Fill(Me.ProDSet.Registro)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.ProDSet.Pagos)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.Fill(Me.ProDSet.Registro)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Contacto' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Contacto' Puede moverla o quitarla según sea necesario.
        Me.ContactoTableAdapter.Fill(Me.ProDSet.Contacto)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Registro' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProDSet1.Municipio' Puede moverla o quitarla según sea necesario.
        Me.MunicipioTableAdapter.Fill(Me.ProDSet.Municipio)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.TipoAva' Puede moverla o quitarla según sea necesario.
        Me.TipoAvaTableAdapter.Fill(Me.ProDSet.TipoAva)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ProDSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Tipo' Puede moverla o quitarla según sea necesario.
        Me.TipoTableAdapter.Fill(Me.ProDSet.Tipo)
        If Me.IsHandleCreated AndAlso Me.Visible Then
            ' RegistroDataGridView.DataSource = RegistroBindingSource
            Me.ContactoTableAdapter.Fill(Me.ProDSet.Contacto)
            Me.RegistroTableAdapter.Fill(Me.ProDSet.Registro)
            Me.NotasTableAdapter.Fill(Me.ProDSet.Notas)
            AddHandler BindingNavigatorPositionItem.TextChanged, AddressOf BindingNavigatorPositionItem_TextChanged
            AddHandler rbtnSolicitado.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnAuto.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnCancel.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnEnCe.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnProceso.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnTerminado.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnListoEn.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnCorre.CheckedChanged, AddressOf rbtnSolicitado_CheckedChanged
            AddHandler rbtnSolicitado.Click, AddressOf rbtnCorre_Click
            AddHandler rbtnAuto.Click, AddressOf rbtnCorre_Click
            AddHandler rbtnCancel.Click, AddressOf rbtnCorre_Click
            AddHandler rbtnEnCe.Click, AddressOf rbtnCorre_Click
            AddHandler rbtnProceso.Click, AddressOf rbtnCorre_Click
            AddHandler rbtnTerminado.Click, AddressOf rbtnCorre_Click
            AddHandler rbtnListoEn.Click, AddressOf rbtnCorre_Click
            AddHandler rbtnCorre.Click, AddressOf rbtnCorre_Click
            AddHandler C1SplitterPanel2.CloseButtonClick, AddressOf btnClosePanel_Click
            AddHandler C1DateSol.ValueChanged, AddressOf C1DateEdit1_ValueChanged
            'AddHandler C1FlexGridSearchPanel1.btnsearch, AddressOf btnClosePanel_Click
            ' AddHandler RegistroDataGridView.DataBindingComplete, AddressOf DataGridView1_DataBindingComplete

            '    For Each row As Row In flexgrid.Rows
            '        MsgBox(row.Item("Status del avalúo").ToString)
            '        If row.Item("Status del avalúo").ToString IsNot Nothing AndAlso row.Item("Status del avalúo").ToString = "Entregado y Cerrado" Then
            '            row.Style.BackColor = Color.White

            '        Else
            '            row.Style.BackColor = Color.Red
            '        End If
            '    Next
            'C1FlexGrid1.DataSource = RegistroBindingSource

            'Dim row As New C1FlexGridBase.
            chkRbut()
            cargaFlexgrid()

            'Dim flexgrid As New C1.Win.C1FlexGrid.C1FlexGrid()
            'flexgrid = C1FlexGrid1
            'C1FlexGrid1.DataSource = RegistroBindingSource
            'For Each row As Row In flexgrid.Rows
            '    'If row.Index > 1 Then ' Ignorar nodos
            '    '    Dim categoria As String = row("Status del avalúo").ToString()
            '    '    If categoria = "CANCELADO" Then
            '    '        row.StyleNew.BackColor = Color.Red
            '    '        'ElseIf categoria = "Verduras" Then
            '    '        '    row.Style = estiloVerduras
            '    '    End If
            '    'If row.Item("Status_del_avalúo") <> Nothing Then
            '    If row.Item("Status del avalúo").ToString IsNot Nothing AndAlso row.Item("Status del avalúo").ToString = "Entregado y Cerrado" Then
            '        '' If row.Item("Status_del_avalúo") = "Entregado y Cerrado" Then
            '        ''MsgBox(row.Item("Status_del_avalúo").ToString)
            '        'If row("Status_del_avalúo").ToString = "CANCELADO" Then
            '        '    row.StyleNew.BackColor = Color.Red
            '        row.StyleNew.BackColor = Color.FromArgb(255, 255, 210)
            '        'End If
            '    End If
            '    If row.Item("Status del avalúo").ToString IsNot Nothing AndAlso row.Item("Status del avalúo").ToString = "Cancelado" Then
            '        row.StyleNew.BackColor = Color.Red
            '    End If
            '    If row.Item("Nombre cliente").ToString IsNot Nothing AndAlso row.Item("Nombre cliente").ToString = "IMSS" Then
            '        row.StyleNew.BackColor = Color.AliceBlue
            '    End If

            '    ' Else



            '    'Else

            '    '    row.DefaultCellStyle.BackColor = Color.White
            '    ' End If
            '    ' End If '
            'Next row
            'For Each control In C1FlexGridSearchPanel1.Controls
            '    If control.name = "cmbSearch" Then
            '        AddHandler CType(control, Control).TextChanged, AddressOf cmbSearch_Click
            '        MsgBox(control.Name)
            '        'MsgBox(control.key)
            '    End If
            'Next
        End If



        'End If



    End Sub
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs)
        MsgBox(sender.name)
        ' Colapsar el primer panel
        C1SplitContainer1.Panels(1).Collapsed = False
    End Sub
    Private Sub cmbSearch_Click(sender As Object, e As EventArgs)
        'Dim searchText As String = C1FlexGridSearchPanel1.Controls(0).Text
        '' Añade comillas para buscar la frase completa
        'searchText = $"""{searchText}"""
        'C1FlexGrid1.ApplySearch(searchText, True, True)
        ApplySearch()

    End Sub
    Private Sub ApplySearch()
        Dim searchText As String = C1FlexGridSearchPanel1.Controls(0).Text

        ' Añade comillas para buscar la frase completa
        searchText = $"""{searchText}"""
        C1FlexGrid1.ApplySearch(searchText, True, True)

    End Sub
    'Private Sub C1FlexGridSearchPanel1_KeyDown(sender As Object, e As KeyEventArgs) Handles C1FlexGridSearchPanel1.KeyPress
    '    If e.KeyData = Keys.Enter Then
    '        ApplySearch()
    '    End If
    'End Sub

    Private Sub Solicitado_porComboBox_Validated(sender As Object, e As EventArgs) Handles C1CboSol.Validated, C1CboCli.Validated, C1CboMun.Validated, C1CboTipo.Validated 'Solicitado_porComboBox.Validated, C1CboSol.Validated
        If sender.name = "C1CboSol" Then
            agregaCboSol()
        End If
        If sender.name = "C1CboCli" Then
            agregaCboCli()
        End If
        If sender.name = "C1CboMun" Then
            agregaCboMun()
        End If
        If sender.name = "C1CboTipo" Then
            agregaCboTipo()
        End If
    End Sub

    Private Sub btnComentar_Click(sender As Object, e As EventArgs) Handles btnComentar.Click
        AbrirFormulario(New frmCom)
        ''Panel1.Top
        'Panel1.Controls.Add(frmCom)
        'frmCom.Show()
    End Sub
    Private Sub AbrirFormulario(frahijo As Object)
        'If (Panel1.Controls.Count > 0) Then
        '    Panel1.Controls.RemoveAt(0)
        'End If
        If BindingNavigatorCountItem1.ToString = "de 0" Then
            BindingNavigatorAddNewItem1.PerformClick()
        End If

        Dim fra As Form = TryCast(frahijo, Form)
        fra = frahijo
        fra.TopLevel = False
        fra.Dock = DockStyle.Fill
        fra.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(fra)
        Panel1.Tag = fra
        fra.Show()

    End Sub


    'Dim time As Integer = 10 ' Inicializa el contador en 10 segundos


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim row As DataGridViewRow = Me.RegistroDataGridView.CurrentRow
        If Labeltick.Visible = True Then
            Labeltick.Visible = False
            Labeltick.ForeColor = Color.FromArgb(30, 57, 91)
            ' row.DefaultCellStyle.BackColor = Color.White
            'Labeltick.ForeColor = SystemColors.WindowText
        Else
            Labeltick.Visible = True
            Labeltick.ForeColor = Color.Red
            'Labeltick.Visible = False
            'row.DefaultCellStyle.BackColor = Color.Red
        End If
        'If row.Cells("StatusA").Value IsNot Nothing AndAlso row.Cells("StatusA").Value.ToString() = "cerrado" Then
        '    row.DefaultCellStyle.BackColor = Color.White

        'Else
        '    row.DefaultCellStyle.BackColor = Color.Red
        'End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Labeltick.Text = Time.ToString()
        Timer1.Interval = 1000
        Timer1.Enabled = True
        ' Dim colo2 = Labeltick.ForeColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
        Labeltick.Visible = True
        Labeltick.ForeColor = Color.FromArgb(30, 57, 91)
    End Sub

    Private Sub RegistroDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) 'Handles RegistroDataGridView.RowEnter, RegistroDataGridView.CellEnter

        'Dim row As DataGridViewRow = RegistroDataGridView.CurrentRow
        'Timer1.Stop()
        'If Status_del_avalúoTextBox.Text = "cerrado" Then
        '    chekStatus.Checked = 1
        '    rbtnEnCe.Checked = True
        'Else
        '    chekStatus.Checked = 0
        '    rbtnEnCe.Checked = False
        'End If
        'If chekStatus.Checked = 0 Then
        '    Timer1.Interval = 1000
        '    Timer1.Start() ' = 1
        'Else
        '    Timer1.Stop()
        '    Labeltick.Visible = 1
        '    Labeltick.ForeColor = Color.FromArgb(30, 57, 91)
        '    'row.DefaultCellStyle.BackColor = Color.White


        'End If
        ''If RegistroDataGridView.
        ''If row.Cells("StatusA").Value IsNot Nothing AndAlso row.Cells("StatusA").Value.ToString() = "cerrado" Then
        ''    row.DefaultCellStyle.BackColor = Color.Red

        ''Else
        ''    row.DefaultCellStyle.BackColor = Color.White
        ''End If

    End Sub
    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles RegistroDataGridView.DataBindingComplete
        ' Realiza acciones después de llenar el DataGridView
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    If row.Cells("Nombre").Value.ToString() = "María" Then
        '        row.DefaultCellStyle.BackColor = Color.Yellow
        '    End If
        'Next
        'Dim row As DataGridViewRow ' RegistroDataGridView
        For Each row As DataGridViewRow In RegistroDataGridView.Rows
            If row.Cells("Status_del_avalúo").Value IsNot Nothing AndAlso row.Cells("Status_del_avalúo").Value.ToString = "Entregado y Cerrado" Then
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 210)
            End If
            If row.Cells("Status_del_avalúo").Value IsNot Nothing AndAlso row.Cells("Status_del_avalúo").Value.ToString = "Cancelado" Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If
            If row.Cells("Cliente").Value IsNot Nothing AndAlso row.Cells("Cliente").Value.ToString = "IMSS" Then
                row.DefaultCellStyle.BackColor = Color.AliceBlue
            End If

            'Else

            '    row.DefaultCellStyle.BackColor = Color.White
            'End If
        Next


    End Sub


    Dim vuelta As Integer = 0
    Private Sub rbtnSolicitado_CheckedChanged(sender As Object, e As EventArgs) 'envia 2 estADOS, ANTERIOR  Y NUEVO
        ''Me.SuspendLayout()
        ''RegistroDataGridView.SuspendLayout()
        '' MsgBox(sender.text & sender.checked & "vuelta" & vuelta)
        '' If Me.IsHandleCreated AndAlso Me.Visible Then
        'Dim dt = ProDSet.Registro
        'If vuelta = 1 And sender.checked = True Then
        '    If sender.checked = True Then
        '        'UpdateRecord(dt, FindRowIndex(dt, "id", CInt(Me.BindingNavigatorPositionItem.Text)), sender.text)
        '        '' Me.RegistroTableAdapter.Update(dr("Status del Avaluo"))
        '        ''Status_del_avalúoTextBox.Text = sender.text
        '        'For Each row As DataRow In dt.Rows
        '        '    Console.WriteLine("ID: " & row("id") & ", Status: " & row("Status del Avalúo"))
        '        'Next
        '        Console.WriteLine("reg: " & BindingNavigatorPositionItem.Text)
        '        ' UpdateRecord(dt, FindRowIndex(dt, "id", CInt(BindingNavigatorPositionItem.Text)), sender.text)
        '        'UpdateRecord(dt, index, sender.text)

        '        'Dim index = FindRowIndex(dt, "id", CInt(BindingNavigatorPositionItem.Text))
        '        'Console.WriteLine("index changed: " & index)
        '        ' agregaNotaRadio(sender.text)
        '        'guardar()
        '    End If
        '    'vuelta = 0
        'End If
        'If vuelta = 0 Then
        '    If sender.checked = True Then
        '        Label1.Text = sender.text
        '        'agregaNotaRadio(sender.text)
        '        vuelta += 1
        '    End If
        'End If
        '' End If
        ''For Each radiob As RadioButton In Me.Controls
        ''    If radiob.Text = Status_del_avalúoTextBox.Text Then
        ''        sender.checked = True
        ''    End If
        ''Next
        '' vuelta += 1
        '' Me.RegistroTableAdapter.Update(dr("Status del Avaluo"))
        ''Status_del_avalúoTextBox.Text = sender.text
        ''For Each row As DataRow In dt.Rows
        ''    Console.WriteLine("ID: " & row("id") & ", Status: " & row("Status del Avalúo"))
        ''Next
        ''RegistroDataGridView.ResumeLayout()
        ''Me.ResumeLayout()
    End Sub
    Private Sub UpdateRecord(dt As DataTable, id As Integer, newValor As String)
        For Each row As DataRow In dt.Rows
            If row("id") = id + 1 Then
                row("Status del Avalúo") = newValor
                Console.WriteLine("ID: " & row("id") & ", Status: " & row("Status del Avalúo"))
                Exit For
            End If
        Next
    End Sub



    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) 'Handles BindingNavigatorPositionItem.TextChanged
        'Dim row As DataGridViewRow = RegistroDataGridView.CurrentRow
        'Dim ind As ind
        Timer1.Stop()
        chkRbut()

        'If rbtnEnCe.Checked = False Then
        '    Timer1.Interval = 500
        '    Timer1.Start() ' = 1
        'Else
        '    Timer1.Stop()
        '    Labeltick.Visible = 1
        '    Labeltick.ForeColor = Color.FromArgb(30, 57, 91)
        '    'row.DefaultCellStyle.BackColor = Color.White


        'End If

    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        guardar()
        RemoveHandler BindingNavigatorPositionItem.TextChanged, AddressOf BindingNavigatorPositionItem_TextChanged
    End Sub

    Private Sub rbtnCorre_Click(sender As Object, e As EventArgs) 'click los radio buttons
        'Me.SuspendLayout()
        'RegistroDataGridView.SuspendLayout()
        Dim dt = ProDSet.Registro

        'UpdateRecord(dt, FindRowIndex(dt, "id", CInt(BindingNavigatorPositionItem.Text)), sender.text)
        guardar()
        UpdateRecord(dt, FindRowIndex(dt, "id", CInt(BindingNavigatorPositionItem.Text)), sender.text)
        cargaFlexgrid()
        ' UpdateRecord(dt, index, sender.text)
        agregaNotaRadio(sender.text)
        guardar()
        'RegistroDataGridView.ResumeLayout()
        'Me.ResumeLayout()
    End Sub

    Private Sub C1DateEdit1_ValueChanged(sender As Object, e As EventArgs)
        If C1TextBox1.Text IsNot Nothing AndAlso C1TextBox1.Text <> "" Then
            ' rbtnSolicitado.Checked = True
            'rbtnCorre.PerformClick()
            ' guardar()

        End If
    End Sub



    Private Sub C1Button2_Click(sender As Object, e As EventArgs)
        Dim flexgrid As New C1.Win.C1FlexGrid.C1FlexGrid()
        flexgrid = C1FlexGrid1
        C1FlexGrid1.DataSource = RegistroBindingSource
        For Each row As C1.Win.C1FlexGrid.Row In flexgrid.Rows
            MsgBox(row.Item("Status del avalúo"))
            If row.Item("Status del avalúo").ToString IsNot Nothing AndAlso row.Item("Status del avalúo").ToString = "Entregado y Cerrado" Then
                row.Style.BackColor = Color.White

            Else
                row.Style.BackColor = Color.Red
            End If
        Next
    End Sub





    Private Sub C1SplitterPanel2_CloseButtonClick(sender As Object, e As EventArgs) Handles C1SplitterPanel2.CloseButtonClick
        C1SplitterPanel2.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmSPago.Show()
    End Sub







    'Private Sub C1FlexGridSearchPanel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C1FlexGridSearchPanel1.KeyPress
    '    '    Private Sub C1FlexGridSearchPanel1_KeyDown(sender As Object, e As KeyEventArgs) Handles C1FlexGridSearchPanel1.KeyPress
    '    If e.KeyDa = Keys.Enter Then
    '        ApplySearch()
    '    End If
    '    ' End Sub
    'End Sub





    'Private Sub C1txtNotas_TextChanged(sender As Object, e As EventArgs) Handles C1txtNotas.TextChanged
    '    Dim rtb As TextBox = CType(sender, TextBox)
    '    Dim variable As String = "Texto a cambiar"

    '    ' Verificar si el texto del TextBox contiene la variable
    '    'Dim rtb As RichTextBox = CType(sender, RichTextBox)
    '    Dim wordToStyle As String = "palabra"

    '    ' Guardar la posición actual del cursor
    '    Dim currentPos As Integer = rtb.SelectionStart

    '    ' Desactivar la actualización del control para evitar parpadeos
    '    rtb.SuspendLayout()

    '    ' Recorrer el texto y cambiar el color y estilo de la palabra específica
    '    Dim startIndex As Integer = 0
    '    While startIndex <rtb.Text.Length
    '        startIndex = rtb.Find(wordToStyle, startIndex, RichTextBoxFinds.None)
    '        If startIndex <> -1 Then
    '            rtb.SelectionStart = startIndex
    '            rtb.SelectionLength = wordToStyle.Length
    '            rtb.SelectionColor = Color.Red
    '            rtb.SelectionFont = New Font(rtb.SelectionFont, FontStyle.Bold Or FontStyle.Italic)
    '            startIndex += wordToStyle.Length
    '        Else
    '            Exit While
    '        End If
    '    End While

    '    ' Restaurar la posición del cursor
    '    rtb.SelectionStart = currentPos
    '    rtb.SelectionLength = 0
    '    rtb.SelectionColor = rtb.ForeColor

    '    ' Reactivar la actualización del control
    '    rtb.ResumeLayout()
    'End Sub
    'End Sub

    'Private Sub C1FlexGridClassic1_DataBindingComplete(sender As Object, e As EventArgs)
    '    For Each row As Row In C1FlexGridClassic1.Controls
    '        If row.Item("StatusA").Value IsNot Nothing AndAlso row.Item("StatusA").Value.ToString = "cerrado" Then
    '            row.Style.BackColor = Color.White

    '        Else
    '            row.Style.BackColor = Color.Red
    '        End If
    '    Next
    'End Sub

    'Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles C1Button1.Click
    '    C1FlexGrid1.DataSource = RegistroBindingSource
    '    Dim flexgrid As New C1.Win.C1FlexGrid.C1FlexGrid()
    '    flexgrid = C1FlexGrid1
    '    'Dim row As New C1FlexGridBase.
    '    'For Each row As Row In C1FlexGridClassic1.Controls
    '    '    If row.Item("StatusA").Value IsNot Nothing AndAlso row.Item("StatusA").Value.ToString = "cerrado" Then
    '    '        row.Style.BackColor = Color.White

    '    '    Else
    '    '        row.Style.BackColor = Color.Red
    '    '    End If
    '    'Next
    '    'For i As Integer = 1 To c1f.Rows - 1

    '    '    If c1f.Item(i, 13) IsNot Nothing AndAlso c1f.Item(i, 13) = "Entregado y Cerrado" Then
    '    '        c1f.CellBackColor = Color.Red
    '    '        'C1FlexGridClassic1.CellBackColor = Color.LightBlue
    '    '    Else
    '    '        c1f.Row = i
    '    '            c1f.CellBackColor = Color.LightGreen
    '    '        End If

    '    'Next
    '    'For i As Integer = 1 To flexgrid.Rows.Count - 1
    '    '    ' MsgBox(flexgrid.Item(i, "Status del avalúo").ToString)
    '    '    If flexgrid.Item(i, "Status del avalúo").ToString = "Entregado y Cerrado" Then
    '    '        flexgrid.Row = i
    '    '        flexgrid.BackColor = Color.Red
    '    '    Else
    '    '        flexgrid.Row = i
    '    '        flexgrid.BackColor = Color.LightGreen
    '    '    End If
    '    'Next
    '    For Each row As Row In flexgrid.Rows
    '        MsgBox(row.Item("Status del avalúo").ToString)
    '        If row.Item("Status del avalúo").ToString IsNot Nothing AndAlso row.Item("Status del avalúo").ToString = "Entregado y Cerrado" Then
    '            row.Style.BackColor = Color.White

    '        Else
    '            row.Style.BackColor = Color.Red
    '        End If
    '    Next
    'End Sub

    'Private Sub C1FlexGrid1_DataBindingComplete(sender As Object, e As EventArgs)
    '    MsgBox("hola")
    'End Sub
End Class
