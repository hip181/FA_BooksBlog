using FA.JustBlog.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        [Authorize(Roles = SD.Role_Blog_Owner + "," + SD.Role_Contributor)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
