using InvoiceApi.Modal.Entities;

namespace InvoiceApi.Repository
{
    public interface IRepositoryInvoiceItem
    {
        IEnumerable<InvoiceItem> GetAllitems();
        InvoiceItem GetitemById(int id);
        void CreateInvoiceItem(InvoiceItem item);
        bool UpdateInvoiceItem(InvoiceItem item, int id);
        bool DeleteInvoiceItem(InvoiceItem item);
        
        int CalculatePrice( int id);
    }
}
