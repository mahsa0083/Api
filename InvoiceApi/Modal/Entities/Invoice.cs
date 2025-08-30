using System.ComponentModel.DataAnnotations;

namespace InvoiceApi.Modal.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public int InvoiceNumber { get; set; }

        public int? CustomerId {  get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        //deadline of Payment
        public DateTime DueDate { get; set; }

        [Required]
        [DataType("decimal,(18,4)")]
        public decimal TotalAmount { get; set; }
        [Required]
        [MaxLength(500)]
        public string Statues { get; set; }

        public virtual InvoiceItem InvoiceItem { get; set; }

    }
}
