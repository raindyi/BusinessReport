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
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class StoreModifyForm : Form
    {
        public StoreModel Store { get; set; }
        public StoreModifyForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitData();
        }

        private void InitData()
        {
            if (Store != null)
            {
                textBoxName.Text = Store.Name;
                textBoxPhone.Text = Store.Phone;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }

        private HandlingResult Validate()
        {
            HandlingResult result = new HandlingResult();
            StoreModel model = new StoreModel();
            model.Name = textBoxName.Text.Trim();
            model.Phone = textBoxPhone.Text.Trim();
            model.Id = Store.Id;
            if (String.IsNullOrEmpty(model.Name))
            {
                result.Message += "请填写门店名称\r\n";
            }
            //if (String.IsNullOrEmpty(model.Phone))
            //{
            //    result.Message += "请填写门店电话\r\n";
            //}
            result.Successed = result.Message.Length == 0;
            result.Result = model;
            return result;
        }

        private void Save()
        {
            HandlingResult result = Validate();
            if (result.Successed)
            {
                StoreModel model = (StoreModel)result.Result;
                StoreAction action = new StoreAction();
                result = action.Update(model);
                if (result.Successed)
                {
                    MessageHelper.ShowInformationNotify(this, result.Message);
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageHelper.ShowErrorNotify(this, result.Message);
                }
            }
            else
            {
                MessageHelper.ShowWarningNotify(this, result.Message);
            }
        }

        private void StoreModifyForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
