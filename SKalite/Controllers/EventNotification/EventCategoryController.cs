using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.EventNotification;

namespace SKalite.Controllers.EventNotification
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventCategoryController : ControllerBase
    {
        private readonly IEventCategoryService _EventCategoryService;
        public EventCategoryController(IEventCategoryService EventCategoryService)
        {
            _EventCategoryService = EventCategoryService;
        }
        [HttpPost]
        public ActionResult Create(EventCategory EventCategory)
        {
            var response = _EventCategoryService.Create(EventCategory);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _EventCategoryService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _EventCategoryService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_EventCategoryService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(EventCategory EventCategory, int id)
        {
            var response = _EventCategoryService.Update(EventCategory, id);
            return Ok(response);
        }
    }
}
