﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.UI.Events
{
    public class MessageEventArgs
    {
        public String Message { get; set; }
        public Exception Exception { get; set; }
        public Boolean Successed { get; set; }
    }

    public delegate void MessageEventHandler(object sender, MessageEventArgs messageEventArgs);
}
