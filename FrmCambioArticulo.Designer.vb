<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioArticulo
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
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmCambio = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.UlblDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Panel1.suspendlayout()
        Me.FrmCambio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 43)
        Me.Panel1.TabIndex = 2
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(105, 6)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(87, 31)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(210, 6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 31)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'FrmCambio
        '
        Me.FrmCambio.Controls.Add(Me.UlblDescArticulo)
        Me.FrmCambio.Controls.Add(Me.AdvArticulo)
        Me.FrmCambio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmCambio.Location = New System.Drawing.Point(0, 0)
        Me.FrmCambio.Name = "FrmCambio"
        Me.FrmCambio.Size = New System.Drawing.Size(402, 57)
        Me.FrmCambio.TabIndex = 0
        Me.FrmCambio.TabStop = False
        Me.FrmCambio.Text = "Introduzca Nuevo Articulo"
        '
        'AdvArticulo
        '
        Me.AdvArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescArticulo", UlblDescArticulo)})
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(12, 22)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(130, 23)
        Me.AdvArticulo.TabIndex = 1
        Me.AdvArticulo.ViewName = "advArticulo"
        '
        'UlblDescArticulo
        '
        Me.UlblDescArticulo.Location = New System.Drawing.Point(148, 22)
        Me.UlblDescArticulo.Name = "UlblDescArticulo"
        Me.UlblDescArticulo.Size = New System.Drawing.Size(240, 23)
        Me.UlblDescArticulo.TabIndex = 2
        '
        'FrmCambioArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 100)
        Me.Controls.Add(Me.FrmCambio)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambioArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio Artículo"
        Me.Panel1.ResumeLayout(False)
        Me.FrmCambio.ResumeLayout(False)
        Me.FrmCambio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmCambio As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents UlblDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
End Class
