using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{
    public class Player
    {
        public Inventory backpack = new Inventory();
        public Recipe recipe;
        public Player()
        {

        }

        public void ChooseRecipe()
        {
            Console.WriteLine("What recipe would you like to use for today?");
            string pickRecipe = Console.ReadLine();
            switch (pickRecipe)
            {

                // console.wrtie line CHOOSE A RECIPE
                // string userRecipe = Console.ReadLine();
                case "1":
                    recipe = recipe.CreateBestRecipe();
                    for (int i = 0; i < recipe.cups; i++)
                    {
                        backpack.cup.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.ice; i++)
                    {
                        backpack.ice.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.lemons; i++)
                    {
                        backpack.lemons.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.sugar; i++)
                    {
                        backpack.sugar.RemoveAt(i);
                    }
                    break;
                case "2":
                    recipe = recipe.CreateSecondBest();
                    for (int i = 0; i < recipe.cups; i++)
                    {
                        backpack.cup.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.ice; i++)
                    {
                        backpack.ice.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.lemons; i++)
                    {
                        backpack.lemons.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.sugar; i++)
                    {
                        backpack.sugar.RemoveAt(i);
                    }
                    break;
                case "3":
                    recipe = recipe.CreateSugarLemonaid();
                    for (int i = 0; i < recipe.cups; i++)
                    {
                        backpack.cup.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.ice; i++)
                    {
                        backpack.ice.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.lemons; i++)
                    {
                        backpack.lemons.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.sugar; i++)
                    {
                        backpack.sugar.RemoveAt(i);
                    }
                    break;
                case "4":
                    recipe = recipe.CreateSugarLemonaid();
                    for (int i = 0; i < recipe.cups; i++)
                    {
                        backpack.cup.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.ice; i++)
                    {
                        backpack.ice.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.lemons; i++)
                    {
                        backpack.lemons.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.sugar; i++)
                    {
                        backpack.sugar.RemoveAt(i);
                    }
                    break;
                case "5":
                    recipe = recipe.CreateLemonRecipe();
                    for (int i = 0; i < recipe.cups; i++)
                    {
                        backpack.cup.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.ice; i++)
                    {
                        backpack.ice.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.lemons; i++)
                    {
                        backpack.lemons.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.sugar; i++)
                    {
                        backpack.sugar.RemoveAt(i);
                    }
                    break;
                case "6":
                    recipe = recipe.CreateCheapRecipe();
                    for (int i = 0; i < recipe.cups; i++)
                    {
                        backpack.cup.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.ice; i++)
                    {
                        backpack.ice.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.lemons; i++)
                    {
                        backpack.lemons.RemoveAt(i);
                    }
                    for (int i = 0; i < recipe.sugar; i++)
                    {
                        backpack.sugar.RemoveAt(i);
                    }
                    break;
                case "7":
                    //mainmenu
                    break;
                default:
                    Console.WriteLine("Invalid answer, please try again");
                    Console.ReadLine();
                    ChooseRecipe();
                    return;
            }
        }

        void PaymentForLemonaid()
        {
            Console.WriteLine("How much does the lemonaid");
            double howMuchPay = double.Parse(Console.ReadLine());
            // howMuchPay -= backpack.cup;
        }
    }
}


    

