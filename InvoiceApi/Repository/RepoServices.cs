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
        public bool SaveChanges()
        {
            return (context.SaveChanges() >= 0);
        }
        #region
        public void CreateInvoice(Invoice invoice)
        {
            if (invoice == null)
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
        public void Update(Invoice invoice)
        {
            context.Entry(invoice).State = EntityState.Modified;
            context.SaveChanges();
        }

        #endregion

        #region
        public void CreateInvoice(InvoiceItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));

            }
            context.invoiceItems.Add(item);
        }



        public void DeleteItem(InvoiceItem item)
        {
            context.invoiceItems.Remove(item);
        }


        public IEnumerable<InvoiceItem> GetAllitems()
        {
            return context.invoiceItems.ToList();
        }



        public InvoiceItem GetitemById(int id)
        {
            return context.invoiceItems.FirstOrDefault(x => x.ItemId == id);
        }
        public void UpdateItem(InvoiceItem item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
    #endregion


}
