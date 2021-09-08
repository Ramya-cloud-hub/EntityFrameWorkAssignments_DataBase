using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models;
using WebAppAssignmentDATABASE_5.Models.Service;

namespace WebAppAssignmentDATABASE_5.Controllers
{
    public class CityController : Controller
    {

        //Dependency injectin Entity Framework
        ICityService _cityService;
        ExDbContext _exContext;

        public CityController(ICityService citiesService, ExDbContext context)
        {
            _cityService = citiesService;
            _exContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
