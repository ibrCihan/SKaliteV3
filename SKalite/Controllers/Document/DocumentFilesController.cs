using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Entity.Document;
using SKalite.Service.Document;

namespace SKalite.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentFilesController : ControllerBase
    {
        private readonly IDocumentFilesService _DocumentFilesService;
        public DocumentFilesController(IDocumentFilesService DocumentFilesService)
        {
            _DocumentFilesService = DocumentFilesService;
        }
        [HttpPost]
        public ActionResult Create(DocumentFiles DocumentFiles)
        {
            var response = _DocumentFilesService.Create(DocumentFiles);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _DocumentFilesService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _DocumentFilesService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_DocumentFilesService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(DocumentFiles DocumentFiles, int id)
        {
            var response = _DocumentFilesService.Update(DocumentFiles, id);
            return Ok(response);
        }
    }
}
