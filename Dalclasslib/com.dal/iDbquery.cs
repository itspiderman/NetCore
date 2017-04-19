using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalclasslib.com.dal
{
    public interface iDbquery
    {
        int execProcedure(String sStoreProName);
        int execProcedure(String sStoreProName, String sPara1);
        int execProcedure(String sStoreProName, String sPara1, String sPara2);
        int execProcedure(String sStoreProName, String sPara1, String sPara2, String sPara3);
        int execProcedure(String sStoreProName, String sPara1, String sPara2, String sPara3, String sPara4);
        int execProcedure(String sStoreProName, String sPara1, String sPara2, String sPara3, String sPara4, String sPara5);
    }
}
