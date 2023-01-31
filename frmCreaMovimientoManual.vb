Public Class frmCreaMovimientoManual

    Public fechaDocumento As String
    Public idAlmacenDestino As String

    Private Sub bActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bActualizar.Click
        fechaDocumento = cbFecha.Text
        idAlmacenDestino = advAlmacen.Text
        If (fechaDocumento.ToString.Length = 0 Or idAlmacenDestino.ToString.Length = 0) Then
            MsgBox("La fecha y el almacén son datos obligatorios.")
        Else
            realizarMovimientos(fechaDocumento, idAlmacenDestino)
        End If
    End Sub

    Public Sub realizarMovimientos(ByVal fechaDocumento As String, ByVal idAlmacenDestino As String)
        'Guardo la tabla del Grid donde haya X modifico la FechaEnvio e IDAlmacen
        Dim dtSinFiltrar As New DataTable
        dtSinFiltrar = Grid2.DataSource

        Dim dt As New DataTable
        Dim cont As Integer = 0
        'Recorre la tabla y me quedo con la de X
        For i As Integer = 0 To dtSinFiltrar.Columns.Count - 1
            dt.Columns.Add(dtSinFiltrar.Columns(i).ColumnName)
        Next

        For Each dr As DataRow In dtSinFiltrar.Rows
            If dtSinFiltrar.Rows(cont)("Confirmacion").ToString = "X" Then
                dt.Rows.Add(dtSinFiltrar.Rows(cont).ItemArray)
            End If
            cont += 1
        Next
        Dim sqlact As String
        Dim sqlins As String
        'Realiza la actualización recorriendo la nueva tabla
        Dim aux As New Business.ClasesTecozam.MetodosAuxiliares
        Dim fecha As Date
        fecha = Today
        For Each dr As DataRow In dt.Rows
            'Actualizo el articulo con su numero de serie
            sqlact = "UPDATE tbControlArticulosNSerie SET FechaEnvio ='" & fechaDocumento & "', IDAlmacen = '" & idAlmacenDestino & "', FechaModificacionAudi = '" & Today & "', UsuarioAudi = '" & ExpertisApp.Token.UserName.ToString & "' WHERE IDArticulo = '" & dr("IDArticulo") & "' and NSerie = '" & dr("NSerie") & "'"
            aux.EjecutarSql(sqlact)
            'Inserto el movimiento en tbhistoricoActivos
            sqlins = "INSERT INTO tbHistoricoActivos(IDLineaMovimiento, IDAlmacenOrigen, IDAlmacenDestino, IDArticulo, NSerie, FechaEnvio, UsuarioAudi, FechaCreacionAudi, FechaModificacionAudi)" & _
                    " VALUES('" & aux.devuelveAutonumeri & "','" & dr("IDAlmacen") & "','" & idAlmacenDestino & "', '" & dr("IDArticulo") & "', '" & dr("NSerie") & "', '" & fechaDocumento & "', '" & ExpertisApp.Token.UserName.ToString & "', '" & Today & "', '" & Today & "')"
            aux.EjecutarSql(sqlins)
        Next

        MessageBox.Show("Se han actualizado los articulos con su número de serie correctamente.", "Proceso confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
    End Sub
End Class