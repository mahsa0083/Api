using InvoiceApi.Modal.Entities;
using InvoiceApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApi.DTOs.Invoice
{
    public class InvoiceReadDTOs
    {
      
        public int Id { get; set; }

        public int InvoiceNumber { get; set; }

        public int? CustomerId { get; set; }


        public DateTime InvoiceDate { get; set; }


        public DateTime DueDate { get; set; }


        public decimal TotalAmount { get; set; }

        public CheckStatusValue Statues { get; set; }


    }
}
