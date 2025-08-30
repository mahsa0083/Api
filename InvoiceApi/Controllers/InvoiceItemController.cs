using AutoMapper;
using InvoiceApi.DTOs.InvoceItem;
using InvoiceApi.DTOs.Invoice;
using InvoiceApi.Modal.Entities;
using InvoiceApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApi.Controllers
{
    [Route("api/InvoiceItemController")]
    [ApiController]
    public class InvoiceItemController : ControllerBase
    {
        private readonly IRepository _repo;
        private readonly IMapper _mapper;
        public InvoiceItemController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoceItemReadDtos>>> GetAllItems()
        {

            var invoiceEntities = _repo.GetAll();


            var invoiceDtos = _mapper.Map<IEnumerable<InvoceItemReadDtos>>(invoiceEntities);
            return Ok(invoiceDtos);
        }

        [HttpGet("id", Name = "GetItemById")]
        public ActionResult<InvoceItemReadDtos> GetItemById(int id)
        {
            var FindInvoice = _repo.GetById(id);
            if (FindInvoice != null)
            {
                return Ok(_mapper.Map<InvoceItemReadDtos>(FindInvoice));
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<InvoceItemReadDtos>> CreateItems(InvoiceItemCreateDtos item)
        {
            var model = _mapper.Map<Invoice>(item);

            _repo.CreateInvoice(model);
            _repo.SaveChanges();

            var ReadDTo = _mapper.Map<InvoiceItemCreateDtos>(model);

            return CreatedAtRoute("GetById", new { id = ReadDTo.ItemId}, ReadDTo);

        }

        [HttpPut("id")]
        public ActionResult UpdateInvoiceItems(int id, InvoiceItemCreateDtos item)
        {
            var model = _repo.GetById(id);

            if (model == null)
            {
                return NotFound();
            }


            _mapper.Map(model, item);

            _repo.SaveChanges();

            return NoContent();
        }

        [HttpDelete("id")]

        public ActionResult DeleteInvoiceItems(int id)
        {
            var item = _repo.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            _repo.Delete(item);
            _repo.SaveChanges();

            return NoContent();
        }

    }
}
