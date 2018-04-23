namespace WindowsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.nwindDataSet1 = new WindowsApplication2.nwindDataSet1();
            this.ordersTableAdapter1 = new WindowsApplication2.nwindDataSet1TableAdapters.OrdersTableAdapter();
            this.colCustomerID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEmployeeID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colOrderDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRequiredDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFreight = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCustomerID,
            this.colEmployeeID,
            this.colOrderDate,
            this.colRequiredDate,
            this.colFreight});
            this.treeList1.DataSource = this.ordersBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeList1.KeyFieldName = "OrderID";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "OrderID";
            this.treeList1.Size = new System.Drawing.Size(768, 381);
            this.treeList1.TabIndex = 0;
            this.treeList1.ToolTipController = this.toolTipController1;
            this.treeList1.TopVisibleNodeIndexChanged += new System.EventHandler(this.treeList1_TopVisibleNodeIndexChanged);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.nwindDataSet1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet1";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "CustomerID";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            this.colCustomerID.Width = 47;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 1;
            this.colEmployeeID.Width = 47;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "OrderDate";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Format.FormatString = "d";
            this.colOrderDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            this.colOrderDate.Width = 47;
            // 
            // colRequiredDate
            // 
            this.colRequiredDate.Caption = "RequiredDate";
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.Format.FormatString = "d";
            this.colRequiredDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRequiredDate.Name = "colRequiredDate";
            this.colRequiredDate.Visible = true;
            this.colRequiredDate.VisibleIndex = 3;
            this.colRequiredDate.Width = 47;
            // 
            // colFreight
            // 
            this.colFreight.Caption = "Freight";
            this.colFreight.FieldName = "Freight";
            this.colFreight.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 4;
            this.colFreight.Width = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 467);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.toolTipController1.SetSuperTip(this, null);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmployeeID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colOrderDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRequiredDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFreight;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private nwindDataSet1 nwindDataSet1;
        private WindowsApplication2.nwindDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
    }
}

