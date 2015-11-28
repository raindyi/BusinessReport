using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using log4net;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;

namespace PV.BusinessReport.Core.Lib
{
    public class DetailReportAction
    {
        private ILog _log = LogManager.GetLogger(typeof (DetailReportAction));
        private const String TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
        public DetailReportAction()
        {

        }

        public DataTable Query(DetailReportQueryModel model)
        {
            String sql =
                "SELECT B.ID, B.SN, B.RUNNINGNO, B.EXCTIME, B.EXCSOURCE, B.NETPAY,B.PAYABLE, B.HANDLING, B.STATUE, B.BANKRUNNINGNO FROM `BUSINESS_TRANSFLOW` B ";
            if (model.StoreId != null && model.StoreId!=Guid.Empty.ToString())
            {
                sql += String.Format(
                    " INNER JOIN `BPSYS_STORESN` N ON B.`SN`= N.`CODE` " +
                    " INNER JOIN `BPSYS_STORE` S ON S.`ID`= N.`STOREID` " +
                    " WHERE 1=1 AND S.`ID`= '{0}' ", model.StoreId);
                if (!String.IsNullOrEmpty(model.SN))
                {
                    sql += String.Format(" AND N.CODE='{0}'", model.SN);
                }
            }
            else
            {
                sql += " WHERE 1=1 ";
            }
            if (!String.IsNullOrEmpty(model.Source))
            {
                sql += String.Format(" AND B.EXCSOURCE='{0}'", model.Source);
            }
            if (model.StartTime.HasValue && model.FinishTime.HasValue)
            {
                sql += String.Format(" AND B.EXCTIME BETWEEN '{0}' AND '{1}' ",
                    model.StartTime.Value.ToString(TIME_FORMAT), model.FinishTime.Value.ToString(TIME_FORMAT));
            }
            DataTable dt = new DataTable();
            using (DataBaseProcess process=new DataBaseProcess())
            {
                dt = process.Query(sql);
            }
            
            return dt;
        }
    }
}
