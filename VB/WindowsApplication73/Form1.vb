Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace ImmediateInitRow

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            view.SetRowCellValue(e.RowHandle, view.Columns("Name"), "Noname")
            view.SetRowCellValue(e.RowHandle, view.Columns("Date"), Date.Today)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If view.IsNewItemRow(view.FocusedRowHandle) AndAlso Not Equals(view.FocusedColumn.FieldName, "ID") Then view.ActiveEditor.IsModified = True
        End Sub
    End Class
End Namespace
