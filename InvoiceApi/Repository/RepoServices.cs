using InvoiceApi.Modal.DataBase;
using InvoiceApi.Modal.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Repository
{
    public class RepoServices : IRepository
    {
      private  readonly InvoiceDataBase context;
        public RepoServices(InvoiceDataBase context)
        {
            this.context = context;
        }

        public void CreateInvoice(Invoice invoice)
        {
            if(invoice == null)
            {
                throw new ArgumentNullException(nameof(invoice));

            }
            context.invoices.Add(invoice);
        }

        public void Delete(Invoice invoice)
        {
            context.invoices.Remove(invoice);
        }

        public IEnumerable<Invoice> GetAll()
        {
            return context.invoices.ToList();
        }

        public Invoice GetById(int id)
        {
            return context.invoices.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (context.SaveChanges()>=0);
        }

        public void Update(Invoice invoice)
        {
            context.Entry(invoice).State = EntityState.Modified;
        }
    }
}
