namespace MyHotelApp.Core.Models.Room
{
    public class RoomViewModel
    {
        public int Id { get; set; }

        public int Floor { get; set; }

        public string View { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string ImgUrl { get; set; } = string.Empty;

        public string Price {  get; set; } = string.Empty;
    }
}
