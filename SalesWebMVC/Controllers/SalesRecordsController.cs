using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController(SalesRecordService salesRecordService) : Controller
    {
        private readonly SalesRecordService _salesRecordService = salesRecordService;
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateOnly? minDate, DateOnly? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateOnly(DateTime.Now.Year, 1, 1);
            }

            DateTime dateTime = DateTime.Now;

            if (!maxDate.HasValue)
            {
                maxDate = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateOnly? minDate, DateOnly? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateOnly(DateTime.Now.Year, 1, 1);
            }

            DateTime dateTime = DateTime.Now;

            if (!maxDate.HasValue)
            {
                maxDate = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }
    }
}
