using Assignment.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.ViewComponents
{
    public class ProductViewComponent: ViewComponent
    {
       public async Task<IViewComponentResult> InvokeAsync(ProductRespone respone)
        {
            return await Task.FromResult(View("Default", respone));
        }
    }
}
