using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;

namespace PV.BusinessReport.Core.Lib
{
    public class ReportClearAction
    {
        private const String TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
        public HandlingResult Clear(ReportClearModel model)
        {
            HandlingResult result=new HandlingResult();
            Boolean wherecluse = false;
//            SELECT F.*FROM BUSINESS_TRANSFLOW F
//INNER
//                      JOIN BPSYS_STORESN SN ON SN.CODE = F.RUNNINGNO
//                INNER
//                      JOIN BPSYS_STORE S ON S.ID = SN.STOREID
//WHERE F.EXCTIME BETWEEN '2015-11-30 17:00:00'  AND '2015-12-01 19:00:00'
//AND F.SN = '89'
//AND F.EXCSOURCE = '微信'
//AND SN.NAME = '子店1'
//AND S.ID = ''
            String delsql = " DELETE FROM BUSINESS_TRANSFLOW WHERE EXISTS ";
            String insertsql = " INSERT INTO BUSINESS_TRANSFLOWT ";
            String closql=" SELECT F.* FROM BUSINESS_TRANSFLOW F ";
            closql += " INNER JOIN BPSYS_STORESN SN ON SN.CODE = F.RUNNINGNO ";
            closql += " INNER JOIN BPSYS_STORE S ON S.ID = SN.STOREID ";
            closql += " WHERE 1=1 ";
            if (model.StoreId != null && model.StoreId != Guid.NewGuid())
            {
                closql += String.Format(" AND S.ID='{0}' ",model.StoreId);
            }
            
            if (model.StartTime.HasValue && model.FinishTime.HasValue)
            {
                closql += String.Format(" AND F.EXCTIME BETWEEN '{0}'  AND '{1}'",
                    model.StartTime.Value.ToString(TIME_FORMAT), model.FinishTime.Value.ToString(TIME_FORMAT));
            }
            if (!String.IsNullOrEmpty(model.SN))
            {
                closql += String.Format("  F.SN={0}",model.SN);
            }
            if (!String.IsNullOrEmpty(model.SNName))
            {
                closql += String.Format("  SN.NAME={0}", model.SNName);
            }
            if (!String.IsNullOrEmpty(model.Source))
            {
                closql += String.Format("  F.EXCSOURCE={0}", model.Source);
            }
            insertsql += closql;
            delsql += string.Format("(SELECT 1 FROM ( {0} ) T WHERE BUSINESS_TRANSFLOW.ID=T.ID)", closql);
            using (DataBaseProcess process=new DataBaseProcess())
            {
                result.MsgNumber= process.Exec(insertsql);
                result.MsgNumber=process.Exec(delsql);
            }
            result.Successed = result.MsgNumber > 0;
            return result;
        }
    }
}
