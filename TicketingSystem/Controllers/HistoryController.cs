using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Models;

namespace TicketingSystem.Controllers
{
    public class HistoryController : Controller
    {

        public IActionResult Index(int id)
        {
            ticketingContext context = new ticketingContext();

            IEnumerable<TicketHistory> th = 
            from t in context.TicketHistory
            where t.TicketId ==id
            select new TicketHistory
            {
                Id = t.Id,
               Comments = t.Comments
            };

            return View(th);
        }
    }
}