Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmTiempo
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
            Label1.Text = "Sistema Cargando " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Me.Dispose()
            Me.Close()
        End If


    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class