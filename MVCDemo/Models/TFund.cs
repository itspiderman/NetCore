using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;

namespace MVCDemo.Models
{
    public class TFund
    {
        [Key]
        public string fundCode { get;  set; }
        public string fundName { get; set; }
        public string fundUrl { get; set; }
        public char fundTypecode { get; set; }
        public DateTime crtDateTime { get; set; }

       // public FundModel() { fundCode = "001048"; fundName = "富国新兴产业股票"; }
    }
}
