using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.PL.Context;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class PwChangeForm : Form
    {
        public PwChangeForm()
        {
            InitializeComponent();
        }

        private void ChangePassWord()
        {
            String pw1 = textBoxPw1.Text;
            String pw2 = textBoxPw2.Text;
            if (String.IsNullOrEmpty(pw1))
            {
                labelMessage.Text = "请输入密码";
            }
            else
            {
                if (String.IsNullOrEmpty(pw2))
                {
                    labelMessage.Text = "请输入确认密码";
                }
                else
                {
                    if (!pw1.Equals(pw2))
                    {
                        labelMessage.Text = "两次输入的密码不一致";
                    }
                    else
                    {
                        UserAction action=new UserAction();
                        action.ChangePassword(UserInformationContext.ID,pw1);
                        MessageHelper.ShowInformationNotify(this,"密码修改完成");
                        Close();
                    }
                }
            }

        }
        private void Init()
        {
            labelMessage.ForeColor = Color.Red;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ChangePassWord();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PwChangeForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
