Public Class frmDgoPagos
    Private Sub DgoPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.MdiParent = frmPrincipal.ParentForm
        C1FlexGrid1.DataSource = frmPrincipal.RegistroPagosBindingSource
        Me.Aceptar.DialogResult = DialogResult.OK

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Aceptar.DialogResult = DialogResult.OK
    End Sub
End Class