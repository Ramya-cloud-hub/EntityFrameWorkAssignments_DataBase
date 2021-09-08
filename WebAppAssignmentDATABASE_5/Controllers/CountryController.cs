using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models;
using WebAppAssignmentDATABASE_5.Models.Service;

namespace WebAppAssignmentDATABASE_5.Controllers
{
    public class CountryController : Controller
    {


        //Dependency injectin Entity Framework
        ICountryService _countyService;
        ExDbContext _exContext;

        public CountryController(ICountryService countryService, ExDbContext exContext)
        {
            _countyService = countryService;
            _exContext = exContext;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
