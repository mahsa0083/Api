using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApi.Controllers.InvioceItem.DTOs
{
    public class InvoiceItemCreateDtos
    {
        public int ItemId { get; set; }


        public int ProductName { get; set; }


        public int Quantity { get; set; }


        public decimal UnitPrice { get; set; }


        //calculate the cost of Product


        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }


    }
}
