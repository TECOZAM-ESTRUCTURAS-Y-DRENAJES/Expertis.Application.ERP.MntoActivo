Imports Solmicro.Expertis.Application.ERP.CommonClasses
Imports Janus.Windows.GridEX
Imports System.Drawing.Color

Public Class MntoCrearNumerosDeSerie
    Inherits Solmicro.Expertis.Engine.UI.GridMnto
    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub


    Private Sub Grid_CellEdited(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellEdited
         Select e.Column.Key
            Case "NSerie"
                Grid.SetValue("IDEstadoActivo", "0")
                Grid.SetValue("IDAlmacen", "011")
        End Select

    End Sub
End Class