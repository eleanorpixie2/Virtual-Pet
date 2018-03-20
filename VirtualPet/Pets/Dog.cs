using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VirtualPet
{
    class Dog:Pet
    {
        //Gets the full date for the day this is called
        DateTime petBirthday = DateTime.Today;

        public Dog(Player person)
        {
            //Strength(0),Speed(1),Indurance(2),Agility(3),Sit(4),Stay(5),Shake(6),Come(7)
            petSkills = new int[8];

            //Gets the month
            bDayMonth = petBirthday.Month;

            //Gets the day
            bDay = petBirthday.Day;

            //Gets the year
            bDayYear = petBirthday.Year;

            skillNotUsedTime = new int[8];

            petType = "dog";

            player = person;
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
            bool firstIteration = true;
            Console.WriteLine("Welcome to the feeding menu!");
            Console.WriteLine("=========================");
            Console.WriteLine("\n\n{0} is very hungery/thirsty.", petName);
            while (play)
            {
                if (firstIteration != true)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                Console.WriteLine("Pet Level: {0}", petLevel);
                Console.WriteLine("Hunger:{0}\tThirst:{1}\n", hungerLevel, thirstLevel);
                DogImage();
                Console.WriteLine("Points:{0}", player.points);
                Console.WriteLine("Treats:{0}\n\n", player.GetDogBiscut()); 
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Dry Food-{0}\n2.Premium Dry Food-{1}\n3.Water-{2}\n4.Dog Biscut-{3} \n5.Canned Food-{4}" +
                    "\n6.Premium Canned Food-{5}\n7.Back to Main Menu",player.GetDryFood(),player.GetPremiumDryFood(),player.GetWater(),
                    player.GetDogBiscut(),player.GetCannedFood(),player.GetPremiumCannedFood());
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
                        if (hungerLevel < hungerMax && player.HasDryFood())
                        {
                            Console.WriteLine("{0} went crazy and devoured all the food you put down.",petName);
                            hungerLevel += 3;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if (hungerLevel >= hungerMax)
                        {
                            Console.WriteLine("Your dog is already full, please choose something else");
                        }
                        else if(player.HasDryFood()==false)
                        {
                            Console.WriteLine("You do not have enough food. Please visit the store.");
                        }
                        break;
                    case 2:
                        //add item check
                        if (hungerLevel < hungerMax && player.HasPremiumDryFood())
                        {
                            Console.WriteLine("\n{0} devours the dry food you placed in front of them", petName);
                            hungerLevel += 5;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if (hungerLevel >= hungerMax)
                        {
                            Console.WriteLine("Your dog is already full, please choose something else");
                        }
                        else if (player.HasPremiumDryFood() == false)
                        {
                            Console.WriteLine("You do not have enough food. Please visit the store.");
                        }
                        break;
                    case 3:
                        if (thirstLevel < thirstMax && player.HasWater())
                        {
                            Console.WriteLine("\n{0} laps up the water hurriedly.", petName);
                            thirstLevel += 3;
                            if (thirstLevel > thirstMax)
                                thirstLevel = thirstMax;
                        }
                        else if(thirstLevel >= thirstMax)
                        {
                            Console.WriteLine("Your dog is not thirsty at this moment, please choose something else.");
                        }
                        else if (player.HasWater() == false)
                        {
                            Console.WriteLine("You do not have enough water. Please visit the store.");
                        }
                        break;
                    case 4:
                        if (hungerLevel < hungerMax && player.HasDogBiscut())
                        {
                            Console.WriteLine("\n{0} devours the dog biscut placed in front of them", petName);
                            hungerLevel += 2;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if (hungerLevel >= hungerMax)
                        {
                            Console.WriteLine("Your dog is already full, please choose something else");
                        }
                        else if (player.HasDogBiscut() == false)
                        {
                            Console.WriteLine("You do not have enough dog biscuts. Please visit the store.");
                        }
                        break;
                    case 5:
                        if (hungerLevel < hungerMax && player.HasCannedFood())
                        {
                            Console.WriteLine("\n{0} devours the canned food placed in front of them", petName);
                            hungerLevel += 3;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if (hungerLevel >= hungerMax)
                        {
                            Console.WriteLine("Your dog is already full, please choose something else");
                        }
                        else if (player.HasCannedFood() == false)
                        {
                            Console.WriteLine("You do not have enough food. Please visit the store.");
                        }
                        break;
                    case 6:
                        if (hungerLevel < hungerMax && player.HasPremiumCannedFood())
                        {
                            Console.WriteLine("\n{0} devours the wet food placed in front of them", petName);
                            hungerLevel += 5;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if (hungerLevel >= hungerMax)
                        {
                            Console.WriteLine("Your dog is already full, please choose something else");
                        }
                        else if (player.HasPremiumCannedFood() == false)
                        {
                            Console.WriteLine("You do not have enough food. Please visit the store.");
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
            bool firstIteration = true;
            Console.WriteLine("Welcome to the play menu!");
            Console.WriteLine("=========================");
            Console.WriteLine("\n\n{0} is excited to play with you.", petName);
            while (play)
            {
                if (firstIteration != true)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                Console.WriteLine("Pet Level: {0}", petLevel);
                Console.WriteLine("Hunger:{0}\tThirst:{1}\n", hungerLevel, thirstLevel);
                Console.WriteLine("Points:{0}", player.points);
                Console.WriteLine("Treats:{0}\n\n",player.GetDogBiscut());
                DateTime skillDecrease = DateTime.Now;
                DogImage();
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Ball-{0}\n2.Rope-{1}\n3.Frisbee-{2}\n4.Squeaky toy-{3}\n5.Back to Main Menu",player.GetBall(),
                    player.GetRope(),player.GetFrisbee(),player.GetSqueakyToy());
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
                Console.WriteLine(choice);
                switch (choice)
                {
                    case 1:
                        //add item condition
                        if (player.HasBall())
                        {
                            Console.WriteLine("\n{0} barks and runs after the ball. \n{0} Returns to you with the ball with its head held high and tail wagging.", petName);
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;

                                Console.WriteLine("\nSpeed +1");
                            }
                            if (petSkills[3] < 10)
                            {
                                petSkills[3] += 1;
                                skillNotUsedTime[3] = skillDecrease.Minute;
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
                        if (player.HasRope())
                        {
                            Console.WriteLine("\n{0} is excited when it sees the rope and starts barking excitedly and jumping around before" +
                                " \nlunging at the rope, starting a game of tug-o-war.", petName);
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed +1");
                            }
                            if (petSkills[0] < 10)
                            {
                                petSkills[0] += 1;
                                skillNotUsedTime[0] = skillDecrease.Minute;
                                Console.WriteLine("\nStrength +1");
                            }
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nIndurance +1");
                            }
                            player.points += 5;

                        }
                        else
                        {
                            Console.WriteLine("Sorry you do not own this item yet, please visit the store.");
                        }
                        break;
                    case 3:
                        if (petSkills[3] >= 1&& player.HasFrisbee())
                        {

                            Console.WriteLine("\n{0} runs after the firsbee, catching it and running back to you.", petName);
                            if (petSkills[3] < 10)
                            {
                                petSkills[3] += 1;
                                skillNotUsedTime[3] = skillDecrease.Minute;
                                Console.WriteLine("\nAgility +1");
                            }
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nIndurance +1");
                            }
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed +1");
                            }
                            player.points += 5;
                        }
                        else if (petSkills[3]<1)
                        {
                            Console.WriteLine("Sorry, you can not do this yet, your agility is too low, please train your dog more.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry you do not own this item yet, please visit the store.");
                        }

                        break;
                    case 4:
                        if (player.HasSqueakyToy())
                        {

                            Console.WriteLine("\n{0} runs around excitedly while making the toy squeak and trying to get you to play tug-o-war.", petName);
                            if (petSkills[3] < 10)
                            {
                                petSkills[3] += 1;
                                skillNotUsedTime[3] = skillDecrease.Minute;
                                Console.WriteLine("\nAgility +1");
                            }
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nIndurance +1");
                            }
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed +1");
                            }
                            if (petSkills[0] < 10)
                            {
                                petSkills[0] += 1;
                                skillNotUsedTime[0] = skillDecrease.Minute;
                                Console.WriteLine("\nStrength +1");
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
            bool firstIteration = true;
            bool train = true;
        

            while (train)
            {
                if (firstIteration!=true)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                Console.WriteLine("Pet Level: {0}", petLevel);
                Console.WriteLine("Hunger:{0}\tThirst:{1}\n", hungerLevel, thirstLevel);
                Console.WriteLine("Points:{0}",player.points);
                Console.WriteLine("Dog Biscuts:{0}",player.GetDogBiscut());
                DogImage();
                DateTime skillDecrease = DateTime.Now;
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Sit\n2.Stay\n3.Shake\n4.Come\n5.Back to Main Menu");
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
                    //Add treat cost component and point requirement, may be corollated
                    case 1:
                        if (petSkills[4]==0 && player.HasDogBiscut())
                        {
                            Console.WriteLine("{0} doesn't know what to do, but as you enitce it \nwith treats and praise, the pup eventually sits", petName);
                            petSkills[4] += 1;
                            player.points += 5;
                            skillNotUsedTime[4] = skillDecrease.Minute;
                            Console.WriteLine("\nSit +1");
                        }
                        else if (petSkills[4] >= 1 && player.HasDogBiscut())
                        {
                            player.points += 5;
                            petSkills[4] += 1;
                            Console.WriteLine("{0} sits on command and you give the puppy a treat as a reward.", petName);
                            skillNotUsedTime[4] = skillDecrease.Minute;
                            Console.WriteLine("\nSit +1");
                        }
                        else if (petSkills[4] >= 10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if (player.HasDogBiscut() == false)
                        {
                            Console.WriteLine("You do not have enough dog biscuts. Please visit the store.");
                        }
                        break;
                    case 2:
                        if (petSkills[5] < 2 && player.HasDogBiscut())
                        {
                            Console.WriteLine("{0} doesn't quite know what to do when you do the gesture for stay and follows you, " +
                                "\nbut after a lot of enticing, it stays for a few seconds.\nYou give {0} a treat as a reward.", petName);
                            petSkills[5] += 1;
                            player.points += 5;
                            Console.WriteLine("\nStay +1");
                            skillNotUsedTime[5] = skillDecrease.Minute;
                        }
                        else if (petSkills[5] >= 2 && petSkills[5] < 10 && player.HasDogBiscut())
                        {
                            Console.WriteLine("{0} stays quietly when you make the gesture for the command stay. \nYou give {0} a treat as a reward.", petName);
                            petSkills[5] += 1;
                            player.points += 5;
                            Console.WriteLine("\nStay +1");
                            skillNotUsedTime[5] = skillDecrease.Minute;
                        }
                        else if (petSkills[5]>=10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if (player.HasDogBiscut() == false)
                        {
                            Console.WriteLine("You do not have enough dog biscuts. Please visit the store.");
                        }
                        break;
                    case 3:
                        if (petSkills[6] <= 2 && player.HasDogBiscut())
                        {
                            Console.WriteLine("{0} doesn't quite know what to do as you gesture your hand for it to shake, \nbut after a while {0} gives you its paw and you give it a treat.", petName);
                            petSkills[6] += 1;
                            player.points += 5;
                            Console.WriteLine("\nShake +1");
                            skillNotUsedTime[6] = skillDecrease.Minute;
                        }
                        else if (petSkills[6] > 2 && petSkills[6] < 10 && player.HasDogBiscut())
                        {
                            Console.WriteLine("{0} throws its paw in your hand as you gesture your hand for it to shake, \nbut after a while {0} gives you its paw and you give it a treat.", petName);
                            petSkills[6] += 1;
                            player.points += 5;
                            Console.WriteLine("\nShake +1");
                            skillNotUsedTime[6] = skillDecrease.Minute;
                        }
                        else if (petSkills[6] >= 10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if (player.HasDogBiscut() == false)
                        {
                            Console.WriteLine("You do not have enough dog biscuts. Please visit the store.");
                        }
                        break;
                    case 4:
                        if (petSkills[7] <=2 && player.HasDogBiscut())
                        {
                            //spell check
                            Console.WriteLine("{0} doesn't know what you want as you yell come from across the house, \nbut as soon as the dog sees the treat, it comes running.", petName);
                            petSkills[7] += 1;
                            skillNotUsedTime[7] = skillDecrease.Minute;
                            player.points += 5;
                        }
                        else if(petSkills[7]>2 && petSkills[7]<10 && player.HasDogBiscut())
                        {
                            Console.WriteLine("{0} comes on command and you give it a treat as a reward.", petName);
                            petSkills[7] += 1;
                            skillNotUsedTime[7] = skillDecrease.Minute;
                            player.points += 5;
                        }
                        else if(petSkills[7]>=10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if (player.HasDogBiscut() == false)
                        {
                            Console.WriteLine("You do not have enough dog biscuts. Please visit the store.");
                        }
                        break;
                    case 5:
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
            Console.WriteLine("Strength:{0} Speed:{1} Indurance:{2} Agility:{3} Sit:{4} Stay:{5} Shake:{6} Come:{7}\n",petSkills[0]
                , petSkills[1], petSkills[2], petSkills[3], petSkills[4], petSkills[5], petSkills[6], petSkills[7]);
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

        public void DogImage()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"    |\|\");
            Console.WriteLine(@"  ..    \       .");
            Console.WriteLine(@"o--     \\    / @)");
            Console.WriteLine(@" v__///\\\\__/ @");
            Console.WriteLine(@"    {           }");
            Console.WriteLine(@"     {  } \\\{  }");
            Console.WriteLine(@"     <_|      <_|");
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

    }
}
