using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HubbleGalaxyHotelApp.Models;
using HubbleGalaxyHotelApp.Data;
using Microsoft.EntityFrameworkCore;

namespace HubbleGalaxyHotelApp.Controllers
{
    public class HomeController : Controller
    {

    // Replaced ILogger / _logger with ApplicationDBContext / _context

        private readonly ApplicationDbContext _context;


        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

    // GET: Rooms
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = await _context.Rooms.ToListAsync();

            var rooms = applicationDbContext;

            return View(rooms);
        }
    
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
