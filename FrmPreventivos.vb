Public Class FrmPreventivos
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
    Friend WithEvents jngPreventivos As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.jngPreventivos = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.jngPreventivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jngPreventivos
        '
        Me.jngPreventivos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngPreventivos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngPreventivos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDPreventivo" & _
        """><Caption>Preventivo</Caption><DataMember>IDPreventivo</DataMember><Key>IDPreve" & _
        "ntivo</Key><Position>0</Position><TextAlignment>Near</TextAlignment><Width>95</W" & _
        "idth></Column0><Column1 ID=""IDActivo""><Caption>IDActivo</Caption><DataMember>IDA" & _
        "ctivo</DataMember><Key>IDActivo</Key><Position>1</Position><TextAlignment>Near</" & _
        "TextAlignment><Visible>False</Visible></Column1><Column2 ID=""DescPreventivo""><Ca" & _
        "ption>Desc. Preventivo</Caption><DataMember>DescPreventivo</DataMember><Key>Desc" & _
        "Preventivo</Key><Position>2</Position><TextAlignment>Near</TextAlignment><Width>" & _
        "133</Width></Column2><Column3 ID=""FechaUltima""><Caption>Fecha Ultima Int.</Capti" & _
        "on><DataMember>FechaUltima</DataMember><EditTarget>Text</EditTarget><FormatStrin" & _
        "g>dd/MM/yy</FormatString><Key>FechaUltima</Key><Position>3</Position><TextAlignm" & _
        "ent>Near</TextAlignment><Width>110</Width></Column3><Column4 ID=""Cierre""><Captio" & _
        "n>Cierre</Caption><DataMember>Cierre</DataMember><Key>Cierre</Key><Position>4</P" & _
        "osition><TextAlignment>Near</TextAlignment><Visible>False</Visible></Column4><Co" & _
        "lumn5 ID=""FechaSolicitud""><Caption>Fecha Solicitud</Caption><DataMember>FechaSol" & _
        "icitud</DataMember><EditTarget>Text</EditTarget><FormatString>dd/MM/yy</FormatSt" & _
        "ring><Key>FechaSolicitud</Key><Position>5</Position><TextAlignment>Near</TextAli" & _
        "gnment><Width>98</Width></Column5></Columns><GroupCondition ID="""" /></RootTable>" & _
        "</GridEXLayoutData>"
        Me.jngPreventivos.DesignTimeLayout = GridEXLayout1
        Me.jngPreventivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngPreventivos.EntityName = "Activo"
        Me.jngPreventivos.Location = New System.Drawing.Point(0, 0)
        Me.jngPreventivos.Name = "jngPreventivos"
        Me.jngPreventivos.PrimaryDataFields = "IDActivo"
        Me.jngPreventivos.SecondaryDataFields = "IDActivo"
        Me.jngPreventivos.Size = New System.Drawing.Size(480, 269)
        Me.jngPreventivos.TabIndex = 0
        Me.jngPreventivos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngPreventivos.ViewName = "vCtlCIPreventivoActivo"
        '
        'FrmPreventivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(480, 269)
        Me.Controls.Add(Me.jngPreventivos)
        Me.EntityName = "Activo"
        Me.Name = "FrmPreventivos"
        Me.Text = "Preventivos asociados al Activo"
        Me.ViewName = "vCtlCIPreventivoActivo"
        CType(Me.jngPreventivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
