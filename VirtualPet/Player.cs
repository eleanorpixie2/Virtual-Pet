using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Player:Item
    {
        public string name;
        public int points;

        //decreases points if animal's needs aren't met
        public void PetManager(int hunger, int thirst, int max)
        {
            if(hunger < (max/2) || thirst < (max/2))
            {
                points -= 5;
            }
        }

       
    }
}
