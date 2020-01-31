using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HubbleGalaxyHotelApp.Data;
using HubbleGalaxyHotelApp.Models;
using HubbleGalaxyHotelApp.Models.ViewModels;

namespace HubbleGalaxyHotelApp.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Private field to store user manager
        private readonly UserManager<ApplicationUser> _userManager;

        public ReservationsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Private method to get current user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Reservations
        public async Task<IActionResult> Index()

        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();

            var applicationDbContext = await _context.Reservations.ToListAsync();

            var reservations = applicationDbContext;

            return View(reservations);
            
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await GetCurrentUserAsync();

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create(int id)
        {
            CreateReservationViewModel vm = new CreateReservationViewModel();

    // Created variable - linked to DB to retrieve Room details (Name and Price per Night)
            var rooms = _context.Rooms.Single(r => r.Id == id);
    // Assigned rooms variable to ViewModel (for access to data)
            vm.Room = rooms;

            vm.PaymentTypes = _context.PaymentTypes.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.NameOfAccount
            }
            ).ToList();

            vm.PaymentTypes.Insert(0, new SelectListItem()
            {
                Value = "0",
                Text = "Please choose a Payment Type"
            });

            return View(vm);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, CreateReservationViewModel viewmodel)
        {
            

            if (ModelState.IsValid)
            {
                ApplicationUser loggedInUser = await GetCurrentUserAsync();
                viewmodel.Reservation.UserId = loggedInUser.Id;
                viewmodel.Reservation.RoomId = id;

                _context.Add(viewmodel.Reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { viewmodel.Reservation.Id });
            }
            return View(viewmodel);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoomId,PaymentTypeId,UserId,StartDate,EndDate")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }
}
