using APICloud.DTOs;
using APICloud.Interfaces;
using APICloud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace APICloud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost("register")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Register([FromBody] RegisterDTO newUserDto)
        {
            if (newUserDto == null)
            {
                return BadRequest(ModelState);
            }

            var user = new User
            {
                Username = newUserDto.Username,
                Email = newUserDto.Email,
                Password = newUserDto.Password
            };

            if (!await _accountRepository.AddUser(user))
            {
                throw new Exception("Process interrupted! Couldn't add user");
            }

            return Ok(user);
        }

       

    }
}