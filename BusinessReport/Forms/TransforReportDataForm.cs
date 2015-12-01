using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.Core.Lib;

namespace PV.BusinessReport.UI.Forms
{
    public partial class TransforReportDataForm : Form
    {
        private const String TIME_FORMAT = "yyyy年MM月dd日 HH时:mm分:ss秒";
        public TransforReportDataForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitControl();
        }

        private void InitControl()
        {
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = TIME_FORMAT;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerFinish.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinish.CustomFormat = TIME_FORMAT;
            dateTimePickerStart.Value = DateTime.Now.AddDays(-1);
        }

        private void TransforReportDataForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Clear()
        {
            //TODO button enable
            ReportClearModel model = new ReportClearModel();
            model.StartTime = dateTimePickerStart.Value;
            model.FinishTime = dateTimePickerFinish.Value;
            model.SN = textBoxSN.Text.TrimStart().TrimEnd();
            model.SNName= textBoxSNName.Text.TrimStart().TrimEnd();
            model.Source = comboBoxSource.SelectedText;
            model.StoreId = comboBoxStore.SelectedIndex >= 0
                ? Guid.Parse(comboBoxStore.SelectedValue.ToString())
                : Guid.Empty;
            ReportClearAction action=new ReportClearAction();
            HandlingResult result = action.Clear(model);
            //TODO message
        }

        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Thread thread=new Thread(new ThreadStart(Clear));
            thread.Start();
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
