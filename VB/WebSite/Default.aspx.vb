Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If Session("bound") IsNot Nothing AndAlso CBool(Session("bound")) = True Then
			ASPxGridView1.DataBind()
		End If
	End Sub
	Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
		grid.DataSource = GetData()
	End Sub
	Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		ASPxGridView1.DataBind()
		Session("bound") = True
	End Sub
	Private Function GetData() As Object
		Return Enumerable.Range(0, 10)
	End Function
End Class