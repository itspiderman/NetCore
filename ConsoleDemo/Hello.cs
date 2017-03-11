using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Hello
    {
        public String sysHello()
        {
            System.Console.WriteLine("Hello word");
            return "hello kevin!";
        }

        public void addString()
        {
            String sb = "";
            for (int i = 0; i < 200; i++)
            {
                sb=sb+";outter:" + i;
                for (int j = 0; j < 200; j++)
                {
                    sb=sb+";inner:" + j;
                }
            }
        }

        public void appendString()
        {
            StringBuilder sb=new StringBuilder();
            for(int i = 0; i < 200; i++)
            {
                sb.Append(";outter:" + i);
                for(int j = 0; j < 200; j++)
                {
                    sb.Append(";inner:" + j);
                }
            }
        }
    }
}
