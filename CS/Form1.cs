using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using System.Reflection;
using DevExpress.XtraTreeList.Scrolling;
using DevExpress.Utils;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.nwindDataSet1.Orders);
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
                e.Info = new DevExpress.Utils.ToolTipControlInfo(treeList1.TopVisibleNodeIndex, treeList1.TopVisibleNodeIndex.ToString(), true, DevExpress.Utils.ToolTipIconType.None); 
        }

        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeListHitInfo hi = ((TreeList)sender).CalcHitInfo(new Point(e.X, e.Y));
        }

        private void treeList1_TopVisibleNodeIndexChanged(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                string toolTip = "Node " + ((TreeList)sender).TopVisibleNodeIndex.ToString() + " of " + ((TreeList)sender).VisibleNodesCount.ToString();
                ToolTipControlInfo info = new ToolTipControlInfo(treeList1.TopVisibleNodeIndex, toolTip, true, DevExpress.Utils.ToolTipIconType.None);
                toolTipController1.ShowHint(info);
            }
        }
    }
}