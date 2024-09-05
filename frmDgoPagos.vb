Public Class frmDgoPagos
    Private Sub DgoPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.MdiParent = frmPrincipal.ParentForm
        C1FlexGrid1.DataSource = frmPrincipal.RegistroPagosBindingSource
        'Me.btnAceptar.DialogResult = DialogResult.OK
        C1FlexGrid1.Cols("Cant").Format = "C2"
        C1FlexGrid1.Cols("id").Visible = False
        C1FlexGrid1.Cols("idAva").Visible = False
        C1FlexGrid1.Cols("idCont").Visible = False
        C1FlexGrid1.Cols.Item("Cant").TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter ' = "C. Pagada"
        C1FlexGrid1.Cols.Item("Fecha").TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter ' = "Fecha de Pago"
        C1FlexGrid1.Cols.Item("Fecha").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter ' = "Fecha de Pago"

        C1FlexGrid1.Cols.Item("Cant").Caption = "C. Pagada"
        C1FlexGrid1.Cols.Item("Fecha").Caption = "Fecha de Pago"
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Me.btnAceptar.DialogResult = DialogResult.OK
    End Sub
End Class