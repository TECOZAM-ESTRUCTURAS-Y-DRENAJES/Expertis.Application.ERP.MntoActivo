Public Class FrmCambioArticulo

    Public ReadOnly Property IDArticulo() As String
        Get
            Return Me.AdvArticulo.Value
        End Get
    End Property

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Length(Me.AdvArticulo.Value) > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else : ExpertisApp.GenerateMessage("No ha seleccionado un artículo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub AdvArticulo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvArticulo.SetPredefinedFilter
        e.Filter.Add("NSerieObligatorio", FilterOperator.Equal, 1)
    End Sub

End Class