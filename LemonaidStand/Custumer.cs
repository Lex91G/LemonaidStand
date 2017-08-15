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
        Weather weather = new Weather();
        
        
        public Customer()
        {

        }
        public void BestWeather(Weather Weather)
        {
            
            if (Weather.todaysWeather == Weather.weatherOptions[0])
            {
                chanceOfBuying += 30;
                
            }
             else if (Weather.todaysWeather == Weather.weatherOptions[1])
            {
                chanceOfBuying += 40;
                
            }
            else if (Weather.todaysWeather == Weather.weatherOptions[2])
            {
                chanceOfBuying -= 10;
            }

            else if (Weather.todaysWeather == Weather.weatherOptions[3])
            {
                chanceOfBuying -= 20;
            }
            
             else if (Weather.todaysWeather == Weather.weatherOptions[4])
            {
                chanceOfBuying += 20;
            }
             else if (Weather.todaysWeather == Weather.weatherOptions[5])
            {
                chanceOfBuying += 0;
            }
              else if (Weather.todaysWeather == Weather.weatherOptions[6])
            {
                chanceOfBuying -= 30;
            }
              else if (Weather.todaysWeather == Weather.weatherOptions[7])
            {
                chanceOfBuying += 0;
            }
             else if (Weather.todaysWeather == Weather.weatherOptions[8])
            {
                chanceOfBuying -= 50;
            }
              else if (Weather.todaysWeather == Weather.weatherOptions[9])
            {
                chanceOfBuying += 10;
            }



        }
        
        

        } 
    }

