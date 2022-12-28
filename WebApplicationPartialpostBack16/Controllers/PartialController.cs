using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WebApplicationPartialpostBack16.Models;
using static WebApplicationPartialpostBack16.Models.DynamicRows;

namespace WebApplicationPartialpostBack16.Controllers
{
    public class PartialController : Controller
    {
        public ActionResult Index()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.InfoModel = new List<Information>();
            obj.InfoModel.Add(new Information { ID = 0, Name = "", Contact = 0, Address = "" });
            return View(obj);
        }
        [HttpPost]
        public ActionResult Index(EmployeeModel objmodel)
        {
            objmodel.InfoModel.Add(new Information { ID = 0, Name = "", Contact = 0, Address = "" });
            return View(objmodel);
        }
    }
}


