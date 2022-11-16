Public Class frmAltaPreventivoContador
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
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ulbladvIDUDMedida As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDUDMedida As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvIDUDMedida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxIncremento As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents nbxLimiteOcupacion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblIncremento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblLimiteOcupacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulbDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cmbCampoOrigen As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cmbTablaOrigen As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents advIDArticuloFacturacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents chbNecesitaArtFacturacion As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents txtDescContadorPrev As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIDContadorPrev As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDContadorPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescContadorPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNecesitaArtFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDArticuloFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTablaOrigen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCampoOrigen As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulbladvIDUDMedida = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDUDMedida = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvIDUDMedida = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxIncremento = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.nbxLimiteOcupacion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblIncremento = New Solmicro.Expertis.Engine.UI.Label
        Me.lblLimiteOcupacion = New Solmicro.Expertis.Engine.UI.Label
        Me.ulbDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cmbCampoOrigen = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cmbTablaOrigen = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.advIDArticuloFacturacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chbNecesitaArtFacturacion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.txtDescContadorPrev = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtIDContadorPrev = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblIDContadorPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescContadorPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNecesitaArtFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDArticuloFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTablaOrigen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCampoOrigen = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(312, 253)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(85, 26)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(412, 253)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 26)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.ulbladvIDUDMedida)
        Me.Frame1.Controls.Add(Me.advIDUDMedida)
        Me.Frame1.Controls.Add(Me.lbladvIDUDMedida)
        Me.Frame1.Controls.Add(Me.nbxIncremento)
        Me.Frame1.Controls.Add(Me.nbxLimiteOcupacion)
        Me.Frame1.Controls.Add(Me.lblIncremento)
        Me.Frame1.Controls.Add(Me.lblLimiteOcupacion)
        Me.Frame1.Controls.Add(Me.ulbDescArticulo)
        Me.Frame1.Controls.Add(Me.cmbCampoOrigen)
        Me.Frame1.Controls.Add(Me.cmbTablaOrigen)
        Me.Frame1.Controls.Add(Me.advIDArticuloFacturacion)
        Me.Frame1.Controls.Add(Me.chbNecesitaArtFacturacion)
        Me.Frame1.Controls.Add(Me.txtDescContadorPrev)
        Me.Frame1.Controls.Add(Me.txtIDContadorPrev)
        Me.Frame1.Controls.Add(Me.lblIDContadorPrev)
        Me.Frame1.Controls.Add(Me.lblDescContadorPrev)
        Me.Frame1.Controls.Add(Me.lblNecesitaArtFacturacion)
        Me.Frame1.Controls.Add(Me.lblIDArticuloFacturacion)
        Me.Frame1.Controls.Add(Me.lblTablaOrigen)
        Me.Frame1.Controls.Add(Me.lblCampoOrigen)
        Me.Frame1.Location = New System.Drawing.Point(9, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(488, 245)
        Me.Frame1.TabIndex = 22
        Me.Frame1.TabStop = False
        '
        'ulbladvIDUDMedida
        '
        Me.ulbladvIDUDMedida.Location = New System.Drawing.Point(269, 62)
        Me.ulbladvIDUDMedida.Name = "ulbladvIDUDMedida"
        Me.ulbladvIDUDMedida.Size = New System.Drawing.Size(210, 24)
        Me.ulbladvIDUDMedida.TabIndex = 41
        '
        'advIDUDMedida
        '
        Me.advIDUDMedida.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescUDMedida", ulbladvIDUDMedida)})
        Me.advIDUDMedida.EntityName = "UDMedida"
        Me.advIDUDMedida.Location = New System.Drawing.Point(159, 63)
        Me.advIDUDMedida.Name = "advIDUDMedida"
        Me.advIDUDMedida.SecondaryDataFields = "IDUdMedida"
        Me.advIDUDMedida.Size = New System.Drawing.Size(107, 21)
        Me.advIDUDMedida.TabIndex = 25
        '
        'lbladvIDUDMedida
        '
        Me.lbladvIDUDMedida.Location = New System.Drawing.Point(9, 65)
        Me.lbladvIDUDMedida.Name = "lbladvIDUDMedida"
        Me.lbladvIDUDMedida.Size = New System.Drawing.Size(68, 17)
        Me.lbladvIDUDMedida.TabIndex = 40
        Me.lbladvIDUDMedida.Text = "Ud. Medida"
        '
        'nbxIncremento
        '
        Me.nbxIncremento.Location = New System.Drawing.Point(159, 162)
        Me.nbxIncremento.Name = "nbxIncremento"
        Me.nbxIncremento.Size = New System.Drawing.Size(80, 21)
        Me.nbxIncremento.TabIndex = 31
        '
        'nbxLimiteOcupacion
        '
        Me.nbxLimiteOcupacion.Location = New System.Drawing.Point(159, 138)
        Me.nbxLimiteOcupacion.Name = "nbxLimiteOcupacion"
        Me.nbxLimiteOcupacion.Size = New System.Drawing.Size(80, 21)
        Me.nbxLimiteOcupacion.TabIndex = 29
        '
        'lblIncremento
        '
        Me.lblIncremento.Location = New System.Drawing.Point(9, 164)
        Me.lblIncremento.Name = "lblIncremento"
        Me.lblIncremento.Size = New System.Drawing.Size(86, 17)
        Me.lblIncremento.TabIndex = 39
        Me.lblIncremento.Text = "% Incremento"
        '
        'lblLimiteOcupacion
        '
        Me.lblLimiteOcupacion.Location = New System.Drawing.Point(9, 140)
        Me.lblLimiteOcupacion.Name = "lblLimiteOcupacion"
        Me.lblLimiteOcupacion.Size = New System.Drawing.Size(102, 17)
        Me.lblLimiteOcupacion.TabIndex = 38
        Me.lblLimiteOcupacion.Text = "Límite Ocupación"
        '
        'ulbDescArticulo
        '
        Me.ulbDescArticulo.Location = New System.Drawing.Point(269, 111)
        Me.ulbDescArticulo.Name = "ulbDescArticulo"
        Me.ulbDescArticulo.Size = New System.Drawing.Size(210, 23)
        Me.ulbDescArticulo.TabIndex = 37
        '
        'cmbCampoOrigen
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxInfoFormatStyle><Prede" & _
        "finedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxInfoFormatStyl" & _
        "e><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</PredefinedStyle></G" & _
        "roupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormatStyle</Predef" & _
        "inedStyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedStyle>PreviewRow" & _
        "FormatStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyle><Predefined" & _
        "Style>RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedFormatStyle><Pre" & _
        "definedStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatStyle><Selecte" & _
        "dInactiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</PredefinedSty" & _
        "le></SelectedInactiveFormatStyle><WatermarkImage /><BorderStyle>Flat</BorderStyl" & _
        "e><FlatBorderColor>125, 159, 190</FlatBorderColor><ControlStyle><ButtonAppearanc" & _
        "e>Flat</ButtonAppearance></ControlStyle><VisualStyle>Standard</VisualStyle><Allo" & _
        "wEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisi" & _
        "ble>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection></GridEXLay" & _
        "outData>"
        Me.cmbCampoOrigen.DesignTimeLayout = GridEXLayout1
        Me.cmbCampoOrigen.Location = New System.Drawing.Point(159, 216)
        Me.cmbCampoOrigen.Name = "cmbCampoOrigen"
        Me.cmbCampoOrigen.SelectedIndex = -1
        Me.cmbCampoOrigen.SelectedItem = Nothing
        Me.cmbCampoOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cmbCampoOrigen.TabIndex = 34
        Me.cmbCampoOrigen.Value = Nothing
        '
        'cmbTablaOrigen
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxInfoFormatStyle><Prede" & _
        "finedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxInfoFormatStyl" & _
        "e><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</PredefinedStyle></G" & _
        "roupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormatStyle</Predef" & _
        "inedStyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedStyle>PreviewRow" & _
        "FormatStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyle><Predefined" & _
        "Style>RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedFormatStyle><Pre" & _
        "definedStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatStyle><Selecte" & _
        "dInactiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</PredefinedSty" & _
        "le></SelectedInactiveFormatStyle><WatermarkImage /><BorderStyle>Flat</BorderStyl" & _
        "e><FlatBorderColor>125, 159, 190</FlatBorderColor><ControlStyle><ButtonAppearanc" & _
        "e>Flat</ButtonAppearance></ControlStyle><VisualStyle>Standard</VisualStyle><Allo" & _
        "wEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisi" & _
        "ble>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection></GridEXLay" & _
        "outData>"
        Me.cmbTablaOrigen.DesignTimeLayout = GridEXLayout2
        Me.cmbTablaOrigen.Location = New System.Drawing.Point(159, 188)
        Me.cmbTablaOrigen.Name = "cmbTablaOrigen"
        Me.cmbTablaOrigen.SelectedIndex = -1
        Me.cmbTablaOrigen.SelectedItem = Nothing
        Me.cmbTablaOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cmbTablaOrigen.TabIndex = 32
        Me.cmbTablaOrigen.Value = Nothing
        '
        'advIDArticuloFacturacion
        '
        Me.advIDArticuloFacturacion.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescArticulo", ulbDescArticulo)})
        Me.advIDArticuloFacturacion.EntityName = "Articulo"
        Me.advIDArticuloFacturacion.Location = New System.Drawing.Point(158, 112)
        Me.advIDArticuloFacturacion.Name = "advIDArticuloFacturacion"
        Me.advIDArticuloFacturacion.SecondaryDataFields = "IDArticulo"
        Me.advIDArticuloFacturacion.Size = New System.Drawing.Size(107, 21)
        Me.advIDArticuloFacturacion.TabIndex = 27
        '
        'chbNecesitaArtFacturacion
        '
        Me.chbNecesitaArtFacturacion.Location = New System.Drawing.Point(158, 87)
        Me.chbNecesitaArtFacturacion.Name = "chbNecesitaArtFacturacion"
        Me.chbNecesitaArtFacturacion.Size = New System.Drawing.Size(15, 17)
        Me.chbNecesitaArtFacturacion.TabIndex = 26
        '
        'txtDescContadorPrev
        '
        Me.txtDescContadorPrev.Location = New System.Drawing.Point(158, 39)
        Me.txtDescContadorPrev.Name = "txtDescContadorPrev"
        Me.txtDescContadorPrev.Size = New System.Drawing.Size(321, 21)
        Me.txtDescContadorPrev.TabIndex = 23
        '
        'txtIDContadorPrev
        '
        Me.txtIDContadorPrev.Location = New System.Drawing.Point(158, 15)
        Me.txtIDContadorPrev.Name = "txtIDContadorPrev"
        Me.txtIDContadorPrev.Size = New System.Drawing.Size(121, 21)
        Me.txtIDContadorPrev.TabIndex = 22
        '
        'lblIDContadorPrev
        '
        Me.lblIDContadorPrev.Location = New System.Drawing.Point(9, 17)
        Me.lblIDContadorPrev.Name = "lblIDContadorPrev"
        Me.lblIDContadorPrev.Size = New System.Drawing.Size(78, 17)
        Me.lblIDContadorPrev.TabIndex = 24
        Me.lblIDContadorPrev.Text = "ID. Contador"
        '
        'lblDescContadorPrev
        '
        Me.lblDescContadorPrev.Location = New System.Drawing.Point(9, 41)
        Me.lblDescContadorPrev.Name = "lblDescContadorPrev"
        Me.lblDescContadorPrev.Size = New System.Drawing.Size(92, 17)
        Me.lblDescContadorPrev.TabIndex = 28
        Me.lblDescContadorPrev.Text = "Desc. Contador"
        '
        'lblNecesitaArtFacturacion
        '
        Me.lblNecesitaArtFacturacion.Location = New System.Drawing.Point(9, 87)
        Me.lblNecesitaArtFacturacion.Name = "lblNecesitaArtFacturacion"
        Me.lblNecesitaArtFacturacion.Size = New System.Drawing.Size(147, 17)
        Me.lblNecesitaArtFacturacion.TabIndex = 30
        Me.lblNecesitaArtFacturacion.Text = "Necesita Art. Facturación"
        '
        'lblIDArticuloFacturacion
        '
        Me.lblIDArticuloFacturacion.Location = New System.Drawing.Point(9, 114)
        Me.lblIDArticuloFacturacion.Name = "lblIDArticuloFacturacion"
        Me.lblIDArticuloFacturacion.Size = New System.Drawing.Size(117, 17)
        Me.lblIDArticuloFacturacion.TabIndex = 33
        Me.lblIDArticuloFacturacion.Text = "Artículo Facturación"
        '
        'lblTablaOrigen
        '
        Me.lblTablaOrigen.Location = New System.Drawing.Point(9, 190)
        Me.lblTablaOrigen.Name = "lblTablaOrigen"
        Me.lblTablaOrigen.Size = New System.Drawing.Size(77, 17)
        Me.lblTablaOrigen.TabIndex = 35
        Me.lblTablaOrigen.Text = "Tabla Origen"
        '
        'lblCampoOrigen
        '
        Me.lblCampoOrigen.Location = New System.Drawing.Point(9, 218)
        Me.lblCampoOrigen.Name = "lblCampoOrigen"
        Me.lblCampoOrigen.Size = New System.Drawing.Size(86, 17)
        Me.lblCampoOrigen.TabIndex = 36
        Me.lblCampoOrigen.Text = "Campo Origen"
        '
        'frmAltaPreventivoContador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 287)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAltaPreventivoContador"
        Me.Text = "Nuevo Contador"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Propiedades "

    Private mblnCerrar As Boolean


    Private mdtPrevCont As DataTable
    Public ReadOnly Property PreventivoContador() As DataTable
        Get
            Return mdtPrevCont
        End Get
    End Property

    Public ReadOnly Property LimiteOcupacionDiaria() As Double
        Get
            Return CDbl(Me.nbxLimiteOcupacion.Value)
        End Get
    End Property

    Public ReadOnly Property IncrementoPrecio() As Double
        Get
            Return CDbl(Me.nbxIncremento.Value)
        End Get
    End Property

    Public ReadOnly Property DescArticuloFacturacion() As String
        Get
            Return Me.ulbDescArticulo.Text
        End Get
    End Property

#End Region

#Region " Carga del formulario "

    Private Sub frmAltaPreventivoContador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadCombos()
            HabilitarControles()
        End If
    End Sub

    Private Sub LoadCombos()
        CargarEntidadesOrigen()
        cmbCampoOrigen.DataSource = Nothing
    End Sub

    Private Sub CargarEntidadesOrigen()
        Dim dt As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf EntidadContador.ObtenerEntidades, Nothing)
        cmbTablaOrigen.DataSource = dt
    End Sub

    Private Sub CargarCamposOrigen(ByVal IDEntidad As String)
        If Length(IDEntidad) > 0 Then
            Dim dt As DataTable = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf Parametro.ObtenerCamposEntidad, IDEntidad)
            cmbCampoOrigen.DataSource = dt
        End If
    End Sub

