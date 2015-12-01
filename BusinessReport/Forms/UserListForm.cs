using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using NPV.BusinessReport.Common.Helper;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class UserListForm : Form
    {
        private ILog _log = LogManager.GetLogger(typeof(UserListForm));

        private UserAction _action = new UserAction();
        public UserListForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitControl();
            InitData();
            InitControlAfterData();
        }

        private void InitControl()
        {
            dataGridViewList.AllowUserToAddRows = false;
        }
        private void InitData()
        {
            StoreAction storeAction = new StoreAction();
            DataTable dtstore = storeAction.Query();
            if (dtstore != null && dtstore.Rows.Count > 0)
            {
                DataRow dr = dtstore.NewRow();
                dr["ID"] = Guid.Empty;
                dr["NAME"] = "---";
                dtstore.Rows.InsertAt(dr, 0);
                
                comboBoxStore.ValueMember = "ID";
                comboBoxStore.DisplayMember = "Name";
                comboBoxStore.DataSource = dtstore;
                
                comboBoxQStore.ValueMember = "ID";
                comboBoxQStore.DisplayMember = "Name";
                comboBoxQStore.DataSource = dtstore.Copy();
            }
        }

        private void InitControlAfterData()
        {
            comboBoxQStore.SelectedIndexChanged += comboBoxQStore_SelectedIndexChanged;
        }
        

        private void LoadData()
        {
            UserQueryModel model=new UserQueryModel();
            model.Name = textBoxQName.Text.TrimStart().TrimEnd();
            model.Phone = textBoxQPhone.Text.TrimStart().TrimEnd();
            if (comboBoxQStore.SelectedValue != null)
            {
                model.Store = Guid.Parse(comboBoxQStore.SelectedValue.ToString());
            }
            DataTable dt= _action.GetList(model);
            Bind(dt);
        }

        private void Bind(DataTable source)
        {
            if (source != null)
            {
                SetListInvoke(source);
            }
        }

        private HandlingResult ValidateBeforeSave()
        {
            HandlingResult result = new HandlingResult();
            result.Successed = true;
            UserModel model = new UserModel();
            model.Name = textBoxName.Text.TrimStart().TrimEnd();
            model.Phone = textBoxPhone.Text.TrimStart().TrimEnd();
            model.Password = textBoxPassword.Text;
            model.LoginName = textBoxLoginName.Text.TrimStart().TrimEnd();
            if (comboBoxStore.SelectedValue != null)
            {
                model.StoreId = Guid.Parse(comboBoxStore.SelectedValue.ToString());
            }
            if (String.IsNullOrEmpty(model.LoginName))
            {
                result.Message += "\r\n请录入登录名";
                result.Successed = false;
            }
            if (String.IsNullOrEmpty(model.Name))
            {
                result.Message += "\r\n请录入姓名";
                result.Successed = false;
            }
            if (String.IsNullOrEmpty(model.Password))
            {
                result.Message += "\r\n请录入登录密码";
                result.Successed = false;
            }
            else
            {
                model.Password = Md5Helper.GetMD5String(model.Password);
            }
            if (model.StoreId == null || model.StoreId == Guid.Empty)
            {
                result.Message += "\r\n请选择门店";
                result.Successed = false;
            }
            model.Id = Guid.NewGuid();
            result.Result = model;
            return result;
        }

        private void Add()
        {
            HandlingResult result = ValidateBeforeSave();
            if (result.Successed)
            {
                UserModel model = (UserModel) result.Result;
                _action=new UserAction();
                result= _action.Add(model);
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
                MessageHelper.ShowErrorNotify(this,result.Message);
            }
        }

        private void Modify()
        {
            HandlingResult result = ValidateBeforeSave();
            if (result.Successed)
            {
                UserModel model = (UserModel)result.Result;
                result = _action.Modify(model);
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

        private void Del(Guid userId)
        {
            HandlingResult result = ValidateBeforeSave();
            result = _action.Delete(userId);
            if (result.Successed)
            {
                MessageHelper.ShowErrorNotify(this, result.Message);
            }
            else
            {
                MessageHelper.ShowErrorNotify(this, result.Message);
            }
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
                DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.UserSettings);
            }
            dataGridViewList.DataSource = source;
        }

        #region ControlEvent
        private void UserListForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)dataGridViewList.CurrentRow.DataBoundItem;
                DataRow dr = drv.Row;
                textBoxLoginName.Text = dr["LoginName"].ToString();
                textBoxName.Text = dr["Name"].ToString();
                textBoxPassword.Text = dr["Password"].ToString(); ;
                textBoxPhone.Text = dr["Phone"].ToString();
                comboBoxStore.SelectedValue = dr["StoreId"];
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxQStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Modify();
        }

        private void dataGridViewList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //TODO del
            try
            {
                DataRowView drv = (DataRowView)dataGridViewList.CurrentRow.DataBoundItem;
                DataRow dr = drv.Row;
                DialogResult result= MessageBox.Show(String.Format("确认删除[{0}]?", dr["LoginName"]), "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _action=new UserAction();
                    _action.Delete(Guid.Parse(dr["ID"].ToString()));
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
    }
}
