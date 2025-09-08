using Azure.Messaging;
using InvoiceApi.DataAccess.DataBase;
using InvoiceApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Repository
{
    public class InvoiceRepo : IRepositoryInvoice 
    {
        private readonly AppDBContext context;
        public InvoiceRepo(AppDBContext context)
        {
            this.context = context;
        }

        public void CreateInvoice(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentNullException("فاکتور خالی است");
            }
            
            //context.invoices.Add(invoice);
            
        }
        public void Delete(Invoice invoice)
        {
            if (invoice.Id == null || invoice.Id == 0)
            {
                throw new ArgumentNullException("Compelet the Field ID");
            }
            //context.invoices.Remove(invoice);
        }
       
        public Invoice GetById(int id)
        {
            if (id == null || id == 0)
            {
                throw new ArgumentNullException("Please enter ID");
            }
            return context.invoices.FirstOrDefault(x => x.Id == id);
        }
        public void Update(Invoice invoice)
        {
            if (invoice.Id == 0 || invoice.Id == null)
            {
                throw new ArgumentNullException("Please compelet the values");
            }
            if (invoice == null)
            {
                throw new ArgumentNullException("Please compelet the values");
            }
            context.Entry(invoice).State = EntityState.Modified;
            context.SaveChanges();
        }


        public void CreateInvoice(InvoiceItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));

            }
            //context.invoiceItems.Add(/*item*/);
        }



        public void DeleteItem(InvoiceItem item)
        {
            //context.invoiceItems.Remove(item);
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

        public List<Invoice> GetAll()
        {
            return context.invoices.ToList();
        }
    }

}