Imports System.ComponentModel.Design
Imports System.Configuration
Imports System.Reflection
Imports Registro.ProDSetTableAdapters

Module mdFunciones
    'Public index As Integer
    'Public txtdt As New RegistroTableAdapter
    'Public dt = txtdt.GetData
    Public Sub cargaFlexgrid()
        Dim flexgrid As New C1.Win.C1FlexGrid.C1FlexGrid()
        flexgrid = frmPrincipal.C1FlexGrid1
        flexgrid.DataSource = frmPrincipal.RegistroBindingSource
        For Each row As C1.Win.C1FlexGrid.Row In flexgrid.Rows
            ' If row.Index >= 2 Then ' Ignorar nodos
            '    Dim categoria As String = row("Status del avalúo").ToString()
            '    If categoria = "CANCELADO" Then
            '        row.StyleNew.BackColor = Color.Red
            '        'ElseIf categoria = "Verduras" Thena
            '        '    row.Style = estiloVerduras
            '    End If
            'If row.Item("Status_del_avalúo") <> Nothing Then
            If row.Item("Status del avalúo").ToString IsNot Nothing AndAlso row.Item("Status del avalúo").ToString = "Entregado y Cerrado" Then
                    '' If row.Item("Status_del_avalúo") = "Entregado y Cerrado" Then
                    ''MsgBox(row.Item("Status_del_avalúo").ToString)
                    'If row("Status_del_avalúo").ToString = "CANCELADO" Then
                    '    row.StyleNew.BackColor = Color.Red
                    row.StyleNew.BackColor = Color.FromArgb(255, 255, 210)
                    'End If
                End If
                If row.Item("Status del avalúo").ToString IsNot Nothing AndAlso row.Item("Status del avalúo").ToString = "Cancelado" Then
                    row.StyleNew.BackColor = Color.Red
                End If
                If row.Item("Nombre cliente").ToString IsNot Nothing AndAlso row.Item("Nombre cliente").ToString = "IMSS" Then
                    row.StyleNew.BackColor = Color.AliceBlue
                End If

            ' Else



            'Else

            '    row.DefaultCellStyle.BackColor = Color.White
            ' End If
            ' End If '
        Next row
    End Sub
    Public Sub guardar()
        frmPrincipal.Validate()
        frmPrincipal.RegistroPagosBindingSource.EndEdit()
        actualizaPagos(frmPrincipal.ProDSet.Pagos, frmPrincipal.IdTextBox.Text, IdContacto(frmPrincipal.ProDSet.Contacto, frmPrincipal.C1CboSol.Text))

        'frmPrincipal.C1FlexPagos.Item(1, "idCont") = IdContacto(frmPrincipal.ProDSet.Contacto, frmPrincipal.C1CboSol.Text)

        ' frmPrincipal.RegistroBindingSource.EndEdit()
        frmPrincipal.NotasBindingSource.EndEdit()
        frmPrincipal.RegistroBindingSource.EndEdit()
        frmPrincipal.ContactoBindingSource.EndEdit()

        frmPrincipal.RegistroPagosBindingSource.EndEdit() 'emdd Update(frmPrincipal.ProDSet)
        'frmPrincipal.TableAdapterManager.UpdateAll(frmPrincipal.ProDSet)
        'frmPrincipal.RegistroDataGridView.SuspendLayout()
        ' frmPrincipal.PagosBindingSource.EndEdit()
        'frmPrincipal.ContactoTableAdapter.Fill(frmPrincipal.ProDSet.Contacto)
        frmPrincipal.TableAdapterManager.UpdateAll(frmPrincipal.ProDSet)
        '' Console.WriteLine("registros guardados")
        'frmPrincipal.RegistroDataGridView.ResumeLayout()
        ' actualizaPagos(frmPrincipal.ProDSet.Pagos, frmPrincipal.IdTextBox.Text, IdContacto(frmPrincipal.ProDSet.Contacto, frmPrincipal.C1CboSol.Text))

    End Sub
    'Public Sub agregaContacto()
    '    If frmPrincipal.Solicitado_porComboBox.Text <> Nothing Then
    '        Dim valselect = frmPrincipal.Solicitado_porComboBox.Text
    '        Dim a = If(frmPrincipal.ContactoTableAdapter.Contar(frmPrincipal.Solicitado_porComboBox.Text), 0)
    '        If a = 0 Then
    '            'ContactoComboBox.Items.Add(ContactoComboBox.Text)


    '            frmPrincipal.ContactoTableAdapter.Insert(1, frmPrincipal.Solicitado_porComboBox.Text)
    '            frmPrincipal.ContactoTableAdapter.Fill(frmPrincipal.ProDSet.Contacto)
    '            'Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.FindString(valselect))frmPrincipal
    '            frmPrincipal.Solicitado_porComboBox.Text = frmPrincipal.Solicitado_porComboBox.GetItemText(frmPrincipal.Solicitado_porComboBox.Items.Item(frmPrincipal.Solicitado_porComboBox.FindString(valselect)))

    '            ' Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.Items.Item(Solicitado_porComboBox.Items.Count - 1))
    '            'Dim numitems = Solicitado_porComboBox.Items.Count()
    '            'Solicitado_porComboBox.SelectedIndex = numitems - 1
    '        End If
    '        'Console.WriteLine(a)
    '    End If
    'End Sub
    Public Sub agregaCboSol()

        If frmPrincipal.C1CboSol.Text <> Nothing Then
            Dim txtdt As New RegistroTableAdapter
            Dim dt = txtdt.GetData
            Dim valbusc = CInt(frmPrincipal.BindingNavigatorPositionItem.Text)
            'Dim txtdt = frmPrincipal.RegistroTableAdapter.GetData
            ' Dim currentRow As DataRow = txtdt.Rows(1)
            Dim index As Integer = FindRowIndex(dt, "id", valbusc)

            Dim valselect = frmPrincipal.C1CboSol.Text
            Dim a = If(frmPrincipal.ContactoTableAdapter.Contar(frmPrincipal.C1CboSol.Text), 0)
            If a = 0 Then
                'ContactoComboBox.Items.Add(ContactoComboBox.Text)
                ' FindRowIndex(,)

                frmPrincipal.ContactoTableAdapter.Insert(index + 1, frmPrincipal.C1CboSol.Text)
                frmPrincipal.ContactoTableAdapter.Fill(frmPrincipal.ProDSet.Contacto)
                'Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.FindString(valselect))frmPrincipal
                frmPrincipal.C1CboSol.Text = frmPrincipal.C1CboSol.GetItemText(frmPrincipal.C1CboSol.FindString(valselect), "contacto")

                ' Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.Items.Item(Solicitado_porComboBox.Items.Count - 1))
                'Dim numitems = Solicitado_porComboBox.Items.Count()
                'Solicitado_porComboBox.SelectedIndex = numitems - 1
            End If
            'Console.WriteLine(a)
        End If
    End Sub
    Public Sub agregaCboCli()

        If frmPrincipal.C1CboCli.Text <> Nothing Then
            Dim valselect = frmPrincipal.C1CboCli.Text
            Dim a = If(frmPrincipal.ClienteTableAdapter.Contar(frmPrincipal.C1CboCli.Text), 0)
            If a = 0 Then
                'ContactoComboBox.Items.Add(ContactoComboBox.Text)


                frmPrincipal.ClienteTableAdapter.Insert(1, frmPrincipal.C1CboCli.Text)
                frmPrincipal.ClienteTableAdapter.Fill(frmPrincipal.ProDSet.Cliente)
                'Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.FindString(valselect))frmPrincipal
                frmPrincipal.C1CboCli.Text = frmPrincipal.C1CboCli.GetItemText(frmPrincipal.C1CboCli.FindString(valselect), "Cliente")

                ' Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.Items.Item(Solicitado_porComboBox.Items.Count - 1))
                'Dim numitems = Solicitado_porComboBox.Items.Count()
                'Solicitado_porComboBox.SelectedIndex = numitems - 1
            End If
            'Console.WriteLine(a)
        End If
    End Sub
    Public Sub agregaCboTipo()

        If frmPrincipal.C1CboTipo.Text <> Nothing Then
            Dim valselect = frmPrincipal.C1CboTipo.Text
            Dim a = If(frmPrincipal.TipoAvaTableAdapter.Contar(frmPrincipal.C1CboTipo.Text), 0)
            If a = 0 Then
                'ContactoComboBox.Items.Add(ContactoComboBox.Text)


                frmPrincipal.TipoAvaTableAdapter.Insert(1, frmPrincipal.C1CboTipo.Text)
                frmPrincipal.TipoAvaTableAdapter.Fill(frmPrincipal.ProDSet.TipoAva)
                'Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.FindString(valselect))frmPrincipal
                frmPrincipal.C1CboTipo.Text = frmPrincipal.C1CboTipo.GetItemText(frmPrincipal.C1CboTipo.FindString(valselect), "TipoAva")

                ' Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.Items.Item(Solicitado_porComboBox.Items.Count - 1))
                'Dim numitems = Solicitado_porComboBox.Items.Count()
                'Solicitado_porComboBox.SelectedIndex = numitems - 1
            End If
            'Console.WriteLine(a)
        End If
    End Sub
    Public Sub agregaCboMun()

        If frmPrincipal.C1CboMun.Text <> Nothing Then
            Dim valselect = frmPrincipal.C1CboMun.Text
            Dim a = If(frmPrincipal.MunicipioTableAdapter.Contar(frmPrincipal.C1CboMun.Text), 0)
            If a = 0 Then
                'ContactoComboBox.Items.Add(ContactoComboBox.Text)


                frmPrincipal.MunicipioTableAdapter.Insert(1, frmPrincipal.C1CboMun.Text)
                frmPrincipal.MunicipioTableAdapter.Fill(frmPrincipal.ProDSet.Municipio)
                'Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.FindString(valselect))frmPrincipal
                frmPrincipal.C1CboMun.Text = frmPrincipal.C1CboMun.GetItemText(frmPrincipal.C1CboMun.FindString(valselect), "Municipio")

                ' Me.Solicitado_porComboBox.Text = Solicitado_porComboBox.GetItemText(Solicitado_porComboBox.Items.Item(Solicitado_porComboBox.Items.Count - 1))
                'Dim numitems = Solicitado_porComboBox.Items.Count()
                'Solicitado_porComboBox.SelectedIndex = numitems - 1
            End If
            'Console.WriteLine(a)
        End If

    End Sub
    Public Sub agregaFecha()

        frmPrincipal.C1DateSol.Value = Now
    End Sub
    Public Sub chkRbut()
        'frmPrincipal.SuspendLayout()
        'frmPrincipal.RegistroDataGridView.SuspendLayout()
        Dim txtdt As New RegistroTableAdapter
        Dim dt = txtdt.GetData
        Dim valbusc = CInt(frmPrincipal.BindingNavigatorPositionItem.Text)
        'Dim txtdt = frmPrincipal.RegistroTableAdapter.GetData
        ' Dim currentRow As DataRow = txtdt.Rows(1)
        Dim index As Integer = FindRowIndex(dt, "id", valbusc)

        'Dim index As Integer = FindRowIndex(txtdt.GetData, "id", CInt(frmPrincipal.BindingNavigatorPositionItem.Text))
        If index > -1 Then


            ' Dim ind = txtdt.Rows.IndexOf(index)
            Dim valsta = txtdt.GetData.Item(index).Item("Status del avalúo").ToString()
            'Dim valsta = frmPrincipal.BindingNavigatorPositionItem1.Text ' txtdt.GetData.Item(index).Item("Status del avalúo").ToString()
            ' MsgBox(valsta)
            For Each radiob As Control In frmPrincipal.GpoStatus.Controls
                Console.WriteLine("name radi" & radiob.Name)
                If TypeOf radiob Is RadioButton Then
                    Dim but As RadioButton = radiob
                    Console.WriteLine("val boton" & valsta)
                    If but.Text = valsta Then
                        but.Checked = True
                        'If valsta = "Cancelado" Then
                        '    but.ForeColor = Color.Red
                        'Else
                        '    but.ForeColor = Color.FromArgb(30, 57, 91)
                        'End If
                    Else
                        but.Checked = False
                    End If
                End If
            Next
        Else
            'Dim valsta = txtdt.GetData.Item(index).Item("Status del avalúo").ToString()
            For Each radiob As Control In frmPrincipal.GpoStatus.Controls
                If TypeOf radiob Is RadioButton Then
                    Dim but As RadioButton = radiob


                    If but.Text <> Nothing Then
                        but.Checked = False
                        'If valsta = "Cancelado" Then
                        '    but.ForeColor = Color.Red
                        'Else
                        '    but.ForeColor = Color.FromArgb(30, 57, 91)
                        'End If
                    Else
                        but.Checked = False
                    End If

                End If
            Next
        End If

        'frmPrincipal.RegistroDataGridView.ResumeLayout()
        'frmPrincipal.ResumeLayout()
    End Sub
    Public Function FindRowIndex(dt As DataTable, columnName As String, value As Object) As Integer
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)(columnName).Equals(CInt(value)) Then
                ' index = i
                Console.WriteLine("index Encontrado" & i)
                Return i

            End If
        Next
        Return -1 ' Si no se encuentra la fila, devolver -1
    End Function
    Public Sub agregaNota(nota As String)
        Dim fecha = Now
        Dim usuario = Environment.UserName
        Dim pc = Environment.UserDomainName
        Dim nl = Environment.NewLine
        frmPrincipal.C1txtNotas.ReadOnly = False
        If frmPrincipal.C1txtNotas.Text = Nothing Then

            'frmPrincipal.C1txtNotas.ForeColor = Color.AliceBlue
            frmPrincipal.C1txtNotas.Text = fecha & " - " & usuario & nl & nota
            ' frmPrincipal.C1txtNotas.ForeColor = Color.Gray

        Else
            frmPrincipal.C1txtNotas.Text = fecha & " - " & usuario & nl & nota & vbNewLine & "·························································································································" _
                                                                & vbNewLine & frmPrincipal.C1txtNotas.Text
        End If
        'frmPrincipal.C1TextBox1.Text = (frmPrincipal.C1TextBox1.Text & vbNewLine & Now & ". " & Environment.UserName & ". " & Environment.UserDomainName & Environment.NewLine & Me.C1TextBox1.Text)
        frmPrincipal.C1txtNotas.ReadOnly = True
    End Sub
    Public Sub agregaNotaRadio(radio As String)
        If frmPrincipal.BindingNavigatorCountItem1.ToString = "de 0" Then
            frmPrincipal.BindingNavigatorAddNewItem1.PerformClick()
        End If
        Dim fecha = Now
        Dim usuario = Environment.UserName
        Dim pc = Environment.UserDomainName
        Dim nl = Environment.NewLine
        frmPrincipal.C1txtNotas.ReadOnly = False
        If frmPrincipal.C1txtNotas.Text = Nothing Then
            frmPrincipal.C1txtNotas.Text = fecha & " - " & usuario & nl & radio
        Else
            frmPrincipal.C1txtNotas.Text = fecha & " - " & usuario & nl & radio & vbNewLine & "·························································································································" _
                                                                & vbNewLine & frmPrincipal.C1txtNotas.Text
        End If
        'frmPrincipal.C1TextBox1.Text = (frmPrincipal.C1TextBox1.Text & vbNewLine & Now & ". " & Environment.UserName & ". " & Environment.UserDomainName & Environment.NewLine & Me.C1TextBox1.Text)
        frmPrincipal.C1txtNotas.ReadOnly = True

    End Sub
    Public Function IdContacto(dtbuscar As DataTable, contacto As String) As Integer
        For Each row As DataRow In dtbuscar.Rows
            If row("Contacto") = contacto Then
                Return row("id")
                'row("Status del Avalúo") = newValor
                Console.WriteLine("ID: " & row("id"))
                Exit For
            End If

        Next
        Return 0
    End Function
    Public Sub actualizaPagos(dtbuscar As DataTable, idAva As Integer, newValor As Integer)
        For Each row As DataRow In dtbuscar.Rows
            If row("idAva") = idAva Then
                'row("IdContacto") =
                row("idCont") = newValor
                Console.WriteLine("ID: " & row("id"))
                'Exit For
            End If
        Next
    End Sub


End Module
