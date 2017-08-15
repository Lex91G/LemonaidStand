using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{
    
    public class Customer
    {
        public int CupsSold;
        public Day day = new Day();
        public static int chanceOfBuying;
        
        
        public Customer()
        {

        }
        public void BestWeather(Weather weather);
        {
            day.DetermineHowManyPeople(weather);
            if (Weather.todaysWeather == weather.weatherOptions[0])
            {
                chanceOfBuying += 30 / 100;
                
            }
             else if (Weather.todaysWeather == weather.weatherOptions[1])
            {
                chanceOfBuying += 40 / 100;
                
            }
            else if (Weather.todaysWeather == weather.weatherOptions[2])
            {
                chanceOfBuying -= 10/100;
            }

            else if (Weather.todaysWeather == weather.weatherOptions[3])
            {
                chanceOfBuying -= 20/100;
            }
            
             else if (Weather.todaysWeather == weather.weatherOptions[4])
            {
                chanceOfBuying += 20/100;
            }
             else if (Weather.todaysWeather == weather.weatherOptions[5])
            {
                chanceOfBuying += 0/100;
            }
              else if (Weather.todaysWeather == weather.weatherOptions[6])
            {
                chanceOfBuying -= 30/100;
            }
              else if (Weather.todaysWeather == weather.weatherOptions[7])
            {
                chanceOfBuying += 0/100;
            }
             else if (Weather.todaysWeather == weather.weatherOptions[8])
            {
                chanceOfBuying -= 50/100;
            }
              else if (Weather.todaysWeather == weather.weatherOptions[9])
            {
                chanceOfBuying += 10/100;
            }



        }
        
        

        } 
    }

