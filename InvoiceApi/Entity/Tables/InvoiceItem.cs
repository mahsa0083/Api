using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApi.Modal.Entities
{
    public class InvoiceItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public int ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [DataType("decimal,(18,4)")]
        
        public decimal UnitPrice { get; set; }

 

         public int InvoiceFk {  get; set; }
        public  Invoice Invoice { get; set; }

    }
}
