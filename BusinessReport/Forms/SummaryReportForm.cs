using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.Core.Lib;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Helper;

namespace PV.BusinessReport.UI.Forms
{
    public partial class SummaryReportForm : Form
    {
        private const String TIME_FORMAT = "yyyy年MM月dd日 HH时:mm分:ss秒";
        private const String TIME_FORMATSTART = "yyyy-MM-dd 00:00:00";
        private const String TIME_FORMATFINISH = "yyyy-MM-dd 23:59:59";
        private Dictionary<String, Int32> _defineTimeDic = new Dictionary<string, int>()
        {
            { "今天",0},
            { "近一周",7},
            { "近一月",30},
            { "近半年",180},
            { "近一年",365}
        };

        private SummaryReportQueryModel _queryModel=new SummaryReportQueryModel();
        public SummaryReportForm()
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
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = TIME_FORMAT;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerFinish.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinish.CustomFormat = TIME_FORMAT;
            dateTimePickerStart.Value = DateTime.Now.AddDays(-1);
            dataGridViewList.AllowUserToAddRows = false;
            comboBoxTime.DropDownStyle=ComboBoxStyle.DropDown;
        }

        private void InitData()
        {
            comboBoxTime.Items.AddRange(_defineTimeDic.Keys.ToArray<Object>());
        }
        
        private void InitControlAfterData()
        {
            radioButtonCustomer.CheckedChanged += RadioButtonCustomer_CheckedChanged;
            radioButtonDefine.CheckedChanged += RadioButtonDefine_CheckedChanged;
        }

        private void SetTimeCondition(Boolean condition)
        {
            dateTimePickerStart.Enabled = condition;
            dateTimePickerFinish.Enabled = condition;
            comboBoxTime.Enabled = !condition;
        }

        private void RadioButtonDefine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDefine.Checked)
            {
                radioButtonCustomer.Checked = false;
                SetTimeCondition(false);
            }
            else
            {
                SetTimeCondition(true);
            }
        }

        private void RadioButtonCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomer.Checked)
            {
                radioButtonDefine.Checked = false;
                SetTimeCondition(true);
            }
            else
            {
                SetTimeCondition(false);
            }
        }

        private void SummaryReportForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Query()
        {
            SumaryReportAction action=new SumaryReportAction();
            
            DataTable dt = action.Query(_queryModel);

            Int32 rptype=checkBoxReportType.Checked?(String.IsNullOrEmpty(_queryModel.SN)?3:2):1;
            SetListInvork(dt,rptype);
        }

        private void SetListInvork(DataTable dt,Int32 listType)
        {
            if (dataGridViewList.InvokeRequired)
            {
                dataGridViewList.Invoke((MethodInvoker) (() =>
                {
                    SetList(dt, listType);
                }));
            }
            else
            {
                SetList(dt,listType);
            }
        }

        private void SetList(DataTable source, Int32 listType)
        {
            dataGridViewList.DataSource = null;
            dataGridViewList.Columns.Clear();
            if (listType == 1)
            {
                DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.SNDetailReportSettings);
            }
            else if (listType == 2)
            {
                DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.SNSummaryReport_NOSNSettings);
            }
            else if (listType == 3)
            {
                DataGridViewHelper.SetDataGridViewHead(dataGridViewList, DataViewGridColumnsConfig.SNSummaryReport_SNSettings);
            }
            if (source != null)
            {
                dataGridViewList.DataSource = source;
            }
        }

        private void GetQueryCondition()
        {
            _queryModel = new SummaryReportQueryModel();
            _queryModel.SN = textBoxSN.Text.Trim();
            _queryModel.ReportType = checkBoxReportType.Checked ? 2 : 1;
            if (radioButtonCustomer.Checked)
            {
                _queryModel.StartTime = dateTimePickerStart.Value;
                _queryModel.FinishTime = dateTimePickerFinish.Value;
            }
            if (radioButtonDefine.Checked)
            {
                _queryModel.FinishTime = DateTime.Parse(DateTime.Now.ToString(TIME_FORMATFINISH));
                Int32 addday = 0;
                if (_defineTimeDic.ContainsKey(comboBoxTime.Text))
                {
                    addday = _defineTimeDic[comboBoxTime.Text];
                }
                _queryModel.StartTime = DateTime.Parse(DateTime.Now.AddDays(0 - addday).ToString(TIME_FORMATSTART));
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            GetQueryCondition();
            Thread t = new Thread(new ThreadStart(Query));
            t.Start();
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
