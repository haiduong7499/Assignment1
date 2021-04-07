using Assignment.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.Services
{
    public interface ICategoryApiClient
    {
        Task<IList<CategoryRespone>> GetCategory();
    }
}
