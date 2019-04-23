using Microsoft.EntityFrameworkCore;
using System;

namespace TicketingSystem.Services
{
    //#########################
    //Note from Andrew Rogers:
    //#########################

    //I was going to seperate the Database context into another project at this point
    //and reference the context from the main project

    //Also was going to denonstrate creating some other abstraction, Interfaces, helpers etc
           
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
