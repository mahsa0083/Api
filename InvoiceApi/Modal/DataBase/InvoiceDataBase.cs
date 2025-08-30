using InvoiceApi.Modal.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Modal.DataBase
{
    public class InvoiceDataBase : DbContext
    {
        public InvoiceDataBase(DbContextOptions<InvoiceDataBase> options)
                : base(options)
        {
        }
        public DbSet<Invoice> invoices { get; set; }
        public DbSet<InvoiceItem> invoiceItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-one relationship configuration
            modelBuilder.Entity<Invoice>()
                .HasOne(u => u.InvoiceItem)
                .WithOne(up => up.Invoice)
                .HasForeignKey<InvoiceItem>(up => up.ItemId);
        }
    }
}