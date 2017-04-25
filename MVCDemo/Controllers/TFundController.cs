using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.ModelsDbConext;

namespace MVCDemo.Controllers
{
    public class TFundController : Controller
    {
        private TFundDbContext db = new TFundDbContext();

        // GET: TFund
        public ActionResult Index()
        {
            return View(db.fFunds.ToList());
        }

        // GET: TFund/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TFund tFund = db.fFunds.Find(id);
            if (tFund == null)
            {
                return HttpNotFound();
            }
            return View(tFund);
        }

        // GET: TFund/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TFund/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fundCode,fundName,fundUrl,crtDateTime")] TFund tFund)
        {
            if (ModelState.IsValid)
            {
                db.fFunds.Add(tFund);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tFund);
        }

        // GET: TFund/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TFund tFund = db.fFunds.Find(id);
            if (tFund == null)
            {
                return HttpNotFound();
            }
            return View(tFund);
        }

        // POST: TFund/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fundCode,fundName,fundUrl,crtDateTime")] TFund tFund)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tFund).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tFund);
        }

        // GET: TFund/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TFund tFund = db.fFunds.Find(id);
            if (tFund == null)
            {
                return HttpNotFound();
            }
            return View(tFund);
        }

        // POST: TFund/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TFund tFund = db.fFunds.Find(id);
            db.fFunds.Remove(tFund);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
