using InvoiceApi.Mapper;
using InvoiceApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using InvoiceApi.Modal.Entities;
using InvoiceApi.DTOs.Invoice;

namespace InvoiceApi.Controllers
{
    [Route("api/InvoiceController")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IRepository _repo;
        private readonly IMapper _mapper;
        public InvoiceController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceReadDTOs>>> GetAll()
        {

            var invoiceEntities = _repo.GetAll();


            var invoiceDtos = _mapper.Map<IEnumerable<InvoiceReadDTOs>>(invoiceEntities);
            return Ok(invoiceDtos);
        }

        [HttpGet("id",Name = "GetById")]
        public ActionResult<InvoiceReadDTOs> GetById(int id)
        {
            var FindInvoice = _repo.GetById(id);
            if (FindInvoice != null)
            {
                return Ok(_mapper.Map<InvoiceReadDTOs>(FindInvoice));
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<InvoiceReadDTOs>> CreateInvoice(InvoiceCreateDTOs item)
        {
            var model = _mapper.Map<Invoice>(item);
            if (item != null)
            {
                _repo.CreateInvoice(model);
                _repo.SaveChanges();
                var ReadDTo = _mapper.Map<InvoiceReadDTOs>(model); 

                return CreatedAtRoute("GetById", new { id = ReadDTo.Id }, ReadDTo);
            }

            else
            {
                return NoContent();
            }
           

        }

        [HttpPut("id")]
        public ActionResult UpdateInvoice(int id, InvoiceUpdateDTOs item)
        {
            var model = _repo.GetById(id);

            if (model == null)
            {
                return NotFound();
            }


            _mapper.Map(item,model);

       

            return NoContent();
        }

        [HttpDelete("id")]

        public ActionResult DeleteInvoice(int id)
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
