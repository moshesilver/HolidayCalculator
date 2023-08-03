using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolidayCalculator;

namespace OffDayCalcWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<String> Result { get; private set; } = new List<String>();

        public void OnPost()
        {
            string userInput = Request.Form["userInput"];

            int number;
            if (int.TryParse(userInput, out number))
            {
                OffDayCalculator holidayCalculator = new(number);
                List<DateTime> holidayOffDays = holidayCalculator.CalculateHolidayOffDays();
                int i = 0;
                foreach (DateTime offDay in holidayOffDays)
                {
                    Result.Add($"{holidayCalculator.holidayNames[i]}: {offDay.ToShortDateString()}");
                    i++;
                }
                
            }
            else
            {
                //Result = "Invalid input. Please enter a valid number.";
            }
        }
    }
}