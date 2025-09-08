using InvoiceApi.DataAccess.Entities;

namespace InvoiceApi.Repository
{
    public interface IRepositoryInvoice
    {
        List<Invoice> GetAll();
        Invoice GetById(int id);
        void CreateInvoice(Invoice invoice);
        void Update(Invoice invoice);
        void Delete(Invoice invoice);
        
        

      


    }
}
