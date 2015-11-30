using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPV.BusinessReport.Common.Helper;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class UserListForm : Form
    {
        private UserAction _action = new UserAction();
        public UserListForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitControl();
            InitData();
        }

        private void InitControl()
        {
            splitContainerBottom.Panel1.Height = 1;
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
                comboBoxStore.DataSource = dtstore;
                comboBoxStore.DisplayMember = "Name";
            }
        }

        private void LoadData()
        {
            UserQueryModel model=new UserQueryModel();
            model.Name = textBoxQName.Text.TrimStart().TrimEnd();
            model.Phone = textBoxQPhone.Text.TrimStart().TrimEnd();
            if (comboBoxStore.SelectedValue != null)
            {
                DataRow dr = ((System.Data.DataRowView)comboBoxStore.SelectedValue).Row;
                model.Store = Guid.Parse(dr["ID"].ToString());
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
                DataRow dr = ((System.Data.DataRowView) comboBoxStore.SelectedValue).Row;
                model.StoreId = Guid.Parse(dr["ID"].ToString());
            }
            if (String.IsNullOrEmpty(model.LoginName))
            {
                result.Message = "请录入登录名";
                result.Successed = false;
            }
            if (String.IsNullOrEmpty(model.Name))
            {
                result.Message = "请录入姓名";
                result.Successed = false;
            }
            if (String.IsNullOrEmpty(model.Password))
            {
                result.Message = "请录入登录密码";
                result.Successed = false;
            }
            else
            {
                model.Password = Md5Helper.GetMD5String(model.Password);
            }
            if (model.StoreId == null || model.StoreId == Guid.Empty)
            {
                result.Message = "请选择门店";
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
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxQStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxStore_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }
    }
}
