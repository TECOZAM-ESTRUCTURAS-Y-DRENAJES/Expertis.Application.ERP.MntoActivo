Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Application.ERP.CommonClasses

Public Class MntoActivos
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Public WithEvents TabActivo As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents jngPreventivos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngActivoContador As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngCaracteristica As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngHistorico As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngEstructura As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngRepuestos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngElementos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents FraClasificacion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiCentroCoste As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiCentroCoste As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiCentroCoste As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiClase As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiClase As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiClase As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiZona As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiZona As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIdProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiPrecUltCompra As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiPrecUltCompra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiCosteParada As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblFwiCosteParada As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiPadre As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiIdActivo As Solmicro.Expertis.Engine.UI.CounterTextBox
    Public WithEvents lblfwiIdActivo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDescActivo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiFechaAlta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaAlta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaFinGarantia As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaFinGarantia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCategoria As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiCategoria As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents trvActivos As System.Windows.Forms.TreeView
    Public WithEvents TabPagePicPreventivos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagepicDatos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicActivoContador As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagepicCaracteristica As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagepicHistorico As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicEstructura As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicRepuestos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicArbol As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicElementos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents PicCabecera As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents lblFechaBaja As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaBaja As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents advNSerie As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LbUbicacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwINSerieFab As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwIDepCombus As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwInput1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiNSerie As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiUbicacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiMatricula As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiNumeroMotor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiObservaciones As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIDMarca As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIDModelo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwINSerieFab As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FwIDepCombus As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents FwInput1 As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblcfwiArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents fwiUbicacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblcfwiEstado As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiMatricula As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiNumeroMotor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiObservaciones As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblcfwiIDMarca As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIDMarca As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblcfwiIDModelo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIDModelo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents PnlDatosGenerales As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents CTxtMenuArbol As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents CmdAbrirArt As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdAbrirArt1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdAbrirActivo As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FechaCaducidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fWiFechaCaducidad As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents CmdAbrirActivo1 As Janus.Windows.UI.CommandBars.UICommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngCaracteristica_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngCaracteristica_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage")
        Dim jngActivoContador_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngActivoContador_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim jngActivoContador_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim jngActivoContador_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim jngRepuestos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngRepuestos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage")
        Dim jngEstructura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngEstructura_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoActivos))
        Dim jngHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngElementos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngPreventivos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngPreventivos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim jngPreventivos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Dim jngPreventivos_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim fwiZona_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiCategoria_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TabActivo = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPagepicDatos = New Janus.Windows.UI.Tab.UITabPage
        Me.PnlDatosGenerales = New Solmicro.Expertis.Engine.UI.Panel
        Me.advNSerie = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.LbUbicacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwINSerieFab = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwIDepCombus = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwInput1 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiUbicacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiMatricula = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiNumeroMotor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiObservaciones = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiIDMarca = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiIDModelo = New Solmicro.Expertis.Engine.UI.Label
        Me.FwINSerieFab = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwIDepCombus = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FwInput1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblcfwiArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fwiUbicacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblcfwiEstado = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiMatricula = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiNumeroMotor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiObservaciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblcfwiIDMarca = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIDMarca = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblcfwiIDModelo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIDModelo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPagepicCaracteristica = New Janus.Windows.UI.Tab.UITabPage
        Me.jngCaracteristica = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicActivoContador = New Janus.Windows.UI.Tab.UITabPage
        Me.jngActivoContador = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicRepuestos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngRepuestos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicEstructura = New Janus.Windows.UI.Tab.UITabPage
        Me.jngEstructura = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicArbol = New Janus.Windows.UI.Tab.UITabPage
        Me.trvActivos = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPagepicHistorico = New Janus.Windows.UI.Tab.UITabPage
        Me.jngHistorico = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicElementos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngElementos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicPreventivos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngPreventivos = New Solmicro.Expertis.Engine.UI.Grid
        Me.PicCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.fWiFechaCaducidad = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FechaCaducidad = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaBaja = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaBaja = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FraClasificacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiCentroCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiCentroCoste = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiCentroCoste = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiClase = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiClase = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiClase = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiZona = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiZona = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiIdProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiPrecUltCompra = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPrecUltCompra = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiCosteParada = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiCosteParada = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FwiPadre = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblfwiIdActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIdActivo = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.fwiDescActivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFechaAlta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaAlta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaFinGarantia = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaFinGarantia = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCategoria = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.CTxtMenuArbol = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.CmdAbrirArt1 = New Janus.Windows.UI.CommandBars.UICommand("CmdAbrirArt")
        Me.CmdAbrirActivo1 = New Janus.Windows.UI.CommandBars.UICommand("CmdAbrirActivo")
        Me.CmdAbrirArt = New Janus.Windows.UI.CommandBars.UICommand("CmdAbrirArt")
        Me.CmdAbrirActivo = New Janus.Windows.UI.CommandBars.UICommand("CmdAbrirActivo")
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.TabActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabActivo.SuspendLayout()
        Me.TabPagepicDatos.SuspendLayout()
        Me.PnlDatosGenerales.suspendlayout()
        Me.TabPagepicCaracteristica.SuspendLayout()
        CType(Me.jngCaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicActivoContador.SuspendLayout()
        CType(Me.jngActivoContador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicRepuestos.SuspendLayout()
        CType(Me.jngRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicEstructura.SuspendLayout()
        CType(Me.jngEstructura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicArbol.SuspendLayout()
        Me.TabPagepicHistorico.SuspendLayout()
        CType(Me.jngHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicElementos.SuspendLayout()
        CType(Me.jngElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicPreventivos.SuspendLayout()
        CType(Me.jngPreventivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PicCabecera.suspendlayout()
        Me.FraClasificacion.SuspendLayout()
        CType(Me.fwiZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTxtMenuArbol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(696, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.CmdAbrirArt, Me.CmdAbrirActivo})
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.CTxtMenuArbol})
        Me.UiCommandManager1.ImageList = Me.ImageList1
        '
        'GoFirst
        '
        Me.GoFirst.Icon = CType(resources.GetObject("GoFirst.Icon"), System.Drawing.Icon)
        '
        'GoPrevious
        '
        Me.GoPrevious.Icon = CType(resources.GetObject("GoPrevious.Icon"), System.Drawing.Icon)
        '
        'GoNext
        '
        Me.GoNext.Icon = CType(resources.GetObject("GoNext.Icon"), System.Drawing.Icon)
        '
        'Delete
        '
        Me.Delete.Icon = CType(resources.GetObject("Delete.Icon"), System.Drawing.Icon)
        Me.Delete.Text = ""
        '
        'Ok
        '
        Me.Ok.Icon = CType(resources.GetObject("Ok.Icon"), System.Drawing.Icon)
        Me.Ok.Text = ""
        '
        'Cancel
        '
        Me.Cancel.Icon = CType(resources.GetObject("Cancel.Icon"), System.Drawing.Icon)
        Me.Cancel.Text = ""
        '
        'Print
        '
        Me.Print.Icon = CType(resources.GetObject("Print.Icon"), System.Drawing.Icon)
        Me.Print.Text = ""
        '
        'Search
        '
        Me.Search.Icon = CType(resources.GetObject("Search.Icon"), System.Drawing.Icon)
        Me.Search.Text = ""
        '
        'GoLast
        '
        Me.GoLast.Icon = CType(resources.GetObject("GoLast.Icon"), System.Drawing.Icon)
        '
        'Find
        '
        Me.Find.Icon = CType(resources.GetObject("Find.Icon"), System.Drawing.Icon)
        Me.Find.Text = ""
        '
        'NewRow
        '
        Me.NewRow.Icon = CType(resources.GetObject("NewRow.Icon"), System.Drawing.Icon)
        Me.NewRow.Text = ""
        '
        'Requery
        '
        Me.Requery.Icon = CType(resources.GetObject("Requery.Icon"), System.Drawing.Icon)
        Me.Requery.Text = ""
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabActivo)
        Me.MainPanel.Controls.Add(Me.PicCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(688, 468)
        '
        'TabActivo
        '
        Me.TabActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabActivo.Location = New System.Drawing.Point(0, 188)
        Me.TabActivo.Name = "TabActivo"
        Me.TabActivo.Size = New System.Drawing.Size(688, 280)
        Me.TabActivo.TabIndex = 13
        Me.TabActivo.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPagepicDatos, Me.TabPagepicCaracteristica, Me.TabPagePicActivoContador, Me.TabPagePicRepuestos, Me.TabPagePicEstructura, Me.TabPagePicArbol, Me.TabPagepicHistorico, Me.TabPagePicElementos, Me.TabPagePicPreventivos})
        Me.TabActivo.Text = "Preventivos "
        Me.TabActivo.UseThemes = True
        '
        'TabPagepicDatos
        '
        Me.TabPagepicDatos.Controls.Add(Me.PnlDatosGenerales)
        Me.TabPagepicDatos.Key = "DatosGenerales"
        Me.TabPagepicDatos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagepicDatos.Name = "TabPagepicDatos"
        Me.TabPagepicDatos.Size = New System.Drawing.Size(686, 258)
        Me.TabPagepicDatos.TabStop = True
        Me.TabPagepicDatos.Text = "Datos generales"
        '
        'PnlDatosGenerales
        '
        Me.PnlDatosGenerales.Controls.Add(Me.advNSerie)
        Me.PnlDatosGenerales.Controls.Add(Me.lblEstado)
        Me.PnlDatosGenerales.Controls.Add(Me.LbUbicacion)
        Me.PnlDatosGenerales.Controls.Add(Me.lblFwINSerieFab)
        Me.PnlDatosGenerales.Controls.Add(Me.lblFwIDepCombus)
        Me.PnlDatosGenerales.Controls.Add(Me.lblFwInput1)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiArticulo)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiNSerie)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiUbicacion)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiMatricula)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiNumeroMotor)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiObservaciones)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiIDMarca)
        Me.PnlDatosGenerales.Controls.Add(Me.lblfwiIDModelo)
        Me.PnlDatosGenerales.Controls.Add(Me.FwINSerieFab)
        Me.PnlDatosGenerales.Controls.Add(Me.FwIDepCombus)
        Me.PnlDatosGenerales.Controls.Add(Me.FwInput1)
        Me.PnlDatosGenerales.Controls.Add(Me.lblcfwiArticulo)
        Me.PnlDatosGenerales.Controls.Add(Me.advArticulo)
        Me.PnlDatosGenerales.Controls.Add(Me.fwiUbicacion)
        Me.PnlDatosGenerales.Controls.Add(Me.lblcfwiEstado)
        Me.PnlDatosGenerales.Controls.Add(Me.fwiMatricula)
        Me.PnlDatosGenerales.Controls.Add(Me.fwiNumeroMotor)
        Me.PnlDatosGenerales.Controls.Add(Me.fwiObservaciones)
        Me.PnlDatosGenerales.Controls.Add(Me.lblcfwiIDMarca)
        Me.PnlDatosGenerales.Controls.Add(Me.fwiIDMarca)
        Me.PnlDatosGenerales.Controls.Add(Me.lblcfwiIDModelo)
        Me.PnlDatosGenerales.Controls.Add(Me.fwiIDModelo)
        Me.PnlDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PnlDatosGenerales.Name = "PnlDatosGenerales"
        Me.PnlDatosGenerales.Size = New System.Drawing.Size(686, 258)
        Me.PnlDatosGenerales.TabIndex = 66
        '
        'advNSerie
        '
        Me.TryDataBinding(advNSerie, New System.Windows.Forms.Binding("Text", Me, "NSerie", True))
        Me.advNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.advNSerie.EntityName = "ArticuloNSerie"
        Me.advNSerie.Location = New System.Drawing.Point(88, 45)
        Me.advNSerie.MaxLength = 100
        Me.advNSerie.Name = "advNSerie"
        Me.advNSerie.PrimaryDataFields = "NSerie"
        Me.advNSerie.SecondaryDataFields = "NSerie"
        Me.advNSerie.Size = New System.Drawing.Size(304, 23)
        Me.advNSerie.TabIndex = 93
        Me.advNSerie.ViewName = "tbArticuloNSerie"
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(16, 10)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 13)
        Me.lblEstado.TabIndex = 85
        Me.lblEstado.Tag = "IdRec=12843;"
        Me.lblEstado.Text = "Estado:"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbUbicacion
        '
        Me.LbUbicacion.Location = New System.Drawing.Point(333, 10)
        Me.LbUbicacion.Name = "LbUbicacion"
        Me.LbUbicacion.Size = New System.Drawing.Size(66, 13)
        Me.LbUbicacion.TabIndex = 66
        Me.LbUbicacion.Text = "Ubicación:"
        Me.LbUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFwINSerieFab
        '
        Me.lblFwINSerieFab.Location = New System.Drawing.Point(402, 125)
        Me.lblFwINSerieFab.Name = "lblFwINSerieFab"
        Me.lblFwINSerieFab.Size = New System.Drawing.Size(117, 13)
        Me.lblFwINSerieFab.TabIndex = 67
        Me.lblFwINSerieFab.Tag = "IdRec=12840;"
        Me.lblFwINSerieFab.Text = "Nº Serie Fabricante"
        '
        'lblFwIDepCombus
        '
        Me.lblFwIDepCombus.Location = New System.Drawing.Point(402, 151)
        Me.lblFwIDepCombus.Name = "lblFwIDepCombus"
        Me.lblFwIDepCombus.Size = New System.Drawing.Size(132, 13)
        Me.lblFwIDepCombus.TabIndex = 78
        Me.lblFwIDepCombus.Tag = "IdRec=12841;"
        Me.lblFwIDepCombus.Text = "Depósito Combustible"
        '
        'lblFwInput1
        '
        Me.lblFwInput1.Location = New System.Drawing.Point(402, 73)
        Me.lblFwInput1.Name = "lblFwInput1"
        Me.lblFwInput1.Size = New System.Drawing.Size(57, 13)
        Me.lblFwInput1.TabIndex = 79
        Me.lblFwInput1.Tag = "IdRec=12842;"
        Me.lblFwInput1.Text = "Nº Motor"
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(16, 73)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 80
        Me.lblfwiArticulo.Tag = "IdRec=4377;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'lblfwiNSerie
        '
        Me.lblfwiNSerie.Location = New System.Drawing.Point(16, 47)
        Me.lblfwiNSerie.Name = "lblfwiNSerie"
        Me.lblfwiNSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiNSerie.TabIndex = 82
        Me.lblfwiNSerie.Tag = "IdRec=11608;"
        Me.lblfwiNSerie.Text = "Nº Serie"
        '
        'lblfwiUbicacion
        '
        Me.lblfwiUbicacion.Location = New System.Drawing.Point(16, 151)
        Me.lblfwiUbicacion.Name = "lblfwiUbicacion"
        Me.lblfwiUbicacion.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiUbicacion.TabIndex = 83
        Me.lblfwiUbicacion.Tag = "IdRec=7240;"
        Me.lblfwiUbicacion.Text = "Ubicación"
        '
        'lblfwiMatricula
        '
        Me.lblfwiMatricula.Location = New System.Drawing.Point(402, 99)
        Me.lblfwiMatricula.Name = "lblfwiMatricula"
        Me.lblfwiMatricula.Size = New System.Drawing.Size(58, 13)
        Me.lblfwiMatricula.TabIndex = 86
        Me.lblfwiMatricula.Tag = "IdRec=8936;"
        Me.lblfwiMatricula.Text = "Matrícula"
        '
        'lblfwiNumeroMotor
        '
        Me.lblfwiNumeroMotor.Location = New System.Drawing.Point(402, 47)
        Me.lblfwiNumeroMotor.Name = "lblfwiNumeroMotor"
        Me.lblfwiNumeroMotor.Size = New System.Drawing.Size(72, 13)
        Me.lblfwiNumeroMotor.TabIndex = 87
        Me.lblfwiNumeroMotor.Tag = "IdRec=12844;"
        Me.lblfwiNumeroMotor.Text = "Nº Bastidor"
        '
        'lblfwiObservaciones
        '
        Me.lblfwiObservaciones.Location = New System.Drawing.Point(14, 179)
        Me.lblfwiObservaciones.Name = "lblfwiObservaciones"
        Me.lblfwiObservaciones.Size = New System.Drawing.Size(91, 13)
        Me.lblfwiObservaciones.TabIndex = 88
        Me.lblfwiObservaciones.Tag = "IdRec=5286;"
        Me.lblfwiObservaciones.Text = "Observaciones"
        '
        'lblfwiIDMarca
        '
        Me.lblfwiIDMarca.Location = New System.Drawing.Point(16, 99)
        Me.lblfwiIDMarca.Name = "lblfwiIDMarca"
        Me.lblfwiIDMarca.Size = New System.Drawing.Size(41, 13)
        Me.lblfwiIDMarca.TabIndex = 89
        Me.lblfwiIDMarca.Tag = "IdRec=4363;"
        Me.lblfwiIDMarca.Text = "Marca"
        '
        'lblfwiIDModelo
        '
        Me.lblfwiIDModelo.Location = New System.Drawing.Point(16, 125)
        Me.lblfwiIDModelo.Name = "lblfwiIDModelo"
        Me.lblfwiIDModelo.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiIDModelo.TabIndex = 91
        Me.lblfwiIDModelo.Tag = "IdRec=10104;"
        Me.lblfwiIDModelo.Text = "Modelo"
        '
        'FwINSerieFab
        '
        Me.TryDataBinding(FwINSerieFab, New System.Windows.Forms.Binding("Text", Me, "NSerieFabricante", True))
        Me.FwINSerieFab.DisabledBackColor = System.Drawing.Color.White
        Me.FwINSerieFab.Location = New System.Drawing.Point(535, 123)
        Me.FwINSerieFab.MaxLength = 50
        Me.FwINSerieFab.Name = "FwINSerieFab"
        Me.FwINSerieFab.Size = New System.Drawing.Size(137, 21)
        Me.FwINSerieFab.TabIndex = 75
        '
        'FwIDepCombus
        '
        Me.TryDataBinding(FwIDepCombus, New System.Windows.Forms.Binding("Value", Me, "DepositoCombustible", True))
        Me.FwIDepCombus.DisabledBackColor = System.Drawing.Color.White
        Me.FwIDepCombus.Location = New System.Drawing.Point(535, 149)
        Me.FwIDepCombus.Name = "FwIDepCombus"
        Me.FwIDepCombus.Size = New System.Drawing.Size(137, 21)
        Me.FwIDepCombus.TabIndex = 76
        '
        'FwInput1
        '
        Me.TryDataBinding(FwInput1, New System.Windows.Forms.Binding("Text", Me, "NumeroMotor", True))
        Me.FwInput1.DisabledBackColor = System.Drawing.Color.White
        Me.FwInput1.Location = New System.Drawing.Point(535, 71)
        Me.FwInput1.MaxLength = 100
        Me.FwInput1.Name = "FwInput1"
        Me.FwInput1.Size = New System.Drawing.Size(137, 21)
        Me.FwInput1.TabIndex = 73
        '
        'lblcfwiArticulo
        '
        Me.TryDataBinding(lblcfwiArticulo, New System.Windows.Forms.Binding("Text", Me.advArticulo, "DescArticulo", True))
        Me.lblcfwiArticulo.Location = New System.Drawing.Point(208, 71)
        Me.lblcfwiArticulo.Name = "lblcfwiArticulo"
        Me.lblcfwiArticulo.Size = New System.Drawing.Size(184, 21)
        Me.lblcfwiArticulo.TabIndex = 81
        '
        'advArticulo
        '
        Me.advArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescArticulo", lblcfwiArticulo)})
        Me.TryDataBinding(advArticulo, New System.Windows.Forms.Binding("Text", Me, "IDArticulo", True))
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(88, 71)
        Me.advArticulo.MaxLength = 25
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.PrimaryDataFields = "IDArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(117, 23)
        Me.advArticulo.TabIndex = 68
        Me.advArticulo.ViewName = "tbMaestroArticulo"
        '
        'fwiUbicacion
        '
        Me.TryDataBinding(fwiUbicacion, New System.Windows.Forms.Binding("Text", Me, "Ubicacion", True))
        Me.fwiUbicacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiUbicacion.Location = New System.Drawing.Point(88, 149)
        Me.fwiUbicacion.MaxLength = 100
        Me.fwiUbicacion.Name = "fwiUbicacion"
        Me.fwiUbicacion.Size = New System.Drawing.Size(304, 21)
        Me.fwiUbicacion.TabIndex = 71
        '
        'lblcfwiEstado
        '
        Me.TryDataBinding(lblcfwiEstado, New System.Windows.Forms.Binding("Text", Me, "DescEstadoActivo", True))
        Me.lblcfwiEstado.Location = New System.Drawing.Point(121, 3)
        Me.lblcfwiEstado.Name = "lblcfwiEstado"
        Me.lblcfwiEstado.Size = New System.Drawing.Size(164, 21)
        Me.lblcfwiEstado.TabIndex = 84
        Me.lblcfwiEstado.Visible = False
        '
        'fwiMatricula
        '
        Me.TryDataBinding(fwiMatricula, New System.Windows.Forms.Binding("Text", Me, "Matricula", True))
        Me.fwiMatricula.DisabledBackColor = System.Drawing.Color.White
        Me.fwiMatricula.Location = New System.Drawing.Point(535, 97)
        Me.fwiMatricula.MaxLength = 100
        Me.fwiMatricula.Name = "fwiMatricula"
        Me.fwiMatricula.Size = New System.Drawing.Size(137, 21)
        Me.fwiMatricula.TabIndex = 74
        '
        'fwiNumeroMotor
        '
        Me.TryDataBinding(fwiNumeroMotor, New System.Windows.Forms.Binding("Text", Me, "NumeroBastidor", True))
        Me.fwiNumeroMotor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNumeroMotor.Location = New System.Drawing.Point(535, 45)
        Me.fwiNumeroMotor.MaxLength = 100
        Me.fwiNumeroMotor.Name = "fwiNumeroMotor"
        Me.fwiNumeroMotor.Size = New System.Drawing.Size(137, 21)
        Me.fwiNumeroMotor.TabIndex = 72
        '
        'fwiObservaciones
        '
        Me.fwiObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(fwiObservaciones, New System.Windows.Forms.Binding("Text", Me, "Observaciones", True))
        Me.fwiObservaciones.DisabledBackColor = System.Drawing.Color.White
        Me.fwiObservaciones.Location = New System.Drawing.Point(14, 199)
        Me.fwiObservaciones.Multiline = True
        Me.fwiObservaciones.Name = "fwiObservaciones"
        Me.fwiObservaciones.Size = New System.Drawing.Size(658, 56)
        Me.fwiObservaciones.TabIndex = 77
        '
        'lblcfwiIDMarca
        '
        Me.TryDataBinding(lblcfwiIDMarca, New System.Windows.Forms.Binding("Text", Me.fwiIDMarca, "DescMarca", True))
        Me.lblcfwiIDMarca.Location = New System.Drawing.Point(208, 97)
        Me.lblcfwiIDMarca.Name = "lblcfwiIDMarca"
        Me.lblcfwiIDMarca.Size = New System.Drawing.Size(184, 21)
        Me.lblcfwiIDMarca.TabIndex = 90
        '
        'fwiIDMarca
        '
        Me.fwiIDMarca.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescMarca", lblcfwiIDMarca)})
        Me.TryDataBinding(fwiIDMarca, New System.Windows.Forms.Binding("Text", Me, "IDMarca", True))
        Me.fwiIDMarca.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDMarca.EntityName = "Marca"
        Me.fwiIDMarca.Location = New System.Drawing.Point(88, 97)
        Me.fwiIDMarca.MaxLength = 25
        Me.fwiIDMarca.Name = "fwiIDMarca"
        Me.fwiIDMarca.PrimaryDataFields = "IDMarca"
        Me.fwiIDMarca.SecondaryDataFields = "IDMarca"
        Me.fwiIDMarca.Size = New System.Drawing.Size(117, 23)
        Me.fwiIDMarca.TabIndex = 69
        Me.fwiIDMarca.ViewName = "tbMaestroMarca"
        '
        'lblcfwiIDModelo
        '
        Me.TryDataBinding(lblcfwiIDModelo, New System.Windows.Forms.Binding("Text", Me.fwiIDModelo, "DescModelo", True))
        Me.lblcfwiIDModelo.Location = New System.Drawing.Point(208, 123)
        Me.lblcfwiIDModelo.Name = "lblcfwiIDModelo"
        Me.lblcfwiIDModelo.Size = New System.Drawing.Size(184, 21)
        Me.lblcfwiIDModelo.TabIndex = 92
        '
        'fwiIDModelo
        '
        Me.fwiIDModelo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescModelo", lblcfwiIDModelo)})
        Me.TryDataBinding(fwiIDModelo, New System.Windows.Forms.Binding("Text", Me, "IDModelo", True))
        Me.fwiIDModelo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDModelo.EntityName = "Modelo"
        Me.fwiIDModelo.Location = New System.Drawing.Point(88, 123)
        Me.fwiIDModelo.MaxLength = 25
        Me.fwiIDModelo.Name = "fwiIDModelo"
        Me.fwiIDModelo.PrimaryDataFields = "IDModelo"
        Me.fwiIDModelo.SecondaryDataFields = "IDModelo"
        Me.fwiIDModelo.Size = New System.Drawing.Size(117, 23)
        Me.fwiIDModelo.TabIndex = 70
        Me.fwiIDModelo.ViewName = "tbMaestroModelo"
        '
        'TabPagepicCaracteristica
        '
        Me.TabPagepicCaracteristica.Controls.Add(Me.jngCaracteristica)
        Me.TabPagepicCaracteristica.Key = "Caracteristicas"
        Me.TabPagepicCaracteristica.Location = New System.Drawing.Point(1, 21)
        Me.TabPagepicCaracteristica.Name = "TabPagepicCaracteristica"
        Me.TabPagepicCaracteristica.Size = New System.Drawing.Size(686, 258)
        Me.TabPagepicCaracteristica.TabStop = True
        Me.TabPagepicCaracteristica.Text = "Características"
        '
        'jngCaracteristica
        '
        Me.jngCaracteristica.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCaracteristica", "Caracteristica", "IDCaracteristica")})
        jngCaracteristica_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngCaracteristica_DesignTimeLayout_Reference_0.Instance"), Object)
        jngCaracteristica_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngCaracteristica_DesignTimeLayout_Reference_0})
        jngCaracteristica_DesignTimeLayout.LayoutString = resources.GetString("jngCaracteristica_DesignTimeLayout.LayoutString")
        Me.jngCaracteristica.DesignTimeLayout = jngCaracteristica_DesignTimeLayout
        Me.jngCaracteristica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngCaracteristica.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngCaracteristica.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCaracteristica.EntityName = "ActivoCaracteristica"
        Me.jngCaracteristica.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngCaracteristica.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngCaracteristica.Location = New System.Drawing.Point(0, 0)
        Me.jngCaracteristica.Name = "jngCaracteristica"
        Me.jngCaracteristica.PrimaryDataFields = "IDActivo"
        Me.jngCaracteristica.SecondaryDataFields = "IDActivo"
        Me.jngCaracteristica.Size = New System.Drawing.Size(686, 258)
        Me.jngCaracteristica.TabIndex = 25
        Me.jngCaracteristica.Tag = "IdRec=4469:8462:4519:9846:12854:5190:12855:;"
        Me.jngCaracteristica.ViewName = "vFrmActivoCaracteristica"
        '
        'TabPagePicActivoContador
        '
        Me.TabPagePicActivoContador.Controls.Add(Me.jngActivoContador)
        Me.TabPagePicActivoContador.Key = "Contadores"
        Me.TabPagePicActivoContador.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicActivoContador.Name = "TabPagePicActivoContador"
        Me.TabPagePicActivoContador.Size = New System.Drawing.Size(686, 258)
        Me.TabPagePicActivoContador.TabStop = True
        Me.TabPagePicActivoContador.Text = "Contadores"
        '
        'jngActivoContador
        '
        Me.jngActivoContador.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDContadorPrev", "PreventivoContador", "IDContadorPrev"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticuloFacturacion", "Articulo", "IDArticulo")})
        jngActivoContador_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngActivoContador_DesignTimeLayout_Reference_0.Instance"), Object)
        jngActivoContador_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngActivoContador_DesignTimeLayout_Reference_1.Instance"), Object)
        jngActivoContador_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("jngActivoContador_DesignTimeLayout_Reference_2.Instance"), Object)
        jngActivoContador_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngActivoContador_DesignTimeLayout_Reference_0, jngActivoContador_DesignTimeLayout_Reference_1, jngActivoContador_DesignTimeLayout_Reference_2})
        jngActivoContador_DesignTimeLayout.LayoutString = resources.GetString("jngActivoContador_DesignTimeLayout.LayoutString")
        Me.jngActivoContador.DesignTimeLayout = jngActivoContador_DesignTimeLayout
        Me.jngActivoContador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngActivoContador.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngActivoContador.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngActivoContador.EntityName = "ActivoContador"
        Me.jngActivoContador.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngActivoContador.ImageSource = Janus.Windows.GridEX.ImageSource.InternalImageList
        Me.jngActivoContador.Location = New System.Drawing.Point(0, 0)
        Me.jngActivoContador.Name = "jngActivoContador"
        Me.jngActivoContador.PrimaryDataFields = "IDActivo"
        Me.jngActivoContador.SecondaryDataFields = "IDActivo"
        Me.jngActivoContador.Size = New System.Drawing.Size(686, 258)
        Me.jngActivoContador.TabIndex = 26
        Me.jngActivoContador.Tag = "IdRec=12845:9501:12846:4810:12847:12848:12849:12850:12851:12852:12853:;"
        Me.jngActivoContador.ViewName = "vFrmMntoActivoContador"
        '
        'TabPagePicRepuestos
        '
        Me.TabPagePicRepuestos.Controls.Add(Me.jngRepuestos)
        Me.TabPagePicRepuestos.Key = "Repuestos"
        Me.TabPagePicRepuestos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicRepuestos.Name = "TabPagePicRepuestos"
        Me.TabPagePicRepuestos.Size = New System.Drawing.Size(686, 286)
        Me.TabPagePicRepuestos.TabStop = True
        Me.TabPagePicRepuestos.Text = "Repuestos"
        '
        'jngRepuestos
        '
        Me.jngRepuestos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDComponente", "Articulo", "IDArticulo", "advArticulo")})
        jngRepuestos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngRepuestos_DesignTimeLayout_Reference_0.Instance"), Object)
        jngRepuestos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngRepuestos_DesignTimeLayout_Reference_0})
        jngRepuestos_DesignTimeLayout.LayoutString = resources.GetString("jngRepuestos_DesignTimeLayout.LayoutString")
        Me.jngRepuestos.DesignTimeLayout = jngRepuestos_DesignTimeLayout
        Me.jngRepuestos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngRepuestos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngRepuestos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngRepuestos.EntityName = "ActivoRepuesto"
        Me.jngRepuestos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngRepuestos.Location = New System.Drawing.Point(0, 0)
        Me.jngRepuestos.Name = "jngRepuestos"
        Me.jngRepuestos.PrimaryDataFields = "IDActivo"
        Me.jngRepuestos.SecondaryDataFields = "IDActivo"
        Me.jngRepuestos.Size = New System.Drawing.Size(686, 286)
        Me.jngRepuestos.TabIndex = 28
        Me.jngRepuestos.Tag = "IdRec=9501:12879:12880:4498:;"
        Me.jngRepuestos.ViewName = "vFrmMntoActivoRepuesto"
        '
        'TabPagePicEstructura
        '
        Me.TabPagePicEstructura.Controls.Add(Me.jngEstructura)
        Me.TabPagePicEstructura.Key = "Elementos"
        Me.TabPagePicEstructura.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicEstructura.Name = "TabPagePicEstructura"
        Me.TabPagePicEstructura.Size = New System.Drawing.Size(686, 286)
        Me.TabPagePicEstructura.TabStop = True
        Me.TabPagePicEstructura.Text = "Elementos"
        '
        'jngEstructura
        '
        Me.jngEstructura.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDActivoComponente", "Activo", "IDActivo", "tbMaestroActivo")})
        jngEstructura_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngEstructura_DesignTimeLayout_Reference_0.Instance"), Object)
        jngEstructura_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngEstructura_DesignTimeLayout_Reference_0})
        jngEstructura_DesignTimeLayout.LayoutString = resources.GetString("jngEstructura_DesignTimeLayout.LayoutString")
        Me.jngEstructura.DesignTimeLayout = jngEstructura_DesignTimeLayout
        Me.jngEstructura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngEstructura.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngEstructura.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngEstructura.EntityName = "ActivoEstructura"
        Me.jngEstructura.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngEstructura.Location = New System.Drawing.Point(0, 0)
        Me.jngEstructura.Name = "jngEstructura"
        Me.jngEstructura.PrimaryDataFields = "IDActivo"
        Me.jngEstructura.SecondaryDataFields = "IDActivo"
        Me.jngEstructura.Size = New System.Drawing.Size(686, 286)
        Me.jngEstructura.TabIndex = 29
        Me.jngEstructura.Tag = "IdRec=9501:12877:12878:;"
        Me.jngEstructura.ViewName = "vFrmMntoActivoEstructura"
        '
        'TabPagePicArbol
        '
        Me.TabPagePicArbol.Controls.Add(Me.trvActivos)
        Me.TabPagePicArbol.Key = "Arbol"
        Me.TabPagePicArbol.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicArbol.Name = "TabPagePicArbol"
        Me.TabPagePicArbol.Size = New System.Drawing.Size(686, 286)
        Me.TabPagePicArbol.TabStop = True
        Me.TabPagePicArbol.Text = "Arbol"
        '
        'trvActivos
        '
        Me.trvActivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.trvActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvActivos.ImageIndex = 0
        Me.trvActivos.ImageList = Me.ImageList1
        Me.trvActivos.Location = New System.Drawing.Point(0, 0)
        Me.trvActivos.Name = "trvActivos"
        Me.trvActivos.SelectedImageIndex = 0
        Me.trvActivos.Size = New System.Drawing.Size(686, 286)
        Me.trvActivos.TabIndex = 30
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'TabPagepicHistorico
        '
        Me.TabPagepicHistorico.Controls.Add(Me.jngHistorico)
        Me.TabPagepicHistorico.Key = "HistoricoEstados"
        Me.TabPagepicHistorico.Location = New System.Drawing.Point(1, 21)
        Me.TabPagepicHistorico.Name = "TabPagepicHistorico"
        Me.TabPagepicHistorico.Size = New System.Drawing.Size(686, 286)
        Me.TabPagepicHistorico.TabStop = True
        Me.TabPagepicHistorico.Text = "Histórico de estados"
        '
        'jngHistorico
        '
        Me.jngHistorico.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngHistorico.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngHistorico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngHistorico_DesignTimeLayout.LayoutString = resources.GetString("jngHistorico_DesignTimeLayout.LayoutString")
        Me.jngHistorico.DesignTimeLayout = jngHistorico_DesignTimeLayout
        Me.jngHistorico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngHistorico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngHistorico.EntityName = "HistoricoEstadoActivo"
        Me.jngHistorico.Location = New System.Drawing.Point(0, 0)
        Me.jngHistorico.Name = "jngHistorico"
        Me.jngHistorico.PrimaryDataFields = "IDActivo"
        Me.jngHistorico.SecondaryDataFields = "IDActivo"
        Me.jngHistorico.Size = New System.Drawing.Size(686, 286)
        Me.jngHistorico.TabIndex = 31
        Me.jngHistorico.Tag = "IdRec=12876:4469:4405:4405:7613:10828:4638:5860:5860:5257:;"
        Me.jngHistorico.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngHistorico.ViewName = "vFrmHistoricoEstadoActivo"
        '
        'TabPagePicElementos
        '
        Me.TabPagePicElementos.Controls.Add(Me.jngElementos)
        Me.TabPagePicElementos.Key = "ElementosAmortizables"
        Me.TabPagePicElementos.Location = New System.Drawing.Point(1, 22)
        Me.TabPagePicElementos.Name = "TabPagePicElementos"
        Me.TabPagePicElementos.Size = New System.Drawing.Size(686, 258)
        Me.TabPagePicElementos.TabStop = True
        Me.TabPagePicElementos.Text = "Elementos amortizables"
        '
        'jngElementos
        '
        Me.jngElementos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngElementos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngElementos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngElementos_DesignTimeLayout.LayoutString = resources.GetString("jngElementos_DesignTimeLayout.LayoutString")
        Me.jngElementos.DesignTimeLayout = jngElementos_DesignTimeLayout
        Me.jngElementos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngElementos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngElementos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngElementos.EntityName = "ElementoAmortizable"
        Me.jngElementos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngElementos.Location = New System.Drawing.Point(0, 0)
        Me.jngElementos.Name = "jngElementos"
        Me.jngElementos.PrimaryDataFields = "IDActivo"
        Me.jngElementos.SecondaryDataFields = "IDActivo"
        Me.jngElementos.Size = New System.Drawing.Size(686, 258)
        Me.jngElementos.TabIndex = 32
        Me.jngElementos.Tag = "$MntoActivos.ctx:1376B"
        Me.jngElementos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngElementos.ViewName = "VCtlCIElementoAmortizable"
        '
        'TabPagePicPreventivos
        '
        Me.TabPagePicPreventivos.Controls.Add(Me.jngPreventivos)
        Me.TabPagePicPreventivos.Key = "Preventivos"
        Me.TabPagePicPreventivos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicPreventivos.Name = "TabPagePicPreventivos"
        Me.TabPagePicPreventivos.Size = New System.Drawing.Size(686, 286)
        Me.TabPagePicPreventivos.TabStop = True
        Me.TabPagePicPreventivos.Text = "Preventivos"
        '
        'jngPreventivos
        '
        Me.jngPreventivos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedor", "Proveedor", "IDProveedor", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescProveedor", "DescProveedor")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDPreventivo", "PreventivoCabecera", "IDPreventivo")})
        jngPreventivos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngPreventivos_DesignTimeLayout_Reference_0.Instance"), Object)
        jngPreventivos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngPreventivos_DesignTimeLayout_Reference_1.Instance"), Object)
        jngPreventivos_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("jngPreventivos_DesignTimeLayout_Reference_2.Instance"), Object)
        jngPreventivos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngPreventivos_DesignTimeLayout_Reference_0, jngPreventivos_DesignTimeLayout_Reference_1, jngPreventivos_DesignTimeLayout_Reference_2})
        jngPreventivos_DesignTimeLayout.LayoutString = resources.GetString("jngPreventivos_DesignTimeLayout.LayoutString")
        Me.jngPreventivos.DesignTimeLayout = jngPreventivos_DesignTimeLayout
        Me.jngPreventivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngPreventivos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngPreventivos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngPreventivos.EntityName = "PreventivoActivo"
        Me.jngPreventivos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngPreventivos.ImageSource = Janus.Windows.GridEX.ImageSource.InternalImageList
        Me.jngPreventivos.Location = New System.Drawing.Point(0, 0)
        Me.jngPreventivos.Name = "jngPreventivos"
        Me.jngPreventivos.PrimaryDataFields = "IDActivo"
        Me.jngPreventivos.SecondaryDataFields = "IDActivo"
        Me.jngPreventivos.Size = New System.Drawing.Size(686, 286)
        Me.jngPreventivos.TabIndex = 33
        Me.jngPreventivos.Tag = "$MntoActivos.ctx:0000"
        Me.jngPreventivos.ViewName = "vFrmMntoPreventivoActivos"
        '
        'PicCabecera
        '
        Me.PicCabecera.Controls.Add(Me.fWiFechaCaducidad)
        Me.PicCabecera.Controls.Add(Me.FechaCaducidad)
        Me.PicCabecera.Controls.Add(Me.lblFechaBaja)
        Me.PicCabecera.Controls.Add(Me.cbxFechaBaja)
        Me.PicCabecera.Controls.Add(Me.FraClasificacion)
        Me.PicCabecera.Controls.Add(Me.lblfwiIdProveedor)
        Me.PicCabecera.Controls.Add(Me.lblcfwiIdProveedor)
        Me.PicCabecera.Controls.Add(Me.fwiIdProveedor)
        Me.PicCabecera.Controls.Add(Me.lblfwiPrecUltCompra)
        Me.PicCabecera.Controls.Add(Me.fwiPrecUltCompra)
        Me.PicCabecera.Controls.Add(Me.lblFwiCosteParada)
        Me.PicCabecera.Controls.Add(Me.FwiCosteParada)
        Me.PicCabecera.Controls.Add(Me.FwiPadre)
        Me.PicCabecera.Controls.Add(Me.lblfwiIdActivo)
        Me.PicCabecera.Controls.Add(Me.fwiIdActivo)
        Me.PicCabecera.Controls.Add(Me.fwiDescActivo)
        Me.PicCabecera.Controls.Add(Me.lblfwiFechaAlta)
        Me.PicCabecera.Controls.Add(Me.fwiFechaAlta)
        Me.PicCabecera.Controls.Add(Me.lblfwiFechaFinGarantia)
        Me.PicCabecera.Controls.Add(Me.fwiFechaFinGarantia)
        Me.PicCabecera.Controls.Add(Me.lblfwiCategoria)
        Me.PicCabecera.Controls.Add(Me.fwiCategoria)
        Me.PicCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PicCabecera.Name = "PicCabecera"
        Me.PicCabecera.Size = New System.Drawing.Size(688, 188)
        Me.PicCabecera.TabIndex = 1
        '
        'fWiFechaCaducidad
        '
        Me.TryDataBinding(fWiFechaCaducidad, New System.Windows.Forms.Binding("BindableValue", Me, "FechaCaducidad", True))
        Me.fWiFechaCaducidad.DisabledBackColor = System.Drawing.Color.White
        Me.fWiFechaCaducidad.Location = New System.Drawing.Point(288, 56)
        Me.fWiFechaCaducidad.Name = "fWiFechaCaducidad"
        Me.fWiFechaCaducidad.Size = New System.Drawing.Size(82, 21)
        Me.fWiFechaCaducidad.TabIndex = 65
        '
        'FechaCaducidad
        '
        Me.FechaCaducidad.AllowDrop = True
        Me.FechaCaducidad.Location = New System.Drawing.Point(171, 56)
        Me.FechaCaducidad.Name = "FechaCaducidad"
        Me.FechaCaducidad.Size = New System.Drawing.Size(104, 13)
        Me.FechaCaducidad.TabIndex = 64
        Me.FechaCaducidad.Text = "Fecha Caducidad"
        '
        'lblFechaBaja
        '
        Me.lblFechaBaja.Location = New System.Drawing.Point(384, 32)
        Me.lblFechaBaja.Name = "lblFechaBaja"
        Me.lblFechaBaja.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaBaja.TabIndex = 63
        Me.lblFechaBaja.Text = "Fecha Baja"
        '
        'cbxFechaBaja
        '
        Me.TryDataBinding(cbxFechaBaja, New System.Windows.Forms.Binding("BindableValue", Me, "FechaBaja", True))
        Me.cbxFechaBaja.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaBaja.ForeColor = System.Drawing.Color.Red
        Me.cbxFechaBaja.Location = New System.Drawing.Point(456, 32)
        Me.cbxFechaBaja.Name = "cbxFechaBaja"
        Me.cbxFechaBaja.Size = New System.Drawing.Size(81, 21)
        Me.cbxFechaBaja.TabIndex = 62
        '
        'FraClasificacion
        '
        Me.FraClasificacion.Controls.Add(Me.lblfwiCentroCoste)
        Me.FraClasificacion.Controls.Add(Me.lblcfwiCentroCoste)
        Me.FraClasificacion.Controls.Add(Me.fwiCentroCoste)
        Me.FraClasificacion.Controls.Add(Me.lblfwiClase)
        Me.FraClasificacion.Controls.Add(Me.lblcfwiClase)
        Me.FraClasificacion.Controls.Add(Me.fwiClase)
        Me.FraClasificacion.Controls.Add(Me.lblfwiZona)
        Me.FraClasificacion.Controls.Add(Me.fwiZona)
        Me.FraClasificacion.Location = New System.Drawing.Point(376, 55)
        Me.FraClasificacion.Name = "FraClasificacion"
        Me.FraClasificacion.Size = New System.Drawing.Size(304, 101)
        Me.FraClasificacion.TabIndex = 9
        Me.FraClasificacion.TabStop = False
        Me.FraClasificacion.Tag = "IdRec=12856;"
        Me.FraClasificacion.Text = "Clasificación"
        '
        'lblfwiCentroCoste
        '
        Me.lblfwiCentroCoste.Location = New System.Drawing.Point(6, 20)
        Me.lblfwiCentroCoste.Name = "lblfwiCentroCoste"
        Me.lblfwiCentroCoste.Size = New System.Drawing.Size(83, 13)
        Me.lblfwiCentroCoste.TabIndex = 0
        Me.lblfwiCentroCoste.Tag = "IdRec=4569;"
        Me.lblfwiCentroCoste.Text = "Centro Coste"
        '
        'lblcfwiCentroCoste
        '
        Me.TryDataBinding(lblcfwiCentroCoste, New System.Windows.Forms.Binding("Text", Me.fwiCentroCoste, "DescCentroCoste", True))
        Me.lblcfwiCentroCoste.Location = New System.Drawing.Point(160, 17)
        Me.lblcfwiCentroCoste.Name = "lblcfwiCentroCoste"
        Me.lblcfwiCentroCoste.Size = New System.Drawing.Size(136, 21)
        Me.lblcfwiCentroCoste.TabIndex = 1
        '
        'fwiCentroCoste
        '
        Me.fwiCentroCoste.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCentroCoste", lblcfwiCentroCoste)})
        Me.TryDataBinding(fwiCentroCoste, New System.Windows.Forms.Binding("Text", Me, "IDCentroCoste", True))
        Me.fwiCentroCoste.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCentroCoste.EntityName = "MntoCentroCoste"
        Me.fwiCentroCoste.Location = New System.Drawing.Point(92, 17)
        Me.fwiCentroCoste.MaxLength = 10
        Me.fwiCentroCoste.Name = "fwiCentroCoste"
        Me.fwiCentroCoste.PrimaryDataFields = "IDCentroCoste"
        Me.fwiCentroCoste.SecondaryDataFields = "IDCentroCoste"
        Me.fwiCentroCoste.Size = New System.Drawing.Size(67, 23)
        Me.fwiCentroCoste.TabIndex = 10
        Me.fwiCentroCoste.ViewName = "tbMntoCentroCoste"
        '
        'lblfwiClase
        '
        Me.lblfwiClase.Location = New System.Drawing.Point(6, 48)
        Me.lblfwiClase.Name = "lblfwiClase"
        Me.lblfwiClase.Size = New System.Drawing.Size(39, 13)
        Me.lblfwiClase.TabIndex = 8
        Me.lblfwiClase.Tag = "IdRec=12857;"
        Me.lblfwiClase.Text = "Clase"
        '
        'lblcfwiClase
        '
        Me.TryDataBinding(lblcfwiClase, New System.Windows.Forms.Binding("Text", Me.fwiClase, "DescClaseActivo", True))
        Me.lblcfwiClase.Location = New System.Drawing.Point(160, 45)
        Me.lblcfwiClase.Name = "lblcfwiClase"
        Me.lblcfwiClase.Size = New System.Drawing.Size(136, 21)
        Me.lblcfwiClase.TabIndex = 9
        '
        'fwiClase
        '
        Me.fwiClase.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescClaseActivo", lblcfwiClase)})
        Me.TryDataBinding(fwiClase, New System.Windows.Forms.Binding("Text", Me, "IDClaseActivo", True))
        Me.fwiClase.DisabledBackColor = System.Drawing.Color.White
        Me.fwiClase.EntityName = "MntoClaseActivo"
        Me.fwiClase.Location = New System.Drawing.Point(88, 45)
        Me.fwiClase.MaxLength = 10
        Me.fwiClase.Name = "fwiClase"
        Me.fwiClase.PrimaryDataFields = "IDClaseActivo"
        Me.fwiClase.SecondaryDataFields = "IDClaseActivo"
        Me.fwiClase.Size = New System.Drawing.Size(67, 23)
        Me.fwiClase.TabIndex = 11
        Me.fwiClase.ViewName = "tbMntoClaseActivo"
        '
        'lblfwiZona
        '
        Me.lblfwiZona.Location = New System.Drawing.Point(6, 75)
        Me.lblfwiZona.Name = "lblfwiZona"
        Me.lblfwiZona.Size = New System.Drawing.Size(36, 13)
        Me.lblfwiZona.TabIndex = 10
        Me.lblfwiZona.Tag = "IdRec=4707;"
        Me.lblfwiZona.Text = "Zona"
        '
        'fwiZona
        '
        Me.TryDataBinding(fwiZona, New System.Windows.Forms.Binding("Value", Me, "IDZona", True))
        fwiZona_DesignTimeLayout.LayoutString = resources.GetString("fwiZona_DesignTimeLayout.LayoutString")
        Me.fwiZona.DesignTimeLayout = fwiZona_DesignTimeLayout
        Me.fwiZona.DisabledBackColor = System.Drawing.Color.White
        Me.fwiZona.DisplayMember = "DescZona"
        Me.fwiZona.EntityName = "MntoZona"
        Me.fwiZona.Location = New System.Drawing.Point(88, 72)
        Me.fwiZona.Name = "fwiZona"
        Me.fwiZona.SelectedIndex = -1
        Me.fwiZona.SelectedItem = Nothing
        Me.fwiZona.Size = New System.Drawing.Size(208, 21)
        Me.fwiZona.TabIndex = 12
        Me.fwiZona.ValueMember = "IDZona"
        Me.fwiZona.ViewName = "tbMntoZona"
        '
        'lblfwiIdProveedor
        '
        Me.lblfwiIdProveedor.Location = New System.Drawing.Point(9, 82)
        Me.lblfwiIdProveedor.Name = "lblfwiIdProveedor"
        Me.lblfwiIdProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblfwiIdProveedor.TabIndex = 16
        Me.lblfwiIdProveedor.Tag = "IdRec=4352;"
        Me.lblfwiIdProveedor.Text = "Proveedor"
        '
        'lblcfwiIdProveedor
        '
        Me.TryDataBinding(lblcfwiIdProveedor, New System.Windows.Forms.Binding("Text", Me.fwiIdProveedor, "DescProveedor", True))
        Me.lblcfwiIdProveedor.Location = New System.Drawing.Point(210, 80)
        Me.lblcfwiIdProveedor.Name = "lblcfwiIdProveedor"
        Me.lblcfwiIdProveedor.Size = New System.Drawing.Size(160, 21)
        Me.lblcfwiIdProveedor.TabIndex = 17
        '
        'fwiIdProveedor
        '
        Me.fwiIdProveedor.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescProveedor", lblcfwiIdProveedor)})
        Me.TryDataBinding(fwiIdProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.fwiIdProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdProveedor.EntityName = "Proveedor"
        Me.fwiIdProveedor.Location = New System.Drawing.Point(122, 80)
        Me.fwiIdProveedor.MaxLength = 25
        Me.fwiIdProveedor.Name = "fwiIdProveedor"
        Me.fwiIdProveedor.PrimaryDataFields = "IDProveedor"
        Me.fwiIdProveedor.SecondaryDataFields = "IDProveedor"
        Me.fwiIdProveedor.Size = New System.Drawing.Size(85, 23)
        Me.fwiIdProveedor.TabIndex = 4
        Me.fwiIdProveedor.ViewName = "tbmaestroproveedor"
        '
        'lblfwiPrecUltCompra
        '
        Me.lblfwiPrecUltCompra.Location = New System.Drawing.Point(9, 108)
        Me.lblfwiPrecUltCompra.Name = "lblfwiPrecUltCompra"
        Me.lblfwiPrecUltCompra.Size = New System.Drawing.Size(111, 13)
        Me.lblfwiPrecUltCompra.TabIndex = 50
        Me.lblfwiPrecUltCompra.Text = "Precio Ult.Compra"
        '
        'fwiPrecUltCompra
        '
        Me.TryDataBinding(fwiPrecUltCompra, New System.Windows.Forms.Binding("Value", Me, "PrecioUltimaCompra", True))
        Me.fwiPrecUltCompra.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPrecUltCompra.Location = New System.Drawing.Point(122, 106)
        Me.fwiPrecUltCompra.Name = "fwiPrecUltCompra"
        Me.fwiPrecUltCompra.Size = New System.Drawing.Size(85, 21)
        Me.fwiPrecUltCompra.TabIndex = 5
        '
        'lblFwiCosteParada
        '
        Me.lblFwiCosteParada.Location = New System.Drawing.Point(100, 160)
        Me.lblFwiCosteParada.Name = "lblFwiCosteParada"
        Me.lblFwiCosteParada.Size = New System.Drawing.Size(114, 13)
        Me.lblFwiCosteParada.TabIndex = 51
        Me.lblFwiCosteParada.Tag = "IdRec=12858;"
        Me.lblFwiCosteParada.Text = "Coste hora parada"
        '
        'FwiCosteParada
        '
        Me.TryDataBinding(FwiCosteParada, New System.Windows.Forms.Binding("Value", Me, "CosteParada", True))
        Me.FwiCosteParada.DisabledBackColor = System.Drawing.Color.White
        Me.FwiCosteParada.Location = New System.Drawing.Point(218, 158)
        Me.FwiCosteParada.Name = "FwiCosteParada"
        Me.FwiCosteParada.Size = New System.Drawing.Size(89, 21)
        Me.FwiCosteParada.TabIndex = 8
        '
        'FwiPadre
        '
        Me.TryDataBinding(FwiPadre, New System.Windows.Forms.Binding("BindableValue", Me, "Padre", True))
        Me.FwiPadre.Location = New System.Drawing.Point(9, 158)
        Me.FwiPadre.Name = "FwiPadre"
        Me.FwiPadre.Size = New System.Drawing.Size(74, 21)
        Me.FwiPadre.TabIndex = 7
        Me.FwiPadre.Text = "Padre"
        '
        'lblfwiIdActivo
        '
        Me.lblfwiIdActivo.Location = New System.Drawing.Point(7, 7)
        Me.lblfwiIdActivo.Name = "lblfwiIdActivo"
        Me.lblfwiIdActivo.Size = New System.Drawing.Size(42, 13)
        Me.lblfwiIdActivo.TabIndex = 52
        Me.lblfwiIdActivo.Tag = "IdRec=4469;"
        Me.lblfwiIdActivo.Text = "Activo"
        '
        'fwiIdActivo
        '
        Me.TryDataBinding(fwiIdActivo, New System.Windows.Forms.Binding("Text", Me, "IDActivo", True))
        Me.fwiIdActivo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdActivo.Location = New System.Drawing.Point(80, 5)
        Me.fwiIdActivo.MaxLength = 25
        Me.fwiIdActivo.Name = "fwiIdActivo"
        Me.fwiIdActivo.Size = New System.Drawing.Size(88, 23)
        Me.fwiIdActivo.TabIndex = 0
        '
        'fwiDescActivo
        '
        Me.TryDataBinding(fwiDescActivo, New System.Windows.Forms.Binding("Text", Me, "DescActivo", True))
        Me.fwiDescActivo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescActivo.Location = New System.Drawing.Point(171, 5)
        Me.fwiDescActivo.MaxLength = 100
        Me.fwiDescActivo.Name = "fwiDescActivo"
        Me.fwiDescActivo.Size = New System.Drawing.Size(511, 21)
        Me.fwiDescActivo.TabIndex = 1
        '
        'lblfwiFechaAlta
        '
        Me.lblfwiFechaAlta.Location = New System.Drawing.Point(7, 33)
        Me.lblfwiFechaAlta.Name = "lblfwiFechaAlta"
        Me.lblfwiFechaAlta.Size = New System.Drawing.Size(66, 13)
        Me.lblfwiFechaAlta.TabIndex = 53
        Me.lblfwiFechaAlta.Tag = "IdRec=4457;"
        Me.lblfwiFechaAlta.Text = "Fecha Alta"
        '
        'fwiFechaAlta
        '
        Me.TryDataBinding(fwiFechaAlta, New System.Windows.Forms.Binding("BindableValue", Me, "FechaAlta", True))
        Me.fwiFechaAlta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaAlta.Location = New System.Drawing.Point(80, 31)
        Me.fwiFechaAlta.Name = "fwiFechaAlta"
        Me.fwiFechaAlta.Size = New System.Drawing.Size(81, 21)
        Me.fwiFechaAlta.TabIndex = 2
        '
        'lblfwiFechaFinGarantia
        '
        Me.lblfwiFechaFinGarantia.Location = New System.Drawing.Point(171, 33)
        Me.lblfwiFechaFinGarantia.Name = "lblfwiFechaFinGarantia"
        Me.lblfwiFechaFinGarantia.Size = New System.Drawing.Size(113, 13)
        Me.lblfwiFechaFinGarantia.TabIndex = 54
        Me.lblfwiFechaFinGarantia.Tag = "IdRec=12859;"
        Me.lblfwiFechaFinGarantia.Text = "Fecha Fin Garantía"
        '
        'fwiFechaFinGarantia
        '
        Me.TryDataBinding(fwiFechaFinGarantia, New System.Windows.Forms.Binding("BindableValue", Me, "FechaGarantia", True))
        Me.fwiFechaFinGarantia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaFinGarantia.Location = New System.Drawing.Point(288, 31)
        Me.fwiFechaFinGarantia.Name = "fwiFechaFinGarantia"
        Me.fwiFechaFinGarantia.Size = New System.Drawing.Size(81, 21)
        Me.fwiFechaFinGarantia.TabIndex = 3
        '
        'lblfwiCategoria
        '
        Me.lblfwiCategoria.Location = New System.Drawing.Point(9, 134)
        Me.lblfwiCategoria.Name = "lblfwiCategoria"
        Me.lblfwiCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiCategoria.TabIndex = 55
        Me.lblfwiCategoria.Tag = "IdRec=6111;"
        Me.lblfwiCategoria.Text = "Categoría"
        '
        'fwiCategoria
        '
        Me.TryDataBinding(fwiCategoria, New System.Windows.Forms.Binding("Value", Me, "IDCAtegoriaActivo", True))
        fwiCategoria_DesignTimeLayout.LayoutString = resources.GetString("fwiCategoria_DesignTimeLayout.LayoutString")
        Me.fwiCategoria.DesignTimeLayout = fwiCategoria_DesignTimeLayout
        Me.fwiCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCategoria.DisplayMember = "DescCategoriaActivo"
        Me.fwiCategoria.EntityName = "MntoCategoriaActivo"
        Me.fwiCategoria.Location = New System.Drawing.Point(122, 132)
        Me.fwiCategoria.Name = "fwiCategoria"
        Me.fwiCategoria.SelectedIndex = -1
        Me.fwiCategoria.SelectedItem = Nothing
        Me.fwiCategoria.Size = New System.Drawing.Size(184, 21)
        Me.fwiCategoria.TabIndex = 6
        Me.fwiCategoria.ValueMember = "IDCategoriaActivo"
        Me.fwiCategoria.ViewName = "tbMntoCategoriaActivo"
        '
        'CTxtMenuArbol
        '
        Me.CTxtMenuArbol.CommandManager = Me.UiCommandManager1
        Me.CTxtMenuArbol.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.CmdAbrirArt1, Me.CmdAbrirActivo1})
        Me.CTxtMenuArbol.Key = "CTxtMenuArbol"
        '
        'CmdAbrirArt1
        '
        Me.CmdAbrirArt1.Key = "CmdAbrirArt"
        Me.CmdAbrirArt1.Name = "CmdAbrirArt1"
        '
        'CmdAbrirActivo1
        '
        Me.CmdAbrirActivo1.Key = "CmdAbrirActivo"
        Me.CmdAbrirActivo1.Name = "CmdAbrirActivo1"
        '
        'CmdAbrirArt
        '
        Me.CmdAbrirArt.ImageIndex = 3
        Me.CmdAbrirArt.Key = "CmdAbrirArt"
        Me.CmdAbrirArt.Name = "CmdAbrirArt"
        Me.CmdAbrirArt.Text = "Abrir Articulo"
        '
        'CmdAbrirActivo
        '
        Me.CmdAbrirActivo.ImageIndex = 2
        Me.CmdAbrirActivo.Key = "CmdAbrirActivo"
        Me.CmdAbrirActivo.Name = "CmdAbrirActivo"
        Me.CmdAbrirActivo.Text = "Abrir Activo"
        '
        'MntoActivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 541)
        Me.EntityName = "Activo"
        Me.Name = "MntoActivos"
        Me.NavigationFields = "IDActivo"
        Me.ViewName = "frmMntoActivos"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.TabActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabActivo.ResumeLayout(False)
        Me.TabPagepicDatos.ResumeLayout(False)
        Me.PnlDatosGenerales.ResumeLayout(False)
        Me.PnlDatosGenerales.PerformLayout()
        Me.TabPagepicCaracteristica.ResumeLayout(False)
        CType(Me.jngCaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicActivoContador.ResumeLayout(False)
        CType(Me.jngActivoContador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicRepuestos.ResumeLayout(False)
        CType(Me.jngRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicEstructura.ResumeLayout(False)
        CType(Me.jngEstructura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicArbol.ResumeLayout(False)
        Me.TabPagepicHistorico.ResumeLayout(False)
        CType(Me.jngHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicElementos.ResumeLayout(False)
        CType(Me.jngElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicPreventivos.ResumeLayout(False)
        CType(Me.jngPreventivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PicCabecera.ResumeLayout(False)
        Me.PicCabecera.PerformLayout()
        Me.FraClasificacion.ResumeLayout(False)
        Me.FraClasificacion.PerformLayout()
        CType(Me.fwiZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTxtMenuArbol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrTipoProv As String
    Private mblnActivosConNSeries As Boolean

    Private Const cn_UBICACION_PENDIENTE_INVENTARIAR As String = "Ubicación: Pendiente de Inventariar"
    Private Const cn_UBICACION_ALMACEN As String = "Ubicación: #IDAlmacen# - #DescAlmacen# "
    Private Const cn_UBICACION_SIN_UBICACION As String = "Sin Ubicación"

#Region " Carga del formulario "

    Private Sub MntoActivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Me.NoEditableControls.Add(fwiIdActivo)

            LoadFormActions()
            LoadGridActions()
            LoadERPData()
            LoadEnums()

            GridFormatStyle.CrearFormatos(jngHistorico, GridFormatStyle.TipoFormato.EstadoActivo)
        End If
    End Sub

    Protected Overridable Sub LoadFormActions()
        'Me.FormActions.Add("Preventivos asociados a ese Activo", AddressOf AccionCargarPreventivo)
        Me.FormActions.Add("Ordenes abiertas del Activo", AddressOf AccionCargarOT)
        Me.AddSeparator()
        Me.FormActions.Add("Cambio de Estado", AddressOf AccionCambioDeEstado)
        Me.FormActions.Add("Recuperar Características", AddressOf AccionRecuperarCaracteristicas)
        Me.FormActions.Add("Cambio Artículo", AddressOf AccionCambioArticulo)
        Me.FormActions.Add("Cambio de Artículo en Maquinaria", AddressOf AccionCambioDeArticuloEnMaquinaria)
        Me.AddSeparator()
        Me.FormActions.Add("Duplicar Activo", AddressOf AccionDuplicarActivo)
    End Sub

    Private Sub LoadGridActions()
        With jngEstructura
            .Actions.Add("Ir a Activo", AddressOf AccionGridIrActivo)
        End With
    End Sub

    Private Sub LoadERPData()
        Dim objNegParam As New Parametro
        mstrTipoProv = objNegParam.TipoProvContrata
        '//GestionNumeroSerieConActivos: Cuando se da de alta un Nº de Serie obliga a que se genere un activo, si no no se genera el activo.
        mblnActivosConNSeries = objNegParam.GestionNumeroSerieConActivos
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumpaContadorFecha", jngPreventivos.Columns("ContadorFecha"))
    End Sub

#End Region

#Region " Acciones de los Grids "

    Private Sub AccionGridIrActivo()
        If Length(jngEstructura.Value("IDActivoComponente")) > 0 Then
            AccionTreeViewCargarActivo(jngEstructura.Value("IDActivoComponente") & String.Empty)
        End If
    End Sub

#End Region

#Region " Eventos del formulario "

    Private Sub MntoActivos_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        DatosActuales()
        DefaultValuesGrid()
    End Sub

    Private Sub MntoActivos_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        DatosActuales()
    End Sub

    Private Sub DatosActuales()
        trvActivos.Nodes.Clear()

        EtiquetaEstado(Me.CurrentRow("DescEstadoActivo") & String.Empty)
        EtiquetaUbicacion()
        HabilitarArticulo()

        Dim t As TreeNode
        PintarArbolActivos(fwiIdActivo.Text, fwiDescActivo.Text, t)
        trvActivos.ExpandAll()
    End Sub

    Private Sub MntoActivos_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordAdded
        '//Etiqueta de Estado. La cargamos cuando estamos dando de alta un Activo nuevo.
        If Length(Me.CurrentRow("IDEstadoActivo")) > 0 Then
            Dim objNegEstadoActivo As New MntoEstadoActivo
            Dim dt As DataTable = objNegEstadoActivo.SelOnPrimaryKey(Me.CurrentRow("IDEstadoActivo"))
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                EtiquetaEstado(dt.Rows(0)("DescEstadoActivo") & String.Empty)
            End If
        End If
    End Sub

#End Region

#Region " Acciones del formulario "

    Private Sub AccionDuplicarActivo()
        '//Duplica el Activo y sus repuestos y estructura.
        Me.Cursor = Cursors.WaitCursor
        Dim objNegActivo As New Activo
        Dim strIDActivoNew As String = ExpertisApp.ExecuteTask(Of String, String)(AddressOf Activo.DuplicarActivo, Me.fwiIdActivo.Text)
        If Length(strIDActivoNew) > 0 Then
            AccionTreeViewCargarActivo(strIDActivoNew)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub AccionCargarPreventivo()
    '    Dim frm As New FrmPreventivos
    '    frm.FilterCriteria = New StringFilterItem("IDActivo", fwiIdActivo.Text)
    '    frm.ShowDialog()
    '    frm.Dispose()
    'End Sub

    Private Sub AccionCargarOT()
        Dim frm As New FrmOTs
        frm.FilterCriteria = New StringFilterItem("IDActivo", fwiIdActivo.Text)
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub AccionCambioDeEstado()
        If Not IsNothing(Me.CurrentRow) Then

            Dim valor As String
            valor = Me.CurrentRow("IDEstadoActivo")
            'ExpertisApp.GenerateMessage("Estado de la maquina anterior: " & valor, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim objNegEstadoActivo As New MntoEstadoActivo
            Dim dtEstadoActivo As DataTable = objNegEstadoActivo.Filter(New StringFilterItem("IDEstadoActivo", Me.CurrentRow("IDEstadoActivo")))
            If Not IsNothing(dtEstadoActivo) AndAlso dtEstadoActivo.Rows.Count > 0 AndAlso dtEstadoActivo.Rows(0)("Baja") Then
                'ExpertisApp.GenerateMessage("Es Activo está dado de baja, no se puede cambiar de Estado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Exit Sub
            End If

            Dim frm As New frmCambioDeEstado
            Dim arti As New ArticuloNSerie
            If frm.ShowDialog() = DialogResult.OK Then
                If Me.CurrentRow("IDEstadoActivo") <> frm.Estado Then
                    Me.CurrentRow("IDEstadoActivo") = frm.Estado
                    Me.CurrentRow("FechaEstado") = frm.FechaEstado
                    Me.CurrentRow("IDOperario") = frm.Operario
                    Me.CurrentRow("Texto") = frm.Texto

                    'CAMBIA EL ESTADO EN TBARTICULONSERIE. BUENA VINCULACION
                    'Dim NSerie As String
                    'NSerie = Me.CurrentRow("Nserie")
                    'Dim estado As String
                    'estado = frm.Estado
                    ''arti.ActualizaIDEstadoActivo(IDAct, estado)
                    'Dim act As New Business.Negocio.ArticuloNSerie
                    'act.ActualizaEstadoNSerie(NSerie, estado)


                    'Hasta aquí
                    If frm.FechaBaja <> cnMinDate Then Me.CurrentRow("FechaBaja") = frm.FechaBaja
                    'EtiquetaEstado escribe en la primera solapa el nuevo estado.
                    EtiquetaEstado(frm.DescEstado)
                    'Esto se encarga de guardar en el histórico.
                    Dim ClsHist As New HistoricoEstadoActivo
                    Dim DtHistoricoEstado As DataTable = ClsHist.AddNewForm
                    DtHistoricoEstado.Rows(0)("IDActivo") = Me.CurrentRow("IDActivo")
                    DtHistoricoEstado.Rows(0)("IDEstadoActivo") = frm.Estado
                    DtHistoricoEstado.Rows(0)("FechaEstado") = frm.FechaEstado
                    DtHistoricoEstado.Rows(0)("IDOperario") = frm.Operario
                    DtHistoricoEstado.Rows(0)("Texto") = frm.Texto
                    ClsHist.Update(DtHistoricoEstado)

                    Me.Ok.InvokeOnClick()
                    Me.TabActivo.SelectedTab = TabPagepicDatos
                End If
            End If
        End If
    End Sub

    Private Sub AccionRecuperarCaracteristicas()
        If Length(advArticulo.Text) > 0 Then
            '//11646: Se va a proceder a la Recuperación de las Características del Activo. ¿ Desea Continuar?
            If ExpertisApp.GenerateMessage("Se va a proceder a la Recuperación de las Características del Activo. ¿ Desea Continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                Dim dtCaracteristicasActual As DataTable = CType(jngCaracteristica.DataSource, DataTable)
                Dim objNegActivoCaract As New ActivoCaracteristica
                Dim StDatos As New ActivoCaracteristica.DatosRecupCaract(advArticulo.Text, fwiIdActivo.Text, dtCaracteristicasActual)
                Dim dt As DataTable = ExpertisApp.ExecuteTask(Of ActivoCaracteristica.DatosRecupCaract, DataTable)(AddressOf ActivoCaracteristica.RecuperaCaracteristicas, StDatos)
                Me.Cursor = Cursors.Default

                If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                    For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                        dtCaracteristicasActual.ImportRow(dt.Rows(i))
                    Next
                    jngCaracteristica.Refresh()
                    Me.RecordsState = RecordsState.Modified
                    '//1472: Proceso finalizado correctamente.
                    ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Ok.InvokeOnClick()
                Else
                    '//11647: El artículo relacionado con el activo no tiene características agregables.
                    ExpertisApp.GenerateMessage("El Artículo Relacionado con el Activo no tiene Características. ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("No se ha indicado un Artículo para recuperar las características.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AccionCambioArticulo()
        If Me.CurrentRow("IDEstadoActivo") = 5 AndAlso Length(Me.CurrentRow("Ubicacion")) = 0 Then
            Dim FrmCambio As New FrmCambioArticulo
            If FrmCambio.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim DtSave As DataTable = Me.CurrentData.Clone
                DtSave.Rows.Add(Me.CurrentRow.ItemArray)
                DtSave.AcceptChanges()
                Dim StData As New Activo.StActuaArtSerie(DtSave, FrmCambio.IDArticulo)
                ExpertisApp.ExecuteTask(Of Activo.StActuaArtSerie)(AddressOf Activo.ActualizarArticuloSerie, StData)
                Me.Requery.InvokeOnClick()
            End If
        End If
    End Sub

    Private Sub AccionCambioDeArticuloEnMaquinaria()
        If Length(fwiIdActivo.Text) > 0 Then
            Dim blnCancel As Boolean = False
            Dim strTipoAlbTransf As String = New Parametro().TipoAlbaranDeDeposito

            Dim fNSerie As New Filter
            fNSerie.Add(New StringFilterItem("IDActivo", fwiIdActivo.Text))
            Dim dtNSerie As DataTable = New ArticuloNSerie().Filter(fNSerie)
            If Not dtNSerie Is Nothing AndAlso dtNSerie.Rows.Count > 0 Then
                'Comprobaciones si hay algo metido en artículo
                If Length(advArticulo.Text) > 0 Then
                    Dim fObra As New Filter
                    fObra.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, 1))
                    fObra.Add(New StringFilterItem("Lote", fwiIdActivo.Text))
                    Dim dtObra As DataTable = New ObraMaterial().Filter(fObra)
                    If Not dtObra Is Nothing AndAlso dtObra.Rows.Count > 0 Then
                        Dim dtTrabajo As DataTable = New ObraTrabajo().SelOnPrimaryKey(dtObra.Rows(0)("IDTrabajo"))
                        Dim strCodTrabajo As String
                        If Not IsNothing(dtTrabajo) AndAlso dtTrabajo.Rows.Count > 0 Then
                            strCodTrabajo = dtTrabajo.Rows(0)("CodTrabajo") & String.Empty
                        End If
                        ExpertisApp.GenerateMessage("No es posible modificar el Artículo. La Máquina está asociada a la Orden de Servicio | . ", MessageBoxButtons.OK, MessageBoxIcon.Information, strCodTrabajo)
                        blnCancel = True
                    End If
                    Dim StDatos As New Activo.DatosObtAlqRetorno(advArticulo.Text, fwiIdActivo.Text, strTipoAlbTransf)
                    Dim dtRetorno As DataTable = ExpertisApp.ExecuteTask(Of Activo.DatosObtAlqRetorno, DataTable)(AddressOf Activo.ObtenerAlquilerRetorno, StDatos)
                    If Not IsNothing(dtRetorno) AndAlso dtRetorno.Rows.Count > 0 Then
                        Dim intIDAlbaran As Integer = Nz(dtRetorno.Rows(0)("IDAlbaran"), 0)
                        Dim strCodTrabajo As String = dtRetorno.Rows(0)("CodTrabajo") & String.Empty
                        ExpertisApp.GenerateMessage("La máquina está pendiente de retorno. Únicamente se podrá modificar el código de artículo si se elimina  previamente el albarán de envío Nº  | (O.Servicio: | ) o bien, tras el retorno de la máquina.", MessageBoxButtons.OK, MessageBoxIcon.Information, intIDAlbaran, strCodTrabajo)
                        blnCancel = True
                    End If
                End If
                If Not blnCancel Then
                    '//Llevamos a cabo la acción
                    Dim frm As New frmCambioDeArticulo
                    frm.IDArticulo = advArticulo.Text & String.Empty
                    frm.IDAlmacen = dtNSerie.Rows(0)("IDAlmacen") & String.Empty
                    frm.IDActivo = fwiIdActivo.Text
                    frm.ShowDialog()

                    Me.Requery.InvokeOnClick()
                End If
            Else
                ExpertisApp.GenerateMessage("El Activo no está asociado a ningún número de serie.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

#End Region

#Region " Pestaña Datos Generales "

    Private Sub advNSerie_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advNSerie.SetPredefinedFilter
        e.Filter.Add(New IsNullFilterItem("IDActivo"))
        If Length(advArticulo.Text) > 0 Then
            'e.Filter.Add(New StringFilterItem("IDArticulo", advArticulo.Text))
        End If
    End Sub

    Private Sub advNSerie_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advNSerie.SelectionChanged
        EtiquetaUbicacion()
        HabilitarArticulo()
    End Sub

    Private Sub HabilitarArticulo()
        advArticulo.Enabled = (Length(advNSerie.Text) = 0)
    End Sub

    Private Sub EtiquetaUbicacion()
        Dim strUbicacion As String

        If mblnActivosConNSeries Then
            strUbicacion = cn_UBICACION_PENDIENTE_INVENTARIAR
            If Length(advNSerie.Text) > 0 And Length(advArticulo.Text) > 0 Then
                Dim objFilter As New Filter
                objFilter.Add(New StringFilterItem("NSerie", advNSerie.Text))
                objFilter.Add(New StringFilterItem("IDArticulo", advArticulo.Text))

                Dim BEDataEngine As New BE.DataEngine
                Dim dtUbicacion As DataTable = BEDataEngine.Filter("VfrmArticuloNserie", objFilter, "IDAlmacen,DescAlmacen")
                If Not IsNothing(dtUbicacion) AndAlso dtUbicacion.Rows.Count > 0 Then
                    strUbicacion = Replace(cn_UBICACION_ALMACEN, "#IDAlmacen#", dtUbicacion.Rows(0)("IDAlmacen") & String.Empty)
                    strUbicacion = Replace(strUbicacion, "#DescAlmacen#", dtUbicacion.Rows(0)("DescAlmacen") & String.Empty)
                End If
            End If
        Else
            strUbicacion = cn_UBICACION_SIN_UBICACION
        End If

        LbUbicacion.Text = UCase(strUbicacion)
    End Sub

    Private Sub EtiquetaEstado(ByVal strDescEstado As String)
        lblEstado.Text = UCase("ESTADO: " & strDescEstado)
    End Sub

#End Region

#Region " Grid Características "

    Private Sub jngCaracteristica_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCaracteristica.GotFocus
        DefaultValuesGrid()
    End Sub

    Private Sub jngCaracteristica_AddingRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngCaracteristica.AddingRecord, jngCaracteristica.UpdatingRecord
        With jngCaracteristica
            If Length(.Value("IDCaracteristica")) = 0 Then
                e.Cancel = True
                '//8453: El código de la Característica es obligatorio
                ExpertisApp.GenerateMessage("El código de la Característica es obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub jngCaracteristica_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngCaracteristica.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "Valor"
                If Length(jngCaracteristica.Value("IDCaracteristica")) > 0 Then
                    e.Filter.Add(New StringFilterItem("IDCaracteristica", jngCaracteristica.Value("IDCaracteristica")))
                End If
        End Select
    End Sub

    Private Sub jngCaracteristica_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngCaracteristica.EditingCell
        With jngCaracteristica
            Select Case e.Column.Key
                Case "IDCaracteristica"
                    e.Cancel = (.Row <> Grid.newTopRowPosition)
                    If e.Cancel Then
                        .Columns("IDCaracteristica").ButtonStyle = ButtonStyle.NoButton
                    Else
                        .Columns("IDCaracteristica").ButtonStyle = ButtonStyle.Image
                    End If
                Case "Valor"
                    CargarValoresCaracteristica(jngCaracteristica, "Valor", .Value("IDCaracteristica"), .Value("TipoValor"))
            End Select
        End With
    End Sub

    Public Sub CargarValoresCaracteristica(ByVal g As Grid, ByVal ColumnName As String, ByVal IDCaracteristica As String, ByVal TipoValor As enumTipoValor)
        Select Case TipoValor
            Case enumTipoValor.Discreto
                Dim objFilter As New Filter
                objFilter.Add(New StringFilterItem("IDCaracteristica", IDCaracteristica))
                Dim dtValoresCaracteristica As DataTable = New CaracteristicaValor().Filter(objFilter)
                g.Columns(ColumnName).DropDown.SetDataBinding(dtValoresCaracteristica, Nothing)
                g.Columns(ColumnName).EditType = EditType.MultiColumnCombo
            Case enumTipoValor.Continuo
                g.Columns(ColumnName).DropDown.SetDataBinding(Nothing, Nothing)
                g.Columns(ColumnName).EditType = EditType.TextBox
        End Select
    End Sub

#End Region

#Region " Grid Contadores "

    Private Sub jngActivoContador_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngActivoContador.GotFocus
        DefaultValuesGrid()
    End Sub

    Private Sub jngActivoContador_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngActivoContador.EditingCell
        With jngActivoContador
            Select Case e.Column.Key
                Case "IDArticuloFacturacion"
                    If Length(.Value("NecesitaArtFacturacion")) = 0 OrElse _
                       .Value("NecesitaArtFacturacion") = False Then
                        e.Cancel = True
                    End If
                    If e.Cancel Then
                        .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    Else
                        .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    End If
                Case "Principal"
                    If .Row <> Grid.newTopRowPosition Then
                        '//NOTA: Ver evento Click. Complementa el caso en el que estaba la marca activada.
                        If e.Value Then    '//Si estaba marcada, no la dejamos desmarcar
                            e.Cancel = True
                        Else
                            '//Si la marcamos, se desmarca la que estaba marcada.
                            Dim FilActCont As New Filter
                            FilActCont.Add("IDContadorPrev", FilterOperator.Equal, .GetValue("IDContadorPrev"))
                            FilActCont.Add("IDActivo", FilterOperator.NotEqual, .GetValue("IDActivo"))
                            FilActCont.Add("Principal", FilterOperator.Equal, True)
                            Dim DtActCont As DataTable = New ActivoContador().Filter(FilActCont)
                            If Not DtActCont Is Nothing AndAlso DtActCont.Rows.Count > 0 Then
                                ExpertisApp.GenerateMessage("El Contador | ya es principal en el activo |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, .GetValue("IDContadorPrev"), DtActCont.Rows(0)("IDActivo"))
                                e.Cancel = True
                            Else
                                Dim objFilterPpal As New Filter
                                objFilterPpal.Clear()
                                objFilterPpal.Add(New BooleanFilterItem("Principal", True))
                                For Each drRow As DataRow In CType(.DataSource, DataTable).Select(objFilterPpal.Compose(New AdoFilterComposer))
                                    .GetRow(drRow).BeginEdit()
                                    .GetRow(drRow).Cells("Principal").Value = False
                                    .GetRow(drRow).EndEdit()
                                Next
                            End If
                        End If
                    End If
            End Select
        End With

    End Sub

    Private Sub jngActivoContador_DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngActivoContador.DeletingRecords
        With jngActivoContador
            '//Si se va a borrar una linea con marca "Principal", no se debe dejar borrar. A menos que sea la última.
            If .RowCount > 1 AndAlso (.Value("Principal")) Then
                e.Cancel = True
                '//9616: No es posible eliminar el registro Principal
                ExpertisApp.GenerateMessage("No es posible eliminar el registro Principal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub jngActivoContador_AddingRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngActivoContador.AddingRecord, jngActivoContador.UpdatingRecord
        With jngActivoContador
            If .Row = Grid.newTopRowPosition Then
                If Length(.Value("IDContadorPrev")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Debe indicar al menos el contador.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    If .Value("Principal") Then
                        Dim FilActCont As New Filter
                        FilActCont.Add("IDContadorPrev", FilterOperator.Equal, .GetValue("IDContadorPrev"))
                        FilActCont.Add("Principal", FilterOperator.Equal, True)
                        Dim DtActCont As DataTable = New ActivoContador().Filter(FilActCont)
                        If Not DtActCont Is Nothing AndAlso DtActCont.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Contador | ya es principal en el activo |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, .GetValue("IDContadorPrev"), DtActCont.Rows(0)("IDActivo"))
                            .SetValue("Principal", False)
                            e.Cancel = True
                        Else
                            Dim objFilterPpal As New Filter
                            objFilterPpal.Clear()
                            objFilterPpal.Add(New BooleanFilterItem("Principal", True))
                            For Each drRow As DataRow In CType(.DataSource, DataTable).Select(objFilterPpal.Compose(New AdoFilterComposer))
                                .GetRow(drRow).BeginEdit()
                                .GetRow(drRow).Cells("Principal").Value = False
                                .GetRow(drRow).EndEdit()
                            Next
                        End If
                    End If
                End If
                If .RowCount = 0 Then
                    Dim FilActCont As New Filter
                    FilActCont.Add("IDContadorPrev", FilterOperator.Equal, .GetValue("IDContadorPrev"))
                    FilActCont.Add("Principal", FilterOperator.Equal, True)
                    Dim DtActCont As DataTable = New ActivoContador().Filter(FilActCont)
                    If Not DtActCont Is Nothing AndAlso DtActCont.Rows.Count > 0 Then
                        .SetValue("Principal", False)
                        e.Cancel = True
                    Else : .SetValue("Principal", True)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub jngActivoContador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngActivoContador.Click
        With jngActivoContador
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Principal"
                            If .Row <> Grid.newTopRowPosition Then
                                '//NOTA: Esto es necesario. Es una especie de cancelación de edición. 
                                '//El EditingCell salta una vez y si volvemos a clickar no vuelve a saltar, por estar el registro ya en 
                                '//edición, aunque si cambia el valor. Entonces, hay que volver a poner el valor que nos interesa.
                                '//Ver evento EditingCell
                                .GetRow(.Row).BeginEdit()
                                .GetRow(.Row).Cells(c.Key).Value = True
                                .GetRow(.Row).EndEdit()
                                .Refresh()
                            End If
                        Case "NuevoContador"
                            GeneraNuevoContador()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub GeneraNuevoContador()
        Dim frm As New frmAltaPreventivoContador
        If frm.ShowDialog(Me) = DialogResult.OK Then
            Dim dtPrevCont As DataTable = frm.PreventivoContador
            If Not IsNothing(dtPrevCont) AndAlso dtPrevCont.Rows.Count > 0 Then
                With jngActivoContador
                    .Row = Grid.newTopRowPosition
                    .Value("IDContadorPrev") = dtPrevCont.Rows(0)("IDContadorPrev")
                    .Value("DescContadorPrev") = dtPrevCont.Rows(0)("DescContadorPrev")
                    .Value("NecesitaArtFacturacion") = dtPrevCont.Rows(0)("NecesitaArtFacturacion")
                    .Value("IDArticuloFacturacion") = dtPrevCont.Rows(0)("IDArticuloFacturacion")
                    .Value("DescArticulo") = frm.DescArticuloFacturacion
                    .Value("TablaOrigen") = dtPrevCont.Rows(0)("TablaOrigen")
                    .Value("CampoOrigen") = dtPrevCont.Rows(0)("CampoOrigen")
                    .Value("LimiteOcupacionDiaria") = frm.LimiteOcupacionDiaria
                    .Value("PorcIncrementoPrecio") = frm.IncrementoPrecio
                End With
            End If
        End If
    End Sub
#End Region

#Region " Grid Repuestos "

    Private Sub jngRepuestos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngRepuestos.GotFocus
        DefaultValuesGrid()
    End Sub

    Private Sub jngRepuestos_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngRepuestos.AddingRecord
        With jngRepuestos
            If Length(.Value("IDComponente")) = 0 Then
                e.Cancel = True
                '//10457: El Repuesto es obligatorio.
                ExpertisApp.GenerateMessage("El Repuesto es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub
    Private Sub jngRepuestos_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngRepuestos.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDComponente"
                e.Filter.Add(New BooleanFilterItem("Compra", True))
        End Select
    End Sub
    Private Sub jngRepuestos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngRepuestos.EditingCell
        With jngRepuestos
            Select Case e.Column.Key
                Case "IDComponente"
                    If jngRepuestos.Row = Grid.newTopRowPosition Then
                        .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    Else
                        e.Cancel = True
                        .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
            End Select
        End With
    End Sub

#End Region

#Region " Grid Estructura "

    Private Sub jngEstructura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngEstructura.GotFocus
        DefaultValuesGrid()
    End Sub
    Private Sub jngEstructura_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngEstructura.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDActivoComponente"
                e.Filter.Add(New BooleanFilterItem("Padre", False))
                e.Filter.Add(New StringFilterItem("IDActivo", FilterOperator.NotEqual, fwiIdActivo.Text))
        End Select
    End Sub
    Private Sub jngEstructura_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngEstructura.EditingCell
        With jngEstructura
            Select Case e.Column.Key
                Case "IDActivoComponente"
                    If jngEstructura.Row = Grid.newTopRowPosition Then
                        .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    Else
                        e.Cancel = True
                        .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
            End Select
        End With
    End Sub

#End Region

#Region " Grid Preventivos "

    Private Sub jngPreventivos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngPreventivos.GotFocus
        DefaultValuesGrid()
    End Sub

    Private Sub jngPreventivos_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngPreventivos.AdvSearchSetPredefinedFilter
        With jngPreventivos
            Select Case e.Key
                Case "IDProveedor"
                    If Length(.Value("ConContrata")) > 0 AndAlso .Value("ConContrata") Then
                        e.Filter.Add(New StringFilterItem("IDTipoProveedor", mstrTipoProv))
                    End If
            End Select
        End With
    End Sub

    Private Sub jngPreventivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngPreventivos.Click
        Dim hit As GridArea
        With jngPreventivos


            hit = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Materiales"
                            If Length(.Value("IDLineaActivo")) > 0 Then
                                Dim frmMat As New FrmMateriales
                                frmMat.IDPreventivo = .Value("IDPreventivo") & String.Empty
                                frmMat.DescPreventivo = .Value("DescPreventivo") & String.Empty
                                .Value("DescPreventivo") = "Por defecto"
                                frmMat.IDActivo = fwiIdActivo.Text
                                frmMat.DescActivo = fwiDescActivo.Text

                                frmMat.IDLineaActivo = .Value("IDLineaActivo")
                                frmMat.FilterCriteria = New NumberFilterItem("IDLineaActivo", .Value("IDLineaActivo"))
                                frmMat.ShowDialog()
                                frmMat.Dispose()
                            End If

                        Case "Periodos"
                            Dim frmPer As New FrmPeriodos
                            frmPer.IDActivo = fwiIdActivo.Text
                            frmPer.DescActivo = fwiDescActivo.Text
                            frmPer.IDPreventivo = .Value("IDPreventivo") & String.Empty
                            frmPer.DescPreventivo = .Value("DescPreventivo") & String.Empty
                            If Length(.Value("FechaInicio")) > 0 AndAlso IsDate(.Value("FechaInicio")) Then
                                frmPer.FechaIni = .Value("FechaInicio")
                            End If
                            If Length(.Value("FechaUltima")) > 0 AndAlso IsDate(.Value("FechaUltima")) Then
                                frmPer.FechaFin = .Value("FechaUltima")
                            End If
                            frmPer.NROTUltimaIntervencion = .Value("NROT") & String.Empty
                            If Length(.Value("Periodo")) > 0 Then
                                frmPer.Periodo = .Value("Periodo")
                            End If
                            frmPer.TipoPeriodo = Nz(.Value("TipoPeriodo"), CInt(enumcpPeriodo.cpDia))

                            Dim b() As Boolean = New Boolean() {Nz(.Value("LunesExcluido"), False), Nz(.Value("MartesExcluido"), False), _
                                                                Nz(.Value("MiercolesExcluido"), False), Nz(.Value("JuevesExcluido"), False), _
                                                                Nz(.Value("ViernesExcluido"), False), Nz(.Value("SabadoExcluido"), True), _
                                                                Nz(.Value("DomingoExcluido"), True)}
                            frmPer.DiasSemana = b
                            frmPer.Obligatorio = Nz(.Value("Obligatorio"), False)
                            frmPer.Planificar = Nz(.Value("Planificar"), False)
                            frmPer.Criterio = Nz(.Value("Criterio"), emumpaCriterioPlanificaion.DesdeUltimaIntervencion)
                            frmPer.ContadorPrev = .Value("IDContadorPrev") & String.Empty
                            frmPer.Intervalo = .Value("IntervaloContador")
                            frmPer.PeriodoMax = .Value("PeriodoMaximo")
                            frmPer.PeriodoMin = .Value("PeriodoMinimo")
                            frmPer.Contador = .Value("ContadorFecha")

                            Dim res As DialogResult = frmPer.ShowDialog()
                            If res = DialogResult.OK Then
                                If Length(.Value("FechaInicio")) = 0 OrElse (.Value("FechaInicio") <> frmPer.FechaIni) Then
                                    .SetValue("FechaInicio", frmPer.FechaIni)
                                End If
                                If Length(.Value("FechaUltima")) = 0 OrElse (.Value("FechaUltima") <> frmPer.FechaFin) Then
                                    .SetValue("FechaUltima", frmPer.FechaFin)
                                End If
                                If Length(.Value("Periodo")) = 0 OrElse (.Value("Periodo") <> frmPer.Periodo) Then
                                    .SetValue("Periodo", frmPer.Periodo)
                                End If
                                If Length(.Value("TipoPeriodo")) = 0 And frmPer.TipoPeriodo <> -1 Then
                                    .SetValue("TipoPeriodo", frmPer.TipoPeriodo)
                                ElseIf .Value("TipoPeriodo") <> frmPer.TipoPeriodo Then
                                    If frmPer.TipoPeriodo <> -1 Then
                                        .SetValue("TipoPeriodo", frmPer.TipoPeriodo)
                                    Else
                                        .SetValue("TipoPeriodo", System.DBNull.Value)
                                    End If
                                End If
                                If .Value("LunesExcluido") <> frmPer.DiasSemana(0) Then
                                    .SetValue("LunesExcluido", frmPer.DiasSemana(0))
                                End If
                                If .Value("MartesExcluido") <> frmPer.DiasSemana(1) Then
                                    .SetValue("MartesExcluido", frmPer.DiasSemana(1))
                                End If
                                If .Value("MiercolesExcluido") <> frmPer.DiasSemana(2) Then
                                    .SetValue("MiercolesExcluido", frmPer.DiasSemana(2))
                                End If
                                If .Value("JuevesExcluido") <> frmPer.DiasSemana(3) Then
                                    .SetValue("JuevesExcluido", frmPer.DiasSemana(3))
                                End If
                                If .Value("ViernesExcluido") <> frmPer.DiasSemana(4) Then
                                    .SetValue("ViernesExcluido", frmPer.DiasSemana(4))
                                End If
                                If .Value("SabadoExcluido") <> frmPer.DiasSemana(5) Then
                                    .SetValue("SabadoExcluido", frmPer.DiasSemana(5))
                                End If
                                If .Value("DomingoExcluido") <> frmPer.DiasSemana(6) Then
                                    .SetValue("DomingoExcluido", frmPer.DiasSemana(6))
                                End If
                                If .Value("Obligatorio") <> frmPer.Obligatorio Then
                                    .SetValue("Obligatorio", frmPer.Obligatorio)
                                End If
                                If .Value("Planificar") <> frmPer.Planificar Then
                                    .SetValue("Planificar", frmPer.Planificar)
                                End If
                                If .Value("Criterio") <> frmPer.Criterio Then
                                    .SetValue("Criterio", frmPer.Criterio)
                                End If
                                If Length(.Value("IDContadorPrev")) = 0 OrElse .Value("IDContadorPrev") <> frmPer.ContadorPrev Then
                                    .SetValue("IDContadorPrev", frmPer.ContadorPrev)
                                End If
                                If Length(.Value("IntervaloContador")) = 0 OrElse .Value("IntervaloContador") <> frmPer.Intervalo Then
                                    .SetValue("IntervaloContador", frmPer.Intervalo)
                                End If
                                If Length(.Value("PeriodoMaximo")) = 0 OrElse .Value("PeriodoMaximo") <> frmPer.PeriodoMax Then
                                    .SetValue("PeriodoMaximo", frmPer.PeriodoMax)
                                End If
                                If Length(.Value("PeriodoMinimo")) = 0 OrElse .Value("PeriodoMinimo") <> frmPer.PeriodoMin Then
                                    .SetValue("PeriodoMinimo", frmPer.PeriodoMin)
                                End If
                                If .Value("IntervaloContador") <> frmPer.Intervalo Then
                                    .SetValue("IntervaloContador", frmPer.Intervalo)
                                End If
                                If .Value("PeriodoMaximo") <> frmPer.PeriodoMax Then
                                    .SetValue("PeriodoMaximo", frmPer.PeriodoMax)
                                End If
                                If .Value("PeriodoMinimo") <> frmPer.PeriodoMin Then
                                    .SetValue("PeriodoMinimo", frmPer.PeriodoMin)
                                End If
                            End If
                    End Select
                End If
            End If
        End With

    End Sub

#End Region

#Region " Grid Histórico "

    Private Sub jngHistorico_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngHistorico.FormattingRow
        If Length(e.Row.Cells("IDEstadoActivo").Value) > 0 Then GridFormatStyle.AplicarFormato(e.Row, e.Row.Cells("IDEstadoActivo").Value)
    End Sub

#End Region

#Region " Arbol de Activos "

    Private cnMNTO_ARTICULO As String = "MARTICULO"
    Private cnPREFIJO_NODO_ARTICULO As String = "AR"
    Private cnPREFIJO_NODO_ACTIVO As String = "AC"
    Private mNode As TreeNode


    Private Sub PintarArbolActivos(ByVal strIdActivo As String, _
                                   ByVal strDescActivo As String, _
                                   ByVal nodoBase As TreeNode)
        '// 1 - A partir del activo pasado, (el registro actual con lo que el evento Navigated es candidato),
        '//     sacar con vFrmMntoActivoRepuesto los componentes del activo.
        '// 2 - Por cada IDComponente de vFrmMntoActivoRepuesto añadimos un nodo. 
        '// 3 - Con vFrmMntoActivoEstructura sacamos IDActivoComponente y por cada uno de ellos
        '//     añadimos un nodo principal, y llamamos recursivamente a esta función.

        Dim strRepuesto As String
        Dim strActivoComp As String
        Dim objNegActivo As New Activo

        If nodoBase Is Nothing Then
            Dim t As New TreeNode(strIdActivo & " " & strDescActivo)
            t.ImageIndex = 1
            t.SelectedImageIndex = 1
            trvActivos.Nodes.Add(t)
            nodoBase = t
        End If

        Dim dtRepuestos As DataTable = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf Activo.ObtenerRepuestosActivo, strIdActivo)
        Dim dtEstructura As DataTable = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf Activo.ObtenerEstructuraActivo, strIdActivo)

        If Not dtRepuestos Is Nothing AndAlso dtRepuestos.Rows.Count > 0 Then
            For Each dr As DataRow In dtRepuestos.Rows
                strRepuesto = dr("IDComponente")
                Dim t As New TreeNode(strRepuesto & dr("DescComponente") & String.Empty)
                t.ImageIndex = 0
                t.SelectedImageIndex = 0
                t.Tag = cnPREFIJO_NODO_ARTICULO & "_" & strRepuesto
                nodoBase.Nodes.Add(t)
            Next
        End If

        If Not dtEstructura Is Nothing AndAlso dtEstructura.Rows.Count > 0 Then
            For Each dr As DataRow In dtEstructura.Rows
                strActivoComp = dr("IDActivoComponente")
                Dim t As New TreeNode(strActivoComp & "  " & dr("DescActivoComponente") & String.Empty)
                t.Tag = cnPREFIJO_NODO_ACTIVO & "_" & strActivoComp
                t.ImageIndex = 1
                t.SelectedImageIndex = 1
                nodoBase.Nodes.Add(t)
                PintarArbolActivos(strActivoComp, dr("DescActivoComponente") & String.Empty, t)
            Next
        End If
    End Sub

    Private Sub trvActivos_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trvActivos.MouseDown
        If e.Button = MouseButtons.Right Then
            '//Mostramos un menú contextual u otro en función de si es un artículo o un activo.
            mNode = trvActivos.GetNodeAt(e.X, e.Y)
            If Not IsNothing(mNode) Then
                If Microsoft.VisualBasic.Left(mNode.Tag, 2) = cnPREFIJO_NODO_ARTICULO Then
                    CmdAbrirArt1.IsVisible = True
                    CmdAbrirActivo1.IsVisible = False
                Else
                    CmdAbrirActivo1.IsVisible = True
                    CmdAbrirArt1.IsVisible = False
                End If
                trvActivos.SelectedNode = mNode
                CTxtMenuArbol.Show(trvActivos, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub CmdAbrirActivo1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles CmdAbrirActivo1.Click, CmdAbrirArt1.Click
        AccionTreeViewMenuContextual()
    End Sub

    Private Sub AccionTreeViewMenuContextual()
        If Length(fwiIdActivo.Text) > 0 Then
            Dim strID As String
            If Not IsNothing(mNode) Then strID = Mid$(mNode.Tag, 4)
            If Length(strID) > 0 Then
                If CmdAbrirArt1.IsVisible Then
                    AccionTreeViewAbrirArticulo(strID)
                ElseIf CmdAbrirActivo1.IsVisible Then
                    AccionTreeViewCargarActivo(strID)
                End If
            End If
        End If
    End Sub

    Private Sub AccionTreeViewCargarActivo(ByVal strIDActivo As String)
        If Length(strIDActivo) > 0 Then
            Me.GotoRecord(DataProviderActions.All, New StringFilterItem("IDActivo", strIDActivo), Me.CurrentData)
        End If
    End Sub

    Private Sub AccionTreeViewAbrirArticulo(ByVal strIDArticulo As String)
        ExpertisApp.OpenForm(cnMNTO_ARTICULO, New StringFilterItem("IDArticulo", strIDArticulo))
    End Sub

#End Region

#Region " Funciones Generales "

    Private Sub DefaultValuesGrid()
        With jngCaracteristica
            .Columns("IDActivo").DefaultValue = fwiIdActivo.Text
        End With

        With jngActivoContador
            .Columns("IDActivo").DefaultValue = fwiIdActivo.Text
            .Columns("Principal").DefaultValue = False
        End With

        With jngRepuestos
            .Columns("IDActivo").DefaultValue = fwiIdActivo.Text
        End With

        With jngEstructura
            .Columns("IDActivo").DefaultValue = fwiIdActivo.Text
        End With

        With jngHistorico
            .Columns("IDActivo").DefaultValue = fwiIdActivo.Text
        End With

        With jngElementos
            .Columns("IDActivo").DefaultValue = fwiIdActivo.Text
        End With

        With jngPreventivos
            .Columns("IDActivo").DefaultValue = fwiIdActivo.Text
            .Columns("ConContrata").DefaultValue = False
            .Columns("FechaInicio").DefaultValue = Today
            .Columns("FechaUltima").DefaultValue = Today
            .Columns("LunesExcluido").DefaultValue = False
            .Columns("MartesExcluido").DefaultValue = False
            .Columns("MiercolesExcluido").DefaultValue = False
            .Columns("JuevesExcluido").DefaultValue = False
            .Columns("ViernesExcluido").DefaultValue = False
            .Columns("SabadoExcluido").DefaultValue = True
            .Columns("DomingoExcluido").DefaultValue = True
            .Columns("Obligatorio").DefaultValue = False
            .Columns("Planificar").DefaultValue = False
            .Columns("Criterio").DefaultValue = emumpaCriterioPlanificaion.DesdeUltimaIntervencion
            .Columns("TipoPeriodo").DefaultValue = CInt(enumcpPeriodo.cpDia)
        End With
    End Sub

#End Region

#Region " Reports "

    Private Const cnDATABASEALIAS_HISTORICO_MANTENIEMIENTO As String = "REGCVOPVO"
    Private Const cnDATABASEALIAS_ESTADISTICA_PREVENTIVOS As String = "ESTPREV"
    Private Const cnDATABASEALIAS_INMOVILIZADO_POR_ACTIVOS As String = "LINMA"

    Private Sub MntoActivos_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Select Case e.Alias
            Case cnDATABASEALIAS_HISTORICO_MANTENIEMIENTO, _
                 cnDATABASEALIAS_ESTADISTICA_PREVENTIVOS, _
                 cnDATABASEALIAS_INMOVILIZADO_POR_ACTIVOS
                e.Filter.Add(New StringFilterItem("IDActivo", Me.fwiIdActivo.Text))
        End Select
    End Sub

    Private Sub MntoActivos_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case cnDATABASEALIAS_INMOVILIZADO_POR_ACTIVOS
                Dim objNegMoneda As New Moneda
                e.Formulas("NDecimales").Text = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).NDecimalesImporte
        End Select
    End Sub

#End Region


End Class