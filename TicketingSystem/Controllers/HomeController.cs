using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Models;

namespace TicketingSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ticketingContext context = new ticketingContext();
            

                IEnumerable<Tickets> CurrentTickets = from t in context.Tickets
                                                      select new Tickets
                                                      {
                                                          Id = t.Id,
                                                          Subject = t.Subject,
                                                          Description = t.Description,
                                                          DateRasied = t.DateRasied
                                                      };

                //var ticket = context.Tickets.FirstOrDefault();
                return View(CurrentTickets);
           
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
