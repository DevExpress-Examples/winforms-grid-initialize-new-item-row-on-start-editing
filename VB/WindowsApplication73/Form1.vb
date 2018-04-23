Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace ImmediateInitRow
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridView1.InitNewRow

			 Dim view As GridView = TryCast(sender, GridView)
			 view.SetRowCellValue(e.RowHandle, view.Columns("Name"), "Noname")
			 view.SetRowCellValue(e.RowHandle, view.Columns("Date"), DateTime.Today)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ShownEditor
			Dim view As GridView = TryCast(sender, GridView)
			If view.IsNewItemRow(view.FocusedRowHandle) AndAlso view.FocusedColumn.FieldName <> "ID" Then
				view.ActiveEditor.IsModified = True
			End If
		End Sub
	End Class
End Namespace