using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing.Drawing2D;

namespace ConsoleApp.xpgroup
{
    public class Xpgroup
    {
        public Hashtable getTargetHasTable()
        {
            Hashtable targetHasTable = new Hashtable();
            targetHasTable.Add("n", "Bastian");
            targetHasTable.Add("name", "He has to give me a new name");
            targetHasTable.Add("same", "open sesame");
            return targetHasTable;
        }
        public bool checkTargetString(string value, string key)
        {
            Hashtable targetHasTable = getTargetHasTable();
            string hastableValue = targetHasTable[key].ToString();
            if (hastableValue == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string confirmEnding(string str,string target)
        {
            if (checkTargetString(str, target)) {
                return str;
            }
            else
            {
                return "";
            }
        }

    }
}
