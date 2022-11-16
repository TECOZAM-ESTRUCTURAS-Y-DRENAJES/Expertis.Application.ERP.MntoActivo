Imports Solmicro.Expertis.Application.ERP.CommonClasses

Public Class CINumeroDeSerie
    Inherits Solmicro.Expertis.Engine.UI.CIMnto



    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow

        If Length(e.Row.DataRow("IDEstadoActivo")) > 0 Then
            e.Row.RowStyle = Grid.FormatStyles("FMT" & e.Row.DataRow("IDEstadoActivo"))
        End If
    End Sub


    Private Sub CINumeroDeSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            GridFormatStyle.CrearFormatos(Grid, GridFormatStyle.TipoFormato.EstadoActivo)
        End If
    End Sub
End Class