using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PV.BusinessReport.UI.Model;

namespace PV.BusinessReport.UI.Config
{
    public static class MenuConfig
    {
        public static Dictionary<String, MenuConfigModel> MenuConfigSettings = new Dictionary<string, MenuConfigModel>()
        {
            {
                "ABOUT",
                new MenuConfigModel()
                {
                    DialogModel = true,
                    OperateFormFullName = "PV.BusinessReport.UI.Forms.AboutForm"
                }
            },
            {
                "USERLIST",
                new MenuConfigModel()
                {
                    OperateFormFullName = "PV.BusinessReport.UI.Forms.UserListForm"
                }
            },
            {
                "TRANSFLOWIMPORT",
                new MenuConfigModel()
                {
                    DialogModel = true,
                    OperateFormFullName = "PV.BusinessReport.UI.Forms.TransFlowImportForm"
                }
            },
            {
                "DATADICLIST",
                new MenuConfigModel()
                {
                    DialogModel = false,
                    OperateFormFullName = "PV.BusinessReport.UI.Forms.DataDicListForm"
                }
            },
            {
                "DETAILREPORT",
                new MenuConfigModel()
                {
                    DialogModel = false,
                    OperateFormFullName = "PV.BusinessReport.UI.Forms.DetailReportForm"
                }
            },{
                "SUMMARYREPORT",
                new MenuConfigModel()
                {
                    DialogModel = false,
                    OperateFormFullName = "PV.BusinessReport.UI.Forms.SummaryReportForm"
                }
            }

        };
    }
}
