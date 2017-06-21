using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.TORCHx.Core.Web.Common;

namespace Web.TORCHx.Core.Web.MVC
{
	public class LoginController : Controller
	{
		public LoginController()
		{
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(LoginRequest request)
		{
			return View(request);
		}
	}
}
