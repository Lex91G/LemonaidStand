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
        Customer custumer;
        public void day()
        {

        }   // call function to set howManyPeople
        public void DetermineHowManyPeople(Weather Weather)
        {
            
            if (Weather.todaysWeather == "Sunny")
            {
                
                howManyPeople = 140;

            }
            else if (Weather.todaysWeather == "Sunny and warm")
            {
                howManyPeople = 150;
            }
            else if (Weather.todaysWeather == "Raining")
            {
                howManyPeople = 80;
            }
            else if (Weather.todaysWeather == "Raining and chilly")
            {
                howManyPeople = 60;
            }
            else if (Weather.todaysWeather == "Foggy and humid")
            {
                howManyPeople = 100;
            }
            else if (Weather.todaysWeather == "Foggy and chilly")
            {
                howManyPeople = 70;
            }
            else if (Weather.todaysWeather == "Snowy")
            {
                howManyPeople = 30;
            }
            else if (Weather. todaysWeather == "Windy")
            {
                howManyPeople = 90;
            }
            else if (Weather.todaysWeather == "Tornato")
            {
                howManyPeople = 3;
            }
            else if (Weather.todaysWeather == "Parlty cloudy")
            {
                howManyPeople = 125;
            }

        }
        public void SetALimitToBuy()
        {
            
            Customer.chanceOfBuying += 40;
            if(Customer.chanceOfBuying > 100)
            {
                Customer.chanceOfBuying = 100;
            }
            else if(Customer.chanceOfBuying < 0)
            {
                Customer.chanceOfBuying = 0;
            }
        }
        public void runLoop()
        {
            for (int i = 0; i <= howManyPeople; i++)
            {
                Customer customer = new Customer();
                Game game = new Game();
               
                Customer.chanceOfBuying = random.Next(1, 100);
                if (Customer.chanceOfBuying > 50)
                {
                    
                    customer.CupsSold++;

                }

                else
                {

                }
               
                custumers.Add(customer);
            }
        } 
    }
}
