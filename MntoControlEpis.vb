Imports Solmicro.Expertis.Application.ERP.MmtoStocks
Public Class MntoControlEpis

    Private Sub MntoControlEpis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFormActions()
    End Sub

    Protected Overridable Sub LoadFormActions()
        Me.FormActions.Add("Insertar excel EPIS.", AddressOf InsertarEpis)
    End Sub

    Public Sub InsertarEpis()
        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A2:Z10000"
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Try
                    ruta = openFD.FileName
                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)
                    Dim dtLimpia As New DataTable
                    dtLimpia = ObtenerdtLimpia(dt)

                    Dim IDOperario As String
                    Dim Nobra As String
                    Dim Fecha As Date
                    Dim cantidad As Integer
                    Dim IDArticulo As String


                    For fila As Integer = 0 To dtLimpia.Rows.Count - 1
                        IDOperario = dtLimpia.Rows(fila)(0).ToString()
                        Nobra = dtLimpia.Rows(fila)(1).ToString()
                        Fecha = dtLimpia.Rows(fila)(2).ToString()
                        If IDOperario.ToString.Length = 0 Or Fecha.ToString.Length = 0 Then
                            MsgBox("No se puede cargar porque hay alguna fila que no tiene el operario, la fecha o la obra y son DATOS OBLIGATORIOS.")
                            Exit Sub
                        End If
                    Next
                    '-----
                    For fila As Integer = 0 To dtLimpia.Rows.Count - 1
                        IDOperario = dtLimpia.Rows(fila)(0).ToString()
                        Nobra = dtLimpia.Rows(fila)(1).ToString()
                        Fecha = dtLimpia.Rows(fila)(2).ToString()
                        For columna As Integer = 3 To dtLimpia.Columns.Count - 1
                            cantidad = dtLimpia.Rows(fila)(columna).ToString()
                            IDArticulo = dtLimpia.Columns(columna).ColumnName
                            If cantidad <> "0" Then
                                CreaLineaOpEpi(IDOperario, Fecha, Nobra, IDArticulo, cantidad)
                            End If
                        Next
                    Next

                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If
            MessageBox.Show("Excel importado correctamente.")
            Me.UpdateData()
        End With
    End Sub

    Public Sub CreaLineaOpEpi(ByVal IDOperario As String, ByVal Fecha As Date, ByVal Nobra As String, ByVal IDArticulo As String, ByVal cantidad As Integer)
        Dim LineaEpi As New Business.ClasesTecozam.ControlEpisTrabajadores
        Dim dtEpi As DataTable = LineaEpi.AddNewForm
        dtEpi.Rows(0)("IDOperario") = IDOperario
        dtEpi.Rows(0)("IDArticulo") = IDArticulo
        dtEpi.Rows(0)("Cantidad") = cantidad
        Try
            dtEpi.Rows(0)("IDAlmacen") = Nobra
        Catch ex As Exception

        End Try

        dtEpi.Rows(0)("FechaEntrega") = Fecha
        Try
            LineaEpi.Update(dtEpi)
        Catch ex As Exception

        End Try
    End Sub
    Public Function ObtenerdtLimpia(ByVal dtLimpia As DataTable) As DataTable
        Dim IDOperario As String

        Dim dtLim As New DataTable
        Dim drLim As DataRow
        dtLim.Columns.Add("IDOperario")
        dtLim.Columns.Add("Nobra")
        dtLim.Columns.Add("Fecha")
        dtLim.Columns.Add("99ARNCOMP")
        dtLim.Columns.Add("99ARNES")
        dtLim.Columns.Add("99BOTAGUA")
        dtLim.Columns.Add("99BOTASEG")
        dtLim.Columns.Add("99BOTASENC")
        dtLim.Columns.Add("99CASCO")
        dtLim.Columns.Add("99CASCOENC")
        dtLim.Columns.Add("99CAZADORAENC")
        dtLim.Columns.Add("99CAZADORAINV")
        dtLim.Columns.Add("99CAZADORASHOLF")
        dtLim.Columns.Add("99CHALECO")
        dtLim.Columns.Add("99CUERDSEG")
        dtLim.Columns.Add("99GAFAS")
        dtLim.Columns.Add("99GANCHO115")
        dtLim.Columns.Add("99GANCHO60")
        dtLim.Columns.Add("99GUANTE")
        dtLim.Columns.Add("99PANTALON")
        dtLim.Columns.Add("99PANTALONENC")
        dtLim.Columns.Add("99POLAR")
        dtLim.Columns.Add("99POLOMC")
        dtLim.Columns.Add("99POLOML")
        dtLim.Columns.Add("99PROTAUD")
        dtLim.Columns.Add("99TRAJAGU")


        For Each dr As DataRow In dtLimpia.Rows
            Try
                IDOperario = dr(0)
            Catch ex As Exception
                Return dtLim
            End Try

            If IDOperario.ToString.Length = 0 Then
                Return dtLim
            Else
                drLim = dtLim.NewRow
                drLim("IDOperario") = IDOperario
                drLim("Nobra") = dr(1)
                drLim("Fecha") = dr(2)
                drLim("99ARNCOMP") = Nz(dr(3), 0)
                drLim("99ARNES") = Nz(dr(4), 0)
                drLim("99BOTAGUA") = Nz(dr(5), 0)
                drLim("99BOTASEG") = Nz(dr(6), 0)
                drLim("99BOTASENC") = Nz(dr(7), 0)
                drLim("99CASCO") = Nz(dr(8), 0)
                drLim("99CASCOENC") = Nz(dr(9), 0)
                drLim("99CAZADORAENC") = Nz(dr(10), 0)
                drLim("99CAZADORAINV") = Nz(dr(11), 0)
                drLim("99CAZADORASHOLF") = Nz(dr(12), 0)
                drLim("99CHALECO") = Nz(dr(13), 0)
                drLim("99CUERDSEG") = Nz(dr(14), 0)
                drLim("99GAFAS") = Nz(dr(15), 0)
                drLim("99GANCHO115") = Nz(dr(16), 0)
                drLim("99GANCHO60") = Nz(dr(17), 0)
                drLim("99GUANTE") = Nz(dr(18), 0)
                drLim("99PANTALON") = Nz(dr(19), 0)
                drLim("99PANTALONENC") = Nz(dr(20), 0)
                drLim("99POLAR") = Nz(dr(21), 0)
                drLim("99POLOMC") = Nz(dr(22), 0)
                drLim("99POLOML") = Nz(dr(23), 0)
                drLim("99PROTAUD") = Nz(dr(24), 0)
                drLim("99TRAJAGU") = Nz(dr(25), 0)
                dtLim.Rows.Add(drLim)
            End If
        Next
        Return dtLim
    End Function
    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt

    End Function

    Private Sub MntoControlEpis_SetReportDesignObjects(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim frm As New Expertis.Application.ERP.MmtoStocks.frmInformeFecha

        Dim Fecha1 As Date
        Dim Fecha2 As Date

        If e.Alias = "CONTEPIS" Then
            frm.ShowDialog()

            Fecha1 = frm.FechaDesde.Value

            Fecha2 = frm.FechaHasta.Value
            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If

            Dim rp As New Report("CONTEPIS")
            Dim filtro As New Filter
            filtro.Add("FechaEntrega", FilterOperator.GreaterThanOrEqual, Fecha1)
            filtro.Add("FechaEntrega", FilterOperator.LessThanOrEqual, Fecha2)

            rp.DataSource = New BE.DataEngine().Filter("vControlEpisTrabajadores", filtro)
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            ExpertisApp.OpenReport(rp)

            e.Cancel = True
        End If

    End Sub
End Class