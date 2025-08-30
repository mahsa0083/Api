using System.ComponentModel.DataAnnotations;

namespace InvoiceApi.DTOs.InvoceItem
{
    public class InvoceItemReadDtos
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
    }
}
