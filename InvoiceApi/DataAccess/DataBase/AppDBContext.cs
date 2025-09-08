using InvoiceApi.DataAccess.Entities;

using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.DataAccess.DataBase
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
                : base(options)
        {
        }
        public DbSet<Invoice> invoices { get; set; }
        public DbSet<InvoiceItem> invoiceItems { get; set; }

    }
}