using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDemo
{
    [DataContract]
    public class Ticket
    {
        private bool boolCount = true;
        private int howMany = 10;
        [DataMember]
        public bool BoolCount
        {
            get { return boolCount; }
            set
            {
                if (HowMany > 0) boolCount = false;
                else boolCount = true;
            }
        }
        [DataMember]
        public int HowMany
        {
            get
            {
                return howMany;
            }

            set
            {
                howMany = value;
            }
        }


    }
}