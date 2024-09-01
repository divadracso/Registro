Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPrincipal.MdiParent = Me
        frmSPago.MdiParent = Me
        frmPrincipal.Show()
    End Sub
End Class