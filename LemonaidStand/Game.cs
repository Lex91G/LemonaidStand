﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{
    public class Game
    {
        
        Customer customer;

        Player player;
        Weather weather;
        Store store;

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
            Console.WriteLine("The Lemonaid stand \n The point of the game is to buy as limited lemons sugar and cups as you need. But just enough to finish up a days work of selling lemonaid. After 7 days that will be it. Try getting the highest income and make the most money.");
            Console.ReadLine();
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine("Cups: " + player.backpack.cup + "\n Ice: " + player.backpack.ice + "\n Lemons: " + player.backpack.lemons + "\n Sugar(cups): " + player.backpack.sugar + "\n Cash: " + player.backpack.money);
            Console.ReadLine();
        }
        public void Mainmenu()
        {
            Console.WriteLine("Would you like to  buy items before you leave for the day? \n 1 = Go to store \n 2 = Get down to business");
            string MainMenuQuestion = Console.ReadLine();
            if (MainMenuQuestion == "1") {
                store.BuyProducts(player);
            }
            else if(MainMenuQuestion == "2")
            {
                // run day
            }
            else
            {
                Console.WriteLine("Sorry invalid answer. Try again");
                Console.ReadLine();
                Mainmenu();
            }
        }
        public void ChoosingWhichRecipe()
        {
            Console.WriteLine("Pick a recipe to make for the day ");
            int numberOfRecipe = int.Parse(Console.ReadLine());
            switch (numberOfRecipe)
            {
                case 1:
                    player.recipe.CreateYourOwnRecipe();
                    break;

                case 2:
                    player.recipe.CreateBestRecipe();
                    break;

                case 3:
                    player.recipe.CreateSecondBest();
                    break;

                case 4:
                    player.recipe.CreateLemonRecipe();
                    break;

                case 5:
                    player.recipe.CreateSugarLemonaid();
                    break;
                case 6:
                    player.recipe.CreateCheapRecipe();
                    break;
                case 7:
                    //Main menu
                    break;
                default:
                    Console.WriteLine("Invalid answer please try again");
                    Console.ReadLine();
                    ChoosingWhichRecipe();
                    return;
            }
        }
        public void HowMuchPerCup()
        {
            Console.WriteLine("How much for a cup of lemonaid");
            double answerForPerCup = double.Parse(Console.ReadLine());
            if (answerForPerCup >= .25)
            {
                customer.chanceOfBuying += 15/100;
            }
            else if (answerForPerCup < .25 && answerForPerCup >= .50)
            {
                customer.chanceOfBuying += 10/100;
            }
            else if (answerForPerCup < .50 && answerForPerCup >= .75)
            {
                customer.chanceOfBuying += 5/100;
            }
            else if (answerForPerCup < .75 && answerForPerCup >= 1.25)
            {
                customer.chanceOfBuying += 0/100;
            }
            else if (answerForPerCup < 1.25 && answerForPerCup >= 1.50)
            {
                customer.chanceOfBuying -= 5/100;
            }
            else if (answerForPerCup < 1.50 && answerForPerCup >= 1.75)
            {
                customer.chanceOfBuying -= 10 / 100;
            }
            else if (answerForPerCup < 1.75 && answerForPerCup >= 2)
            {
                customer.chanceOfBuying -= 15 / 100;
            }
            else if (answerForPerCup < 2 && answerForPerCup >= 2.25)
            {
                customer.chanceOfBuying -= 20 / 100;
            }
            else if (answerForPerCup < 2.25 && answerForPerCup >= 2.50)
            {
                customer.chanceOfBuying -= 25 / 100;
            }
            else if (answerForPerCup < 2.50 && answerForPerCup >= 2.75)
            {
                customer.chanceOfBuying -= 30 / 100;
            }
            else if (answerForPerCup < 2.75 && answerForPerCup >= 3)
            {
                customer.chanceOfBuying -= 35 / 100;
            }
            else if (answerForPerCup > 3)
            {
                customer.chanceOfBuying -= 40 / 100;
            }



        }

        public void RunGame()
        {
            Display();

            // the below will probably be in a loop
            DisplayInventory(player);
            Mainmenu();
        }
        
        
         
        
    }
}
