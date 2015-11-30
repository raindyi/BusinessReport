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
    public partial class DataDicListForm : Form
    {
        private DataDicAction _action=new DataDicAction();
        public DataDicListForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitData();
            LoadData();
        }

        private void InitData()
        {
            DataTable dt= _action.GetDicList();
            if (dt != null && dt.Rows.Count > 0)
            {
                comboBoxMainType.DataSource = dt;
                comboBoxMainType.DisplayMember = "Code";
            }
        }

        private void LoadData()
        {
            DataTable dt= _action.GetList();
            if (dt != null)
            {
                if (dataGridViewList.Columns.Count == 0)
                {
                    DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.DataDicSettings);
                }
                dataGridViewList.DataSource = dt;
            }
        }

        private void Add()
        {
            HandlingResult result = ValidateBeforeSave();
            if (result.Successed)
            {
                DataDicDetailModel model = (DataDicDetailModel)result.Result;
                result= _action.Add(model);
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

        private HandlingResult ValidateBeforeSave()
        {
            HandlingResult result = new HandlingResult();
            result.Successed = true;
            DataDicDetailModel model = new DataDicDetailModel();
            model.Code = textBoxSubName.Text.TrimStart().TrimEnd();
            if (comboBoxMainType.SelectedValue != null)
            {
                DataRow dr = ((System.Data.DataRowView)comboBoxMainType.SelectedValue).Row;
                model.Source = Guid.Parse(dr["ID"].ToString());
            }
            if (String.IsNullOrEmpty(model.Code))
            {
                result.Message = "请录入名称";
                result.Successed = false;
            }
            if (model.Source == null || model.Source == Guid.Empty)
            {
                result.Message = "请选择类别";
                result.Successed = false;
            }
            model.Id = Guid.NewGuid();
            result.Result = model;
            return result;
        }

        private void DataDicListForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void comboBoxMainType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
