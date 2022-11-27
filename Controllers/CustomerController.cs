using CMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class CustomerController : Controller
    {
        private readonly databaseContext _dbContext;
        public CustomerController(databaseContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public ActionResult home()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(customer cus)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                _dbContext.customer.Add(cus);
                _dbContext.SaveChanges();
                return RedirectToAction("GetCustomer");
            }
            catch (Exception ex)
            {
                return View();
            }
            return View();   
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            var list = _dbContext.customer.ToList();
            return View(list);
        }

        [HttpDelete]
        public ActionResult DeleteCustomer(int id)
        {
            customer data = _dbContext.customer.Where(x => x.CustomerID == id).FirstOrDefault();
            _dbContext.customer.Remove(data);
            return View(data);
         
            
        
            //return RedirectToAction("GetCustomer");
        }
        [HttpGet]
        public ActionResult Detail(int id)
        {
            var data = _dbContext.customer.Where(x => x.CustomerID == id).FirstOrDefault();
            return View(data);
        }
        [HttpGet]
        public ActionResult FindById(string id)
        {
            int Id=int.Parse(id);
            var data = _dbContext.customer.Where(x => x.CustomerID == Id).FirstOrDefault();
            return View(data);
        }

        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            var data = _dbContext.customer.Where(x => x.CustomerID == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult EditCustomer(customer cust)
        {
            var data = _dbContext.customer.Where(x => x.CustomerID == cust.CustomerID).FirstOrDefault();
            if (data != null)
            {
                data.CustomerName = cust.CustomerName;
                data.City = cust.City;
                data.Age = cust.Age;
                data.Phone = cust.Phone;
                data.Pincode = cust.Pincode;
                _dbContext.SaveChanges();
            }
            return RedirectToAction("GetCustomer");
        }


    }
}
