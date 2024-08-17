Imports Registro.ProDSetTableAdapters

Public Class frmSPago
    Private Sub frmSPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProDSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.ProDSet.Pagos)
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



    Private Sub C1FlexGrid1_Click(sender As Object, e As EventArgs) Handles C1FlexReg.Click

    End Sub

    Private Sub C1FlexGrid1_DataBindingComplete(sender As Object, e As EventArgs) Handles C1FlexReg.DataBindingComplete
        Console.WriteLine("Completado")
    End Sub

    Private Sub C1Combo1_Validated(sender As Object, e As EventArgs) Handles C1Combo1.Validated
        Me.PagosTableAdapter.FillByContacto(ProDSet.Pagos, CInt(C1Combo1.SelectedValue.ToString))
    End Sub
End Class