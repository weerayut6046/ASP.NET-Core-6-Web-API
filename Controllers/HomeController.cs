using ASPNETLIVE.Services.ThaiDate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETLIVE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IThaiDate _thaiDate;
        public HomeController(IThaiDate thaiDate) // inject เข้ามาใช้งาน
        { 
            _thaiDate = thaiDate;
        }
        [HttpGet]
        public IActionResult Get() 
        {
            var myThaiDate = _thaiDate.ShowThaiDate();
            return Ok(new { message = $"วันที่ปัจจุบัน {myThaiDate}" });
        }
    }
}
