using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApi.Modal.Entities
{
    public class InvoiceItem
    {
        [Key]
        public int ItemId { get; set; }

        public int ProductName { get; set; }

        public int Quantity { get; set; }


        
        public decimal UnitPrice { get; set; }

 

         public int InvoiceId {  get; set; }
        public  Invoice Invoice { get; set; }

    }
}
