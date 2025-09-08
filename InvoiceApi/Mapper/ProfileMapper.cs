using AutoMapper;
using InvoiceApi.Controllers.InvioceItem.DTOs;
using InvoiceApi.Controllers.Invoice.Dtos;

using InvoiceApi.DataAccess.Entities;


using InvoiceApi.Repository;
namespace InvoiceApi.Mapper
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Invoice, InvoiceReadDTOs>()
                  .ForMember(d => d.Id, opt => opt.Ignore());
                  
            

            CreateMap<Invoice, InvoiceCreateDTOs>()
                .ForMember(d => d.Id, opt => opt.Ignore());
            CreateMap<Invoice, InvoiceReadDTOs>().ReverseMap();
            CreateMap<Invoice, InvoiceUpdateDTOs>();
            CreateMap<Invoice, InvoiceUpdateDTOs>().ReverseMap();
            CreateMap<Invoice, InvoiceCreateDTOs>().ReverseMap();



            CreateMap<InvoiceItem, InvoceItemReadDtos>()
                 .ForMember(d => d.ItemId, opt => opt.Ignore());

            CreateMap<InvoiceItem, InvoiceItemCreateDtos>()
                .ForMember(d => d.ItemId, opt => opt.Ignore());
            CreateMap<InvoiceItem, InvoceItemReadDtos>().ReverseMap();
            CreateMap<InvoiceItem, InvoceItemUpdateDtos>();
            CreateMap<InvoiceItem, InvoceItemUpdateDtos>().ReverseMap();
            CreateMap<InvoiceItem, InvoiceItemCreateDtos>().ReverseMap();

            CreateMap<Invoice, InvoiceItem>().ReverseMap()
                .ForMember(d=>d.Id , p=>p.MapFrom(src=>src.InvoiceId));




        }
    }
}
