using WEB_Api.Models.HotelDto;

namespace WEB_Api.Data
{
    public static class HotelStore
    {
        public static List<HotelsDTO> HotelList = new List<HotelsDTO> {
      
                new HotelsDTO { Id = 1, Name = "Bunglow" },
                new HotelsDTO { Id = 2, Name = "Villa" }
        };
    }
}
