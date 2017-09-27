using AlloyCommerce.Models.Catalog;
using AlloyCommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlloyCommerce.Controllers
{
    public class AlloyCategoryController : ContentControllerBase<AlloyNode>
    {
        public ActionResult Index(AlloyNode currentContent)
        {
            var model = PageViewModel.Create<AlloyNode>(currentContent);

            return View(model);
        }

    }
}