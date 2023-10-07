using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.General;

namespace SKalite.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimePeriodController : ControllerBase
    {
        private readonly ITimePeriodService _TimePeriodService;
        public TimePeriodController(ITimePeriodService TimePeriodService)
        {
            _TimePeriodService = TimePeriodService;
        }
        [HttpPost]
        public ActionResult Create(TimePeriod TimePeriod)
        {
            var response = _TimePeriodService.Create(TimePeriod);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _TimePeriodService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _TimePeriodService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_TimePeriodService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(TimePeriod TimePeriod, int id)
        {
            var response = _TimePeriodService.Update(TimePeriod, id);
            return Ok(response);
        }
    }
}
