﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoControlEpis
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoControlEpis))
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(465, 28)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 28)
        Me.MenuBar.Size = New System.Drawing.Size(910, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(662, 344)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDAlmacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDAlmacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescAlmacen", "DescAlmacen")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOperario", "IDOperario"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOperario", "IDOperario"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario")}))})
        Me.Grid.DataSource = Nothing
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ControlEpisTrabajadores"
        Me.Grid.PrimaryDataFields = "IDLinea"
        Me.Grid.SecondaryDataFields = "IDLinea"
        Me.Grid.Size = New System.Drawing.Size(662, 344)
        Me.Grid.ViewName = "vControlEpisTrabajadores"
        '
        'MntoControlEpis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 432)
        Me.EntityName = "ControlEpisTrabajadores"
        Me.Name = "MntoControlEpis"
        Me.NavigationFields = "IDLinea"
        Me.Text = "Control Epis Trabajadores"
        Me.ViewName = "vControlEpisTrabajadores"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
