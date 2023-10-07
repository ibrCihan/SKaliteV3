using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.General;

namespace SKalite.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitService _UnitService;
        public UnitController(IUnitService UnitService)
        {
            _UnitService = UnitService;
        }
        [HttpPost]
        public ActionResult Create(Unit Unit)
        {
            var response = _UnitService.Create(Unit);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _UnitService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _UnitService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_UnitService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(Unit Unit, int id)
        {
            var response = _UnitService.Update(Unit, id);
            return Ok(response);
        }
    }
}
