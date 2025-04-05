using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_Api.Models;
using WEB_Api.Models.HotelDto;

namespace WEB_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmicHotelController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<HotelsDTO> GetHotels()
        {
            return new List<HotelsDTO>
            {
                new HotelsDTO { Id = 1, Name = "Bunglow" },
                new HotelsDTO { Id = 2, Name = "Villa" }
            };


        }
    }
}
