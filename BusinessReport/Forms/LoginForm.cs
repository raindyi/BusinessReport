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
using PV.BusinessReport.PL.Context;

namespace PV.BusinessReport.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login()
        {
            UserValidationModel model=new UserValidationModel();
            model.LoginName = textBoxName.Text.TrimStart().TrimEnd();
            model.Password = textBoxPassWord.Text;
            if (String.IsNullOrEmpty(model.LoginName) || String.IsNullOrEmpty(model.Password))
            {
                labelMessage.Text = "请录入登录信息";
            }
            else
            {
                HandlingResult result = new HandlingResult();
                ValidationAction action = new ValidationAction();
                result = action.ValidateLogin(model);
                if (result.Successed)
                {
                    UserInformationModel user = (UserInformationModel)result.Result;
                    UserInformationContext.ID = user.Id;
                    UserInformationContext.Name = user.Name;
                    UserInformationContext.LoginName = user.LoginName;
                    UserInformationContext.LoginTime = DateTime.Now;
                    Close();
                }
                else
                {
                    labelMessage.Text = result.Message;
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
