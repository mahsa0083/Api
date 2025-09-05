using InvoiceApi.Modal.DataBase;
using InvoiceApi.Modal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InvoiceApi.Repository
{
    public class RepoInvoiceItemService : IRepositoryInvoiceItem
    {
        private readonly InvoiceDataBase context;
        public RepoInvoiceItemService(InvoiceDataBase _context)
        {
            context = _context;
                
        }
        public int CalculatePrice(InvoiceItem item)
        {
            if (item.Quantity <= 0 || item.Quantity == null)
            {
                throw new ArgumentException(nameof(item), "Quntity Cant be ZERO Or NULL");
            }
            if (item.UnitPrice <= 0 || item.UnitPrice == null)
                throw new ArgumentException(nameof(item), "Quntity Cant be ZERO Or NULL");


            var TotalPrice = item.Quantity * item.UnitPrice;
            int ConvertedPrice = Convert.ToInt32(TotalPrice);
            return ConvertedPrice;
        }

        

        public void CreateInvoiceItem(InvoiceItem item)
        {
            if (item == null)
                throw new Exception("item is empty");
            context.invoiceItems.Add(item);
            context.SaveChanges();

            
        }

        public bool DeleteInvoiceItem(InvoiceItem item)
        {
            var model=context.invoiceItems.FirstOrDefault(u=>u.ItemId==item.ItemId);
            if (model==null)
            {
                throw new Exception("No fields Matches");
            }
            context.invoiceItems.Remove(model);
            context.SaveChanges();
            return true;
        }

        public IEnumerable<InvoiceItem> GetAllitems()
        {
            if (context == null)
                throw new ArgumentException("No value exsit");
            return context.invoiceItems.ToList();
        }

        public InvoiceItem GetitemById(int id)
        {
           if (id==0 || id == null)
            {
                throw new Exception("ID is Null or Zero");
            }
            var item = context.invoiceItems.SingleOrDefault(u=>u.ItemId==id);
            if(item == null)
            {
                throw new Exception("No Item matches with this Id");
            }
            return item;

        }

        public bool UpdateInvoiceItem(InvoiceItem item, int id)
        {

            if (item == null)
            {
                throw new Exception("Please Fill the Fields");
                
            }
            var model = context.invoiceItems.SingleOrDefault(u => u.ItemId == id);

            if (model == null)
            {
                throw new Exception("No Entites Find With this ID");
            }



            //model.UnitPrice = item.UnitPrice;
            //model.Quantity = item.Quantity;
            //model.ProductName = item.ProductName;
            //model.InvoiceId = item.InvoiceId;
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
    }
}
