using InvoiceApi.Modal.Entities;

namespace InvoiceApi.Repository
{
    public interface IRepository
    {
        #region Invoice
        IEnumerable<Invoice> GetAll();
        Invoice GetById(int id);
        void CreateInvoice(Invoice invoice);
        bool SaveChanges();
        void Update(Invoice invoice);
        void Delete(Invoice invoice);
        #endregion

        #region Invoice item
        IEnumerable<InvoiceItem> GetAllitems();
        InvoiceItem GetitemById(int id);
        void CreateInvoice(InvoiceItem item);
        void UpdateItem(InvoiceItem item);
        void DeleteItem(InvoiceItem item);
        #endregion


    }
}
