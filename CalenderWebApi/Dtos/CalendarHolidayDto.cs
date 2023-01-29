namespace CalenderWebApi.Dtos
{
    public class CalendarHolidayDto
    {
        public int Day { get; set; }
        public string DayOfTheWeek { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public bool IsHoliday { get; set; }
        //public string Type { get; set; }
    }
}
