Imports Microsoft.VisualBasic
Imports System
Namespace RunningSum
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.nwindDataSet1 = New RunningSum.nwindDataSet()
			Me.productsTableAdapter = New RunningSum.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Height = 25
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'			Me.Detail.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.Detail_BeforePrint);
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder", "")})
			Me.xrLabel2.ForeColor = System.Drawing.Color.Black
			Me.xrLabel2.Location = New System.Drawing.Point(258, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(142, 25)
			Me.xrLabel2.StylePriority.UseForeColor = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
			Me.xrLabel1.ForeColor = System.Drawing.Color.Black
			Me.xrLabel1.Location = New System.Drawing.Point(33, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(217, 25)
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "xrLabel1"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6, Me.xrLabel3})
			Me.GroupFooter1.Height = 58
			Me.GroupFooter1.Name = "GroupFooter1"
'			Me.GroupFooter1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.GroupFooter1_BeforePrint);
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(236))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.xrLabel6.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(192))))))
			Me.xrLabel6.Location = New System.Drawing.Point(33, 8)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.Size = New System.Drawing.Size(217, 25)
			Me.xrLabel6.StylePriority.UseBackColor = False
			Me.xrLabel6.StylePriority.UseFont = False
			Me.xrLabel6.StylePriority.UseForeColor = False
			Me.xrLabel6.StylePriority.UseTextAlignment = False
			Me.xrLabel6.Text = "Running Total:"
			Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(236))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.xrLabel3.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(192))))))
			Me.xrLabel3.Location = New System.Drawing.Point(258, 8)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.Size = New System.Drawing.Size(175, 25)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseForeColor = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.Height = 11
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.GroupFooter1, Me.GroupHeader1})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.FilterString = "[UnitsOnOrder] <> 0"
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.Version = "8.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As RunningSum.nwindDataSetTableAdapters.ProductsTableAdapter
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
	End Class
End Namespace
