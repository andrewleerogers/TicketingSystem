using System;
using System.Collections.Generic;

namespace TicketingSystem.Models
{
    public partial class Attachments
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public byte[] Data { get; set; }
        public string Comments { get; set; }
        public int TicketId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
