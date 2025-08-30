namespace InvoiceApi.DTOs
{
    public class InvoiceUpdateDTOs
    {
        public int Id { get; set; }

        public int InvoiceNumber { get; set; }

        public int? CustomerId { get; set; }


        public DateTime InvoiceDate { get; set; }


        public DateTime DueDate { get; set; }


        public decimal TotalAmount { get; set; }

        public string Statues { get; set; }

        public int ItemId { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
        public int InvoiceFk { get; set; }
    }
}
