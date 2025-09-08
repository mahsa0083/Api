using InvoiceApi.DataAccess.Enum;


namespace InvoiceApi.Controllers.Invoice.Dtos
{
    public class InvoiceReadDTOs
    {

        public int Id { get; set; }

        public int InvoiceNumber { get; set; }

        public int? CustomerId { get; set; }


        public DateTime InvoiceDate { get; set; }


        public DateTime DueDate { get; set; }


        public decimal TotalAmount { get; set; }

        public CheckStatusValue Status { get; set; }


    }
}
