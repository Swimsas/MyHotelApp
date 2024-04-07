namespace MyHotelApp.Core.Constants
{
    public static class ErrorMessages
    {
        public const string DateErrorMessage = "Start date must be today or in present and before leaving date.";
        public const string DateFormatErrorMessage = "The date format must be YYYY-MM-DD.";

        public const string RequiredField = "The field {0} is required.";

        public const string MinMaxLength = "The field {0} length must be between {2} and {1}.";

        public const string RangeNumbers = "The field {0} must be a number between {2} and {1}.";
    }
}
