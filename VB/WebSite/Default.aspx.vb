Imports Microsoft.VisualBasic
Imports System

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		ViewState("needBind") = True
		ASPxGridView1.DataBind()
	End Sub

	Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		If ViewState("needBind") IsNot Nothing AndAlso CBool(ViewState("needBind")) Then
			ASPxGridView1.DataSource = Product.GetData()
		End If
	End Sub
End Class