using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Model
{
    public class ReportClearModel
    {
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }

        public Guid StoreId { get; set; }
        public String SN { get; set; }

        public String SNName { get; set; }

        public String Source { get; set; }
    }
}
