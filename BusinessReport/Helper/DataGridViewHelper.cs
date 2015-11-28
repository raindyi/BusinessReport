using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PV.BusinessReport.UI.Model;

namespace PV.BusinessReport.UI.Helper
{
    public static class DataGridViewHelper
    {
        public static void SetDataGridViewHead(DataGridView gridView, Dictionary<String, GridColumnModel> configSettings)
        {
            foreach (String key in configSettings.Keys)
            {
                if (configSettings[key].DataType == typeof(String))
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    GridColumnModel model = configSettings[key];
                    col.DataPropertyName = model.Name;
                    col.Name = model.Name;
                    col.HeaderText = model.HeadName;
                    col.ReadOnly = !model.CanEdit;
                    col.Visible = model.Visible;
                    col.Width = model.Width;
                    gridView.Columns.Add(col);
                }
                else if (configSettings[key].DataType == typeof(Decimal))
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    GridColumnModel model = configSettings[key];
                    col.HeaderText = model.HeadName;
                    col.ReadOnly = !model.CanEdit;
                    col.Visible = model.Visible;
                    col.Width = model.Width;
                    gridView.Columns.Add(col);
                }
            }
        }
    }
}
