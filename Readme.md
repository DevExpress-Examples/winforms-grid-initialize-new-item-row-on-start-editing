<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630891/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1146)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Initialize a new row after the user activates the grid cell

This example handles the [InitNewRow](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.InitNewRow) event to initialize the New Item Row with default values. The GridView raises the `InitNewRow` event after the user has changed the value of a cell. The example also handles the [GridView.ShownEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.ShownEditor) event to force the `InitNewRow` event to fire after the user has clicked the "Item New Row" cell:

```csharp
private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
    GridView view = sender as GridView;
    view.SetRowCellValue(e.RowHandle, view.Columns["Name"], "Noname");
    view.SetRowCellValue(e.RowHandle, view.Columns["Date"], DateTime.Today);
}
private void gridView1_ShownEditor(object sender, EventArgs e) {
    GridView view = sender as GridView;
    if (view.IsNewItemRow(view.FocusedRowHandle) && view.FocusedColumn.FieldName != "ID")
        view.ActiveEditor.IsModified = true;
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication73/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication73/Form1.vb))


## Documentation

* [Add and Remove Rows](https://docs.devexpress.com/WindowsForms/752/controls-and-libraries/data-grid/data-editing-and-validation/add-and-remove-rows)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-initialize-new-item-row-on-start-editing&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-initialize-new-item-row-on-start-editing&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
