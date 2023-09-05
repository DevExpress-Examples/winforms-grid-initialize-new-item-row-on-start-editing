Namespace ImmediateInitRow

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.bindingSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(618, 370)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataMember = "Table1"
            Me.bindingSource1.DataSource = Me.dataSet1
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
            Me.dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.AutoIncrement = True
            Me.dataColumn1.ColumnName = "ID"
            Me.dataColumn1.DataType = GetType(Integer)
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Name"
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.Caption = "Date"
            Me.dataColumn3.ColumnName = "Date"
            Me.dataColumn3.DataType = GetType(System.DateTime)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colName, Me.colDate})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.gridView1.OptionsView.ShowGroupPanel = False
            AddHandler Me.gridView1.InitNewRow, New DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(AddressOf Me.gridView1_InitNewRow)
            AddHandler Me.gridView1.ShownEditor, New System.EventHandler(AddressOf Me.gridView1_ShownEditor)
            ' 
            ' colID
            ' 
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colName
            ' 
            Me.colName.Caption = "Name"
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            ' 
            ' colDate
            ' 
            Me.colDate.Caption = "Date"
            Me.colDate.FieldName = "Date"
            Me.colDate.Name = "colDate"
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(618, 370)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "ImmediateInitRow"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private bindingSource1 As System.Windows.Forms.BindingSource

        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colID As DevExpress.XtraGrid.Columns.GridColumn

        Private colName As DevExpress.XtraGrid.Columns.GridColumn

        Private colDate As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
