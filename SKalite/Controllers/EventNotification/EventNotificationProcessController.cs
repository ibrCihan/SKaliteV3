using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.EventNotification;

namespace SKalite.Controllers.EventNotification
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationProcessController : ControllerBase
    {
        private readonly IEventNotificationProcessService _EventNotificationProcessService;
        public EventNotificationProcessController(IEventNotificationProcessService EventNotificationProcessService)
        {
            _EventNotificationProcessService = EventNotificationProcessService;
        }
        [HttpPost]
        public ActionResult Create(EventNotificationProcess EventNotificationProcess)
        {
            var response = _EventNotificationProcessService.Create(EventNotificationProcess);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _EventNotificationProcessService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _EventNotificationProcessService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_EventNotificationProcessService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(EventNotificationProcess EventNotificationProcess, int id)
        {
            var response = _EventNotificationProcessService.Update(EventNotificationProcess, id);
            return Ok(response);
        }
    }
}
