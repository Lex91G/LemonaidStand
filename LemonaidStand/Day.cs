using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{

    public class Day
    {
        public List<Customer> custumers = new List<Customer> { };
        static int howManyPeople;
        public Weather weather = new Weather();
        Random random = new Random();
        public void day()
        {

        }   // call function to set howManyPeople
        public void DetermineHowManyPeople(Weather todaysWeather)
        {
            if (weather.todaysWeather == "Sunny")
            {
                howManyPeople = 140;

            }
            else if (weather.todaysWeather == "Sunny and warm")
            {
                howManyPeople = 150;
            }
            else if (weather.todaysWeather == "Raining")
            {
                howManyPeople = 80;
            }
            else if (weather.todaysWeather == "Raining and chilly")
            {
                howManyPeople = 60;
            }
            else if (weather.todaysWeather == "Foggy and humid")
            {
                howManyPeople = 100;
            }
            else if (weather.todaysWeather == "Foggy and chilly")
            {
                howManyPeople = 70;
            }
            else if (weather.todaysWeather == "Snowy")
            {
                howManyPeople = 30;
            }
            else if (weather. todaysWeather == "Windy")
            {
                howManyPeople = 90;
            }
            else if (weather.todaysWeather == "Tornato")
            {
                howManyPeople = 3;
            }
            else if (weather.todaysWeather == "Parlty cloudy")
            {
                howManyPeople = 125;
            }

        }
        public void runLoop()
        {
            for (int i = 0; i <= howManyPeople; i++)
            {
                Customer customer = new Customer();
                customer.chanceOfBuying += 40;
                int sexyMoms = random.Next(1, 100);
                if (sexyMoms > 50)
                   customer.CupsSold ++;
                else
                {

                }
                custumers.Add(customer);
            }
        } 
    }
}
