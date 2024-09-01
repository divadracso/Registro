Imports C1.Win.C1FlexGrid
Imports C1.Win.C1List
Imports Registro.ProDSetTableAdapters

Public Class frmSPago
    Private Sub frmSPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        'Me.PagosTableAdapter.Fill(Me.ProDSet.Pagos)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        'Me.PagosTableAdapter.Fill(Me.ProDSet.Pagos)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Contacto' Puede moverla o quitarla según sea necesario.
        Me.ContactoTableAdapter.Fill(Me.ProDSet.Contacto)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Notas' Puede moverla o quitarla según sea necesario.
        'Me.NotasTableAdapter.Fill(Me.ProDSet.Notas)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Registro' Puede moverla o quitarla según sea necesario.
        'Me.RegistroTableAdapter.Fill(Me.ProDSet.Registro)
        'C1FlexGrid1.ContextMenu = ContextMenu
        'C1FlexGrid1.ContextMenuStrip = ContextMenuStrip
        If Me.IsHandleCreated AndAlso Me.Visible Then
            C1Combo1.SelectedIndex = -1
            ' Ordenar los elementos en forma ascendente
            'Dim items As List(Of String) = New List(Of String)()

            '' Recoger los elementos del C1Combo
            'For i As Integer = 0 To C1Combo1.ListCount - 1

            '    items.Add(C1Combo1.Row)
            'Next
            '' Ordenar los elementos
            'items.Sort()

            '    ' Limpiar el C1Combo y añadir los elementos ordenados
            '    C1Combo1.ClearItems()
            '    For Each item As String In items
            '        C1Combo1.AddItem(item)
            '    Next
            'C1Combo1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles C1Combo1.SelectionChangeCommitted
            AddHandler C1Combo1.SelectionChangeCommitted, AddressOf C1Combo1_SelectionChangeCommitted
        End If

    End Sub



    Private Sub C1FlexGrid1_Click(sender As Object, e As EventArgs) Handles C1FlexReg.Click

    End Sub

    Private Sub C1FlexGrid1_DataBindingComplete(sender As Object, e As EventArgs) Handles C1FlexReg.DataBindingComplete
        Console.WriteLine("Completado")
    End Sub

    Private Sub C1Combo1_Validated(sender As Object, e As EventArgs) ' Handles C1Combo1.Validated
        'Me.PagosTableAdapter.FillByContacto(ProDSet.Pagos, CInt(C1Combo1.SelectedValue.ToString))
        'Me.RegistroTableAdapter.FillByContacto(ProDSet.Registro, CInt(C1Combo1.SelectedValue.ToString))
        '' Me.C1FlexReg.Aggregate(sum)
        'C1FlexReg.DataSource = RegistroBindingSource
    End Sub

    Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles c1btnSol.Click
        ' Asumiendo que tienes un C1FlexGrid llamado flexGrid
        C1FlexReg.DataSource = RegistroBindingSource '.GetDataByContacto(CInt(C1Combo1.SelectedValue.ToString)) ' Tu fuente de datos

        ' Crear un diccionario para almacenar los subtotales
        Dim subtotals As New Dictionary(Of String, Integer)

        ' Recorrer las filas del FlexGrid
        For Each row As C1.Win.C1FlexGrid.Row In C1FlexReg.Rows
            If row.Index >= 1 Then
                If Not row.IsNode Then
                    Dim groupKey As String = row("Domicilio").ToString() & row("Folio").ToString() ' Columna por la que quieres agrupar
                    'Dim groupKey2 As String = row("Folio").ToString()
                    Dim value As Decimal = Convert.ToDecimal(row("Cant")) ' Columna que quieres sumar
                    'Dim value = row("pagos")
                    ' Sumar los valores en el diccionario
                    If subtotals.ContainsKey(groupKey) Then
                        subtotals(groupKey) += value
                    Else
                        subtotals.Add(groupKey, value)

                    End If
                End If
            End If
        Next
        ' For Each row As C1.Win.C1FlexGrid.Row In C1FlexReg.Rows
        'If row.Index >= 1 Then
        ' Eliminar todas las filas
        For i As Integer = C1FlexReg.Rows.Count - 1 To 1 Step -1 ' Empieza desde el final para evitar problemas de índice
            C1FlexReg.RemoveItem(i)
        Next
        'row.Visible = False
        'End If
        ' Next
        ' Añadir filas de subtotales al FlexGrid
        For Each key As String In subtotals.Keys
            Dim subtotalRow As C1.Win.C1FlexGrid.Row = C1FlexReg.Rows.Add()
            subtotalRow("Domicilio") = key
            subtotalRow("Folio") = key
            subtotalRow("Cant") = FormatCurrency(subtotals(key).ToString)
            C1FlexGrid1.Cols("Cant").Format = "C2"
            Console.WriteLine(FormatCurrency(subtotals(key).ToString))
            'subtotalRow.Format = FormatCurrency()
            'subtotalRow.Style = C1FlexReg.Styles("Subtotal")
        Next

        ' Variable para almacenar la suma
        Dim suma As Double = 0

        ' Índice de la columna que deseas sumar
        ' Dim columnIndex As Integer = 2 ' Cambia esto al índice de tu columna

        ' Recorrer las filas del FlexGrid y sumar los valores de la columna especificada
        For i As Integer = 1 To C1FlexReg.Rows.Count - 1 ' Empieza en 1 para omitir la fila de encabezado
            suma += Convert.ToDouble(C1FlexReg(i, "Cant"))
        Next
        ' Añadir un nuevo registro al final del FlexGrid para mostrar la suma
        Dim nuevaFila As Integer = C1FlexReg.Rows.Count
        C1FlexReg.Rows.Add()
        C1FlexReg.Item(nuevaFila, 4) = "Gran Total" ' Puedes ajustar esto según la estructura de tus datos
        C1FlexReg.Item(nuevaFila, "Cant") = suma


        For columnIndex = 1 To C1FlexReg.Cols.Count
            If columnIndex > 5 And columnIndex < C1FlexReg.Cols.Count - 6 Then
                C1FlexReg.Cols(columnIndex).Visible = False
            End If
        Next

        ' Mostrar la suma en un Label o en la consola
        'Console.WriteLine("La suma de la columna es: " & suma)
        '' O, por ejemplo, en un Label
        '' Label1.Text = "La suma de la columna es: " & suma
        'C1FlexGrid1.Rows.Add(1 AddItem(suma, "Cant")
        'C1FlexReg.DataSource = GetData() ' Tu fuente de datos
        'C1FlexReg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Nodes
        'C1FlexReg.Tree.Column = 1 ' Columna por la que quieres agrupar

        '' Agrupar por la primera columna
        'C1FlexReg.Gr(1)



        '' Me.RegistroTableAdapter.ScalarQuery(ProDSet.Registro, CInt(C1Combo1.SelectedValue.ToString))
        '' C1FlexReg.DataSource = RegistroBindingSource
    End Sub

    Private Sub C1Combo1_SelectionChangeCommitted(sender As Object, e As EventArgs) 'Handles C1Combo1.SelectionChangeCommitted
        Dim dt As New DataTable

        'bs.DataSource = Me.PagosTableAdapter.FillByContacto(ProDSet.Pagos, CInt(C1Combo1.SelectedValue.ToString))
        dt = Me.PagosTableAdapter.GetDataByContacto(CInt(C1Combo1.SelectedValue.ToString))

        DataGridView1.DataSource = Me.PagosTableAdapter.GetDataByContacto(CInt(C1Combo1.SelectedValue.ToString))
        Me.PagosTableAdapter.FillByContacto(ProDSet.Pagos, CInt(C1Combo1.SelectedValue.ToString))
        Me.RegistroTableAdapter.FillByContacto(ProDSet.Registro, CInt(C1Combo1.SelectedValue.ToString))
        ' Me.C1FlexReg.Aggregate(sum)
        'C1FlexReg.DataSource = RegistroBindingSource
        For Each col As System.Data.DataColumn In dt.Columns
            Console.WriteLine(col.ColumnName)
        Next
        ' Asumiendo que tienes un C1FlexGrid llamado flexGrid
        '    C1FlexReg.DataSource = RegistroBindingSource '.GetDataByContacto(CInt(C1Combo1.SelectedValue.ToString)) ' Tu fuente de datos

        ' Crear un diccionario para almacenar los subtotales
        Dim subtotals As New Dictionary(Of String, Integer)


        ' Recorrer las filas del FlexGrid
        For Each row As C1.Win.C1FlexGrid.Row In C1FlexReg.Rows
            If row.Index >= 1 Then
                If Not row.IsNode Then
                    Dim groupKey As String = row("Domicilio").ToString() '& row("Folio").ToString() ' Columna por la que quieres agrupar
                    'Dim groupKey2 As String = row("Folio").ToString()
                    Dim value As Decimal = Convert.ToDecimal(row("Cant")) ' Columna que quieres sumar
                    'Dim value = row("pagos")
                    ' Sumar los valores en el diccionario
                    If subtotals.ContainsKey(groupKey) Then
                        subtotals(groupKey) += value
                    Else
                        subtotals.Add(groupKey, value)

                    End If

                End If
            End If
        Next
        ' For Each row As C1.Win.C1FlexGrid.Row In C1FlexReg.Rows
        'If row.Index >= 1 Then
        ' Eliminar todas las filas
        For i As Integer = C1FlexReg.Rows.Count - 1 To 1 Step -1 ' Empieza desde el final para evitar problemas de índice
            C1FlexReg.RemoveItem(i)
        Next
        'row.Visible = False
        'End If
        ' Next
        ' Añadir filas de subtotales al FlexGrid
        For Each key As String In subtotals.Keys
            Dim subtotalRow As C1.Win.C1FlexGrid.Row = C1FlexReg.Rows.Add()
            subtotalRow("Domicilio") = key
            subtotalRow("Folio") = key
            subtotalRow("Cant") = FormatCurrency(subtotals(key).ToString)
            C1FlexGrid1.Cols("Cant").Format = "C2"
            Console.WriteLine(FormatCurrency(subtotals(key).ToString))
            'subtotalRow.Format = FormatCurrency()
            'subtotalRow.Style = C1FlexReg.Styles("Subtotal")
        Next

        ' Variable para almacenar la suma
        Dim suma As Double = 0

        ' Índice de la columna que deseas sumar
        ' Dim columnIndex As Integer = 2 ' Cambia esto al índice de tu columna

        ' Recorrer las filas del FlexGrid y sumar los valores de la columna especificada
        For i As Integer = 1 To C1FlexReg.Rows.Count - 1 ' Empieza en 1 para omitir la fila de encabezado
            suma += Convert.ToDouble(C1FlexReg(i, "Cant"))
        Next
        Dim fuenteActual As Font = C1FlexGrid1.Font
        ' Añadir un nuevo registro al final del FlexGrid para mostrar la suma
        Dim nuevaFila As Integer = C1FlexReg.Rows.Count
        'Dim fuente As FontStyle = FontStyle.Bold
        Dim fuente As Font = New Font(fuenteActual.FontFamily, fuenteActual.Size, FontStyle.Bold)

        Dim estilo As CellStyle = C1FlexGrid1.Styles.Add("BoldStyle")
        estilo.Font = fuente
        C1FlexReg.Rows.Add()
        ' C1FlexReg.Font = New Font("Arial", 12, FontStyle.Bold)
        C1FlexReg.Item(nuevaFila, 4) = "Gran Total" ' Puedes ajustar esto según la estructura de tus datos
        C1FlexReg.Item(nuevaFila, "Cant") = suma
        'C1FlexReg.Font = New Font("Arial", 12, FontStyle.Bold)
        C1FlexReg.SetCellStyle(nuevaFila, 4, estilo)
        C1FlexReg.SetCellStyle(nuevaFila, "Cant", estilo)

        For columnIndex = 1 To C1FlexReg.Cols.Count
            If columnIndex > 5 And columnIndex < C1FlexReg.Cols.Count - 6 Then
                C1FlexReg.Cols(columnIndex).Visible = False
            End If
        Next

        ' Mostrar la suma en un Label o en la consola
        'Console.WriteLine("La suma de la columna es: " & suma)
        '' O, por ejemplo, en un Label
        '' Label1.Text = "La suma de la columna es: " & suma
        'C1FlexGrid1.Rows.Add(1 AddItem(suma, "Cant")
        'C1FlexReg.DataSource = GetData() ' Tu fuente de datos
        'C1FlexReg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Nodes
        'C1FlexReg.Tree.Column = 1 ' Columna por la que quieres agrupar

        '' Agrupar por la primera columna
        'C1FlexReg.Gr(1)



        '' Me.RegistroTableAdapter.ScalarQuery(ProDSet.Registro, CInt(C1Combo1.SelectedValue.ToString))
        '' C1FlexReg.DataSource = RegistroBindingSo
        C1FlexReg.AutoResize = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds As New ProDSet
        Dim ta As New RegistroTableAdapter
        Dim bs As New BindingSource

        'Me.RegistroTableAdapter.ScalarQueryAgrupa(ProDSet.Registro)
        ta.ScalarQueryAgrupa(ds.Registro)
        bs.DataSource = ds.Registro

        C1FlexGrid2.DataSource = bs 'ds.Registro
        Dim cellStyle As CellStyle = C1FlexGrid1.Styles.Add("CurrencyStyle")
        cellStyle.Format = "C2" ' Formato de moneda con 2 decimales
        For columnIndex = 0 To C1FlexGrid2.Cols.Count - 1
            If columnIndex <> 1 And columnIndex <> 8 And columnIndex <> 12 And columnIndex <> C1FlexGrid2.Cols.Count - 3 Then
                C1FlexGrid2.Cols(columnIndex).Visible = False
            End If
        Next
        ' Aplicar el estilo a toda la columna
        For fila As Integer = 1 To C1FlexGrid2.Rows.Count - 1
            C1FlexGrid2.SetCellStyle(fila, "Total2", cellStyle)
        Next

    End Sub
End Class