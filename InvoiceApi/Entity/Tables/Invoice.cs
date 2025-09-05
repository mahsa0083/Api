using InvoiceApi.Repository;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApi.Modal.Entities
{
    public class Invoice
    {
        
        public int Id { get; set; }

    
        public string InvoiceNumber { get; set; }

        public int? CustomerId {  get; set; }

      
        public DateTime IncvoiceCreateAt { get; set; }

        //deadline of Payment
        public DateTime InvoicePaymentAt { get; set; }


        public decimal TotalAmount { get; set; }
        public CheckStatusValue Statues { get; set; }

        public  InvoiceItem InvoiceItem { get; set; }

    }
}
