Namespace RunningSumm
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.calcYear = New DevExpress.XtraReports.UI.CalculatedField()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel3})
			Me.Detail.HeightF = 23F
			Me.Detail.Name = "Detail"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductSales]")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(187.5F, 0F)
			Me.xrLabel3.Multiline = True
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.Text = "xrLabel3"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrLabel3.TextFormatString = "{0:C}"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryName"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""144"" />"
			table1.Name = "ProductReports"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "ProductSales"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "ShippedDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Name = "ProductReports"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' calcYear
			' 
			Me.calcYear.DataMember = "ProductReports"
			Me.calcYear.Expression = "GetYear([ShippedDate])"
			Me.calcYear.Name = "calcYear"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShippedDate]")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(35F, 0F)
			Me.xrLabel2.Multiline = True
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrLabel2.TextFormatString = "{0:d}"
			' 
			' groupHeaderBand1
			' 
			Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("calcYear", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.groupHeaderBand1.HeightF = 43F
			Me.groupHeaderBand1.Name = "groupHeaderBand1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calcYear]")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10F, 10F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel1.Text = "xrLabel1"
			Me.xrLabel1.TextFormatString = "Year: {0}"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4})
			Me.ReportHeader.HeightF = 35.83333F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.xrLabel4.Font = New System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel4.Multiline = True
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(172.5F, 23F)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.Text = "xrLabel4"
			Me.xrLabel4.TextFormatString = "Product: {0}"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRunningSum([ProductSales])")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(219.1667F, 10F)
			Me.xrLabel5.Multiline = True
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(193.3333F, 23F)
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrLabel5.Summary = xrSummary1
			Me.xrLabel5.Text = "xrLabel5"
			Me.xrLabel5.TextFormatString = "Running Total Sales: {0:C}"
			' 
			' groupFooterBand1
			' 
			Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5})
			Me.groupFooterBand1.HeightF = 36.49999F
			Me.groupFooterBand1.Name = "groupFooterBand1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail, Me.groupHeaderBand1, Me.ReportHeader, Me.groupFooterBand1})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calcYear})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "ProductReports"
			Me.DataSource = Me.sqlDataSource1
			Me.FilterString = "[ProductName] = 'Tofu'"
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Version = "21.2"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private calcYear As DevExpress.XtraReports.UI.CalculatedField
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
	End Class
End Namespace
