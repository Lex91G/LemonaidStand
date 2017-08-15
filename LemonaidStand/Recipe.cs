using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{
    public class Recipe
    {
        Customer customer;
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        Player player;
        



        public Recipe()
        {

        }

        //public void HowmanyCups()
        //{
        //    Console.WriteLine("Cups:");
        //    public string cupCount = Console.ReadLine();
        //    cupCount-=Inventory;
        //}
        //public void HowMuchIce()
        //{
        //    Console.WriteLine("Ice Cubes:");
        //    public string iceCount = Console.ReadLine();
        //    iceCount -=Inventory
        //}
        //public void HowManyLemons()
        //{
        //    Console.WriteLine("Lemons:");
        //    public string lemonCount = Console.ReadLine();
        //    lemonCount -=Inventory
        //}
        //public v0oid HowMuchSugar()
        //{   
        //    Console.WriteLine("Cups of sugar:");
        //    public string sugarCount = Console.ReadLine();
        //    sugarCount -=
        //}



        public Recipe CreateBestRecipe(Player player)
        {
            Recipe bestRecipe = new Recipe();
            player.backpack.lemons.RemoveRange(1, 4);
            player.backpack.sugar.RemoveRange(1, 4);
            player.backpack.ice.RemoveRange(1, 5);
            player.backpack.cup.RemoveRange(1, 1);
            Customer.chanceOfBuying =+ 10;
            return bestRecipe;
        }
        public Recipe CreateSecondBest(Player player)
        {
            Recipe secondBest = new Recipe();
            player.backpack.lemons.RemoveRange(1,4);
            player.backpack.sugar.RemoveRange(1, 3);
            player.backpack.ice.RemoveRange(1, 7);
            player.backpack.cup.RemoveRange(1, 1); 
            Customer.chanceOfBuying =+ 8;
            return secondBest;
            
        }
        
        public Recipe CreateSugarLemonaid(Player player)
        {
            Recipe sugarRecipe = new Recipe();
            player.backpack.lemons.RemoveRange(1, 3);
            player.backpack.sugar.RemoveRange(1,5);
            player.backpack.ice.RemoveRange(1, 3);
            player.backpack.cup.RemoveRange(1, 1);
            Customer.chanceOfBuying = 7;

            return sugarRecipe;
        }
        public Recipe CreateLemonRecipe(Player player)
        {
            Recipe lemonRecipe = new Recipe();
            player.backpack.lemons.RemoveRange(1,5);
            player.backpack.sugar.RemoveRange(1, 4);
            player.backpack.ice.RemoveRange(1, 4);
            player.backpack.cup.RemoveRange(1, 1);
            Customer.chanceOfBuying += 5;
            return lemonRecipe;
        }
        public Recipe CreateCheapRecipe(Player player)
        {
            Recipe cheapRecipe = new Recipe();
            player.backpack.lemons.RemoveRange(1, 1);
            player.backpack.sugar.RemoveRange(1, 1);
            player.backpack.ice.RemoveRange(1, 1);
            player.backpack.cup.RemoveRange(1, 1);
            Customer.chanceOfBuying -= 5;
            return cheapRecipe;
        }
        public Recipe CreateYourOwnRecipe(Player player)
        {
            Recipe createYourOwn = new Recipe();
            Console.WriteLine("How many lemons: ");
            int creatingLemons = int.Parse(Console.ReadLine());
            player.backpack.cup.RemoveRange(1, creatingLemons);
            IfElseLemonLikelyness();


            Console.WriteLine("How many cups of sugar: ");
            int creatingSugar = int.Parse(Console.ReadLine());
            player.backpack.cup.RemoveRange(1, creatingSugar);
            IfElseSugarLikelyNess();

            Console.WriteLine("How many ice Cubes: ");
            int creatingice = int.Parse(Console.ReadLine());
            player.backpack.cup.RemoveRange(1, creatingice);
            IfElseIceLikelyNess();

            createYourOwn.cups = 1;
            return createYourOwn;
        }
        public void IfElseLemonLikelyness()
        {
            Recipe currentRecipe = CreateYourOwnRecipe(player);

            if (currentRecipe.lemons > 5 || currentRecipe.lemons < 4)
            {
                Customer.chanceOfBuying -= 3;
            }
            else if(currentRecipe.lemons <= 6 || currentRecipe.lemons >= 4)
             {
                Customer.chanceOfBuying += 3;
             }
        }
        public void IfElseSugarLikelyNess()
        {
            Recipe currentRecipe = CreateYourOwnRecipe(player);
            if (currentRecipe.ice >= 7 || currentRecipe.ice <= 4)
            {
                Customer.chanceOfBuying -= 3;
            }
            else if(currentRecipe.ice >= 7 || currentRecipe.ice <= 4)
             {

                Customer.chanceOfBuying += 3;
            }
        }
        public void IfElseIceLikelyNess()
        {
            Recipe currentRecipe = CreateYourOwnRecipe(player);
            if (currentRecipe.sugar >= 5 || currentRecipe.sugar <= 4)
            {
                Customer.chanceOfBuying -= 3;
            }
            else if (currentRecipe.sugar >= 5 || currentRecipe.sugar <= 4)
             {

                Customer.chanceOfBuying += 3;
            
            }
        }
        
        

    }
}

    

