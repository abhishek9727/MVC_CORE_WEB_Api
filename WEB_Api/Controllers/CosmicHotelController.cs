using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_Api.Data;
using WEB_Api.Models;
using WEB_Api.Models.HotelDto;

namespace WEB_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmicHotelController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<HotelsDTO>> GetHotels()
        {
            return Ok(HotelStore.HotelList);


        }

        [HttpGet]
        [Route("{id:int}",Name = "GetHotels")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<HotelsDTO> GetHotelsById(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }
            var hotel = HotelStore.HotelList.FirstOrDefault(u => u.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);

            
            


        }

        [HttpPost]
        public ActionResult<HotelsDTO> CreateCatlog(HotelsDTO dto)
        {
            if (dto == null)
            {
                return BadRequest(dto);
            }
            if (dto.Id > 0)
            {
                return BadRequest();
            }
            dto.Id = HotelStore.HotelList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1; //This will create youre Id and incremente with new single id 
            HotelStore.HotelList.Add(dto);

            //return CreatedAtRoute("GetHotels",new {id = dto.Id}, dto);
            return Ok(dto);

        }
    }
}
