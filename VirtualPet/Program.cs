using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Player player = new Player();
            string sPetType1 = null;
            Console.WriteLine("\t\tWelcome to Virtual Pet\n\n");

            while (true)
            {
                Console.Write("What is your name? ");
                player.name = Console.ReadLine();
                if (player.name != "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid value.");
                }
                
            }
            Console.WriteLine("Welcome to the virtual pet world, {0}\nHere you will choose an animal to take care of and raise.\n\n",player.name);
            Console.WriteLine("\nInstructions:\nIn this game you choose a pet and interact with them by playing with, feeding, and petting them.\n" +
                "You can earn points by interacting with them and you can buy items from the store with the points.\n" +
                "Your pets skills will increase as you play with them, \nbut if you don't play with them, the skills will degrade over time.\n");
            
            int petType = 0;
            Dog dog=null;
            Cat cat=null;
            Bird bird=null;
            bool valid = true;
            while (valid)
            {
                try
            {
                Console.WriteLine("What animal would you like? \n1.Dog\n2.Cat\n3.Bird");
                string sPetType = Console.ReadLine();
                petType = Convert.ToInt32(sPetType);
            }
            catch
            {
                Console.WriteLine("Please enter a valid value");
            }
           
                switch (petType)
                {
                    case 1:
                        dog = new Dog(player);
                        valid = false;
                        sPetType1 = dog.GetPetType();
                        break;
                    case 2:
                        cat = new Cat(player);
                        valid = false;
                        sPetType1 = cat.GetPetType();
                        break;
                    case 3:
                        bird = new Bird(player);
                        sPetType1 = bird.GetPetType();
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu option.");
                        break;
                }
            }
            if (petType == 1)
            {
                while (true)
                {
                    Console.Write("What is your pet's name? ");
                    string name = Console.ReadLine();
                    if(name != "")
                    {
                        dog.SetName(name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid name value.");
                    }
                }
                DogMenu(player, dog);
            }
            if (petType == 2)
            {
                while (true)
                {
                    Console.Write("What is your pet's name? ");
                    string name = Console.ReadLine();
                    if (name != "")
                    {
                        cat.SetName(name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid name value.");
                    }
                }
                CatMenu(player, cat);
            }
            if (petType == 3)
            {
                while (true)
                {
                    Console.Write("What is your pet's name? ");
                    string name = Console.ReadLine();
                    if (name != "")
                    {
                        bird.SetName(name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid name value.");
                    }
                }
                BirdMenu(player, bird);
            }
            

            Console.ReadLine();
        }

        public static void DogMenu(Player player,Dog dog)
        {
            Store store = new Store(player);
            bool play = true;
            bool decrease = true;

            while (play)
            {
                Console.Clear();
                Console.WriteLine("Pet Level: {0}",dog.GetLevel());
                Console.WriteLine("Hunger:{0}\tThirst:{1}\n", dog.GetHunger(), dog.GetThirst());
                dog.PrintSkills();
                dog.DogImage();
                Console.WriteLine("Player points: {0}",player.points);
                Console.WriteLine("Treats: {0}\n\n",player.GetDogBiscut());
                Console.WriteLine("Menu options for interacting with your pup: ");
                Console.WriteLine("1.Play\n2.Train\n3.Pet\n4.Feed\n5.Store\n6.Exit Application");
                string sChoice = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(sChoice);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        dog.Play();
                        break;
                    case 2:
                        dog.Train();
                        break;
                    case 3:
                        dog.PetAnimal();
                        break;
                    case 4:
                        dog.Eat();
                        break;
                    case 5:
                        store.DogMenu();
                        break;
                    case 6:
                        Environment.Exit(0);
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }
                dog.LevelUp();
                dog.SkillDecrease();
                dog.PetBirthday();
                
                if (decrease == true)
                {
                    dog.PetDying();
                    decrease = false;
                }
                else
                    decrease = true;
            }
        }

        public static void CatMenu(Player player, Cat cat)
        {
            Store store = new Store(player);
            bool play = true;
            bool decrease = true;

            while (play)
            {
                Console.Clear();
                Console.WriteLine("Pet Level: {0}", cat.GetLevel());
                Console.WriteLine("Hunger:{0}\tThirst:{1}\n", cat.GetHunger(), cat.GetThirst());
                cat.PrintSkills();
                cat.CatImage();
                Console.WriteLine("Player points: {0}",player.points);
                Console.WriteLine("Treats: {0}\n\n",player.GetCatTreat());
                Console.WriteLine("Menu options for interacting with your kitty: ");
                Console.WriteLine("1.Play\n2.Train\n3.Pet\n4.Feed\n5.Store\n6.Exit Application");
                string sChoice = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(sChoice);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        cat.Play();
                        break;
                    case 2:
                        cat.Train();
                        break;
                    case 3:
                        cat.PetAnimal();
                        break;
                    case 4:
                        cat.Eat();
                        break;
                    case 5:
                        store.CatMenu();
                        break;
                    case 6:
                        Environment.Exit(0);
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }
                cat.LevelUp();
                cat.SkillDecrease();
                cat.PetBirthday();

                if (decrease == true)
                {
                    cat.PetDying();
                    decrease = false;
                }
                else
                    decrease = true;
            }
        }

        public static void BirdMenu(Player player, Bird bird)
        {
            Store store = new Store(player);
            bool play = true;
            bool decrease = true;

            while (play)
            {
                Console.Clear();
                Console.WriteLine("Pet Level: {0}", bird.GetLevel());
                Console.WriteLine("Hunger:{0}\tThirst:{1}\n", bird.GetHunger(), bird.GetThirst());
                bird.PrintSkills();
                bird.BirdImage();
                Console.WriteLine("Player points: {0}",player.points);
                Console.WriteLine("Treats: {0}\n\n",player.GetBirdTreat());
                Console.WriteLine("Menu options for interacting with your bird: ");
                Console.WriteLine("1.Play\n2.Train\n3.Pet\n4.Feed\n5.Store\n6.Exit Application");
                string sChoice = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(sChoice);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        bird.Play();
                        break;
                    case 2:
                        bird.Train();
                        break;
                    case 3:
                        bird.PetAnimal();
                        break;
                    case 4:
                        bird.Eat();
                        break;
                    case 5:
                        store.BirdMenu();
                        break;
                    case 6:
                        Environment.Exit(0);
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }
                bird.LevelUp();
                bird.SkillDecrease();
                bird.PetBirthday();

                if (decrease == true)
                {
                    bird.PetDying();
                    decrease = false;
                }
                else
                    decrease = true;
            }
        }
    }
}
