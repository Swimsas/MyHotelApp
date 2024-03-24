using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static MyHotelApp.Core.Constants.ErrorMessages;

namespace MyHotelApp.Core.Models.Room
{
    public class BookRoomSearchModel
    {
        public int RoomsPerPage { get; } = 3;

        public int CurrentPage { get; set; } = 1;

        public int TotalRoomsCount { get; set; }

        [DisplayName("Room view")]
        public IEnumerable<ViewsCategoryModel> ViewsCategoryModels { get; set; } = new List<ViewsCategoryModel>();

        [DisplayName("Room type")]
        public IEnumerable<RoomTypeCategoryModel> RoomTypesCategoryModels { get; set; } = new List<RoomTypeCategoryModel>();

        public int Sorting {  get; set; }

        public int ViewType { get; set; }

        public int RoomType { get; set; }

        public IEnumerable<RoomViewModel> RoomViewModels { get; set; } = new List<RoomViewModel>();

        [DisplayName("Date of arriving")]
        [RegularExpression(@"[1-9][0-9][0-9]{2}-([0][1-9]|[1][0-2])-([1-2][0-9]|[0][1-9]|[3][0-1])", ErrorMessage = DateFormatErrorMessage)]
        public string StartDate { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");

        [DisplayName("Date of leaving")]
        [RegularExpression(@"[1-9][0-9][0-9]{2}-([0][1-9]|[1][0-2])-([1-2][0-9]|[0][1-9]|[3][0-1])", ErrorMessage = DateFormatErrorMessage)]
        public string LeaveDate { get; set; } = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

        public bool IsFirstLoad { get; set; } = true;
    }
}
