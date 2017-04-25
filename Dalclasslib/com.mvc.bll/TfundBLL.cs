//
using Dalclasslib.com.mvc.dal;
using Dalclasslib.com.mvc.entity;
namespace Dalclasslib.com.mvc.bll
{
    public class TfundBLL
    {
        TfundDAL fundDal = new TfundDAL();
        public TfundEntity Get(string fc)
        {
            return fundDal.Get(fc);
        }
    }
}
