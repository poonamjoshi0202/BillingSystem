using BilllingSystemPoc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilllingSystemPoc.Controllers
{
    public class BillingInvoiceController : Controller
    {
        // GET: BillingInvoiceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BillingInvoiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet(Name = "HandleBillingReuqest")]
        public IActionResult Get()
        {
            Company customer = new { 
                customerId = 1,
             
            
            
            
            };
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // GET: BillingInvoiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillingInvoiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BillingInvoiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillingInvoiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BillingInvoiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillingInvoiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
