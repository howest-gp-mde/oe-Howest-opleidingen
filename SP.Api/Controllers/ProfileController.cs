using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SP.Api.Data;
using SP.Api.DTO;
using SP.Api.Entities;
using System.Security.Claims;

namespace SP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize ]
    public class ProfileController : ControllerBase
    {
        SPContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileController(SPContext context, UserManager<ApplicationUser> userManager) 
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get()
        {
            var user = GetUser();

            return Ok(new ProfileResponseDTO
            {
                Email = user.Email,
                NumberOfCertificates = user.NumberOfCertificates,
                ReceiveWeeklyStats = user.ReceiveWeeklyStats,
                UserName = user.UserName
            });
        }


        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> PutAsync(UpdateProfileRequestDTO model)
        {
            var user = GetUser();

            if (ModelState.IsValid)
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.ReceiveWeeklyStats = model.ReceiveWeeklyStats;
                user.NumberOfCertificates = model.NumberOfCertificates;

                try
                {
                    await _context.SaveChangesAsync();
                    return Ok(new ProfileResponseDTO
                    {
                        Email = user.Email,
                        NumberOfCertificates = user.NumberOfCertificates,
                        ReceiveWeeklyStats = user.ReceiveWeeklyStats,
                        UserName = user.UserName
                    });
                }
            }

            // TODO: map errors in response
            return BadRequest("Model errors ");
        }

        private ApplicationUser GetUser()
        {
            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.Name)?.Value;

            return _context.Users.Find(userId);
        }

    }
}
