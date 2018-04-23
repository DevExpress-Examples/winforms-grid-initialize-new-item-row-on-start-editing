using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace ImmediateInitRow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

             GridView view = sender as GridView;
             view.SetRowCellValue(e.RowHandle, view.Columns["Name"], "Noname");
             view.SetRowCellValue(e.RowHandle, view.Columns["Date"], DateTime.Today);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsNewItemRow(view.FocusedRowHandle) && view.FocusedColumn.FieldName != "ID")
                view.ActiveEditor.IsModified = true;
        }
    }
}