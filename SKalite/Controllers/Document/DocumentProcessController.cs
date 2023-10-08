using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Entity.Document;
using SKalite.Service.Document;

namespace SKalite.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentProcessController : ControllerBase
    {
        private readonly IDocumentProcessService _DocumentProcessService;
        public DocumentProcessController(IDocumentProcessService DocumentProcessService)
        {
            _DocumentProcessService = DocumentProcessService;
        }
        [HttpPost]
        public ActionResult Create(DocumentProcess DocumentProcess)
        {
            var response = _DocumentProcessService.Create(DocumentProcess);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _DocumentProcessService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _DocumentProcessService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_DocumentProcessService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(DocumentProcess DocumentProcess, int id)
        {
            var response = _DocumentProcessService.Update(DocumentProcess, id);
            return Ok(response);
        }
    }
}
