using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SKalite
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationController : ControllerBase
    {
        private readonly IEventNotificationService _EventNotificationService;
        public EventNotificationController(IEventNotificationService EventNotificationService)
        {
            _EventNotificationService = EventNotificationService;
        }
        [HttpPost]
        public ActionResult Create(EventNotification EventNotification)
        {
            var response = _EventNotificationService.Create(EventNotification);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _EventNotificationService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _EventNotificationService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_EventNotificationService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(EventNotification EventNotification, int id)
        {
            var response = _EventNotificationService.Update(EventNotification, id);
            return Ok(response);
        }
    }
}
