Public Class frmPagosPC
    Private Sub DgoPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1FlexGrid1.DataSource = frmPrincipal.RegistroPagosBindingSource
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


End Class