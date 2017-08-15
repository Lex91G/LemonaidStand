using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonaidStand
{
    public class Store
    {
        Player player;
        Inventory backPack;
        Game game;
        public Store(Player player)
        {
            this.player = player;
            
        }
        public void BuyProducts(Player player)
        {
            
            Game.DisplayInventory(player);
            Console.WriteLine("Nice seeing you, what can I get for you? \n 1 = Cups \n 2 = Ice \n 3 = Lemons \n 4 = Sugar \n 5 = Back to main menu");
            string productSelection = Console.ReadLine();
            switch (productSelection)
            {
                case "1":
                    CupBuy();
                    BuyProducts(player);
                    break;
                case "2":
                    IceBuy();
                    BuyProducts(player);
                    break;

                case "3":
                    LemonBuy();
                    BuyProducts(player);
                    break;
                case "4":
                    SugarBuy();
                    BuyProducts(player);
                    break;
                case "5":
                    Game game = new Game();
                    game.Mainmenu(player); 
                    break;
                default:
                    Console.WriteLine("Sorry invalid answer. Try again");
                    Console.ReadLine();
                    BuyProducts(player);
                    return;
            }
        }
        public void CupBuy()
        {
            Console.WriteLine(player.backpack.cup.Count);
            Console.WriteLine("How many cups would you like to buy? \n 1 = 30 cups .30$ \n 2 = 75 cups .60$ \n 3 = 150 cups 1.00$ \n 4 = Go back to store");
            string cupBuyAnswer = Console.ReadLine();
            switch (cupBuyAnswer)
            {
                case "1":
                    if (player.backpack.money <= .30)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Cup cup = new Cup();
                            player.backpack.cup.Add(cup);
                        }
                        player.backpack.money -= .30;
                    }
                    break;

                case "2":
                    if (player.backpack.money <= .60)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 75; i++)
                        {
                            Cup cup = new Cup();
                            player.backpack.cup.Add(cup);

                        }
                        player.backpack.money -= .60;
                    }
                        break;
                    

                case "3":
                    if (player.backpack.money <= 1.00)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    { 
                        for (int i = 0; i < 150; i++)
                        {
                            Cup cup = new Cup();
                            player.backpack.cup.Add(cup);
                        }
                        player.backpack.money -= 1.00;
                    }
                    break;
                case "4":
                    
                    break;

                default:
                    Console.WriteLine("Invalid Answer. Try again");
                    Console.ReadLine();
                    CupBuy();
                    return;
            }
            
        }
        public void IceBuy()
        {
            Console.WriteLine(player.backpack.ice.Count);
            Console.WriteLine("How much ice would you like to buy? \n 1 = 75 cubes .60$ \n 2 = 150 cubes 1.00$ \n 3 = 250 cups 1.50$ \n 4 = Go back to store");
            string iceBuyAnswer = Console.ReadLine();
            switch (iceBuyAnswer)
            {
                case "1":
                    if (player.backpack.money <= .60)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 75; i++)
                        {
                            Ice ice = new Ice();
                            player.backpack.ice.Add(ice);
                        }
                        player.backpack.money -= .60;
                    }
                    break;

                case "2":
                    if (player.backpack.money <= 1.00)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 150; i++)
                        {
                            Ice ice = new Ice();
                            player.backpack.ice.Add(ice);
                        }
                        player.backpack.money -= 1.00;
                    }
                    break;

                case "3":
                    if (player.backpack.money <= 1.50)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 250; i++)
                        {
                            Ice ice = new Ice();
                            player.backpack.ice.Add(ice);
                        }
                        player.backpack.money -= 1.50;
                    }
                    break;

                case "4":
                    BuyProducts(player);
                    break;

                default:
                    Console.WriteLine("Invalid Answer. Try again");
                    Console.ReadLine();
                    IceBuy();
                    return;
            }
            
        }
        public void LemonBuy()
        {
            Console.WriteLine(player.backpack.lemons.Count);
            Console.WriteLine("How many lemons would you like to buy? \n 1 = 30 lemons 1.00$ \n 2 = 75 lemons 1.50$ \n 3 = 150 lemons 2.00$ \n 4 = Go back to store");
            string lemonBuyAnswer = Console.ReadLine();
            switch (lemonBuyAnswer)
            {
                case "1":
                    if (player.backpack.money <= 1.00)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Lemons lemon = new Lemons();
                            player.backpack.lemons.Add(lemon);
                        }
                        player.backpack.money -= 1.00;
                    }
                        break;
                    


                case "2":
                    if (player.backpack.money <= 1.50)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 75; i++)
                        {
                            Lemons lemon = new Lemons();
                            player.backpack.lemons.Add(lemon);
                        }
                        player.backpack.money -= 1.50;
                    }
                        break;
                    

                case "3":
                    if (player.backpack.money <= 2.00)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 150; i++)
                        {
                            Lemons lemon = new Lemons();
                            player.backpack.lemons.Add(lemon);
                        }
                        player.backpack.money -= 2.00;
                    }
                        break;
                    
                case "4":
                    BuyProducts(player);
                    break;

                default:
                    Console.WriteLine("Invalid Answer. Try again");
                    Console.ReadLine();
                    LemonBuy();
                    return;
            }
            
        }
        public void SugarBuy()
        {
            Console.WriteLine(player.backpack.sugar.Count);
            Console.WriteLine("How many cups of sugar would you like to buy? \n 1 = 30 cups 1.00$ \n 2 = 75 cups 1.50$ \n 3 = 150 cups 2.00$ \n 4 = Go back to store");
            string sugarBuyAnswer = Console.ReadLine();
            switch (sugarBuyAnswer)
            {
                case "1":
                    if (player.backpack.money <= 1.00)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Sugar sugar = new Sugar();
                            player.backpack.sugar.Add(sugar);
                        }
                        player.backpack.money -= 1.00;
                    }
                    break;

                case "2":
                    if (player.backpack.money <= 1.50)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 75; i++)
                        {
                            Sugar sugar = new Sugar();
                            player.backpack.sugar.Add(sugar);
                        }
                        player.backpack.money -= 1.50;
                    }
                    break;

                case "3":
                    if (player.backpack.money <= 2.00)
                    {
                        Console.WriteLine("Sorry not enough money");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < 150; i++)
                        {
                            Sugar sugar = new Sugar();
                            player.backpack.sugar.Add(sugar);
                        }
                        player.backpack.money -= 2.00;
                    }
                    break;
                case "4":
                    BuyProducts(player);
                    break;

                default:
                    Console.WriteLine("Invalid Answer. Try again");
                    Console.ReadLine();
                    CupBuy();
                    return;
            }
            
        }
    }

}
