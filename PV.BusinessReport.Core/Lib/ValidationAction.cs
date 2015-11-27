using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using PV.BusinessReport.Common.Model;

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
            UserInformationModel usermodel = new UserInformationModel()
            {
                Id = Guid.NewGuid(),
                LoginName = "admin",
                Name = "administrator"
            };
            result.Result = usermodel;
            return result;
        }

        public HandlingResult ValidateLiceity()
        {
            HandlingResult result = new HandlingResult();
            return result;
        }
    }
}
