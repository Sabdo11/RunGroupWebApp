using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunGroupWebApp.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        // GET: /<controller>/


        public ClubController(ApplicationDbContext context) {
            _context = context; 


        }

        public IActionResult Index()
        {


            return View();
        }
    }
}

