Imports Registro.ProDSetTableAdapters

Public Class frmSPago
    Private Sub frmSPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        'Me.PagosTableAdapter.Fill(Me.ProDSet.Pagos)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Contacto' Puede moverla o quitarla según sea necesario.
        Me.ContactoTableAdapter.Fill(Me.ProDSet.Contacto)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Notas' Puede moverla o quitarla según sea necesario.
        'Me.NotasTableAdapter.Fill(Me.ProDSet.Notas)
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.Fill(Me.ProDSet.Registro)
        'C1FlexGrid1.ContextMenu = ContextMenu
        'C1FlexGrid1.ContextMenuStrip = ContextMenuStrip

    End Sub

    Private Sub C1FlexGridSearchPanel1_Load(sender As Object, e As EventArgs) Handles C1FlexGridSearchPanel1.Load
        'C1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(C1FlexGrid1, C1FlexGridSearchPanel1)
        C1FlexGridSearchPanel1.HighlightSearchResults = True


    End Sub

    Private Sub C1FlexGrid1_Click(sender As Object, e As EventArgs) Handles C1FlexGrid1.Click

    End Sub

    Private Sub C1FlexGrid1_DataBindingComplete(sender As Object, e As EventArgs) Handles C1FlexGrid1.DataBindingComplete
        Console.WriteLine("Completado")
    End Sub

    Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles C1Button1.Click
        Dim dt As New RegistroTableAdapter
        Dim nuevaColumna As New DataGridViewTextBoxColumn()
        nuevaColumna.Name = "Total"
        nuevaColumna.HeaderText = "Total"
        nuevaColumna.DataPropertyName = "Total"

        ' Agregar la columna al DataGridView
        DataGridView1.Columns.Add(nuevaColumna)

        ' DataGridView1.Columns(1).Name = "Nombre"

        dt.FillBy(ProDSet.Registro)

        'Dim bi As BindingSource
        'bi.DataSource = dt
        'RegistroTableAdapter.FillBy(ProDSet.Registro)
        'C1FlexGrid1.DataSource = RegistroBindingSource
        'DataGridView1.DataSource = dt
        DataGridView1.DataSource = RegistroBindingSource
        DataGridView1.Columns.Remove("id")

        MsgBox(Me.RegistroTableAdapter.ScalarQuery("GDL"))
    End Sub
End Class