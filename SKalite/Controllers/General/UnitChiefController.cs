using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.General;

namespace SKalite.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitChiefController : ControllerBase
    {
        private readonly IUnitChiefService _UnitChiefService;
        public UnitChiefController(IUnitChiefService UnitChiefService)
        {
            _UnitChiefService = UnitChiefService;
        }
        [HttpPost]
        public ActionResult Create(UnitChief UnitChief)
        {
            var response = _UnitChiefService.Create(UnitChief);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _UnitChiefService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _UnitChiefService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_UnitChiefService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(UnitChief UnitChief, int id)
        {
            var response = _UnitChiefService.Update(UnitChief, id);
            return Ok(response);
        }
    }
}
