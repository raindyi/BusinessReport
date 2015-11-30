using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;
using PV.BusinessReport.PL.Context;

namespace PV.BusinessReport.Core.Lib
{
     public class SNAction
    {
         public SNAction()
         {
         }

        public DataTable QueryByStore(Guid storeId)
        {
            String sql =String.Format("SELECT CODE,NAME FROM BPSYS_STORESN WHERE STOREID='{0}'",storeId);
            DataTable dt = null;
            using (DataBaseProcess process=new DataBaseProcess())
            {
                dt = process.Query(sql);
            }
            return dt;
        }

         public HandlingResult Add(SnModel model)
         {
            HandlingResult result = new HandlingResult();
            String sql =
                "INSERT INTO BPSYS_STORESN(ID, StoreID, Name, Code, Status, Creator, CreatorID, CreatedTime) VALUES ({0}, {1}, '{2}', '{3}', {4}, '{5}', {6}, '{7}')";
             sql = String.Format(sql, model.Id, model.StoreId, model.Name, model.Code, 1,
                 UserInformationContext.LoginName,
                 UserInformationContext.ID, DateTime.Now.ToString(ConfigImformationContext.TIME_FORMAT_FULL));
            using (DataBaseProcess process = new DataBaseProcess())
            {
                result.MsgNumber = process.Exec(sql);
            }
            result.Successed = result.MsgNumber > 0;
            result.Message = result.Successed ? "新增成功" : "新增失败";
            return result;
        }
    }
}
