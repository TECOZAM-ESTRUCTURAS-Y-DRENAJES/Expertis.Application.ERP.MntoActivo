Public Class frmCambioDeEstado
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
    Friend WithEvents fwiTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiOperario As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFechaEstado As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFechaEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents WLFrame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fwiEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaBaja As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaBaja As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim fwiOperario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioDeEstado))
        Dim fwiEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmdCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdOk = New Solmicro.Expertis.Engine.UI.Button
        Me.fwiTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiOperario = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaEstado = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.WLFrame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaBaja = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaBaja = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.fwiOperario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLFrame1.SuspendLayout()
        CType(Me.fwiEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(180, 243)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(96, 30)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Cancelar"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(68, 243)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(96, 30)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "Aceptar"
        '
        'fwiTexto
        '
        Me.fwiTexto.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTexto.Location = New System.Drawing.Point(71, 76)
        Me.fwiTexto.Multiline = True
        Me.fwiTexto.Name = "fwiTexto"
        Me.fwiTexto.Size = New System.Drawing.Size(258, 56)
        Me.fwiTexto.TabIndex = 2
        '
        'lblfwiTexto
        '
        Me.lblfwiTexto.Location = New System.Drawing.Point(10, 76)
        Me.lblfwiTexto.Name = "lblfwiTexto"
        Me.lblfwiTexto.Size = New System.Drawing.Size(38, 13)
        Me.lblfwiTexto.TabIndex = 7
        Me.lblfwiTexto.Text = "Texto"
        '
        'fwiOperario
        '
        fwiOperario_DesignTimeLayout.LayoutString = resources.GetString("fwiOperario_DesignTimeLayout.LayoutString")
        Me.fwiOperario.DesignTimeLayout = fwiOperario_DesignTimeLayout
        Me.fwiOperario.DisabledBackColor = System.Drawing.Color.White
        Me.fwiOperario.DisplayMember = "DescOperario"
        Me.fwiOperario.EntityName = "Operario"
        Me.fwiOperario.Location = New System.Drawing.Point(71, 42)
        Me.fwiOperario.Name = "fwiOperario"
        Me.fwiOperario.SelectedIndex = -1
        Me.fwiOperario.SelectedItem = Nothing
        Me.fwiOperario.Size = New System.Drawing.Size(257, 21)
        Me.fwiOperario.TabIndex = 1
        Me.fwiOperario.ValueMember = "IDOperario"
        Me.fwiOperario.ViewName = "tbMaestroOperario"
        '
        'lblfwiOperario
        '
        Me.lblfwiOperario.Location = New System.Drawing.Point(10, 44)
        Me.lblfwiOperario.Name = "lblfwiOperario"
        Me.lblfwiOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblfwiOperario.TabIndex = 8
        Me.lblfwiOperario.Text = "Operario"
        '
        'fwiFechaEstado
        '
        Me.fwiFechaEstado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaEstado.Location = New System.Drawing.Point(71, 8)
        Me.fwiFechaEstado.Name = "fwiFechaEstado"
        Me.fwiFechaEstado.Size = New System.Drawing.Size(105, 21)
        Me.fwiFechaEstado.TabIndex = 0
        '
        'lblfwiFechaEstado
        '
        Me.lblfwiFechaEstado.Location = New System.Drawing.Point(10, 10)
        Me.lblfwiFechaEstado.Name = "lblfwiFechaEstado"
        Me.lblfwiFechaEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblfwiFechaEstado.TabIndex = 10
        Me.lblfwiFechaEstado.Text = "Fecha"
        '
        'WLFrame1
        '
        Me.WLFrame1.Controls.Add(Me.lblFechaBaja)
        Me.WLFrame1.Controls.Add(Me.cbxFechaBaja)
        Me.WLFrame1.Controls.Add(Me.fwiEstado)
        Me.WLFrame1.Controls.Add(Me.lblfwiEstado)
        Me.WLFrame1.Location = New System.Drawing.Point(7, 143)
        Me.WLFrame1.Name = "WLFrame1"
        Me.WLFrame1.Size = New System.Drawing.Size(321, 88)
        Me.WLFrame1.TabIndex = 3
        Me.WLFrame1.TabStop = False
        '
        'lblFechaBaja
        '
        Me.lblFechaBaja.Location = New System.Drawing.Point(132, 56)
        Me.lblFechaBaja.Name = "lblFechaBaja"
        Me.lblFechaBaja.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaBaja.TabIndex = 65
        Me.lblFechaBaja.Text = "Fecha Baja"
        '
        'cbxFechaBaja
        '
        Me.cbxFechaBaja.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaBaja.ForeColor = System.Drawing.Color.Red
        Me.cbxFechaBaja.Location = New System.Drawing.Point(208, 56)
        Me.cbxFechaBaja.Name = "cbxFechaBaja"
        Me.cbxFechaBaja.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaBaja.TabIndex = 64
        '
        'fwiEstado
        '
        fwiEstado_DesignTimeLayout.LayoutString = resources.GetString("fwiEstado_DesignTimeLayout.LayoutString")
        Me.fwiEstado.DesignTimeLayout = fwiEstado_DesignTimeLayout
        Me.fwiEstado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEstado.DisplayMember = "DescEstadoActivo"
        Me.fwiEstado.EntityName = "MntoEstadoActivo"
        Me.fwiEstado.Location = New System.Drawing.Point(96, 24)
        Me.fwiEstado.Name = "fwiEstado"
        Me.fwiEstado.SelectedIndex = -1
        Me.fwiEstado.SelectedItem = Nothing
        Me.fwiEstado.Size = New System.Drawing.Size(200, 21)
        Me.fwiEstado.TabIndex = 4
        Me.fwiEstado.ValueMember = "IDEstadoActivo"
        Me.fwiEstado.ViewName = "tbMntoEstadoActivo"
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(8, 26)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(85, 13)
        Me.lblfwiEstado.TabIndex = 7
        Me.lblfwiEstado.Text = "Nuevo Estado"
        '
        'frmCambioDeEstado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(338, 285)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.lblfwiTexto)
        Me.Controls.Add(Me.lblfwiOperario)
        Me.Controls.Add(Me.lblfwiFechaEstado)
        Me.Controls.Add(Me.fwiTexto)
        Me.Controls.Add(Me.fwiOperario)
        Me.Controls.Add(Me.fwiFechaEstado)
        Me.Controls.Add(Me.WLFrame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCambioDeEstado"
        Me.Text = "Cambio de Estado"
        CType(Me.fwiOperario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLFrame1.ResumeLayout(False)
        Me.WLFrame1.PerformLayout()
        CType(Me.fwiEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Propiedades "
    ReadOnly Property FechaEstado() As Date
        Get
            Return fwiFechaEstado.Value
        End Get
    End Property
    ReadOnly Property Operario() As String
        Get
            Return fwiOperario.Value
        End Get
    End Property
    ReadOnly Property Estado() As String
        Get
            Return fwiEstado.Value
        End Get
    End Property
    ReadOnly Property Texto() As String
        Get
            Return fwiTexto.Text
        End Get
    End Property
    ReadOnly Property DescEstado() As String
        Get
            Return fwiEstado.Text
        End Get
    End Property

    ReadOnly Property FechaBaja() As Date
        Get
            Return Nz(cbxFechaBaja.Value, cnMinDate)
        End Get
    End Property

#End Region

#Region " Eventos del formulario "

    Private Sub frmCambioDeEstado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            fwiFechaEstado.Value = Date.Today
            fwiOperario.Value = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Business.General.Operario.ObtenerIDOperarioUsuario, New Object)
            fwiTexto.Text = "Manual"
        End If
    End Sub

#End Region

#Region " Controles "

    Private Sub fwiEstado_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiEstado.ValueChanged
        If Not IsNothing(fwiEstado.SelectedItem) Then
            cbxFechaBaja.Enabled = CType(fwiEstado.SelectedItem, DataRowView).Row("Baja")
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If Not IsDate(fwiFechaEstado.Value) Then
            ExpertisApp.GenerateMessage("Introduzca una fecha válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Length(fwiOperario.Value) = 0 Then
            ExpertisApp.GenerateMessage("El campo | es obligatorio. Compruebe que el usuario tiene un Operario asociado.", MessageBoxButtons.OK, MessageBoxIcon.Information, lblfwiOperario.Text)
        ElseIf Length(fwiEstado.Text) = 0 Then
            ExpertisApp.GenerateMessage("El campo | es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information, lblfwiTexto.Text)
        ElseIf cbxFechaBaja.Enabled AndAlso Length(cbxFechaBaja.Value) = 0 Then
            '//13398: Si selecciona un estado que implica la baja de la máquina, el campo de "Fecha Baja" es obligatorio el rellenarlo.
            ExpertisApp.GenerateMessage("Si selecciona un estado que implica la baja de la máquina, el campo de Fecha Baja es obligatorio el rellenarlo.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

#End Region

End Class