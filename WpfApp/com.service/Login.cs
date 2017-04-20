using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//user namespace;
using Dalclasslib.com.dal;

namespace WpfApp.com.service
{
    class Login
    {
        public int chklogin(String sName,String sPwd)
        {
            TfundReadDao dq = new TfundReadDao();
            return dq.selectCount(sName,sPwd);
        }
    }
}
