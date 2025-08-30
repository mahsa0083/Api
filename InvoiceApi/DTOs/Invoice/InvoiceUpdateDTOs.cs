namespace InvoiceApi.DTOs.Invoice
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


    }
}
