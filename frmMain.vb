Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmPrincipal.MdiParent = Me
        frmSPago.MdiParent = Me
        frmPrincipal.WindowState = FormWindowState.Maximized
        frmPrincipal.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.Text = "Mi Formulario Centrado"
        If Me.IsHandleCreated AndAlso Me.Visible Then
            ' AddHandler MyBase.Resize, AddressOf Form1_Resize '(sender As Object, e As EventArgs) Handles 

            ' Llamar al método para centrar el texto del título
            'CenterFormTitle()
            'Dim lblTitulo As New Label()
            'lblTitulo.Text = "Mi Formulario Centrado"
            'lblTitulo.Font = New Font("Arial", 16, FontStyle.Bold)
            'lblTitulo.AutoSize = True
            'lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        End If
        '' Agregar el Label al formulario
        'Me.Controls.Add(lblTitulo)

        '' Centrar el Label
        'CenterLabel(lblTitulo)
    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) ' Handles MyBase.Paint
        ' Texto que deseas centrar
        Dim titulo As String = "Mi Formulario Centrado"

        ' Fuente y brocha para dibujar el texto
        Dim fuente As New Font("Arial", 16, FontStyle.Bold)
        Dim brocha As New SolidBrush(Color.Black)

        ' Tamaño del texto
        Dim tamañoTexto As SizeF = e.Graphics.MeasureString(titulo, fuente)

        ' Calcular la posición para centrar el texto
        Dim x As Single = (Me.ClientSize.Width - tamañoTexto.Width) / 2
        Dim y As Single = (Me.ClientSize.Height - tamañoTexto.Height) / 2

        ' Dibujar el texto centrado
        '  e.Graphics.DrawString(titulo, fuente, brocha, x, y)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) ' Handles MyBase.Resize
        ' Llamar al método para centrar el texto del título cada vez que se redimensione el formulario
        'CenterFormTitle()
        ' CenterLabel(Me.Controls.OfType(Of Label)().FirstOrDefault())
        MsgBox(Me.Text)
        CenterFormTitle()
    End Sub
    Dim a As String = Me.Text
    Private Sub CenterFormTitle()
        a = Me.Text
        ' Obtener el tamaño del texto del título
        Dim g As Graphics = Me.CreateGraphics()
        Dim tamañoTexto As SizeF = g.MeasureString(Me.Text, Me.Font)

        ' Calcular la posición para centrar el texto
        Dim espacioDisponible As Integer = Me.ClientSize.Width - tamañoTexto.Width
        Dim espacioIzquierda As Integer = CInt(espacioDisponible / 2)

        ' Establecer el nuevo texto del formulario con espacios para centrarlo
        Me.Text = New String(" "c, CInt(espacioIzquierda / 6)) & a '"Mi Formulario Centrado"
    End Sub
    Private Sub CenterLabel(lbl As Label)
        If lbl IsNot Nothing Then
            lbl.Left = (Me.ClientSize.Width - lbl.Width) / 2
            lbl.Top = (Me.ClientSize.Height - lbl.Height) / 2
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        frmPrincipal.MdiParent = Me
        frmSPago.MdiParent = Me
        frmPrincipal.WindowState = FormWindowState.Maximized
        frmPrincipal.Show()
    End Sub
End Class