using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.UI.Model
{
    public class MenuConfigModel
    {
        public String OperateFormName { get; set; }
        public String OperateFormFullName { get; set; }

        private Boolean _dialogModel = false;
        public Boolean DialogModel
        {
            get { return _dialogModel; }
            set { _dialogModel = value; }
        }
    }
}
