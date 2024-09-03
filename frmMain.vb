Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPrincipal.MdiParent = Me
        frmSPago.MdiParent = Me
        frmPrincipal.WindowState = FormWindowState.Maximized
        frmPrincipal.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class