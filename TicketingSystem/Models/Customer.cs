using System;
using System.Collections.Generic;

namespace TicketingSystem.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
