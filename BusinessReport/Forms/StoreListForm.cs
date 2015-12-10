using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class StoreListForm : Form
    {
        private StoreAction _action=new StoreAction();
        private ILog _log = LogManager.GetLogger(typeof (StoreListForm));
        private Guid _selStoreId = Guid.Empty;
        public StoreListForm()
        {
            InitializeComponent();
        }
        private void Init()
        {
            InitControl();
            LodaData();
        }
        private void InitControl()
        {
            dataGridViewList.AllowUserToAddRows = false;
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
                    MessageHelper.ShowInformationNotify(this, result.Message);
                    LodaData();
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

        private HandlingResult ValidateStoreSave()
        {
            HandlingResult result=new HandlingResult();
            StoreModel model=new StoreModel();
            model.Name = textBoxName.Text.TrimStart().TrimEnd();
            model.Phone = textBoxPhone.Text.TrimStart().TrimEnd();
            if (String.IsNullOrEmpty(model.Name))
            {
                result.Successed = false;
                result.Message = "请填写门店名称";
            }
            model.Id = Guid.NewGuid();
            result.Result = model;
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
                    MessageHelper.ShowInformationNotify(this, result.Message);
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
            SnModel model = new SnModel();
            model.Name = textBoxSnName.Text.TrimStart().TrimEnd();
            model.Code = textBoxSnCode.Text.TrimStart().TrimEnd();
            model.StoreId = _selStoreId;
            if (String.IsNullOrEmpty(model.Name))
            {
                result.Successed = false;
                result.Message += "\r\n请填写SN别名";
            }
            if (String.IsNullOrEmpty(model.Code))
            {
                result.Successed = false;
                result.Message += "\r\n请填写SN";
            }
            if (model.StoreId==null || model.StoreId.Equals(Guid.Empty))
            {
                result.Successed = false;
                result.Message += "\r\n请选择门店";
            }
            model.Id = Guid.NewGuid();
            result.Result = model;
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
            if (e.Button.Equals(MouseButtons.Left))
            {
                try
                {
                    DataRowView drv = (DataRowView)dataGridViewList.CurrentRow.DataBoundItem;
                    DataRow dr = drv.Row;
                    SNForm snForm = new SNForm();
                    snForm.StoreId = Guid.Parse(dr["ID"].ToString());
                    snForm.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    _log.Error("View Sn information error::", ex);
                }
            }
        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView) dataGridViewList.CurrentRow.DataBoundItem;
                DataRow dr = drv.Row;
                textBoxStoreName.Text = dr["Name"].ToString();
                Guid.TryParse(dr["ID"].ToString(), out _selStoreId);
            }
            catch (Exception ex)
            {
                _log.Error("View Sn information error::", ex);
            }
        }

        private void dataGridViewList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    try
                    {
                        DataRowView drv = (DataRowView) dataGridViewList.Rows[e.RowIndex].DataBoundItem;
                        DataRow dr = drv.Row;
                        StoreModifyForm form = new StoreModifyForm();
                        StoreModel model = new StoreModel();
                        model.Id = Guid.Parse(dr["ID"].ToString());
                        model.Name = dr["Name"].ToString();
                        model.Phone = dr["Phone"].ToString();
                        form.Store = model;
                        DialogResult result = form.ShowDialog(this);
                        if (result == DialogResult.Yes)
                        {
                            LodaData();
                        }
                    }
                    catch (Exception ex)
                    {
                        _log.Error("View Sn information error::", ex);
                    }
                }
            }
        }
    }
}
