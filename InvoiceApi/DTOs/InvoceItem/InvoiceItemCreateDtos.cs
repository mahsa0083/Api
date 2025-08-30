using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApi.DTOs.InvoceItem
{
    public class InvoiceItemCreateDtos
    {
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
        private decimal _subtotal
        {
            get;
            set;
        }
        [Required]
        [DataType("decimal,(18,4)")]
        public  decimal SubTotal {get; set; }


    }
}
