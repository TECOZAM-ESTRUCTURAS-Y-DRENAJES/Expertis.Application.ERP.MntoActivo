Public Class vfrmCIMovimientosActivos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub

    Private Sub vfrmCIMovimientosActivos_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, Articulo.Text, FilterType.String)
        e.Filter.Add("NSerie", FilterOperator.Equal, advNSerie.Text, FilterType.String)
        e.Filter.Add("IDAlmacenOrigen", FilterOperator.Equal, Almacen.Text, FilterType.String)
        e.Filter.Add("IDAlmacenDestino", FilterOperator.Equal, AlmacenDestino.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, TipoArticulo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        e.Filter.Add("FechaEnvio", FilterOperator.GreaterThanOrEqual, FechaDocumentoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaEnvio", FilterOperator.LessThanOrEqual, FechaDocumentoHasta.Value, FilterType.DateTime)

    End Sub
End Class