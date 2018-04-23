Imports Microsoft.VisualBasic
Imports System
' ...

Namespace RunningSum
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private currentTotal As Integer = 0

		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
			currentTotal += Convert.ToInt32(Me.GetCurrentColumnValue("UnitsOnOrder"))
		End Sub

		Private Sub GroupFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupFooter1.BeforePrint
			Me.xrLabel3.Text = currentTotal.ToString()
		End Sub

	End Class
End Namespace
