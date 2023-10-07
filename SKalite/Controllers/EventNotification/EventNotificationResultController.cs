using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.EventNotification;

namespace SKalite.Controllers.EventNotification
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventNotificationResultController : ControllerBase
    {
        private readonly IEventNotificationResultService _EventNotificationResultService;
        public EventNotificationResultController(IEventNotificationResultService EventNotificationResultService)
        {
            _EventNotificationResultService = EventNotificationResultService;
        }
        [HttpPost]
        public ActionResult Create(EventNotificationResult EventNotificationResult)
        {
            var response = _EventNotificationResultService.Create(EventNotificationResult);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _EventNotificationResultService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _EventNotificationResultService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_EventNotificationResultService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(EventNotificationResult EventNotificationResult, int id)
        {
            var response = _EventNotificationResultService.Update(EventNotificationResult, id);
            return Ok(response);
        }
    }
}
