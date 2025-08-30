using AutoMapper;
using InvoiceApi.DTOs;
using InvoiceApi.Modal;
using InvoiceApi.Modal.Entities;
namespace InvoiceApi.Mapper
{
    public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<Invoice, InvoiceReadDTOs>();
            CreateMap<Invoice, InvoiceCreateDTOs>();
            CreateMap<InvoiceReadDTOs,Invoice >();


        }
    }
}
