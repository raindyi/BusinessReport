using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using log4net;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class SNForm : Form
    {
        private ILog _log = LogManager.GetLogger(typeof(SNForm));
        public Guid StoreId { get; set; }

        private SnModel _selSN=new SnModel();
        public SNForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitControl();
            LoadData();
        }

        private void InitControl()
        {
            dataGridViewList.AllowUserToAddRows = false;
        }

        private void LoadData()
        {
            _selSN.StoreId = StoreId;
            SNAction action=new SNAction();
            DataTable dt= action.QueryByStore(StoreId);
            SetListInvoke(dt);
        }
        private void SetListInvoke(DataTable source)
        {
            if (dataGridViewList.InvokeRequired)
            {
                dataGridViewList.Invoke((MethodInvoker)(() =>
                {
                    SetList(source);
                }));
            }
            else
            {
                SetList(source);
            }
        }

        private void SetList(DataTable source)
        {
            if (dataGridViewList.Columns.Count == 0)
            {
                DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.SNSettings);
            }
            dataGridViewList.DataSource = source;
        }

        private HandlingResult Validate()
        {
            HandlingResult result = new HandlingResult();
            _selSN.Name = textBoxName.Text.Trim();
            _selSN.Code = textBoxSN.Text.Trim();
            if (String.IsNullOrEmpty(_selSN.Name))
            {
                result.Message += "请填写别名\r\n";
            }
            if (String.IsNullOrEmpty(_selSN.Code))
            {
                result.Message += "请填写SN\r\n";
            }
            result.Successed = result.Message.Length == 0;
            return result;
        }

        private void Save()
        {
            HandlingResult result = Validate();
            if (result.Successed)
            {
                SNAction action = new SNAction();
                result= action.Update(_selSN);
                if (result.Successed)
                {
                    MessageHelper.ShowInformationNotify(this,result.Message);
                    LoadData();
                }
                else
                {
                    MessageHelper.ShowErrorNotify(this, result.Message);
                }
            }
            else
            {
                MessageHelper.ShowWarningNotify(this,result.Message);
            }
        }

        private void SNForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataRowView drv =(DataRowView)dataGridViewList.CurrentRow.DataBoundItem;
                DataRow dr = drv.Row;
                _selSN.Id = Guid.Parse(dr["ID"].ToString());
                _selSN.Name = dr["Name"].ToString();
                _selSN.Code = dr["Code"].ToString();
                textBoxName.Text = _selSN.Name;
                textBoxSN.Text = _selSN.Code;
            }
            catch (Exception ex)
            {
                _log.Error("选择SN数据",ex);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
