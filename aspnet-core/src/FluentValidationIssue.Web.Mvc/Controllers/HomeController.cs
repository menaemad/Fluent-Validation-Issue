using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using FluentValidationIssue.Controllers;

namespace FluentValidationIssue.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FluentValidationIssueControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
