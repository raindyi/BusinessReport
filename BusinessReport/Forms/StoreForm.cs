using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PV.BusinessReport.Common.Model;
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


        private void AddStore()
        {
            HandlingResult result = ValidateStoreSave();
            if (result.Successed)
            {
                StoreModel model = (StoreModel) result.Result;
                result = _action.Add(model);
                if (result.Successed)
                {
                    MessageHelper.ShowErrorNotify(this, result.Message);
                }
                else
                {
                    MessageHelper.ShowErrorNotify(this, result.Message);
                }
            }
            else
            {
                MessageHelper.ShowErrorNotify(this,result.Message);
            }
        }

        private HandlingResult ValidateStoreSave()
        {
            HandlingResult result=new HandlingResult();
            return result;
        }

        private void AddSN()
        {
            HandlingResult result = ValidateSNSave();
            if (result.Successed)
            {
                SnModel model = (SnModel)result.Result;
                SNAction action=new SNAction();
                result = action.Add(model);
                if (result.Successed)
                {
                    MessageHelper.ShowErrorNotify(this, result.Message);
                }
                else
                {
                    MessageHelper.ShowErrorNotify(this, result.Message);
                }
            }
            else
            {
                MessageHelper.ShowErrorNotify(this, result.Message);
            }
        }

        private HandlingResult ValidateSNSave()
        {
            HandlingResult result = new HandlingResult();
            return result;
        }

        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            AddStore();
        }

        private void buttonAddSN_Click(object sender, EventArgs e)
        {
            AddSN();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LodaData();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void dataGridViewList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
