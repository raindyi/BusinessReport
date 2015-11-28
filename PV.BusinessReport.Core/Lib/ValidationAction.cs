using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using log4net;
using NPV.BusinessReport.Common.Helper;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;

namespace PV.BusinessReport.Core.Lib
{
    public class ValidationAction
    {
        private ILog _log = LogManager.GetLogger(typeof(ValidationAction));

        public ValidationAction()
        {
        }

        public HandlingResult ValidateLogin(UserValidationModel model)
        {
            HandlingResult result=new HandlingResult();
            result.Successed = false;
            DataTable dt = null;
            String sql = String.Format("SELECT * FROM BPSYS_USER WHERE LOGINNAME='{0}'", model.LoginName);
            using (DataBaseProcess process = new DataBaseProcess())
            {
                dt = process.Query(sql);
            }
            if (dt != null && dt.Rows.Count > 0)
            {
                UserInformationModel usermodel = new UserInformationModel()
                {
                    Id = Guid.Parse(dt.Rows[0]["ID"].ToString()),
                    LoginName = dt.Rows[0]["LOGINNAME"].ToString(),
                    Name = dt.Rows[0]["NAME"].ToString(),
                };
                String pw = Md5Helper.GetMD5String(model.Password);
                if (pw.Equals(dt.Rows[0]["PASSWORD"].ToString()))
                {
                    result.Result = usermodel;
                    result.Successed = true;
                }
                else
                {
                    result.Message = "用户名或密码错误!";
                }
            }
            else
            {
                result.Message = "用户名或密码错误";
            }
            return result;
        }

        public HandlingResult ValidateLiceity()
        {
            HandlingResult result = new HandlingResult();

            return result;
        }
    }
}
