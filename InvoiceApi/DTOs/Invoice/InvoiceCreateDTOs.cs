using InvoiceApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApi.DTOs.Invoice
{
    public class InvoiceCreateDTOs
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
