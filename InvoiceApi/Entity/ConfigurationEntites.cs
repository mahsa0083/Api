using InvoiceApi.Modal.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Entity
{
    public class ConfigurationEntites:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-one relationship configuration
            modelBuilder.Entity<Invoice>()
                .HasOne(u => u.InvoiceItem)
                .WithOne(up => up.Invoice)
                .HasForeignKey<InvoiceItem>(up => up.InvoiceId);


            modelBuilder.Entity<Invoice>()
        .Property(i => i.Statues)
        .HasConversion<string>();

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("BaseInvoice").HasKey(s => s.Id);

                entity.Property(s => s.InvoiceNumber)
                .IsRequired()
                .HasMaxLength(100);

              
                entity.Property(s => s.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,4)");

                entity.Property(s => s.Statues)
                .IsRequired()
                .HasDefaultValue("درحال پرداخت");

            });
            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.ToTable("BaseInvoiceItems").HasKey(s => s.ItemId);

                entity.Property(s => s.ProductName)
                .IsRequired()
                .HasMaxLength(500);

                entity.Property(s => s.Quantity)
                .IsRequired();
                entity.Property(s => s.UnitPrice)
                  .IsRequired();
                entity.Property(s => s.InvoiceId)
                .IsRequired();


            });
        }
    }
}
