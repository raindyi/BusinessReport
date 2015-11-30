using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class StoreForm : Form
    {
        private StoreAction _action=new StoreAction();
        public StoreForm()
        {
            InitializeComponent();
        }
        private void Init()
        {
            LodaData();
        }

        private void LodaData()
        {
            DataTable dt= _action.Query();
            if (dt != null)
            {
                if (dataGridViewList.Columns.Count == 0)
                {
                    DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.StoreSettings);
                }
                dataGridViewList.DataSource = dt;
            }
        }

        private void buttonAddStore_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddSN_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void dataGridViewList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
