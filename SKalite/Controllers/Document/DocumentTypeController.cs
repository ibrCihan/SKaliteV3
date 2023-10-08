using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Entity.Document;
using SKalite.Service.Document;

namespace SKalite.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeService _DocumentTypeService;
        public DocumentTypeController(IDocumentTypeService DocumentTypeService)
        {
            _DocumentTypeService = DocumentTypeService;
        }
        [HttpPost]
        public ActionResult Create(DocumentType DocumentType)
        {
            var response = _DocumentTypeService.Create(DocumentType);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _DocumentTypeService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _DocumentTypeService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_DocumentTypeService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(DocumentType DocumentType, int id)
        {
            var response = _DocumentTypeService.Update(DocumentType, id);
            return Ok(response);
        }
    }
}
