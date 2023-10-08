using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Entity.Document;
using SKalite.Service.Document;

namespace SKalite.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentCategoryController : ControllerBase
    {
        private readonly IDocumentCategoryService _DocumentCategoryService;
        public DocumentCategoryController(IDocumentCategoryService DocumentCategoryService)
        {
            _DocumentCategoryService = DocumentCategoryService;
        }
        [HttpPost]
        public ActionResult Create(DocumentCategory DocumentCategory)
        {
            var response = _DocumentCategoryService.Create(DocumentCategory);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _DocumentCategoryService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _DocumentCategoryService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_DocumentCategoryService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(DocumentCategory DocumentCategory, int id)
        {
            var response = _DocumentCategoryService.Update(DocumentCategory, id);
            return Ok(response);
        }
    }
}
