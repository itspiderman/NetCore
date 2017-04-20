using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dalclasslib.com.dal
{
    public interface iSqlHelper
    {
        SqlDataReader querySQLDataReader(string strSQL);
        SqlDataReader queryProcedureDataReader(string sStoreProName);
        SqlDataReader queryProcedureDataReader(string sStoreProName, string sPara1, string sPara2);
    }
}
