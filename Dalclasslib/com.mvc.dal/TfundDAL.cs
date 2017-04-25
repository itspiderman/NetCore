using System.Linq;
using Dalclasslib.com.mvc.entity;

namespace Dalclasslib.com.mvc.dal
{
    public class TfundDAL
    {
        context.TfundContext ct = context.TfundContext.currentContext;
        public TfundEntity Get(string fc)
        {
            var query = from a in ct.Tfunds
                        where a.fundCode == fc
                        select new TfundEntity
                        {
                            fundCode = a.fundCode,
                            fundName = a.fundName,
                            fundTypecode = a.fundTypecode,
                            crtDateTime = a.crtDateTime
                        };
            return query.FirstOrDefault();
        }
    }
}
