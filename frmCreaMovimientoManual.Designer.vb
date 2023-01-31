<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreaMovimientoManual
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreaMovimientoManual))
        Dim Grid2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.bActualizar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid2 = New Solmicro.Expertis.Engine.UI.Grid
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.advAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bActualizar
        '
        Me.bActualizar.Icon = CType(resources.GetObject("bActualizar.Icon"), System.Drawing.Icon)
        Me.bActualizar.Location = New System.Drawing.Point(519, 336)
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.Size = New System.Drawing.Size(191, 23)
        Me.bActualizar.TabIndex = 21
        Me.bActualizar.Text = "Realizar movimientos"
        '
        'Grid2
        '
        Me.Grid2.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid2.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid2.ColumnAutoResize = True
        Grid2_DesignTimeLayout.LayoutString = resources.GetString("Grid2_DesignTimeLayout.LayoutString")
        Me.Grid2.DesignTimeLayout = Grid2_DesignTimeLayout
        Me.Grid2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid2.EntityName = "ControlArticuloNSerie"
        Me.Grid2.Location = New System.Drawing.Point(51, 118)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.PrimaryDataFields = Nothing
        Me.Grid2.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid2.SecondaryDataFields = Nothing
        Me.Grid2.Size = New System.Drawing.Size(659, 196)
        Me.Grid2.TabIndex = 19
        Me.Grid2.ViewName = "vControlArticulosNSerie"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(51, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Fecha Envio:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Almacén Destino:"
        '
        'cbFecha
        '
        Me.cbFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbFecha.Location = New System.Drawing.Point(184, 32)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(110, 21)
        Me.cbFecha.TabIndex = 24
        '
        'advAlmacen
        '
        Me.advAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advAlmacen.DisplayField = "IDAlmacen"
        Me.advAlmacen.EntityName = "Almacen"
        Me.advAlmacen.Location = New System.Drawing.Point(184, 68)
        Me.advAlmacen.Name = "advAlmacen"
        Me.advAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advAlmacen.Size = New System.Drawing.Size(110, 23)
        Me.advAlmacen.TabIndex = 25
        Me.advAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'frmCreaMovimientoManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 384)
        Me.Controls.Add(Me.advAlmacen)
        Me.Controls.Add(Me.cbFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bActualizar)
        Me.Controls.Add(Me.Grid2)
        Me.Name = "frmCreaMovimientoManual"
        Me.Text = "Crear Movimientos de Activos manuales"
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bActualizar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid2 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents advAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
End Class
