using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net.Security;

namespace WcfDemo
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    //[ServiceContract(Namespace="http://localhost:8080/",Name="Service1",ProtectionLevel= ProtectionLevel.None)]
    [ServiceContract]
    public interface IService1
    {

        // TODO: 在此添加您的服务操作

        [OperationContract]
        void addTicket(int count);
        [OperationContract]
        int buyTickets(int num);
        [OperationContract]
        int getRemainNum();
    }



    
}
