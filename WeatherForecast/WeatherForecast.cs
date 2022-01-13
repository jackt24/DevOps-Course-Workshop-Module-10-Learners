using System;
using Microsoft.AspNetCore.Authorization;



namespace webapi
{
    [Authorize(Policy = "ApplicationPolicy")]
    public class WeatherForecast
    {
    
        public DateTime Date { get; set; }

        public int Temperature { get; set; }

        public string Summary { get; set; }
    }

    
}
