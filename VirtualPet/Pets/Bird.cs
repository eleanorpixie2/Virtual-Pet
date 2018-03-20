using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VirtualPet
{
    class Bird:Pet
    {
        //Gets the full date for the day this is called
        DateTime petBirthday = DateTime.Today;


        public Bird(Player person)
        {
            //Flying(0),Speed(1),Singing(2),Talking(3),Perching on finger/arm(4),Dancing(5)
            petSkills = new int[6];

            //Gets the month
            bDayMonth = petBirthday.Month;

            //Gets the day
            bDay = petBirthday.Day;

            //Gets the year
            bDayYear = petBirthday.Year;

            skillNotUsedTime = new int[6];

            player = person;

            petType = "bird";
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
                Console.WriteLine("Treats:{0}\n\n", player.GetBirdTreat());
                BirdImage();
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Bird feed-{0}\n2.Premium bird feed-{1}\n3.Water-{2}\n4.Millet Stick-{3} \n5.Back to Main Menu",
                    player.GetBirdFeed(),player.GetPremiumBirdFeed(),player.GetWater(),player.GetBirdTreat());
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
                        if (hungerLevel<hungerMax && player.HasBirdFeed())
                        {
                            Console.WriteLine("{0} munched on the bird feed you put down.");
                            hungerLevel += 3;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if(hungerLevel>=hungerMax)
                        {
                            Console.WriteLine("Your bird is already full, please choose something else");
                        }
                        else if (player.HasBirdFeed() == false)
                        {
                            Console.WriteLine("You do not have enough food. Please visit the store.");
                        }
                        break;
                    case 2:
                        //add item check
                        if (hungerLevel<hungerMax && player.HasPremiumBirdFeed())
                        {
                            Console.WriteLine("\n{0} devours the food placed in front of them", petName);
                            hungerLevel += 5;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if (hungerLevel >= hungerMax)
                        {
                            Console.WriteLine("Your bird is already full, please choose something else");
                        }
                        else if(player.HasPremiumBirdFeed()==false)
                        {
                            Console.WriteLine("You do not have enough food. Please visit the store.");
                        }
                        break;
                    case 3:
                        if (thirstLevel<thirstMax && player.HasWater())
                        {
                            Console.WriteLine("\n{0} laps up the water hurriedly.", petName);
                            thirstLevel += 3;
                            if (thirstLevel > thirstMax)
                                thirstLevel = thirstMax;
                        }
                        else if(thirstLevel >= thirstMax)
                        {
                            Console.WriteLine("Your bird is not thirsty at this moment, please choose something else.");
                        }
                        else if (player.HasWater() == false)
                        {
                            Console.WriteLine("You do not have enough water. Please visit the store.");
                        }
                        break;
                    case 4:
                        if (hungerLevel < hungerMax && player.HasMilletTreat())
                        {
                            Console.WriteLine("\n{0} devours the snack placed in front of them", petName);
                            hungerLevel += 2;
                            if (hungerLevel > hungerMax)
                                hungerLevel = hungerMax;
                        }
                        else if (hungerLevel >= hungerMax)
                        {
                            Console.WriteLine("Your bird is already full, please choose something else");
                        }
                        else if (player.HasMilletTreat() == false)
                        {
                            Console.WriteLine("You do not have enough treats. Please visit the store.");
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

        }

        public override int Play()
        {
            Console.Clear();
            bool play = true;
            Console.WriteLine("Welcome to the play menu!");
            Console.WriteLine("=========================");
            Console.WriteLine("\n\n{0} is excited to play with you.",petName);
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
                Console.WriteLine("Treats:{0}\n\n", player.GetBirdTreat());
                BirdImage();
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Perch-{0}\n2.Bird activity center-{1}\n3.Singing along to a song\n4.Back to Main Menu",player.GetPerch(),
                    player.GetActivityCenter());
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
                        if (petSkills[0] >= 1 && petSkills[4] >= 1 && player.HasPerch())
                        {
                            Console.WriteLine("\n{0} flys and lands on provided perch. \n{0} is excited and chirps loudly.", petName);
                            if (petSkills[0] < 10)
                            {
                                petSkills[0] += 1;
                                skillNotUsedTime[0] = skillDecrease.Minute;

                                Console.WriteLine("\nFlying +1");
                            }
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed +1");
                            }
                            if (petSkills[4] < 10)
                            {
                                petSkills[4] += 1;
                                skillNotUsedTime[4] = skillDecrease.Minute;
                                Console.WriteLine("\nPerching +1");
                            }
                            player.points += 5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you can not play with this yet, please train your bird more.");
                        }
                        break;
                    case 2:
                        //add item check
                        if (player.HasActivityCenter())
                        {
                            Console.WriteLine("\n{0} is excited when it sees the toy and starts chirping and jumping around excitedly before" +
                                " \njumping on the toy and playing with all the bells and whistles.", petName);
                            if (petSkills[1] < 10)
                            {
                                petSkills[1] += 1;
                                skillNotUsedTime[1] = skillDecrease.Minute;
                                Console.WriteLine("\nSpeed +1");
                            }
                            if (petSkills[4] < 10)
                            {
                                petSkills[4] += 1;
                                skillNotUsedTime[4] = skillDecrease.Minute;
                                Console.WriteLine("\nPerching +1");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Sorry you do not own this item yet, please visit the store.");
                        }
                        break;
                    case 3:
                        if (petSkills[2] >= 1)
                        {
                            Console.WriteLine("\n{0} starts whistling to the tune of the song you put on.", petName);
                            if (petSkills[2] < 10)
                            {
                                petSkills[2] += 1;
                                skillNotUsedTime[2] = skillDecrease.Minute;
                                Console.WriteLine("\nSinging +1");
                            }
                            player.points += 5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you can not do this yet, please train your bird more.");
                        }
                        break;
                    case 4:
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
            
            while(train)
            {
                DateTime skillDecrease = DateTime.Now;
                if (firstIteration != true)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                Console.WriteLine("Points:{0}", player.points);
                Console.WriteLine("Treats:{0}\n\n", player.GetBirdTreat());
                BirdImage();
                Console.WriteLine("\n\nMenu Options(choose number): ");
                Console.WriteLine("1.Perching\n2.Singing\n3.Talking\n4.Flying\n5.Dancing\n6.Back to Main Menu");
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

                switch(choice)
                {
                    //Add treat cost component and point requirement, may be corallated
                    case 1:
                        if (petSkills[4] < 10 && petSkills[0] >= 1 && player.HasMilletTreat())
                        {
                            Console.WriteLine("{0} is hesitant to fly to the perch offered, but as you enitce it \nwith treats and praise, it lands successfully on the perch", petName);
                            petSkills[4] += 1;
                            player.points += 5;
                            skillNotUsedTime[4] = skillDecrease.Minute;
                            Console.WriteLine("\nPerching +1");
                        }
                        else if(petSkills[0]<1)
                        {
                            Console.WriteLine("{0} can't learn to use a perch yet, must be taught flying first",petName);
                        }
                        else if(petSkills[4]>=10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.",petName);
                        }
                        else if(player.HasMilletTreat()==false)
                        {
                            Console.WriteLine("You do not have enough treats. Please visit the store.");
                        }
                        break;
                    case 2:
                        if(petSkills[2]<10 && player.HasMilletTreat())
                        {
                            Console.WriteLine("{0} doesn't quite know what to do when you start playing the music, " +
                                "but after you start to sing along, it joins in. \nYou give {0} a treat as a reward.",petName);
                            petSkills[2] += 1;
                            player.points += 5;
                            Console.WriteLine("\nSinging +1");
                            skillNotUsedTime[2] = skillDecrease.Minute;
                        }
                        else if( petSkills[2]>=10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if (player.HasMilletTreat() == false)
                        {
                            Console.WriteLine("You do not have enough treats. Please visit the store.");
                        }
                        break;
                    case 3:
                        if(petSkills[3]<10 && player.HasMilletTreat())
                        {
                            Console.WriteLine("{0} doesn't quite know what to do as you talk to it with a treat in your hand, \nbut after a while {0} starts to mimic you.",petName);
                            petSkills[3] += 1;
                            Console.WriteLine("\nTalking +1");
                            player.points += 5;
                            skillNotUsedTime[3] = skillDecrease.Minute;
                        }
                        else if(petSkills[3]>=10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if (player.HasMilletTreat() == false)
                        {
                            Console.WriteLine("You do not have enough treats. Please visit the store.");
                        }
                        break;
                    case 4:
                        if (petSkills[0] < 10 && player.HasMilletTreat())
                        {
                            //spell check
                            Console.WriteLine("{0} stands on the edge of the high perch you gave it and stands there nervous.\nAfter some persuassion and encouragement, {0} flys.", petName);
                            petSkills[0] += 1;
                            Console.WriteLine("\nFlying +1");
                            player.points += 5;
                            skillNotUsedTime[0] = skillDecrease.Minute;
                        }
                        else if(petSkills[0]>=10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if(!player.HasMilletTreat())
                        {
                            Console.WriteLine("You do not have enough treats. Please visit the store.");
                        }
                        break;
                    case 5:
                        if(petSkills[5]<10 && player.HasMilletTreat())
                        {
                            Console.WriteLine("{0} starts eagerly bobbing and prancing around to the music you put on.\n You give {0} a treat as a reward.", petName);
                            petSkills[5] += 1;
                            Console.WriteLine("\nDancing +1");
                            player.points += 5;
                            skillNotUsedTime[5] = skillDecrease.Minute;
                        }
                        else if(petSkills[5]>=10)
                        {
                            Console.WriteLine("{0} has maxed out this skill, please choose another.", petName);
                        }
                        else if (player.HasMilletTreat() == false)
                        {
                            Console.WriteLine("You do not have enough treats. Please visit the store.");
                        }
                        break;
                    case 6:
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
            Console.WriteLine("Flying:{0} Speed:{1} Singing:{2} Talking:{3} Perching:{4} Dancing:{5}\n", petSkills[0]
                , petSkills[1], petSkills[2], petSkills[3], petSkills[4], petSkills[5]);
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


        public void BirdImage()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"        .---.");
            Console.WriteLine(@"       /   6_6");
            Console.WriteLine(@"       \_  (__\");
            Console.WriteLine(@"       //   \\");
            Console.WriteLine(@"      ((     ))");
            Console.WriteLine(@"=======""===""===========");
            Console.WriteLine(@"         |||");
            Console.WriteLine(@"         |||");
            Console.WriteLine(@"         '|'");
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}
