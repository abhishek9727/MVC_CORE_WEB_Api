using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_Api.Models;

namespace WEB_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmicHotelController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel { Id = 1, Name = "Bunglow" },
                new Hotel { Id = 2, Name = "Villa" }
            };
        }
    }
}
