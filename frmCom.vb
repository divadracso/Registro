Public Class frmCom
    Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Dim fecha = Now
        'Dim usuario = Environment.UserName
        'Dim pc = Environment.UserDomainName
        'frmPrincipal.C1txtNotas.ReadOnly = False
        'If frmPrincipal.C1txtNotas.Text = Nothing Then
        '    frmPrincipal.C1txtNotas.Text = fecha & ". " & usuario & ". " & pc & Environment.NewLine & Me.C1TextBox1.Text
        'Else
        '    frmPrincipal.C1txtNotas.Text = frmPrincipal.C1txtNotas.Text & vbNewLine & fecha & ". " & usuario & ". " & pc & Environment.NewLine & Me.C1TextBox1.Text
        'End If
        ''frmPrincipal.C1TextBox1.Text = (frmPrincipal.C1TextBox1.Text & vbNewLine & Now & ". " & Environment.UserName & ". " & Environment.UserDomainName & Environment.NewLine & Me.C1TextBox1.Text)
        'frmPrincipal.C1txtNotas.ReadOnly = True
        agregaNota(C1TextBox1.Text)
        'Me.Validate()
        '' frmPrincipal.RegistroBindingSource.EndEdit()
        'frmPrincipal.NotasBindingSource.EndEdit()

        '' frmPrincipal.RegistroTableAdapter.Update(frmPrincipal.ProDSet)

        ''ContactoTableAdapter.Fill(ProDSet.Contacto)
        'frmPrincipal.TableAdapterManager.UpdateAll(frmPrincipal.ProDSet)
        guardar()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class