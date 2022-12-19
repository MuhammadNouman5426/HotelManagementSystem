using HotalManagementSystem.HMSContext;
using HotalManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Controllers
{
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context; 

        public HomeController(ILogger<HomeController> logger , Context crud )
        {
            _logger = logger;
            _context = crud;

        }

        public void GetCooks()
        {
            ViewBag.Cooks = new SelectList(_context.Cooks.ToList(),"ID","Name");


                }

        #region Add Dish Code Creat
        [HttpGet]
        public IActionResult AddDish()
        {
            GetCooks();
            return View();
        }
        [HttpPost]
        public IActionResult AddDish(Dish dish)
        {
            if (ModelState.IsValid)
            {
                _context.Dishes.Add(dish);
                _context.SaveChanges();
                TempData["Success"] = "Success";
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError(" ", "Please Fill All Input");
                return View(dish);
            }
        }
        #endregion

        #region View Dish Code Red
        public IActionResult ViewDish()
        {
            var dishe = _context.Dishes.Include(s => s.Cook).ToList();
            return View(dishe);
        }
        #endregion

        #region Update Dish Code Update
        [HttpGet]
        public IActionResult UpdateDish(int id)
        {
            var dish = _context.Dishes.Where(s => s.ID == id).FirstOrDefault();
            return View(dish);
        }
        [HttpPost]
        public IActionResult UpdateDish(Dish dish)
        {
            _context.Entry(dish).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("ViewDish","Home");
        }

        #endregion

        #region Delete Dish Code Delete
        [HttpGet]
        public IActionResult DeleteDish(int id)
        {
            var dish = _context.Dishes.Where(s => s.ID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult DeleteDish(Dish dish)
        {
            _context.Remove(dish);
            _context.SaveChanges();
            return RedirectToAction("ViewDish","Home");
        }
        #endregion



        #region Add Waiter Code Creat
        [HttpGet]
        public IActionResult AddWaiter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddWaiter(Waiter waiter)
        {
            if (ModelState.IsValid)
            {
                _context.Waiters.Add(waiter);
                _context.SaveChanges();
                TempData["Success"] = "Success";
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError(" ", "Please Fill All Input");
                return View(waiter);
            }
        }
        #endregion

        #region View Waiter Code Red
        public IActionResult ViewWaiter()
        {
            var waiter = _context.Waiters.ToList();
            return View(waiter);
        }
        #endregion

        #region Update Waiter Code Update
        [HttpGet]
        public IActionResult UpdateWaiter(int id)
        {
            var waiter = _context.Waiters.Where(s => s.ID == id).FirstOrDefault();
            return View(waiter);
        }
        [HttpPost]
        public IActionResult UpdateWaiter(Waiter waiter)
        {
            _context.Entry(waiter).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("ViewWaiter", "Home");
        }

        #endregion

        #region Delete Waiter Code Delete
        [HttpGet]
        public IActionResult DeleteWaiter(int id)
        {
            var waiter = _context.Waiters.Where(s => s.ID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult DeleteWaiter(Waiter waiter)
        {
            _context.Remove(waiter);
            _context.SaveChanges();
            return RedirectToAction("ViewWaiter", "Home");
        }
        #endregion


        #region Add Cook Creat
        [HttpGet]
        public IActionResult AddCook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCook(Cook cook)
        {
            if (ModelState.IsValid)
            {
                _context.Cooks.Add(cook);
                _context.SaveChanges();
                TempData["Success"] = "Success";
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError(" ", "Please Fill All Input");
                return View(cook);
            }
        }
        #endregion

        #region View Cook Code Red
        public IActionResult ViewCook()
        {
            var cook = _context.Cooks.ToList();
            return View(cook);
        }
        #endregion

        #region Update Cook Code Update
        [HttpGet]
        public IActionResult UpdateCook(int id)
        {
            var cook = _context.Cooks.Where(s => s.ID == id).FirstOrDefault();
            return View(cook);
        }
        [HttpPost]
        public IActionResult UpdateCook(Cook cook)
        {
            _context.Entry(cook).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("ViewCook", "Home");
        }

        #endregion

        #region Delete Cook Code Delete
        [HttpGet]
        public IActionResult DeleteCook(int id)
        {
            var cook = _context.Cooks.Where(s => s.ID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCook(Cook cook)
        {
            _context.Remove(cook);
            _context.SaveChanges();
            return RedirectToAction("ViewCook", "Home");
        }
        #endregion

        
        #region Add Customer Code Creat
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                ModelState.Clear();
                return View();

            }
            else
            {
                ModelState.AddModelError("", "Please Fill All Input");
                return View(customer);
            }
        }

        #endregion

        #region View Customer Code Red
        public IActionResult ViewCustomer()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }
        #endregion

        #region Update Customer Code Update
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var customer = _context.Customers.Where(s => s.ID == id).FirstOrDefault();
            return View(customer);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("ViewCustomer", "Home");
        }

        #endregion

        #region Delete Customer Code Delete
        [HttpGet]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _context.Customers.Where(s => s.ID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCustomer(Customer customer)
        {
            _context.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction("ViewCustomer", "Home");
        }
        #endregion


        #region

        public IActionResult Index()
        {
            return View();
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
        #endregion
  }
}
