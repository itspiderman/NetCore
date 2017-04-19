using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalclasslib.com.dal
{
    interface iSqlHelper
    {
        int execProcedure(String sStoreProName);
        int execProcedure(String sStoreProName, String sPara1, String sPara2);
    }
}
