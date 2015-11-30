using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Model
{
    public class SnModel
    {
        public Guid Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Guid StoreId { get; set; }
    }
}
