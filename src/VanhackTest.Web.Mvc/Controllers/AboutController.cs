﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using VanhackTest.Controllers;

namespace VanhackTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : VanhackTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
