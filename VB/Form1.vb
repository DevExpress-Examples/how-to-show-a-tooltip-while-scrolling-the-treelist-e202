Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports System.Reflection
Imports DevExpress.XtraTreeList.Scrolling
Imports DevExpress.Utils

Namespace WindowsApplication2
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet1.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter1.Fill(Me.nwindDataSet1.Orders)
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
		End Sub

		Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
			If MouseButtons = MouseButtons.Left Then
				e.Info = New DevExpress.Utils.ToolTipControlInfo(treeList1.TopVisibleNodeIndex, treeList1.TopVisibleNodeIndex.ToString(), True, DevExpress.Utils.ToolTipIconType.None)
			End If
		End Sub

		Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList1.MouseDown
			Dim hi As TreeListHitInfo = (CType(sender, TreeList)).CalcHitInfo(New Point(e.X, e.Y))
		End Sub

		Private Sub treeList1_TopVisibleNodeIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles treeList1.TopVisibleNodeIndexChanged
			If MouseButtons = MouseButtons.Left Then
				Dim toolTip As String = "Node " & (CType(sender, TreeList)).TopVisibleNodeIndex.ToString() & " of " & (CType(sender, TreeList)).VisibleNodesCount.ToString()
				Dim info As New ToolTipControlInfo(treeList1.TopVisibleNodeIndex, toolTip, True, DevExpress.Utils.ToolTipIconType.None)
				toolTipController1.ShowHint(info)
			End If
		End Sub
	End Class
End Namespace