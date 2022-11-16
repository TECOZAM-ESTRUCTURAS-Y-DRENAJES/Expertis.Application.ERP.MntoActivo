Public Class FrmOTs
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
    Friend WithEvents jngOTs As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.jngOTs = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.jngOTs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jngOTs
        '
        Me.jngOTs.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngOTs.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngOTs.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""NROT""><Capti" & _
        "on>Nº O.T.</Caption><DataMember>NROT</DataMember><Key>NROT</Key><Position>0</Pos" & _
        "ition><TextAlignment>Near</TextAlignment><Width>90</Width></Column0><Column1 ID=" & _
        """DescOT""><Caption>Desc. OT</Caption><DataMember>DescOT</DataMember><Key>DescOT</" & _
        "Key><Position>1</Position><TextAlignment>Near</TextAlignment><Width>133</Width><" & _
        "/Column1><Column2 ID=""IDEstadoOT""><Caption>Estado OT</Caption><DataMember>IDEsta" & _
        "doOT</DataMember><Key>IDEstadoOT</Key><Position>2</Position><TextAlignment>Near<" & _
        "/TextAlignment><Visible>False</Visible><Width>67</Width></Column2><Column3 ID=""F" & _
        "echaSolicitud""><Caption>Fecha Solicitud</Caption><DataMember>FechaSolicitud</Dat" & _
        "aMember><Key>FechaSolicitud</Key><Position>3</Position><TextAlignment>Near</Text" & _
        "Alignment><Width>105</Width></Column3><Column4 ID=""DescEstadoOT""><Caption>Estado" & _
        " OT</Caption><DataMember>DescEstadoOT</DataMember><Key>DescEstadoOT</Key><Positi" & _
        "on>4</Position><TextAlignment>Near</TextAlignment><Width>70</Width></Column4><Co" & _
        "lumn5 ID=""IDActivo""><Caption>IDActivo</Caption><DataMember>IDActivo</DataMember>" & _
        "<Key>IDActivo</Key><Position>5</Position><TextAlignment>Near</TextAlignment><Vis" & _
        "ible>False</Visible></Column5><Column6 ID=""IDPreventivo""><Caption>Preventivo</Ca" & _
        "ption><DataMember>IDPreventivo</DataMember><EditType>NoEdit</EditType><Key>IDPre" & _
        "ventivo</Key><Position>6</Position><Width>70</Width></Column6><Column7 ID=""DescP" & _
        "reventivo""><Caption>Desc. Preventivo</Caption><DataMember>DescPreventivo</DataMe" & _
        "mber><EditType>NoEdit</EditType><Key>DescPreventivo</Key><Position>7</Position><" & _
        "Width>170</Width></Column7></Columns><GroupCondition ID="""" /></RootTable></GridE" & _
        "XLayoutData>"
        Me.jngOTs.DesignTimeLayout = GridEXLayout1
        Me.jngOTs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngOTs.EntityName = "Activo"
        Me.jngOTs.Location = New System.Drawing.Point(0, 0)
        Me.jngOTs.Name = "jngOTs"
        Me.jngOTs.PrimaryDataFields = "IDActivo"
        Me.jngOTs.SecondaryDataFields = "IDActivo"
        Me.jngOTs.Size = New System.Drawing.Size(664, 301)
        Me.jngOTs.TabIndex = 0
        Me.jngOTs.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngOTs.ViewName = "vCTLCIOrdenesActivo"
        '
        'FrmOTs
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(664, 301)
        Me.Controls.Add(Me.jngOTs)
        Me.EntityName = "Activo"
        Me.Name = "FrmOTs"
        Me.Text = "Ordenes abiertas del Activo"
        Me.ViewName = "vCTLCIOrdenesActivo"
        CType(Me.jngOTs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
