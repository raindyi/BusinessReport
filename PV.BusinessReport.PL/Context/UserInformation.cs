﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.PL.Context
{
    public static class UserInformation
    {
        public static Guid ID { get; set; }

        public static String Name { get; set; }

        //public static String MacAddress { get; set; }

        public static DateTime LoginTime { get; set; }

    }
}
