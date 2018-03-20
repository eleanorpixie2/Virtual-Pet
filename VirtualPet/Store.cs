using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VirtualPet
{
    class Store:Player
    {
        Player player;
        public Store(Player person)
        {
            player = person;
        }

        public void CatMenu()
        {
            Console.Clear();
            bool firstIteration = true;
            Console.WriteLine("\t\tWelcome to the Store Menu!");
            Console.WriteLine("\t\t==========================");
            bool store = true;
            while (store)
            {
                if(firstIteration==false)
                {
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                Console.WriteLine("Player points: {0}\n\n", player.points);
                Console.WriteLine("Store Menu: ");
                Console.WriteLine("\n1.Ball-10 points \n2.Canned Food-6 points\n3.Premium Canned Food-12 points\n4.Dry Food-4 points\n" +
                    "5.Premium Dry Food-10 points\n6.Cat Treats-5 points\n7.Water-5 points\n8.Laser Pointer-17 points\n9.Yarn-5 points" +
                    "\n10.Stick Toy-8 points\n11. Back to Main Menu\n");
                string sChoice = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(sChoice);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPlease enter a valid number");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        if (player.points >= 10)
                        {
                            player.AddBall();
                            player.points -= 10;
                            Console.WriteLine("+1 Ball");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 2:
                        if (player.points >= 6)
                        {
                            player.AddCannedFood();
                            player.points -= 6;
                            Console.WriteLine("+1 Canned Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 3:
                        if (player.points >= 12)
                        {
                            player.AddPremiumCannedFood();
                            player.points -= 12;
                            Console.WriteLine("+1 Premium Canned Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 4:
                        if (player.points >= 4)
                        {
                            player.AddDryFood();
                            player.points -= 4;
                            Console.WriteLine("+1 Dry Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 5:
                        if (player.points >= 10)
                        {
                            player.AddPremiumDryFood();
                            player.points -= 10;
                            Console.WriteLine("+1 Premium Dry Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 6:
                        if (player.points >= 5)
                        {
                            player.AddCatTreat();
                            player.points -= 5;
                            Console.WriteLine("+1 Cat Treat");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 7:
                        if (player.points >= 5)
                        {
                            player.AddWater();
                            player.points -= 5;
                            Console.WriteLine("+1 Water");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 8:
                        if (player.points >= 17)
                        {
                            player.AddLaser();
                            player.points -= 17;
                            Console.WriteLine("+1 Laser");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 9:
                        if (player.points >= 5)
                        {
                            player.AddYarn();
                            player.points -= 5;
                            Console.WriteLine("+1 Yarn");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 10:
                        if (player.points >= 8)
                        {
                            player.AddStickToy();
                            player.points -= 8;
                            Console.WriteLine("+1 StickToy");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 11:
                        store = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }

                firstIteration = false;
            }
        }

        public void DogMenu()
        {
            Console.Clear();
            bool firstIteration = true;
            Console.WriteLine("\t\tWelcome to the Store Menu!");
            Console.WriteLine("\t\t==========================");
            bool store = true;
            while (store)
            {
                if (firstIteration == false)
                {
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                Console.WriteLine("Player points: {0}\n\n", player.points);
                Console.WriteLine("Store Menu: ");
                Console.WriteLine("\n1.Ball-10 points\n2.Canned Food-6 points\n3.Premium Canned Food-12 points\n4.Dry Food-4 points\n" +
                    "5.Premium Dry Food-10 points\n6.Dog Biscuts-5 points\n7.Water-5 points\n8.Squeaky Toy-17 points\n9.Rope-5 points" +
                    "\n10.Frisbee-8 points\n11. Back to Main Menu\n");
                string sChoice = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(sChoice);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPlease enter a valid number");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        if (player.points >= 10)
                        {
                            player.AddBall();
                            player.points -= 10;
                            Console.WriteLine("+1 Ball");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 2:
                        if (player.points >= 6)
                        {
                            player.AddCannedFood();
                            player.points -= 6;
                            Console.WriteLine("+1 Canned Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 3:
                        if (player.points >= 12)
                        {
                            player.AddPremiumCannedFood();
                            player.points -= 12;
                            Console.WriteLine("+1 Premium Canned Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 4:
                        if (player.points >= 4)
                        {
                            player.AddDryFood();
                            player.points -= 4;
                            Console.WriteLine("+1 Dry Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 5:
                        if (player.points >= 10)
                        {
                            player.AddPremiumDryFood();
                            player.points -= 10;
                            Console.WriteLine("+1 Premium Dry Food");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 6:
                        if (player.points >= 5)
                        {
                            player.AddDogBiscut();
                            player.points -= 5;
                            Console.WriteLine("+1 Dog Biscut");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 7:
                        if (player.points >= 5)
                        {
                            player.AddWater();
                            player.points -= 5;
                            Console.WriteLine("+1 Water");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 8:
                        if (player.points >= 17)
                        {
                            player.AddSqueakyToy();
                            player.points -= 17;
                            Console.WriteLine("+1 Squeaky Toy");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 9:
                        if (player.points >= 5)
                        {
                            player.AddRope();
                            player.points -= 5;
                            Console.WriteLine("+1 Rope");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 10:
                        if (player.points >= 8)
                        {
                            player.AddFrisbee();
                            player.points -= 8;
                            Console.WriteLine("+1 Frisbee");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 11:
                        store = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }

                firstIteration = false;
            }
        }

        public void BirdMenu()
        {
            Console.Clear();
            bool firstIteration = true;
            Console.WriteLine("\t\tWelcome to the Store Menu!");
            Console.WriteLine("\t\t==========================");
            bool store = true;
            while (store)
            {
                if (firstIteration == false)
                {
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                Console.WriteLine("Player points: {0}\n\n", player.points);
                Console.WriteLine("Store Menu: ");
                Console.WriteLine("\n1.Bird Feed-6 points\n2.Premium Bird Feed-10 points\n3.Millet Treat-4 points\n4.Water-5 points\n" +
                    "5.Perch-10 points\n6.Activity Center-15 points\n7.Back to Main Menu");
                string sChoice = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(sChoice);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPlease enter a valid number");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        if (player.points >= 6)
                        {
                            player.AddBirdFeed();
                            player.points -= 6;
                            Console.WriteLine("+1 Bird Feed");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 2:
                        if (player.points >= 10)
                        {
                            player.AddPremiumBirdFeed();
                            player.points -= 10;
                            Console.WriteLine("+1 Premium Bird Feed");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 3:
                        if (player.points >= 4)
                        {
                            player.AddMilletTreat();
                            player.points -= 4;
                            Console.WriteLine("+1 Millet Treat");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 4:
                        if (player.points >= 5)
                        {
                            player.AddWater();
                            player.points -= 5;
                            Console.WriteLine("+1 Water");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 5:
                        if (player.points >= 10)
                        {
                            player.AddPerch();
                            player.points -= 10;
                            Console.WriteLine("+1 Perch");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 6:
                        if (player.points >= 15)
                        {
                            player.AddActivityCenter();
                            player.points -= 15;
                            Console.WriteLine("+1 Activity Center");
                        }
                        else
                            Console.WriteLine("You do not have enough points.");
                        break;
                    case 7:
                        store = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }

                firstIteration = false;
            }
        }
    }
}
