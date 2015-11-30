using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Model
{
    public class UserInformationModel
    {
        public Guid Id { get; set; }
        public String LoginName { get; set; }
        public String Name { get; set; }
        public String StoreId { get; set; }
    }
}
