using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class SNForm : Form
    {
        public Guid StoreId { get; set; }
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
        private void SNForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
