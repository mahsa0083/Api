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
       
    }
}