using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETLIVE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        // https://localhost:7000/api/company
        [Route("")]
        [HttpGet]
        public IActionResult Hell() 
        {
            return Ok(new { message = "Hello .NET" });
        }
    }
}
