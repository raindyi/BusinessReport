using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;

namespace PV.BusinessReport.Core.Lib
{
    public class SumaryReportAction
    {
        private const String TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
        public SumaryReportAction()
        {
        }

        public HandlingResult Query(SummaryReportQueryModel queryModel)
        {
            HandlingResult result=new HandlingResult();
            //SELECT SUM(NETPAY)AS NETPAY, SUM(PAYABLE) AS NETPAY, SUM(HANDLING) AS NETPAY, EXCSOURCE
            //FROM   BUSINESS_TRANSFLOW
            //WHERE  SN = '' AND EXCTIME BETWEEN '' AND ''
            //GROUP  BY EXCSOURCE

            //SELECT EXCSOURCE, NETPAY, PAYABLE, HANDLING
            //FROM   BUSINESS_TRANSFLOW
            //WHERE  SN = '' AND EXCTIME BETWEEN '' AND ''

            //SELECT SUM(NETPAY) AS NETPAY, SUM(PAYABLE) AS NETPAY, SUM(HANDLING) AS NETPAY, EXCSOURCE, SN
            //FROM   BUSINESS_TRANSFLOW
            //WHERE  EXCTIME BETWEEN '' AND ''
            //GROUP  BY SN, EXCSOURCE
            StringBuilder cntsqlbuilder = new StringBuilder(" SELECT COUNT(1) AS CNT FROM BUSINESS_TRANSFLOW T ");

            cntsqlbuilder.Append(" INNER JOIN BPSYS_STORESN N ON T.SN=N.CODE ");
            cntsqlbuilder.Append(" INNER JOIN BPSYS_STORE S ON S.ID=N.STOREID ");
            cntsqlbuilder.Append(" WHERE 1=1 ");
            if (queryModel.StartTime.HasValue && queryModel.FinishTime.HasValue)
            {
                cntsqlbuilder.AppendFormat(" AND T.EXCTIME BETWEEN '{0}' AND '{1}' ",
                        queryModel.StartTime.Value.ToString(TIME_FORMAT),
                        queryModel.FinishTime.Value.ToString(TIME_FORMAT));
            }
            if (!String.IsNullOrEmpty(queryModel.SN))
            {
                cntsqlbuilder.AppendFormat(" AND T.SN='{0}' ", queryModel.SN);
            }
            else
            {
                if (!String.IsNullOrEmpty(queryModel.SNName))
                {
                    cntsqlbuilder.AppendFormat(" AND N.CODE='{0}' ",
                        queryModel.SNName);
                }
            }
            if (!String.IsNullOrEmpty(queryModel.Source))
            {
                cntsqlbuilder.AppendFormat("  AND T.EXCSOURCE='{0}' ", queryModel.Source);
            }

            StringBuilder sqlbulider=new StringBuilder();
            if (queryModel.ReportType == 1)
            {
                //明细
                sqlbulider.Append(" SELECT SN,STATUE,BANKRUNNINGNO,EXCTIME,EXCSOURCE, NETPAY, PAYABLE, HANDLING FROM   BUSINESS_TRANSFLOW T");
                sqlbulider.Append(" INNER JOIN BPSYS_STORESN N ON T.SN=N.CODE ");
                sqlbulider.Append(" INNER JOIN BPSYS_STORE S ON S.ID=N.STOREID ");
                sqlbulider.Append(" WHERE 1=1 ");
                if (!String.IsNullOrEmpty(queryModel.SN))
                {
                    sqlbulider.AppendFormat(" AND T.SN='{0}'", queryModel.SN);
                }
                else
                {
                    if (!String.IsNullOrEmpty(queryModel.SNName))
                    {
                        cntsqlbuilder.AppendFormat(" AND N.CODE='{0}' ", queryModel.SNName);
                    }
                }
                if (queryModel.StartTime.HasValue && queryModel.FinishTime.HasValue)
                {
                    sqlbulider.AppendFormat(" AND EXCTIME BETWEEN '{0}' AND '{1}'",
                        queryModel.StartTime.Value.ToString(TIME_FORMAT),
                        queryModel.FinishTime.Value.ToString(TIME_FORMAT));
                }
                if (!String.IsNullOrEmpty(queryModel.Source))
                {
                    cntsqlbuilder.AppendFormat("  AND EXCSOURCE='{0}'", queryModel.Source);
                }

            }
            else
            {
                //汇总
                if (String.IsNullOrEmpty(queryModel.SN))
                {
                    //所有SN汇总
                    sqlbulider.Append("SELECT SUM(NETPAY) AS NETPAY, SUM(PAYABLE) AS PAYABLE, SUM(HANDLING) AS HANDLING, EXCSOURCE, SN FROM   BUSINESS_TRANSFLOW T ");
                    sqlbulider.Append(" INNER JOIN BPSYS_STORESN N ON T.SN=N.CODE ");
                    sqlbulider.Append(" INNER JOIN BPSYS_STORE S ON S.ID=N.STOREID ");
                    sqlbulider.Append(" WHERE 1=1 ");
                    if (queryModel.StartTime.HasValue && queryModel.FinishTime.HasValue)
                    {
                        sqlbulider.AppendFormat(" AND T.EXCTIME BETWEEN '{0}' AND '{1}'",
                            queryModel.StartTime.Value.ToString(TIME_FORMAT),
                            queryModel.FinishTime.Value.ToString(TIME_FORMAT));
                    }
                    if (!String.IsNullOrEmpty(queryModel.SNName))
                    {
                        sqlbulider.AppendFormat(" AND N.CODE='{0}' ", queryModel.SNName);
                    }
                    if (!String.IsNullOrEmpty(queryModel.Source))
                    {
                        sqlbulider.AppendFormat("  AND T.EXCSOURCE='{0}'", queryModel.Source);
                    }
                    sqlbulider.Append(" GROUP  BY T.SN, T.EXCSOURCE");
                }
                else
                {
                    //单独SN汇总
                    sqlbulider.Append("SELECT SUM(NETPAY) AS NETPAY, SUM(PAYABLE) AS PAYABLE, SUM(HANDLING) AS HANDLING, EXCSOURCE FROM   BUSINESS_TRANSFLOW T ");
                    sqlbulider.Append(" INNER JOIN BPSYS_STORESN N ON T.SN=N.CODE ");
                    sqlbulider.Append(" INNER JOIN BPSYS_STORE S ON S.ID=N.STOREID ");
                    sqlbulider.Append(" WHERE 1=1 ");
                    if (queryModel.StartTime.HasValue && queryModel.FinishTime.HasValue)
                    {
                        sqlbulider.AppendFormat(" AND T.EXCTIME BETWEEN '{0}' AND '{1}'",
                            queryModel.StartTime.Value.ToString(TIME_FORMAT),
                            queryModel.FinishTime.Value.ToString(TIME_FORMAT));
                    }
                    sqlbulider.AppendFormat(" AND T.SN='{0}'", queryModel.SN);
                    if (!String.IsNullOrEmpty(queryModel.Source))
                    {
                        sqlbulider.AppendFormat("  AND T.EXCSOURCE='{0}'", queryModel.Source);
                    }
                    sqlbulider.Append(" GROUP  BY T.EXCSOURCE");
                }
            }
            using (DataBaseProcess process = new DataBaseProcess())
            {
                DataTable dtcnt = process.Query(cntsqlbuilder.ToString());
                if (dtcnt != null && dtcnt.Rows.Count > 0)
                {
                    Int32 i = 0;
                    Int32.TryParse(dtcnt.Rows[0]["CNT"].ToString(), out i);
                    result.MsgNumber = i;
                }
                DataTable dt = process.Query(sqlbulider.ToString());
                result.Result = dt;
            }
            return result;
        }
    }
}
