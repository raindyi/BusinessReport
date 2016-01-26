using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using log4net;
using PV.BusinessReport.Common.Helper;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Helper;
using System.Threading;

namespace PV.BusinessReport.UI.Forms
{
    public partial class TransFlowImportForm : Form
    {
        private ILog _log = LogManager.GetLogger(typeof(TransFlowImportForm));
        private Boolean _busyState = false;
        public TransFlowImportForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            openFileDialogMain.Filter = "商户交易流水(*.xls)|*.xls";
        }

        private void TransFlowImportForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Import()
        {
            _busyState = true;
            try
            {
                if (File.Exists(openFileDialogMain.FileName))
                {
                    ExcelHelper helper = new ExcelHelper();
                    DataTable dt = helper.Read(openFileDialogMain.FileName);
                    //机器SN号	交易时间	交易流水号	交易来源	实付金额	应付金额	手续费	状态	银行流水单
                    BusinessTransFlowAction action = new BusinessTransFlowAction();
                    HandlingResult result = action.Import(dt);
                    if (result.Successed)
                    {
                        MessageHelper.ShowInformationNotify(this,result.Message);
                    }
                    else
                    {
                        MessageHelper.ShowErrorNotify(this, "导入失败,请检查文件格式");
                    }
                }
                else
                {
                    MessageHelper.ShowErrorNotify(this, "导入的文件不存在,请检查");
                }
            }
            catch (Exception ex)
            {
                _log.Error(String.Format("\r\n------------导入交易流水数据时出现错误,文件名::{0}\r\n", openFileDialogMain.FileName), ex);
            }
            _busyState = false;
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (!_busyState)
            {
                DialogResult result = openFileDialogMain.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    labelFileName.Text = openFileDialogMain.FileName;
                }
            }
            else
            {
                MessageHelper.ShowWarningNotify(this,"正在导入数据,请等待");
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (!_busyState)
            {
                Thread t = new Thread(Import);
                t.Start();
            }
            else
            {
                MessageHelper.ShowWarningNotify(this, "正在导入数据,请等待");
            }
        }

        private void TransFlowImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_busyState)
            {
                MessageHelper.ShowWarningNotify(this, "正在导入数据,请等待");
                e.Cancel = true;
            }
        }
    }
}
