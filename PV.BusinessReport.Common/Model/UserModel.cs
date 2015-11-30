using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Model
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public String LoginName { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public Guid StoreId { get; set; }
        public String Phone { get; set; }
    }
}