#End Region

#Region " Eventos de los controles  "

    Private Sub cmbTablaOrigen_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTablaOrigen.ValueChanged
        If Length(cmbTablaOrigen.Value) > 0 Then
            CargarCamposOrigen(cmbTablaOrigen.Value)
        End If
    End Sub

    Private Sub chbNecesitaArtFacturacion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbNecesitaArtFacturacion.CheckedChanged
        HabilitarControles()
    End Sub

    Private Sub HabilitarControles()
        Me.advIDArticuloFacturacion.Enabled = chbNecesitaArtFacturacion.Checked
        Me.cmbTablaOrigen.Enabled = chbNecesitaArtFacturacion.Checked
        Me.cmbCampoOrigen.Enabled = chbNecesitaArtFacturacion.Checked
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        mblnCerrar = True
        If ValidacionDatos() Then
            Dim objNegPrevCont As New PreventivoContador
            mdtPrevCont = objNegPrevCont.AddNewForm
            If Not IsNothing(mdtPrevCont) AndAlso mdtPrevCont.Rows.Count > 0 Then
                mdtPrevCont.Rows(0)("IDContadorPrev") = Me.txtIDContadorPrev.Text
                mdtPrevCont.Rows(0)("DescContadorPrev") = Me.txtDescContadorPrev.Text
                mdtPrevCont.Rows(0)("IDUDMedida") = Me.advIDUDMedida.Text
                mdtPrevCont.Rows(0)("Resetear") = False
                mdtPrevCont.Rows(0)("Valor") = 0
                mdtPrevCont.Rows(0)("Medidas") = 0
                mdtPrevCont.Rows(0)("NecesitaArtFacturacion") = Me.chbNecesitaArtFacturacion.Checked
                mdtPrevCont.Rows(0)("IDArticuloFacturacion") = Me.advIDArticuloFacturacion.Text
                mdtPrevCont.Rows(0)("TablaOrigen") = Me.cmbTablaOrigen.Value
                mdtPrevCont.Rows(0)("CampoOrigen") = Me.cmbCampoOrigen.Value
            End If
            objNegPrevCont.Update(mdtPrevCont)
            Me.Close()
        Else
            mblnCerrar = False
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        mblnCerrar = True
        Me.Close()
    End Sub

    Private Function ValidacionDatos() As Boolean
        Dim blnCancel As Boolean

        If Length(txtIDContadorPrev.Text) > 0 Then
            Dim objFilter As New Filter
            objFilter.Add(New StringFilterItem("IDContadorPrev", txtIDContadorPrev.Text))
            Dim objNegPrevCont As New PreventivoContador
            Dim dtPrevCont As DataTable = objNegPrevCont.Filter(objFilter)
            If Not IsNothing(dtPrevCont) AndAlso dtPrevCont.Rows.Count > 0 Then
                blnCancel = True
                ExpertisApp.GenerateMessage("El Contador introducido ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            blnCancel = True
            ExpertisApp.GenerateMessage("El ID.Contador es un campo obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If Not blnCancel AndAlso Length(txtDescContadorPrev.Text) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("La descripción del Contador es un campo obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If Not blnCancel AndAlso Length(advIDUDMedida.Text) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Unidad es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If Not blnCancel AndAlso chbNecesitaArtFacturacion.Checked Then
            If Length(Me.advIDArticuloFacturacion.Text) = 0 Then
                blnCancel = True
                ExpertisApp.GenerateMessage("Debe introducir el artículo de Facturación.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Return Not blnCancel
    End Function

#End Region

    Private Sub frmAltaPreventivoContador_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not mblnCerrar
    End Sub

End Class
