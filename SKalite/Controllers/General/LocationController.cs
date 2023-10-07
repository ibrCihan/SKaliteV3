using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.General;

namespace SKalite.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _LocationService;
        public LocationController(ILocationService LocationService)
        {
            _LocationService = LocationService;
        }
        [HttpPost]
        public ActionResult Create(Location Location)
        {
            var response = _LocationService.Create(Location);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _LocationService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _LocationService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_LocationService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(Location Location, int id)
        {
            var response = _LocationService.Update(Location, id);
            return Ok(response);
        }
    }
}
