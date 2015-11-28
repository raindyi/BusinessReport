using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Model
{
    public class DetailReportQueryModel
    {
        public String SN { get; set; }
        public String Source { get; set; }
        public String StoreId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? FinishTime { get; set; }
    }
}
