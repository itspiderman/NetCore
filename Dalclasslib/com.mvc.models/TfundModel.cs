using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Dalclasslib.com.models
{
    public class TfundModel
    {
        [Key]
        [MaxLength(6)]
        public string fundCode { get; set; }
        [MaxLength(200)]
        public string fundName { get; set; }
        [MaxLength(200)]
        public string fundUrl { get; set; }
        [MaxLength(200)]
        public char fundTypecode { get; set; }
        public DateTime crtDateTime { get; set; }
    }
}
