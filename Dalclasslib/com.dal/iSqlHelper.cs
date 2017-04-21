using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Dalclasslib.com.dal
{
    public interface iSqlHelper
    {
        SqlDataReader querySQLDataReader(string strSQL);
        //OracleDataReader querySQLDataReader(string strSQL);

        DataSet queryProcedureDataSet(string sStoreProName);
        SqlDataReader queryProcedureDataReader(string sStoreProName, string sPara1, string sPara2);
    }
}
