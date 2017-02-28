﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Logbook
{
    /// <summary>
    /// This class is the status field for a log entry and has the type of log that we are looking at
    /// Potential log types are Stockroom, Maintenance and General. More may be added later if desirable.
    /// Id - The record ID field
    /// Type - Type of Logbook entry this is the status for
    /// Name - Name of Status
    /// 
    /// TODO: This will be tied into all of ths statuses for Maintenance and Stockroom
    /// Have to wait until those are built until figuring best way to do this one.
    /// Leave empty for now 
    /// </summary>
    public class LogbookStatus
    {
        public int Id { get; set; }
        public LogbookType LogbookType { get; set; }
        public string Name { get; set; }      
    }
}