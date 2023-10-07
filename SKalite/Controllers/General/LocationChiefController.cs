using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.General;

namespace SKalite.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationChiefController : ControllerBase
    {
        private readonly ILocationChiefService _LocationChiefService;
        public LocationChiefController(ILocationChiefService LocationChiefService)
        {
            _LocationChiefService = LocationChiefService;
        }
        [HttpPost]
        public ActionResult Create(LocationChief LocationChief)
        {
            var response = _LocationChiefService.Create(LocationChief);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _LocationChiefService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _LocationChiefService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_LocationChiefService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(LocationChief LocationChief, int id)
        {
            var response = _LocationChiefService.Update(LocationChief, id);
            return Ok(response);
        }
    }
}
