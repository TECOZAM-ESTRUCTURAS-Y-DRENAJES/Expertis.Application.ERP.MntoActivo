Public Class frmCambioDeArticulo
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents cmdCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdOk As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents WLFrame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblInfo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcboOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbladvArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboOperario As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblcadvArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmdCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdOk = New Solmicro.Expertis.Engine.UI.Button
        Me.WLFrame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblcboOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.lbladvArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.cboOperario = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblInfo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcadvArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.WLFrame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(316, 160)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(96, 30)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancelar"
        '
        'cmdOk
        '
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOk.Location = New System.Drawing.Point(210, 160)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(96, 30)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Aceptar"
        '
        'WLFrame1
        '
        Me.WLFrame1.Controls.Add(Me.lblcboOperario)
        Me.WLFrame1.Controls.Add(Me.lbladvArticulo)
        Me.WLFrame1.Controls.Add(Me.cboOperario)
        Me.WLFrame1.Controls.Add(Me.lblInfo)
        Me.WLFrame1.Controls.Add(Me.lblcadvArticulo)
        Me.WLFrame1.Controls.Add(Me.advArticulo)
        Me.WLFrame1.Location = New System.Drawing.Point(12, 8)
        Me.WLFrame1.Name = "WLFrame1"
        Me.WLFrame1.Size = New System.Drawing.Size(608, 137)
        Me.WLFrame1.TabIndex = 3
        Me.WLFrame1.TabStop = False
        '
        'lblcboOperario
        '
        Me.lblcboOperario.Location = New System.Drawing.Point(22, 98)
        Me.lblcboOperario.Name = "lblcboOperario"
        Me.lblcboOperario.Size = New System.Drawing.Size(53, 17)
        Me.lblcboOperario.TabIndex = 10
        Me.lblcboOperario.Text = "Operario"
        '
        'lbladvArticulo
        '
        Me.lbladvArticulo.Location = New System.Drawing.Point(22, 72)
        Me.lbladvArticulo.Name = "lbladvArticulo"
        Me.lbladvArticulo.Size = New System.Drawing.Size(87, 17)
        Me.lbladvArticulo.TabIndex = 13
        Me.lbladvArticulo.Text = "Nuevo Artículo"
        '
        'cboOperario
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDOperario"">" & _
        "<Caption>Operario</Caption><DataMember>IDOperario</DataMember><Key>IDOperario</K" & _
        "ey><Position>0</Position></Column0><Column1 ID=""DescOperario""><Caption>Descripci" & _
        "ón</Caption><DataMember>DescOperario</DataMember><Key>DescOperario</Key><Positio" & _
        "n>1</Position><Width>175</Width></Column1></Columns><GroupCondition ID="""" /></Ro" & _
        "otTable><RowWithErrorsFormatStyle><PredefinedStyle>RowWithErrorsFormatStyle</Pre" & _
        "definedStyle></RowWithErrorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFo" & _
        "rmatStyle</PredefinedStyle></LinkFormatStyle><CardCaptionFormatStyle><Predefined" & _
        "Style>CardCaptionFormatStyle</PredefinedStyle></CardCaptionFormatStyle><GroupByB" & _
        "oxInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></" & _
        "GroupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatSt" & _
        "yle</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>H" & _
        "eaderFormatStyle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><Pr" & _
        "edefinedStyle>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><Ro" & _
        "wFormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle><" & _
        "SelectedFormatStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></Sele" & _
        "ctedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactiveFo" & _
        "rmatStyle</PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><Bord" & _
        "erStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><Contr" & _
        "olStyle><ButtonAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>Sta" & _
        "ndard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</Expandab" & _
        "leGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</H" & _
        "ideSelection><DisplayMember>DescOperario</DisplayMember><ValueMember>IDOperario<" & _
        "/ValueMember></GridEXLayoutData>"
        Me.cboOperario.DesignTimeLayout = GridEXLayout1
        Me.cboOperario.DisplayMember = "DescOperario"
        Me.cboOperario.EntityName = "Operario"
        Me.cboOperario.Location = New System.Drawing.Point(116, 96)
        Me.cboOperario.Name = "cboOperario"
        Me.cboOperario.SelectedIndex = -1
        Me.cboOperario.SelectedItem = Nothing
        Me.cboOperario.Size = New System.Drawing.Size(325, 21)
        Me.cboOperario.TabIndex = 1
        Me.cboOperario.Value = Nothing
        Me.cboOperario.ValueMember = "IDOperario"
        Me.cboOperario.ViewName = "tbMaestroOperario"
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(16, 22)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(576, 40)
        Me.lblInfo.TabIndex = 12
        Me.lblInfo.Text = "Texto informativo"
        '
        'lblcadvArticulo
        '
        Me.lblcadvArticulo.Location = New System.Drawing.Point(289, 70)
        Me.lblcadvArticulo.Name = "lblcadvArticulo"
        Me.lblcadvArticulo.Size = New System.Drawing.Size(296, 21)
        Me.lblcadvArticulo.TabIndex = 14
        '
        'advArticulo
        '
        Me.advArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescArticulo", lblcadvArticulo)})
        Me.advArticulo.DisplayField = "IDArticulo"
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(116, 70)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(167, 21)
        Me.advArticulo.TabIndex = 0
        Me.advArticulo.ViewName = "tbMaestroArticulo"
        '
        'frmCambioDeArticulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 205)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.WLFrame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCambioDeArticulo"
        Me.Text = "Cambio de Artículo en Maquinaria"
        Me.WLFrame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrIDArticulo As String
    Private mstrIDActivo As String
    Private mstrIDAlmacen As String

    Private mstrIDOperario As String
    Private mstrIDArticuloNuevo As String

#Region " Propiedades "
    WriteOnly Property IDArticulo() As String
        Set(ByVal Value As String)
            mstrIDArticulo = Value
        End Set
    End Property
    WriteOnly Property IDActivo() As String
        Set(ByVal Value As String)
            mstrIDActivo = Value
        End Set
    End Property
    WriteOnly Property IDAlmacen() As String
        Set(ByVal Value As String)
            mstrIDAlmacen = Value
        End Set
    End Property

    ReadOnly Property Operario() As String
        Get
            Return mstrIDOperario
        End Get
    End Property
    ReadOnly Property IDArticuloNuevo() As String
        Get
            Return mstrIDArticuloNuevo
        End Get
    End Property
#End Region


#Region " Eventos del formulario "
    Private Sub frmCambioDeArticulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then

            lblInfo.Text = "Se va a sustituir el artículo " & IIf(Length(mstrIDArticulo) > 0, mstrIDArticulo, "?") & _
                " para el activo " & IIf(Length(mstrIDActivo) > 0, mstrIDActivo, "?") & "." & vbNewLine & _
                "En el proceso se realizarán los movimientos de ajuste en el almacén " & IIf(Length(mstrIDAlmacen) > 0, mstrIDAlmacen, "?") & "."

            cboOperario.Value = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Business.General.Operario.ObtenerIDOperarioUsuario, New Object)
        End If
    End Sub

#End Region

#Region " Controles "

    Private Sub cmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        If Length(advArticulo.Text) = 0 Then
            ExpertisApp.GenerateMessage("El artículo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf advArticulo.SelectedRow Is Nothing Then
            '//8503: El artículo no existe o no lleva una gestión por números de serie.
            ExpertisApp.GenerateMessage("El Artículo no existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Length(cboOperario.Value) = 0 Then
            '//9349: El | es obligatorio.
            ExpertisApp.GenerateMessage("El campo | es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information, lblcboOperario.Text)
        Else
            mstrIDArticuloNuevo = advArticulo.Text
            If Length(mstrIDArticulo) > 0 AndAlso Length(mstrIDArticuloNuevo) > 0 Then
                If mstrIDArticulo.ToUpper = mstrIDArticuloNuevo.ToUpper Then
                    ExpertisApp.GenerateMessage("Los artículos no pueden coincidir.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    mstrIDOperario = cboOperario.Value

                    Me.Cursor = Cursors.WaitCursor
                    Dim StDatos As New Activo.DatosCambiarArtEnMaq(mstrIDArticulo, mstrIDArticuloNuevo, mstrIDActivo)
                    ExpertisApp.ExecuteTask(Of Activo.DatosCambiarArtEnMaq)(AddressOf Activo.CambiarArticuloEnMaquinaria, StDatos)
                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub advArticulo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advArticulo.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("NSerieObligatorio", True))
    End Sub

#End Region


End Class
