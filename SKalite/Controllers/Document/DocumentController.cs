using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Entity.Document;

namespace SKalite
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _DocumentService;
        public DocumentController(IDocumentService DocumentService)
        {
            _DocumentService = DocumentService;
        }
        [HttpPost]
        public ActionResult Create(Document Document)
        {
            var response = _DocumentService.Create(Document);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _DocumentService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _DocumentService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_DocumentService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(Document Document, int id)
        {
            var response = _DocumentService.Update(Document, id);
            return Ok(response);
        }
    }
}
