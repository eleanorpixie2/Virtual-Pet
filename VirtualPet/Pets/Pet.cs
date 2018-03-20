using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VirtualPet
{
    class Pet
    {
        protected string petType;
        protected string petName;
        protected int bDay;
        protected int bDayMonth;
        protected int bDayYear;
        protected int petAge;
        protected int petLevel;
        protected int[] petSkills;
        protected int hungerLevel;
        protected int hungerMax;
        protected int thirstLevel;
        protected int thirstMax;
        protected int skillRegression;
        protected int[] skillNotUsedTime;
        protected Player player;

        //For a new game/new player
        public Pet()
        {
            //Every 4 min
            skillRegression = 4;

            petLevel = 1;

            //Age starts at 0, because it is in years
            petAge = 0;

            //Intial amount the animal can be hungry, can go up with age/levels
            hungerMax = 10;

            //Inital amount the animal can be thirsty, can go up with levels/age
            thirstMax = 10;

            //How hungry the animal is
            hungerLevel = 8;
            thirstLevel = 8;

           
        }

        public virtual void SetName(string name)
        {
            petName = name;
        }

        public virtual string GetPetType()
        {
            return petType;
        }

        //Has the animal eat and the amount they are hungry decreases an amount depending on the food given
        public virtual void Eat()
        {
            
        }

        public virtual int Play()
        {
            return 0;
        }

        public virtual void PetAnimal()
        {
            while (true)
            {
                Console.WriteLine("{0} likes you petting them and you get 10 points in return", petName);
                Thread.Sleep(3000);
                break;
            }

            player.points += 10;
        }

        public virtual void LevelUp()
        {
            //each skill over a certain amount
            int skills = 0;
            foreach(int skill in petSkills)
            {
                if(skill>=(petLevel+1))
                {
                    skills += 1;
                }
            }

            if (skills > 2 && skills <= petSkills.Length)
            {
                hungerLevel = hungerMax + 5;
                thirstLevel = thirstMax + 5;
                petLevel += 1;
                hungerMax += 5;
                thirstMax += 5;
                
                while (true)
                {
                    Console.WriteLine("Congrats! {0} has leveled up to {1}", petName, petLevel);
                    Thread.Sleep(2000);
                    break;
                }
            }
        }

        public virtual void SkillDecrease()
        {
            int n = 0;
            DateTime minDate = DateTime.Now;
            int min = minDate.Minute;
            foreach (int i in skillNotUsedTime)
            {
                if(i+skillRegression<=min)
                {
                    if (i > 0)
                        petSkills[n] -= 1;
                    if (petSkills[n] < 0)
                        petSkills[n] = 0;
                }
                n++;
            }
        }

        public virtual void PetBirthday()
        {
            int daysToBDay = bDay+15;
            if(daysToBDay==bDay)
            {
                petAge += 1;
                daysToBDay += 15;
                while (true)
                {
                    Console.WriteLine("It's {0} birthday! They are now {1} years old.", petName, petAge);
                    Thread.Sleep(2000);
                    break;
                }
            }
            else
            {
                daysToBDay -= 1;
            }
           
        }

        public virtual void PetDying()
        {
            if(hungerLevel>0)
            {
                hungerLevel -= 1;
            }
            else if(hungerLevel<=0)
            {
                player.points -= 2;
                while(true)
                {
                    Console.WriteLine("{0} is straving, please feed them. -2 points");
                    Thread.Sleep(3000);
                    break;
                }
                if (player.points<0)
                {
                    player.points = 0;
                }
            }
            if(thirstLevel>0)
            {
                thirstLevel -= 1;
            }
            else if(thirstLevel<=0)
            {
                player.points -= 2;
                while (true)
                {
                    Console.WriteLine("{0} is dehydrated, please feed them. -2 points");
                    Thread.Sleep(3000);
                    break;
                }
                if (player.points < 0)
                {
                    player.points = 0;
                }
            }
        }

        

        

    }
}
