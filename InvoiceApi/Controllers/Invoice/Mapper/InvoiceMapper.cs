using AutoMapper;
using InvoiceApi.Controllers.Invoice.Dtos;
using InvoiceApi.DataAccess.Entities;


namespace InvoiceApi.Controllers.Invoice.Mapper
{
    public class InvoiceMapper :Profile
    {
        public InvoiceMapper() 
        {
            CreateMap<Invoice, InvoiceReadDTOs>()
            .ForMember(d => d.Id, opt => opt.Ignore());



            CreateMap<Invoice, InvoiceCreateDTOs>()
                .ForMember(d => d.Id, opt => opt.Ignore());
            CreateMap<Invoice, InvoiceReadDTOs>().ReverseMap();
            CreateMap<Invoice, InvoiceUpdateDTOs>();
            CreateMap<Invoice, InvoiceUpdateDTOs>().ReverseMap();
            CreateMap<Invoice, InvoiceCreateDTOs>().ReverseMap();
        }
    }
}
