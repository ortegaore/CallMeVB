Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim servidores As SqlDataSourceEnumerator
        Dim tablaServidores As DataTable
        servidores = SqlDataSourceEnumerator.Instance
        tablaServidores = New DataTable()
        tablaServidores = servidores.GetDataSources()
        Dim rowServidor As DataRow
        For Each rowServidor In tablaServidores.Rows
            If String.IsNullOrEmpty(rowServidor("InstanceName").ToString()) Then
                cmb_server_bd.Items.Add(rowServidor("ServerName").ToString())
            Else
                cmb_server_bd.Items.Add(rowServidor("ServerName") & "\\" & rowServidor("InstanceName"))
            End If
        Next
    End Sub
    Private Sub cmb_server_bd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_server_bd.SelectedIndexChanged
    End Sub
    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class