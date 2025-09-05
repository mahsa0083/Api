using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApi.DTOs.InvoceItem
{
    public class InvoceItemUpdateDtos
    {
        public int ItemId { get; set; }

        public int ProductName { get; set; }

      
        public int Quantity { get; set; }



        public decimal UnitPrice { get; set; }


       
        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
    }
}
