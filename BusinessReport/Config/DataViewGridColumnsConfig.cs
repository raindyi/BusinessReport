using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PV.BusinessReport.UI.Model;

namespace PV.BusinessReport.UI.Config
{
    public static class DataViewGridColumnsConfig
    {
        public static readonly Dictionary<String, GridColumnModel> PNRTaskSettings = new Dictionary
            <String, GridColumnModel>()
        {
            {
                "ID", new GridColumnModel()
                {
                    Name = "ID",
                    HeadName = "ID",
                    Visible = false
                }
            },
            {
                "SERIALNO", new GridColumnModel()
                {
                    Name = "SERIALNO",
                    HeadName = "序号",
                }
            },
             {
                "PNR", new GridColumnModel()
                {
                    Name = "PNR",
                    HeadName = "PNR",
                    Width = 60
                }
            },
             {
                "AIRCOMPANY", new GridColumnModel()
                {
                    Name = "AIRCOMPANY",
                    HeadName = "航司",
                    Width = 100,
                }
            },
             {
                "TICKETNO", new GridColumnModel()
                {
                    Name = "TICKETNO",
                    HeadName = "承运人_票号",
                    Width = 125,
                }
            },
             {
                "BILLPRICE", new GridColumnModel()
                {
                    Name = "BILLPRICE",
                    HeadName = "账单价",
                    Width = 100,
                }
            },
             {
                "ETERMPRICE", new GridColumnModel()
                {
                    Name = "ETERMPRICE",
                    HeadName = "Eterm价格",
                    Width = 100,
                }
            },
             {
                "PRICEDIFF", new GridColumnModel()
                {
                    Name = "PRICEDIFF",
                    HeadName = "差价",
                    Width = 100,
                }
            },

             {
                "STATE", new GridColumnModel()
                {
                    Name = "STATE",
                    HeadName = "状态",
                    Width = 100,
                }
            },
        };
    }
}
