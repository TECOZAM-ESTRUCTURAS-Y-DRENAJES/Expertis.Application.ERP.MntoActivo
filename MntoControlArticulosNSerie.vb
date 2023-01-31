Imports System.Text
Imports System.Net.Mail

Public Class MntoControlArticulosNSerie

    Private Sub MntoControlArticulosNSerie_RecordCanceled(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.RecordCanceled
        Me.UpdateData()
    End Sub

    Private Sub MntoControlArticulosNSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFormActions()
        'muestraCaducados()
    End Sub

    Protected Overridable Sub LoadFormActions()
        Me.FormActions.Add("Mover manualmente activos.", AddressOf creaMovimientoManual)
        Me.AddSeparator()
        'Me.FormActions.Add("Check caducidad en artículos.", AddressOf muestraCaducados)
        'Me.FormActions.Add("Mandar correo.", AddressOf mandaCorreo)
    End Sub

    Public Sub muestraCaducados()
        'Saco los registros cuya FechaCaducidad está caducada, es decir, es menor a getDate()
        Dim sql As String = "SELECT * FROM vControlArticulosNSerie where FechaCaducidad<GETDATE()"
        Dim dt As New DataTable
        Dim pila As New Stack
        Dim control As New Business.ClasesTecozam.ControlArticuloNSerie
        dt = control.EjecutarSqlSelect(sql)
        For i As Integer = 0 To dt.Rows.Count - 1
            pila.Push("El articulo " & dt.Rows(i)("DescArticulo") & " con nº de serie " & dt.Rows(i)("NSerie") & " caducó en " & dt.Rows(i)("FechaCaducidad") & ".")
        Next
        pila.Push("----------------------------------------")
        'Saco los registros cuya FechaCaducidad es en 30 dias
        sql = "SELECT * FROM vControlArticulosNSerie where FechaCaducidad<GETDATE()+30 AND FechaCaducidad>=GETDATE()"
        dt = control.EjecutarSqlSelect(sql)
        For i As Integer = 0 To dt.Rows.Count - 1
            pila.Push("El articulo " & dt.Rows(i)("DescArticulo") & " con nº de serie " & dt.Rows(i)("NSerie") & " caduca en menos de 1 mes " & dt.Rows(i)("FechaCaducidad") & ".")
            'builder.Append(i).Append(dt.Rows(i)("Matricula"))
        Next

        If (pila.Count = 1) Then
        Else
            Dim lista As New StringBuilder()
            For Each value As String In pila
                lista.Append(value & "" & vbCrLf)
            Next
            MessageBox.Show(lista.ToString, "Fecha de Caducidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
            'MsgBox(lista.ToString())
        End If
    End Sub

    Public Sub creaMovimientoManual()
        Dim frmCreaMovimiento As New frmCreaMovimientoManual
        frmCreaMovimiento.ShowDialog()
    End Sub

    Public Sub mandaCorreo()
        Try

            Dim e_mail As New MailMessage

            'Quien escribe el mensaje
            e_mail.From = New MailAddress("davidvelascoherrero1@gmail.com")
            'Quien lo recibe
            e_mail.To.Add("david.velasco@tecozam.com")
            e_mail.To.Add("davidvelascoherrero10@gmail.com")
            'Quien lo recibe en CC
            e_mail.CC.Add("velasquito41@hotmail.com")
            e_mail.Subject = "Recordatorio EPIS"
            e_mail.Body = "Este es el cuerpo del correo donde debe de ir el nombre de la persona y la cantidad de epis que lleva."


            'Dim smtp_Server As New SmtpClient("smtp.tecozam.com")
            Dim smtp_Server As New SmtpClient()
            smtp_Server.EnableSsl = True
            smtp_Server.Host = "smtp.gmail.com"
            smtp_Server.UseDefaultCredentials = False
            smtp_Server.Credentials = New Net.NetworkCredential("davidvelascoherrero1@gmail.com", "btnmodgzchkzahuj")
            smtp_Server.Port = 587
            smtp_Server.Send(e_mail)


            MsgBox("E-mail enviado correctamente.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.StackTrace)
            MsgBox(ex.ToString)
            'MsgBox("Algo salió mal, intentalo de nuevo. ", MsgBoxStyle.Critical)
        End Try


    End Sub
End Class
'Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")}))})
'Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("NObra", "NObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IdObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescObra", "DescObra")}))})
'Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDAlmacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDAlmacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescAlmacen", "DescAlmacen")}))})
'Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDAlmacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDAlmacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescAlmacen", "DescAlmacen")}))})
