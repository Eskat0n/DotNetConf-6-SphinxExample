namespace DotNetConf.Sphinx.Web.Application
{
    using System.Web.Mvc;
    using Forms;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Search(SearchForm form)
        {
            return RedirectToAction("Index");
        }
    }
}