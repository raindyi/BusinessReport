using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Model
{
    public class SummaryReportQueryModel
    {
        public String SN { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        /// <summary>
        /// 1 明细 2汇总
        /// </summary>
        public Int32 ReportType { get; set; }
    }
}
