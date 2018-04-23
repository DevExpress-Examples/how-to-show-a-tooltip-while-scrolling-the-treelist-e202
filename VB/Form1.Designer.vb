Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication2
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.nwindDataSet1 = New WindowsApplication2.nwindDataSet1()
			Me.ordersTableAdapter1 = New WindowsApplication2.nwindDataSet1TableAdapters.OrdersTableAdapter()
			Me.colCustomerID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colEmployeeID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colOrderDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colRequiredDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colFreight = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colFreight})
			Me.treeList1.DataSource = Me.ordersBindingSource
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Top
			Me.treeList1.KeyFieldName = "OrderID"
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.ParentFieldName = "OrderID"
			Me.treeList1.Size = New System.Drawing.Size(768, 381)
			Me.treeList1.TabIndex = 0
			Me.treeList1.ToolTipController = Me.toolTipController1
'			Me.treeList1.TopVisibleNodeIndexChanged += New System.EventHandler(Me.treeList1_TopVisibleNodeIndexChanged);
'			Me.treeList1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.treeList1_MouseDown);
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSet1
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.GetActiveObjectInfo += New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(Me.toolTipController1_GetActiveObjectInfo);
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet1"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersTableAdapter1
			' 
			Me.ordersTableAdapter1.ClearBeforeFill = True
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			Me.colCustomerID.Width = 47
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.Caption = "EmployeeID"
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Visible = True
			Me.colEmployeeID.VisibleIndex = 1
			Me.colEmployeeID.Width = 47
			' 
			' colOrderDate
			' 
			Me.colOrderDate.Caption = "OrderDate"
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Format.FormatString = "d"
			Me.colOrderDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 2
			Me.colOrderDate.Width = 47
			' 
			' colRequiredDate
			' 
			Me.colRequiredDate.Caption = "RequiredDate"
			Me.colRequiredDate.FieldName = "RequiredDate"
			Me.colRequiredDate.Format.FormatString = "d"
			Me.colRequiredDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.colRequiredDate.Name = "colRequiredDate"
			Me.colRequiredDate.Visible = True
			Me.colRequiredDate.VisibleIndex = 3
			Me.colRequiredDate.Width = 47
			' 
			' colFreight
			' 
			Me.colFreight.Caption = "Freight"
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Visible = True
			Me.colFreight.VisibleIndex = 4
			Me.colFreight.Width = 47
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(768, 467)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.toolTipController1.SetSuperTip(Me, Nothing)
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private colCustomerID As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colEmployeeID As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colOrderDate As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colRequiredDate As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colFreight As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
		Private nwindDataSet1 As nwindDataSet1
		Private ordersTableAdapter1 As WindowsApplication2.nwindDataSet1TableAdapters.OrdersTableAdapter
	End Class
End Namespace

