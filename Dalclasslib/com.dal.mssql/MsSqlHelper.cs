using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalclasslib.com.dal.mssql
{
    class MsSqlHelper : iSqlHelper
    {
        public int execProcedure(string sStoreProName, string sPara1, string sPara2)
        {
            throw new NotImplementedException();
        }

        int iSqlHelper.execProcedure(String sStoreProName)
        {
            throw new NotImplementedException();
        }

    }
}
