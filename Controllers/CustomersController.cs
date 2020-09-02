using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewsModels;
using Microsoft.Owin.Security.Provider;
using System.Data.Entity.Validation;
using System.Runtime.Caching;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                MemberShipTypes = membershipTypes
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
           
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MemberShipTypes = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            if(customer != null && customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                //Mapper.Map(customer,customerInDb);

                //TryUpdateModel(customerInDb, "", new string[] { "Name", "Email" });
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerInDb.IsSubscribdedToNewsletter = customer.IsSubscribdedToNewsletter;
            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
                throw;
            }

            return RedirectToAction("Index","Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MemberShipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
            
        }

        public ViewResult Index()
        {
            //if(MemoryCache.Default["Genres"]==null)
            //{
            //    MemoryCache.Default["Genres"] = _context.Genres.ToList();
            //}

            //var genre = MemoryCache.Default["Genres"] as IEnumerable<Genre>;

            //var customers = _context.Customers.Include(c => c.MemberShipType).ToList();
            //return View(customers);
            return View();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

    }
}