using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPV.BusinessReport.Common.Helper;
using PV.BusinessReport.DAL;

namespace PV.BusinessReport.Core.Lib
{
    public class UserAction
    {
        public UserAction()
        {

        }

        public void ChangePassword(Guid userId,String password)
        {
            String secpw = Md5Helper.GetMD5String(password);
            String sql = String.Format("update bpsys_user set password='{0}' where id='{1}'", secpw, userId);
            using (DataBaseProcess process = new DataBaseProcess())
            {
                process.Exec(sql);
            }
        }
    }
}
