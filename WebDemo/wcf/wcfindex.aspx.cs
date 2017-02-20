using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDemo.wcf
{
    public partial class wcfindex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client tClient = new ServiceReference1.Service1Client();
            tClient.buyTickets(1);
            Label1.Text = "you got the ticket!";
            tClient.Close();
        }
    }
}