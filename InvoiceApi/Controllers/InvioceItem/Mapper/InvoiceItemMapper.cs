using AutoMapper;
using InvoiceApi.Controllers.InvioceItem.DTOs;
using InvoiceApi.DataAccess.Entities;


namespace InvoiceApi.Controllers.InvioceItem.Mapper
{
    public class InvoiceMapper : Profile
    {
        public InvoiceMapper()
        {
            CreateMap<InvoiceItem, InvoceItemReadDtos>()
                .ForMember(d => d.ItemId, opt => opt.Ignore());

            CreateMap<InvoiceItem, InvoiceItemCreateDtos>()
                .ForMember(d => d.ItemId, opt => opt.Ignore());
            CreateMap<InvoiceItem, InvoceItemReadDtos>().ReverseMap();
            CreateMap<InvoiceItem, InvoceItemUpdateDtos>();
            CreateMap<InvoiceItem, InvoceItemUpdateDtos>().ReverseMap();
            CreateMap<InvoiceItem, InvoiceItemCreateDtos>().ReverseMap();

            //CreateMap<Invoice, InvoiceItem>().ReverseMap()
            //    .ForMember(d => d.Id, p => p.MapFrom(src => src.InvoiceId));
        }
    }
}
        