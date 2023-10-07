using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.User;

namespace SKalite
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;
        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }
        [HttpPost]
        public ActionResult Create(User User)
        {
            var response = _UserService.Create(User);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _UserService.GetById(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _UserService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_UserService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(User User, int id)
        {
            var response = _UserService.Update(User, id);
            return Ok(response);
        }

    }
}
