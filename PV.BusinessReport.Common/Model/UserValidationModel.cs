using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Model
{
    public class UserValidationModel
    {
        public String LoginName { get; set; }
        public String Password { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
