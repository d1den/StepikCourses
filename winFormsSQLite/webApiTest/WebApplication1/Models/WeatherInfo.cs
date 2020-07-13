using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class WeatherInfo
    {
        private int count = 1;
        public int Id { get; set; }
        public WeatherInfo()
        {
            Id = count++;
        }
        public int MinTemperature { get; set; }
        public int MaxTemperature { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }

        public TypeWeather Type { get; set; }
    }
}
