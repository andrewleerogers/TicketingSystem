using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TicketingSystem.Models
{
    public partial class ticketingContext : DbContext
    {
        public ticketingContext()
        {
        }

        public ticketingContext(DbContextOptions<ticketingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TicketHistory> TicketHistory { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ticketing;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.ToTable("attachments");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("datetime");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Forename)
                    .IsRequired()
                    .HasColumnName("forename")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TicketHistory>(entity =>
            {
                entity.ToTable("Ticket_History");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateRasied)
                    .HasColumnName("date_rasied")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(100);
            });
        }
    }
}
