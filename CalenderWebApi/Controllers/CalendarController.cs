using AmirCalendar;
using CalenderWebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nager.Date;
using PersianTools.Core;
using System.Globalization;

namespace CalenderWebApi.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class CalendarController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult>GetAllDayslnMonth(CalendarDto request)
        {
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                var monthLenght = persianCalendar.GetDaysInMonth(request.Year, request.Month);
                List<CalendarHolidayDto> daysList = new List<CalendarHolidayDto>();
                List<bool> HolidaysList = new List<bool>();
                for (int i = 1; i <= monthLenght; i++)
                {
                    var day = new PersianDateTime(request.Year, request.Month, i);
                    var holiday = day.IsHoliDay;
                    HolidaysList.Add(holiday);
                    daysList.Add(new CalendarHolidayDto
                    {
                        DayOfTheWeek = day.DayOfWeek,
                        Day = day.Day,
                        IsHoliday = holiday,
                         Month = day.MonthOfYear,
                        Year = day.Year
                    });
                }
                return Ok(daysList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async  Task<IActionResult> GetHolidaysInMonth(CalendarDto request)
        {
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                var monthLenght = persianCalendar.GetDaysInMonth(request.Year, request.Month);
                List<CalendarHolidayDto> daysList = new List<CalendarHolidayDto>();
                List<bool> HolidaysList = new List<bool>();
                for (int i = 1; i < monthLenght; i++)
                {
                    var day = new PersianDateTime(request.Year, request.Month, i);
                    var holiday = day.IsHoliDay;
                    if(holiday)
                    {
                        HolidaysList.Add(holiday);
                        daysList.Add(new CalendarHolidayDto
                        {
                            Day = day.Day,
                            IsHoliday = holiday
                        });
                    }
                }
                return Ok(daysList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }





    }
}
