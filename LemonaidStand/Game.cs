using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{
    public class Game
    {


        Customer customer = new Customer();
        Player player;
        Weather weather = new Weather();
        Store store;
        Day day = new Day();

        public Game()
        { player = new Player();
        weather = new Weather();
        store = new Store(player);

        }

        public void StartDay()
        {
            


        }
        public void Display()
        {
            Console.WriteLine("The Lemonaid stand \nThe point of the game is to buy as limited lemons sugar and cups as you need. But just enough to finish up a days work of selling lemonaid. After 7 days that will be it. Try getting the highest income and make the most money.");
            Console.ReadLine();
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine("Cups: " + player.backpack.cup.Count + "\nIce: " + player.backpack.ice.Count + "\nLemons: " + player.backpack.lemons.Count + "\nSugar(cups): " + player.backpack.sugar.Count + "\nCash: " + player.backpack.money);
            Console.ReadLine();
        }
        public void Mainmenu(Player player)
        {
            
            Console.WriteLine("Would you like to  buy items before you leave for the day? \n1 = Go to store \n2 = Get down to business");
            string MainMenuQuestion = Console.ReadLine();
            if (MainMenuQuestion == "1")
            {
                store.BuyProducts(player);
            }
            else if(MainMenuQuestion == "2")
            {
                ChoosingWhichRecipe(player);
            }
            else
            {
                Console.WriteLine("Sorry invalid answer. Try again");
                Console.ReadLine();
                Mainmenu(player);
            }
        }
        public void ChoosingWhichRecipe(Player player)
        {
            Console.WriteLine("Pick a recipe to make for the day \n1 = Create Your Own \n2 = Summer Day Lemonaid\n3 = The Peoples Champ Lemondaid \n4 = Lemony Lemonaid \n5 = Strong Burst Lemonaid \n6 = On A Budget Lemonaid \n7 = Main Menu ");
            int numberOfRecipe = int.Parse(Console.ReadLine());
            switch (numberOfRecipe)
            {
                case 1:
                    Recipe recipe1 = new Recipe();
                    recipe1.CreateYourOwnRecipe(player);
                    break;

                case 2:
                    Recipe recipe2 = new Recipe();
                    recipe2.CreateBestRecipe(player);
                    break;

                case 3:
                    Recipe recipe3 = new Recipe();
                    recipe3.CreateSecondBest(player);
                    
                    break;

                case 4:
                    Recipe recipe4 = new Recipe();
                    recipe4.CreateLemonRecipe(player);
                    break;

                case 5:
                    Recipe recipe5 = new Recipe();
                    recipe5.CreateSugarLemonaid(player);
                    break;
                case 6:
                    Recipe recipe6 = new Recipe();
                    recipe6.CreateCheapRecipe(player);
                    break;
                case 7:
                    Mainmenu(player);
                    break;
                default:
                    Console.WriteLine("Invalid answer please try again");
                    Console.ReadLine();
                    ChoosingWhichRecipe(player);
                    return;
            }
        }
        public void HowMuchPerCup()
        {
            Console.WriteLine("How much for a cup of lemonaid");
            double answerForPerCup = double.Parse(Console.ReadLine());
            if (answerForPerCup <= .25)
            {
                Customer.chanceOfBuying += 15;
            }
            else if (answerForPerCup > .25 && answerForPerCup <= .50)
            {
                Customer.chanceOfBuying += 10;
            }
            else if (answerForPerCup > .50 && answerForPerCup <= .75)
            {
                Customer.chanceOfBuying += 5;
            }
            else if (answerForPerCup > .75 && answerForPerCup <= 1.25)
            {
                Customer.chanceOfBuying += 0;
            }
            else if (answerForPerCup > 1.25 && answerForPerCup <= 1.50)
            {
                Customer.chanceOfBuying -= 5;
            }
            else if (answerForPerCup > 1.50 && answerForPerCup <= 1.75)
            {
                Customer.chanceOfBuying -= 10;
            }
            else if (answerForPerCup > 1.75 && answerForPerCup <= 2)
            {
                Customer.chanceOfBuying -= 15;
            }
            else if (answerForPerCup > 2 && answerForPerCup <= 2.25)
            {
                Customer.chanceOfBuying -= 20;
            }
            else if (answerForPerCup > 2.25 && answerForPerCup <= 2.50)
            {
                Customer.chanceOfBuying -= 25;
            }
            else if (answerForPerCup > 2.50 && answerForPerCup <= 2.75)
            {
                Customer.chanceOfBuying -= 30;
            }
            else if (answerForPerCup > 2.75 && answerForPerCup <= 3)
            {
                Customer.chanceOfBuying -= 35;
            }
            else if (answerForPerCup > 3)
            {
                Customer.chanceOfBuying -= 40;
            }



        }

        public void RunGame()
        {
            Display();

            //the below will probably be in a loop
            DisplayInventory(player);
            weather.GetForeCast();
            Console.WriteLine("Todays weather is: ");
            Console.WriteLine(Weather.todaysWeather);
            Console.ReadLine();
            Mainmenu(player);
            
            customer.BestWeather(weather);
            day.DetermineHowManyPeople(weather);
            HowMuchPerCup();
            day.SetALimitToBuy();
            day.runLoop();
            Console.WriteLine(customer. CupsSold);
            Console.ReadLine();
            

        }
        
        
         
        
    }
}
