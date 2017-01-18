using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MedicalVisitors.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MedicalVisitorsControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}