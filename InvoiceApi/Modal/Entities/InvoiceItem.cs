using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApi.Modal.Entities
{
    public class InvoiceItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [DataType("decimal,(18,4)")]
        
        public decimal UnitPrice { get; set; }

        [Required]
        [DataType("decimal,(18,4)")]
        //calculate the cost of Product
        public decimal SubTotal { get; set; }

        [ForeignKey(nameof(Invoice))]
         public int InvoiceFk {  get; set; }
        public virtual Invoice Invoice { get; set; }

    }
}
