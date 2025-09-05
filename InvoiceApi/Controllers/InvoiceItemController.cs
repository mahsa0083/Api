using AutoMapper;
using InvoiceApi.DTOs.InvoceItem;
using InvoiceApi.DTOs.Invoice;
using InvoiceApi.Modal.Entities;
using InvoiceApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApi.Controllers
{
    [Route("api/InvoiceItem")]
    [ApiController]
    public class InvoiceItemController : ControllerBase
    {
        private readonly IRepositoryInvoiceItem _repo;
        private readonly IMapper _mapper;

        public InvoiceItemController(IRepositoryInvoiceItem repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<InvoceItemReadDtos>> GetAllItems()
        {

            var invoiceEntities = _repo.GetAllitems();
            var invoiceDtos = _mapper.Map<IEnumerable<InvoceItemReadDtos>>(invoiceEntities);
            return Ok(invoiceDtos);
        }

        [HttpGet("id")]
        public ActionResult<InvoceItemReadDtos> GetItemById(int id)
        {
            var FindInvoice = _repo.GetitemById(id);
            if (FindInvoice != null)
            {
                return Ok(_mapper.Map<InvoceItemReadDtos>(FindInvoice));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult CreateItems(InvoiceItemCreateDtos item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            var model = _mapper.Map<InvoiceItem>(item);
            if (model == null)
            {
                 throw new ArgumentException(nameof(item));
            }
           
                _repo.CreateInvoiceItem(model);
                return Ok();
            


        }

        [HttpPut("id")]
        public ActionResult UpdateInvoiceItems(int id, InvoiceItemCreateDtos item)
        {
            var MappedModel=_mapper.Map<InvoiceItem>(item);
            var model = _repo.UpdateInvoiceItem(MappedModel, id);
            if (model == false)
            {
                throw new ArgumentException(nameof(item), "it cannot updated");
            }
            return Ok();
        }

        [HttpDelete("id")]

        public ActionResult DeleteInvoiceItems(int id)
        {
            var item = _repo.GetitemById(id);

            if (item == null)
            {
                return NotFound();
            }

            _repo.DeleteInvoiceItem(item);
            

            return Ok();
        }

    }
}
