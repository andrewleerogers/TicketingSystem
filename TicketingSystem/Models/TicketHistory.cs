using System;
using System.Collections.Generic;

namespace TicketingSystem.Models
{
    public partial class TicketHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int StatusId { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public int DepartmentId { get; set; }
        public int StaffId { get; set; }
    }
}
