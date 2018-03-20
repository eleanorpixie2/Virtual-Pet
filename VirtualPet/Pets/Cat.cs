using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VirtualPet
{
    class Cat:Pet
    {
        //Gets the full date for the day this is called
        DateTime petBirthday = DateTime.Today;

        public Cat(Player person)
        {
            //Speed(0),Strength(1), Agility(2), Sneakiness(3)
            petSkills = new int[4];

            //Gets the month
            bDayMonth = petBirthday.Month;

            //Gets the day
            bDay = petBirthday.Day;

            //Gets the year
            bDayYear = petBirthday.Year;

            skillNotUsedTime = new int[4];

            player = person;

            petType = "cat";
        }

        public override void SetName(string name)
        {
            base.SetName(name);
        }

        public override string GetPetType()
        {
            return base.GetPetType();
        }

        public override void Eat()
        {

            Console.Clear();
            bool play = true;
            Console.WriteLine("Welcome to the feeding menu!");
            Console.WriteLine("=========================");
            Console.WriteLine("\n\n{0} is very hungery/thirsty.", petName);
            bool firstIteration = true;
            while (play)
            {
                if (firstIteration != true)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                Console.WriteLine("Points:{0}", player.points);
                Console.WriteLine("Treats:{0}\n\n", player.GetCatTreat());
                Console.WriteLine("Hunger:{0}\tThirst:{1}\n", hungerLevel, thirstLevel);
                CatImage();
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Dry Food-{0}\n2.Premium Dry Food-{1}\n3.Water-{2}\n4.Cat treat-{3} \n5.Canned Food-{4}" +
                    "\n6.Premium Canned Food-{5}\n7.Back to Main Menu", player.GetDryFood(), player.GetPremiumDryFood(), player.GetWater(),
                    player.GetCatTreat(), player.GetCannedFood(), player.GetPremiumCannedFood());
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
                        //If they have item
                        if (hungerLevel < hungerMax)
                        {
                            Console.WriteLine("{0} went crazy and devoured all the food you put down.",petName);
                            hungerLevel += 3;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else
                        {
                            Console.WriteLine("Your cat is already full, please choose something else");
                        }
                        break;
                    case 2:
                        //add item check
                        if (hungerLevel < hungerMax)
                        {
                            Console.WriteLine("\n{0} devours the dry food you placed in front of them", petName);
                            hungerLevel += 5;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else
                        {
                            Console.WriteLine("Your cat is already full, please choose something else");
                        }
                        break;
                    case 3:
                        if (thirstLevel < thirstMax)
                        {
                            Console.WriteLine("\n{0} laps up the water hurriedly.", petName);
                            thirstLevel += 3;
                            if (thirstLevel > thirstMax)
                                thirstLevel = thirstMax;
                        }
                        else
                        {
                            Console.WriteLine("Your cat is not thirsty at this moment, please choose something else.");
                        }
                        break;
                    case 4:
                        if (hungerLevel < hungerMax)
                        {
                            Console.WriteLine("\n{0} devours the cat treat placed in front of them", petName);
                            hungerLevel += 2;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else
                        {
                            Console.WriteLine("Your cat is already full, please choose something else");
                        }
                        break;
                    case 5:
                        if (hungerLevel < hungerMax)
                        {
                            Console.WriteLine("\n{0} devours the canned food placed in front of them", petName);
                            hungerLevel += 3;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else
                        {
                            Console.WriteLine("Your cat is already full, please choose something else");
                        }
                        break;
                    case 6:
                        if (hungerLevel < hungerMax)
                        {
                            Console.WriteLine("\n{0} devours the wet food placed in front of them", petName);
                            hungerLevel += 5;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else
                        {
                            Console.WriteLine("Your cat is already full, please choose something else");
                        }
                        break;
                    case 7:
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
                firstIteration = false;
            }

        }

        public override int Play()
        {
            Console.Clear();
            bool play = true;
            Console.WriteLine("Welcome to the play menu!");
            Console.WriteLine("=========================");
            Console.WriteLine("\n\n{0} is excited to play with you.", petName);
            bool firstIteration = true;
            while (play)
            {
                DateTime skillDecrease = DateTime.Now;
                if (firstIteration != true)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                Console.WriteLine("Points:{0}", player.points);
                Console.WriteLine("Treats:{0}\n\n", player.GetCatTreat());
                CatImage();
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Ball-{0}\n2.Yarn-{1}\n3.Feather Stick Toy-{2}\n4.Laser-{3}\n5.Back to Main Menu",
                    player.GetBall(),player.GetYarn(),player.GetStickToy(),player.GetLaser());
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
                        //add item condition
                        if (player.HasBall())
                        {
                            Console.WriteLine("\n{0} lunges at the ball and freaks running around all over batting the ball.", petName);
                            if (petSkills[0] < 10)
                            {
                                petSkills[0] += 1;
                                skillNotUsedTime[0] = skillDecrease.Minute;

                                Console.WriteLine("\nSpeed +1");
                            }
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nAgility +1");
                            }
                            player.points += 5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you do not own this toy yet, please visit the store.");
                        }
                        break;
                    case 2:
                        //add item check
                        if (player.HasYarn())
                        {
                            Console.WriteLine("\n{0} is excited when it sees the piece of yarn and crouches into a lunging position" +
                                " \nlunging at the yarn, starting a game of tug-o-war.", petName);
                            if (petSkills[0] < 10)
                            {
                                petSkills[0] += 1;
                                skillNotUsedTime[0] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed +1");
                            }
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;
                                Console.WriteLine("\nStrength +1");
                            }
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nAgility +1");
                            }
                            if (petSkills[3] < 10)
                            {
                                petSkills[3] += 1;
                                skillNotUsedTime[3] = skillDecrease.Minute;
                                Console.WriteLine("\nSneakiness +1");
                            }
                            player.points += 5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry you do not own this item yet, please visit the store.");
                        }
                        break;
                    case 3:
                        if (player.HasStickToy())
                        {

                            Console.WriteLine("\n{0} runs after the feathers, doing flips and insane tricks to try and catch it.", petName);
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nAgility +1");
                            }
                            
                            if (petSkills[0] < 10)
                            {
                                petSkills[0] += 1;
                                skillNotUsedTime[0] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed +1");
                            }
                            player.points += 5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry you do not own this item yet, please visit the store.");
                        }
                        break;
                    case 4:
                        if (player.HasLaser())
                        {

                            Console.WriteLine("\n{0} runs around excitedly chasing the little red dot and eventually pouncing at it after stalking it for a bit.", petName);
                            if (petSkills[3] < 10)
                            {
                                petSkills[3] += 1;
                                skillNotUsedTime[3] = skillDecrease.Minute;
                                Console.WriteLine("\nSneakiness +1");
                            }
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nAgility +1");
                            }
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;
                                Console.WriteLine("\nStrength +1");
                            }
                            if (petSkills[0] < 10)
                            {
                                petSkills[0] += 1;
                                skillNotUsedTime[0] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed+1");
                            }
                            player.points += 5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry you do not own this item yet, please visit the store.");
                        }
                        break;
                    case 5:
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
                firstIteration = false;
            }

            return 0;
        }

        public void Train()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the training menu!");
            Console.WriteLine("=============================");
            Console.WriteLine("\n\n{0} is eager to learn.",petName);

            bool train = true;
            bool firstIteration = true;

            while (train)
            {
                DateTime skillDecrease = DateTime.Now;
                if (firstIteration != true)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                Console.WriteLine("Points:{0}", player.points);
                Console.WriteLine("Treats:{0}\n\n",player.GetCatTreat());
                CatImage();
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Litter\n2.Come\n3.Back to Main Menu");
                string sChoice = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(sChoice);
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("\nPlease enter a valid number");
                    continue;
                }

                switch (choice)
                {
                    //Add treat cost component and point requirement, may be corollated
                    case 1:
                        if (petLevel<2 && player.HasCatTreat())
                        {
                            Console.WriteLine("{0} doesn't know what to do and pees all over the house, \nyou pick it up and place it in the litter box, it uses it, but not always", petName);
                            petSkills[0]+=1;
                            Console.WriteLine("\nSpeed+1");
                            player.points += 5;
                        }
                        else if (petLevel>=2 && player.HasCatTreat())
                        {
                            Console.WriteLine("{0} Already knows how to use the litter box, \nbut you reward them to reinforce the behavior", petName);
                            petSkills[0] += 1;
                            Console.WriteLine("\nSpeed+1");
                            player.points += 5;
                        }
                        else if (!player.HasCatTreat())
                        {
                            Console.WriteLine("You do not have enough cat treats. Please visit the store.");
                        }
                        break;
                    case 2:
                        if (petLevel < 2 && player.HasCatTreat())
                        {
                            Console.WriteLine("{0} doesn't quite know what to do when you do the gesture for it to come, \n" +
                                "but after a lot of enticing, it comes to you. \nYou give {0} a treat as a reward.", petName);
                            petSkills[0] += 1;
                            Console.WriteLine("\nSpeed+1");
                            player.points += 5;
                        }
                        else if (petLevel>=2 && player.HasCatTreat())
                        {
                            Console.WriteLine("{0} comes when you shake a treat bag now and you always give it a treat as a reward.", petName);
                            Console.WriteLine("\nSpeed+1");
                            petSkills[0] += 1;
                            player.points += 5;
                        }
                        else if(!player.HasCatTreat())
                        {
                            Console.WriteLine("You do not have enough cat treats. Please visit the store.");
                        }
                     
                        break;
                    case 3:
                        train = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        break;
                }
                firstIteration = false;
            }

        }

        public int GetLevel()
        {
            return petLevel;
        }

        public int GetHunger()
        {
            return hungerLevel;
        }

        public int GetThirst()
        {
            return thirstLevel;
        }

        public void PrintSkills()
        {
            Console.WriteLine("Speed:{0} Strength:{1} Agility:{2} Sneakiness:{3}\n", petSkills[0]
                , petSkills[1], petSkills[2], petSkills[3]);
        }

        public override void PetAnimal()
        {
            base.PetAnimal();
        }

        public override void LevelUp()
        {
            base.LevelUp();
        }

        public override void SkillDecrease()
        {
            base.SkillDecrease();
        }

        public override void PetBirthday()
        {
            base.PetBirthday();
        }

        public override void PetDying()
        {
            base.PetDying();
        }


        public void CatImage()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(@" |\_/|");
            Console.WriteLine(@" (. .)");
            Console.WriteLine(@"  =w= (\");
            Console.WriteLine(@" / ^ \//");
            Console.WriteLine(@"(|| ||)");
            Console.WriteLine(@" ""  "" ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}
