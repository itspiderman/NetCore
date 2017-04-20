using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dalclasslib.com.dal
{
    public abstract class AbstractSqlHelper
    {
        //public abstract string SqlConnectionString { get; set; }
        public abstract string SqlConnectionString { get; }
        public abstract SqlDataReader querySQLDataReader(string strSQL);
        public abstract SqlDataReader queryProcedureDataReader(string sStoreProName);
        public abstract SqlDataReader queryProcedureDataReader(string sStoreProName, string sPara1, string sPara2);
    }
}
