using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApi.DTOs.InvoceItem
{
    public class InvoceItemUpdateDtos
    {
        public int ItemId { get; set; }

        public string ProductName { get; set; }

      
        public int Quantity { get; set; }



        public decimal UnitPrice { get; set; }


        //calculate the cost of Product
        private decimal _subtotal
        {
            get;
            set;
        }

        public decimal SubTotal { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int InvoiceFk { get; set; }
    }
}
