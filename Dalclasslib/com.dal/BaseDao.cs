namespace Dalclasslib.com.dal
{
    public class BaseDao
    {
        public iSqlHelper sqlHelper;
        public BaseDao()
        {
            int i = 1;
            if (i==1)
            {
                sqlHelper = new mssql.MsSqlHelper();
            }
            else
            {
                sqlHelper = new oracle.OracleSqlHelper();
            }
        }
    }
}
