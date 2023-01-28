using AmirCalendar;
using CalenderWebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nager.Date;
using PersianTools.Core;
using System.Globalization;

namespace CalenderWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult>GetMonth(CalendarDto request)
        {
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                //DateTime s = new DateTime();
                var monthLenght = persianCalendar.GetDaysInMonth(request.Year,request.Month);
                //var publicHolidays = s.GetPublicHoliday(2018, CountryCode.DE);
                //var date = new DateTime(2023, 01, 25);
                //var aaaaas = DateSystem.IsPublicHoliday(date, CountryCode.IR);
                var a = new PersianDateTime(1401,12,13);
                //PersianDateTime persianDateTime2 = new PersianDateTime("1401");
             var aaasadsad= a.IsHoliDay;
                //var startDate = 1401;
                //var endDate = 1402;
                string[] results ;
                //string[] terms = new string[400];
                List<CalendarHolidayDto> calendar = new List<CalendarHolidayDto>();
                List<bool> calendarr = new List<bool>();
                //calendar.Day
                for (int i = 1; i < monthLenght; i++)
                {
                    var day = new PersianDateTime(request.Year, request.Month, i);
                    var aaa = day.IsHoliDay;
                    calendarr.Add(aaa);
                    calendar.Add(new CalendarHolidayDto
                    {
                        Day = day.Day,
                        IsHoliday = aaa
                    });
                    //results[i] = aaa.ToString();
                    //var aaa = day.IsHoliDay;
                    //result = aaa;
                }

                //calendar.Add(new CalendarHolidayDto
                //{
                //    Day = 
                //}
                var aaaa = calendarr;
                var aasdsadsaaaa = calendar;
                //foreach (var day in a)
                //{
                //    startDate = day.Date;
                //}


                //if (startDate > endDate)
                //{
                //    PersianDateTime persianDateTime = startDate;
                //    startDate = endDate;
                //    endDate = persianDateTime;
                //}


                //PersianDateTime persianDateTime2 = new PersianDateTime(startDate);
                //int num = 0;
                //for (; persianDateTime2 <= endDate; ++persianDateTime2)
                //{
                //    if (!persianDateTime2.IsHoliDay && (persianDateTime2.DateTime.DayOfWeek != DayOfWeek.Thursday || includeThursdays))
                //    {
                //        num++;
                //    }
                //}

                //return num;




                //a.IsHoliDay();

                //var cccasdaasasd = persianCalendar.GetDaysInMonth(1401, 11);
                //var persianDate6 = new PersianDateTime(DateTime.Now.Year); // 6
                //var result = PersianDateExtensions.GetContinuousHolidays(1401, 3);
                //var result2132 = PersianDateExtensions.GetContinuousHolidays(1401, 1);
                //var result123 = PersianDateExtensions.GetContinuousHolidays(1401, 2);
                //var result121233 = PersianDateExtensions.GetContinuousHolidays(1401, 0);
                //var resul213t = PersianDateExtensions.GetContinuousHolidays(1401,12);
                //var resul1t = PersianDateExtensions.GetContinuousHolidays(1402, 4);
                //var resul12t = PersianDateExtensions.GetContinuousHolidays(1401, 5);
                //var resul11232t = PersianDateExtensions.GetContinuousHolidays(1401, 6);
                //var resul1123212t = PersianDateExtensions.GetContinuousHolidays(1401, 7);
                //var resul1231212t = PersianDateExtensions.GetContinuousHolidays(1401, 8);
                //var resul31231212t = PersianDateExtensions.GetContinuousHolidays(1401, 9);
                //var resul31212t = PersianDateExtensions.GetContinuousHolidays(1401, 10);
                //var resul21312312t = PersianDateExtensions.GetContinuousHolidays(1401, 11);


                var dt1 = new PersianDateTime("1401/06/13").GetDateInformation();
                var dt2 = new PersianDateTime("1401/08/13").GetDateInformation();
                //var dt1231 = new PersianDateTime(persianDate6).GetDateInformation();
                var dt12131 = new PersianDateTime("1402/01/13").GetDateInformation();

                //var isHoliday = FarsiDateHelper.IsHolidayFarsiDate("1401/11/06") ? "تعطیل" : "غیر تعطیل";

                //    var aaaaa = persianCalendar.geth
                //persianCalendar.holi
                return Ok(aaaa);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           

        }




    }
}
