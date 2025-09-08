using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApi.Controllers.InvioceItem.DTOs
{
    public class InvoceItemReadDtos
    {
        public int ItemId { get; set; }
        public int ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }


        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
    }
}
