using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Data.Entity;
//
using Dalclasslib.com.models;

namespace Dalclasslib.com.context
{
    public class TfundContext:DbContext
    {
        public TfundContext() : base("name=oracleDB") { }
        public DbSet<TfundModel> Tfunds { get; set; }
        private const string contextName = "oracleDB";
        public static TfundContext currentContext
        {
            get
            {
                var http = System.Web.HttpContext.Current;
                TfundContext context = http == null ? null:(TfundContext)http.Items["oracle_" + contextName];
                if (null == context)
                {
                    context = new TfundContext();
                    if (null != http)
                    {
                        http.Items["oracle_" + contextName] = context;
                    }
                }
                return context;
            }
        }
    }
}
