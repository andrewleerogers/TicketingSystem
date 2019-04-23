using System;
using System.Collections.Generic;

namespace TicketingSystem.Models
{
    public partial class Tickets
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public DateTime DateRasied { get; set; }
        public int CustomerId { get; set; }
    }
}
