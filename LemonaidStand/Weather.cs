using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{
    public class Weather
    {
        Day day = new Day();
        Random random = new Random();
        public List <string> weatherOptions = new List<string> { "Sunny", "Sunny and warm", "Raining", "Raining and chilly", "Foggy and humid", "Foggy and chilly", "Snowy", "Windy", "Tornato", "Partly cloudy" };
        public string todaysWeather;
        public Weather()
        {
        

        }
        public void GetForeCast()
        {            
            int dailyWeatherOptions = random.Next(0, weatherOptions.Count);
            todaysWeather = weatherOptions[dailyWeatherOptions];
            
        }

        



        }
        
    }

