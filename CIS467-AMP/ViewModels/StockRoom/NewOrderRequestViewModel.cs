﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.ViewModels.StockRoom
{
    public class NewOrderRequestViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
    }
}