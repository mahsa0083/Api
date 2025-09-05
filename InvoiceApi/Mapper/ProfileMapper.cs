using AutoMapper;
using InvoiceApi.DTOs.InvoceItem;
using InvoiceApi.DTOs.Invoice;
using InvoiceApi.Modal.Entities;
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






        }
    }
}
