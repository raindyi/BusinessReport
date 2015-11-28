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
    public partial class DetailReportForm : Form
    {
        private const String TIME_FORMAT = "yyyy年MM月dd日 HH时:mm分:ss秒";
        public DetailReportForm()
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
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = TIME_FORMAT;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerFinish.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinish.CustomFormat = TIME_FORMAT;
            dateTimePickerStart.Value = DateTime.Now.AddDays(-1);
            dataGridViewList.AllowUserToAddRows = false;
        }

        private void InitData()
        {
            StoreAction storeAction=new StoreAction();
            DataTable dtstore = storeAction.Query();
            if (dtstore != null && dtstore.Rows.Count > 0)
            {
                DataRow dr = dtstore.NewRow();
                dr["ID"] = Guid.Empty;
                dr["NAME"] = "---";
                dtstore.Rows.InsertAt(dr,0);
                comboBoxStore.DataSource = dtstore;
                comboBoxStore.DisplayMember = "Name";
                //comboBoxStore.ValueMember = "ID";
            }
        }

        private void Query()
        {
            DetailReportQueryModel model=new DetailReportQueryModel();
            model.StartTime = dateTimePickerStart.Value;
            model.FinishTime = dateTimePickerFinish.Value;
            model.SN = textBoxSN.Text.Trim();
            model.Source = comboBoxSource.SelectedText;
            if (comboBoxStore.SelectedValue != null)
            {
                DataRow dr =((System.Data.DataRowView)comboBoxStore.SelectedValue).Row;
                model.StoreId = dr["ID"].ToString();
            }
            DetailReportAction action=new DetailReportAction();
            DataTable dt= action.Query(model);
            Bind(dt);
        }

        private void Bind(DataTable source)
        {
            if (source != null )
            {
                SetListInvoke(source);
            }
        }

        private void SetListInvoke(DataTable source)
        {
            if (dataGridViewList.InvokeRequired)
            {
                dataGridViewList.Invoke((MethodInvoker) (() =>
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
            if (dataGridViewList.Columns.Count ==0)
            {
                DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.DeatilReportSettings);
            }
            dataGridViewList.DataSource = source;
        }


        private void buttonQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void comboBoxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query();
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query();
        }

        private void DetailReportForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFinish.MinDate = dateTimePickerStart.Value;
        }

        private void dateTimePickerFinish_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.MaxDate = dateTimePickerStart.Value;
        }
    }
}
