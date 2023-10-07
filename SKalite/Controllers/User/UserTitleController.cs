using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKalite.Service.User;

namespace SKalite.Controllers.User
{
    [Route("api/usertitle")]
    [ApiController]
    public class UserTitleController : ControllerBase
    {
        private readonly IUserTitleService _userTitleService;
        public UserTitleController(IUserTitleService userTitleService)
        {
            _userTitleService = userTitleService;
        }
        [HttpPost]
        public ActionResult Create(UserTitle userTitle)
        {
            var response = _userTitleService.Create(userTitle);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = _userTitleService.GetById(id);
            return Ok(response);  
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _userTitleService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id) 
        {
            return Ok(_userTitleService.Delete(id));
        }
        [HttpPut("{id}")]
        public ActionResult Update(UserTitle userTitle,int id) 
        {
            var response = _userTitleService.Update(userTitle, id);
            return Ok(response);
        }
    }
}
