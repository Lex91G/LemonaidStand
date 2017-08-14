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
        public int chanceOfBuying = 40;



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



        public Recipe CreateBestRecipe()
        {
            Recipe bestRecipe = new Recipe();
            bestRecipe.lemons = 4;
            bestRecipe.sugar = 4;
            bestRecipe.ice = 5;
            bestRecipe.cups = 1;
            customer.chanceOfBuying = 10 / 100;
            return bestRecipe;
        }
        public Recipe CreateSecondBest()
        {
            Recipe secondBest = new Recipe();
            secondBest.lemons = 4;
            secondBest.sugar = 3;
            secondBest.ice = 7;
            secondBest.cups = 1;
            customer.chanceOfBuying = 8 / 100;
            return secondBest;
        }
        public Recipe CreateSugarLemonaid()
        {
            Recipe sugarRecipe = new Recipe();
            sugarRecipe.lemons = 3;
            sugarRecipe.sugar = 5;
            sugarRecipe.ice = 3;
            sugarRecipe.cups = 1;
            customer.chanceOfBuying = 7 / 100;

            return sugarRecipe;
        }
        public Recipe CreateLemonRecipe()
        {
            Recipe lemonRecipe = new Recipe();
            lemonRecipe.lemons = 5;
            lemonRecipe.sugar = 4;
            lemonRecipe.ice = 4;
            lemonRecipe.cups = 1;
            customer.chanceOfBuying += 5 / 100;
            return lemonRecipe;
        }
        public Recipe CreateCheapRecipe()
        {
            Recipe cheapRecipe = new Recipe();
            cheapRecipe.lemons = 1;
            cheapRecipe.sugar = 1;
            cheapRecipe.ice = 1;
            cheapRecipe.cups = 1;
            customer.chanceOfBuying -= 5 / 100;
            return cheapRecipe;
        }
        public Recipe CreateYourOwnRecipe()
        {
            Recipe createYourOwn = new Recipe();
            Console.WriteLine("How many lemons: ");
            int creatingLemons = int.Parse(Console.ReadLine());
            createYourOwn.lemons = creatingLemons;


            Console.WriteLine("How many cups of sugar: ");
            int creatingSugar = int.Parse(Console.ReadLine());
            createYourOwn.sugar = creatingSugar;

            Console.WriteLine("How many ice Cubes: ");
            int creatingice = int.Parse(Console.ReadLine());
            createYourOwn.ice = creatingice;

            createYourOwn.cups = 1;
            return createYourOwn;
        }
        public void IfElseLemonLikelyness()
        {
            Recipe currentRecipe = CreateYourOwnRecipe();

            if (currentRecipe.lemons > 5 || currentRecipe.lemons < 4)
            {
                customer.chanceOfBuying -= 3;
            }
            else if(currentRecipe.lemons <= 6 || currentRecipe.lemons >= 4)
             {
                customer.chanceOfBuying += 3;
             }
        }
        public void IfElseSugarLikelyNess()
        {
            Recipe currentRecipe = CreateYourOwnRecipe();
            if (currentRecipe.ice >= 7 || currentRecipe.ice <= 4)
            {
                customer.chanceOfBuying -= 3;
            }
            else if(currentRecipe.ice >= 7 || currentRecipe.ice <= 4)
             {

                customer.chanceOfBuying += 3;
            }
        }
        public void IfElseIceLikelyNess()
        {
            Recipe currentRecipe = CreateYourOwnRecipe();
            if (currentRecipe.sugar >= 5 || currentRecipe.sugar <= 4)
            {
                customer.chanceOfBuying -= 3;
            }
            else if (currentRecipe.sugar >= 5 || currentRecipe.sugar <= 4)
             {

                customer.chanceOfBuying += 3;
            
            }
        }
        

    }
}

    

