Imports System
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters

Namespace ScaleCustomFormat
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub


		Protected Sub ASPxDashboard1_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			Dim parameters As New Access97ConnectionParameters()
			parameters.FileName = Server.MapPath("~/App_Data/nwind.mdb")
			e.ConnectionParameters = parameters
		End Sub
	End Class
End Namespace