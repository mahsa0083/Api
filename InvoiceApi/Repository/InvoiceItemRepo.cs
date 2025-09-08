using InvoiceApi.DataAccess.DataBase;
using InvoiceApi.DataAccess.Entities;

using Microsoft.EntityFrameworkCore;


namespace InvoiceApi.Repository
{
    public class InvoiceItemRepo : IRepositoryInvoiceItem
    {
        private readonly AppDBContext context;
        public InvoiceItemRepo(AppDBContext _context)
        {
            context = _context;
                
        }

        public int CalculatePrice(int id)
        {
            var finded = context.invoiceItems.Where(p => p.InvoiceId == id).SingleOrDefault();
            if (finded == null)
            {
                throw new ArgumentException(nameof(finded), "Quntity Cant be ZERO Or NULL");

            }
            if (finded.Quantity <= 0 || finded.Quantity == null)
            {
                throw new ArgumentException(nameof(finded), "Quntity Cant be ZERO Or NULL");
            }
            if (finded.UnitPrice <= 0 || finded.UnitPrice == null)
                throw new ArgumentException(nameof(finded), "Quntity Cant be ZERO Or NULL");


            var TotalPrice = finded.Quantity * finded.UnitPrice;
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
                throw new ArgumentException("item","Please Fill the Fields");
                
            }
            //var model = context.invoiceItems.SingleOrDefault(u => u.ItemId == id);

            //if (model == null)
            //{
            //    throw new ArgumentException("item","No Entites Find With this ID");
            //}



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
