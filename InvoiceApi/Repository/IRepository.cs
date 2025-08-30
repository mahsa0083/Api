using InvoiceApi.Modal.Entities;

namespace InvoiceApi.Repository
{
    public interface IRepository
    {
        IEnumerable<Invoice> GetAll();
        Invoice GetById(int id);
         void CreateInvoice (Invoice invoice);
        bool SaveChanges();
        void Update(Invoice invoice);
        void Delete(Invoice invoice);
    }
}
