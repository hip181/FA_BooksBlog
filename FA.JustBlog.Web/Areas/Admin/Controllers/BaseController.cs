using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FA.JustBlog.Web.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            //if (sees == null)
            //{
            context.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "Home", action = "Index", Area = "Admin" }));
            //}
            base.OnActionExecuting(context);
        }
    }
}
