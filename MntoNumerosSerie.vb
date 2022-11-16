Imports Solmicro.Expertis.Application.ERP.CommonClasses
Imports Janus.Windows.GridEX
Imports System.Drawing.Color

Public Class MntoNumerosSerie
    Inherits Solmicro.Expertis.Engine.UI.GridMnto
    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub

    Protected Overridable Sub LoadFormActions()
        'Me.FormActions.Add("Preventivos asociados a ese Activo", AddressOf AccionCargarPreventivo)
        Me.FormActions.Add("Vincular Activos", AddressOf VincularActivos)
    End Sub
    Private Sub VincularActivos()
        Dim dt As New DataTable
        dt = Grid.DataSource

        For Each dr As DataRow In dt.Rows
            If dr("IDActivo").ToString.Length = 0 Then
                Dim filtro As New Filter
                'MsgBox(dr("NSerie"))
                filtro.Add("NSerie", FilterOperator.Equal, dr("NSerie"))
                Dim dtactivo As New DataTable
                dtactivo = New BE.DataEngine().Filter("tbMaestroActivo", filtro)
                Dim idactivo As String
                idactivo = dtactivo.Rows(0)("IDActivo")

                Dim artNSerie As New Business.Negocio.ArticuloNSerie
                artNSerie.ActualizaArticuloNSerie(idactivo, dr("NSerie"))
            Else

            End If
        Next
        

    End Sub

    Private Sub MntoNumerosSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridFormatStyle.CrearFormatos(Grid, GridFormatStyle.TipoFormato.EstadoActivo)

        LoadFormActions()
        Me.UpdateData()

    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        Try
            If Length(e.Row.DataRow("IDEstadoActivo")) > 0 Then
                e.Row.RowStyle = Grid.FormatStyles("FMT" & e.Row.DataRow("IDEstadoActivo"))
            End If
        Catch ex As Exception

        End Try
       
    End Sub
End Class