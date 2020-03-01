using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Api.Resources;
using UserManagement.Core.Models;
using UserManagement.Core.Services;

namespace UserManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            this._userService = userService;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var users = await _userService.GetAll();
            var userResources = _mapper.Map<IEnumerable<User>, IEnumerable<UserResource>>(users);

            return Ok(userResources);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResource>> GetUserById(int id)
        {
            var user = await _userService.GetById(id);

            var userResource = _mapper.Map<User, UserResource>(user);

            return Ok(userResource);
        }

        [HttpPost("")]
        public async Task<ActionResult<UserResource>> CreateUser([FromBody] UserResource userRequest)
        {
            var userToCreate = _mapper.Map<UserResource, User>(userRequest);

            var newUser = await _userService.Create(userToCreate);

            var user = await _userService.GetById(newUser.Id);

            var userResource = _mapper.Map<User, UserResource>(user);

            return Ok(userResource);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserResource>> UpdateUser(int id, [FromBody] UserResource userRequest)
        {
            var userToBeUpdate = await _userService.GetById(id);

            if (userToBeUpdate == null)
                return NotFound();

            var user = _mapper.Map<UserResource, User>(userRequest);

            await _userService.Update(userToBeUpdate, user);

            var updatedUser = await _userService.GetById(id);
            var updatedUserResource = _mapper.Map<User, UserResource>(updatedUser);

            return Ok(updatedUserResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (id == 0)
                return BadRequest();

            var user = await _userService.GetById(id);

            if (user == null)
                return NotFound();

            await _userService.Delete(user);

            return NoContent();
        }

        [HttpGet]
        [Route("login")]
        public async Task<ActionResult<UserResource>> Login (string email, string password)
        {
            var user = await _userService.GetByEmailAndPassword(email, password);

            if (user == null)
                return NotFound();
            
            var loginUser = await _userService.GetById(user.Id);
            var loginUserResource = _mapper.Map<User, UserResource>(loginUser);

            return Ok(loginUserResource);
        }



    }
}
