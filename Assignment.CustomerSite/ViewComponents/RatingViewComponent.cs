using Assignment.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.ViewComponents
{
    public class RatingViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(RatingRespone review)
        {
            return View("Default", review);
        }
    }
}
