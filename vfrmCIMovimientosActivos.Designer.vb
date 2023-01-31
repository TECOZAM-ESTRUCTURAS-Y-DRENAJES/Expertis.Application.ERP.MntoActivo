<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vfrmCIMovimientosActivos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vfrmCIMovimientosActivos))
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.Articulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Almacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.AlmacenDestino = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipoArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TipoArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.advNSerie = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFDocumentoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFDocumentoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.FechaDocumentoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FechaDocumentoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblfwiFDocumentoDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFDocumentoHasta)
        Me.FilterPanel.Controls.Add(Me.FechaDocumentoDesde)
        Me.FilterPanel.Controls.Add(Me.FechaDocumentoHasta)
        Me.FilterPanel.Controls.Add(Me.advNSerie)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipoArticulo)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.TipoArticulo)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.AlmacenDestino)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.Articulo)
        Me.FilterPanel.Controls.Add(Me.Almacen)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 245)
        Me.FilterPanel.Size = New System.Drawing.Size(906, 119)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(906, 245)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(906, 245)
        Me.Grid.ViewName = "vHistoricoActivos"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(906, 364)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(906, 364)
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(24, 40)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 85
        Me.lblfwiArticulo.Tag = "IdRec=4430;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(237, 39)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(96, 13)
        Me.lblfwiAlmacen.TabIndex = 86
        Me.lblfwiAlmacen.Tag = "IdRec=4408;"
        Me.lblfwiAlmacen.Text = "Almacén origen"
        '
        'Articulo
        '
        Me.Articulo.DisabledBackColor = System.Drawing.Color.White
        Me.Articulo.EntityName = "Articulo"
        Me.Articulo.Location = New System.Drawing.Point(105, 35)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.PrimaryDataFields = "IDArticulo"
        Me.Articulo.SecondaryDataFields = "IDArticulo"
        Me.Articulo.Size = New System.Drawing.Size(108, 23)
        Me.Articulo.TabIndex = 83
        Me.Articulo.ViewName = "tbMaestroArticulo"
        '
        'Almacen
        '
        Me.Almacen.DisabledBackColor = System.Drawing.Color.White
        Me.Almacen.EntityName = "Almacen"
        Me.Almacen.Location = New System.Drawing.Point(354, 35)
        Me.Almacen.Name = "Almacen"
        Me.Almacen.PrimaryDataFields = "IDAlmacen"
        Me.Almacen.SecondaryDataFields = "IDAlmacen"
        Me.Almacen.Size = New System.Drawing.Size(108, 23)
        Me.Almacen.TabIndex = 84
        Me.Almacen.ViewName = "tbMaestroAlmacen"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(237, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Tag = "IdRec=4408;"
        Me.Label1.Text = "Almacén destino"
        '
        'AlmacenDestino
        '
        Me.AlmacenDestino.DisabledBackColor = System.Drawing.Color.White
        Me.AlmacenDestino.EntityName = "Almacen"
        Me.AlmacenDestino.Location = New System.Drawing.Point(354, 75)
        Me.AlmacenDestino.Name = "AlmacenDestino"
        Me.AlmacenDestino.PrimaryDataFields = "IDAlmacen"
        Me.AlmacenDestino.SecondaryDataFields = "IDAlmacen"
        Me.AlmacenDestino.Size = New System.Drawing.Size(108, 23)
        Me.AlmacenDestino.TabIndex = 87
        Me.AlmacenDestino.ViewName = "tbMaestroAlmacen"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(493, 80)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 91
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'lblfwiTipoArticulo
        '
        Me.lblfwiTipoArticulo.Location = New System.Drawing.Point(493, 39)
        Me.lblfwiTipoArticulo.Name = "lblfwiTipoArticulo"
        Me.lblfwiTipoArticulo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipoArticulo.TabIndex = 92
        Me.lblfwiTipoArticulo.Tag = "IdRec=4456;"
        Me.lblfwiTipoArticulo.Text = "Tipo"
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(565, 75)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(100, 23)
        Me.AdvFamilia.TabIndex = 90
        Me.AdvFamilia.ViewName = "tbMaestroFamilia"
        '
        'TipoArticulo
        '
        Me.TipoArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.TipoArticulo.EntityName = "TipoArticulo"
        Me.TipoArticulo.Location = New System.Drawing.Point(565, 34)
        Me.TipoArticulo.Name = "TipoArticulo"
        Me.TipoArticulo.PrimaryDataFields = "IDTipo"
        Me.TipoArticulo.SecondaryDataFields = "IDTipo"
        Me.TipoArticulo.Size = New System.Drawing.Size(100, 23)
        Me.TipoArticulo.TabIndex = 89
        Me.TipoArticulo.ViewName = "tbMaestroTipoArticulo"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(27, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Nº Serie"
        '
        'advNSerie
        '
        Me.advNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.advNSerie.EntityName = "ActivoNSerie"
        Me.advNSerie.Location = New System.Drawing.Point(105, 75)
        Me.advNSerie.Name = "advNSerie"
        Me.advNSerie.PrimaryDataFields = "NSerie"
        Me.advNSerie.SecondaryDataFields = "NSerie"
        Me.advNSerie.Size = New System.Drawing.Size(108, 23)
        Me.advNSerie.TabIndex = 94
        Me.advNSerie.ViewName = "tbControlArticulosNSerie"
        '
        'lblfwiFDocumentoDesde
        '
        Me.lblfwiFDocumentoDesde.Location = New System.Drawing.Point(687, 39)
        Me.lblfwiFDocumentoDesde.Name = "lblfwiFDocumentoDesde"
        Me.lblfwiFDocumentoDesde.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiFDocumentoDesde.TabIndex = 97
        Me.lblfwiFDocumentoDesde.Tag = "IdRec=5251;"
        Me.lblfwiFDocumentoDesde.Text = "Fecha Doc. >="
        '
        'lblfwiFDocumentoHasta
        '
        Me.lblfwiFDocumentoHasta.Location = New System.Drawing.Point(687, 80)
        Me.lblfwiFDocumentoHasta.Name = "lblfwiFDocumentoHasta"
        Me.lblfwiFDocumentoHasta.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiFDocumentoHasta.TabIndex = 98
        Me.lblfwiFDocumentoHasta.Tag = "IdRec=4251;"
        Me.lblfwiFDocumentoHasta.Text = "Fecha Doc. <="
        '
        'FechaDocumentoDesde
        '
        Me.FechaDocumentoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDocumentoDesde.Location = New System.Drawing.Point(781, 35)
        Me.FechaDocumentoDesde.Name = "FechaDocumentoDesde"
        Me.FechaDocumentoDesde.Size = New System.Drawing.Size(100, 21)
        Me.FechaDocumentoDesde.TabIndex = 95
        '
        'FechaDocumentoHasta
        '
        Me.FechaDocumentoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDocumentoHasta.Location = New System.Drawing.Point(781, 75)
        Me.FechaDocumentoHasta.Name = "FechaDocumentoHasta"
        Me.FechaDocumentoHasta.Size = New System.Drawing.Size(100, 21)
        Me.FechaDocumentoHasta.TabIndex = 96
        '
        'vfrmCIMovimientosActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 452)
        Me.Name = "vfrmCIMovimientosActivos"
        Me.Text = "Movimientos Activos Nº de Serie"
        Me.ViewName = "vHistoricoActivos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipoArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents TipoArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AlmacenDestino As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Articulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Almacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advNSerie As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFDocumentoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFDocumentoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FechaDocumentoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FechaDocumentoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
End Class
