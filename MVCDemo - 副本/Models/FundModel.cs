﻿using System;

namespace WebDemo.Models
{
    public class FundModel
    {
        public string fundCode { get;  set; }
        public string fundName { get; set; }
        public string fundUrl { get; set; }
        public char fundTypecode { get; set; }
        public DateTime crtDateTime { get; set; }

       // public FundModel() { fundCode = "001048"; fundName = "富国新兴产业股票"; }
    }
}
