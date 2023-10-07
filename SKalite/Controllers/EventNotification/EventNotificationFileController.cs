using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.EventNotification;

namespace SKalite.Controllers.EventNotification
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationFileController : ControllerBase
    {
        private readonly IEventNotificationFileService _EventNotificationFileService;
        public EventNotificationFileController(IEventNotificationFileService EventNotificationFileService)
        {
            _EventNotificationFileService = EventNotificationFileService;
        }
        [HttpPost]
        public ActionResult Create(EventNotificationFile EventNotificationFile)
        {
            var response = _EventNotificationFileService.Create(EventNotificationFile);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _EventNotificationFileService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _EventNotificationFileService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_EventNotificationFileService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(EventNotificationFile EventNotificationFile, int id)
        {
            var response = _EventNotificationFileService.Update(EventNotificationFile, id);
            return Ok(response);
        }
    }
}
