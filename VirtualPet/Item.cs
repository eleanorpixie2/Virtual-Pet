using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Item
    {
        //Toys
        protected int ball;
        protected int yarn;
        protected int laser;
        protected int stickToy;
        protected int rope;
        protected int frisbee;
        protected int squeakyToy;
        protected int perch;
        protected int activityCenter;

        //Food
        protected int dryFood;
        protected int pDryFood;
        protected int cannedFood;
        protected int pCannedFood;
        protected int dogBiscut=5;
        protected int catTreat=5;
        protected int pBirdFeed;
        protected int birdFeed;
        protected int milletTreat=5;
        protected int water;
        public bool HasBall()
        {
            if (ball > 0)
            {
                ball -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddBall()
        {
            ball += 1;
        }

        public int GetBall()
        {
            return ball;
        }

        public bool HasYarn()
        {
            if (yarn > 0)
            {
                yarn -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddYarn()
        {
            yarn += 1;
        }

        public int GetYarn()
        {
            return yarn;
        }

        public bool HasLaser()
        {
            if (laser> 0)
            {
                laser -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddLaser()
        {
            laser += 1;
        }

        public int GetLaser()
        {
            return laser;
        }

        public bool HasStickToy()
        {
            if (stickToy > 0)
            {
                stickToy -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddStickToy()
        {
            stickToy += 1;
        }

        public int GetStickToy()
        {
            return stickToy;
        }

        public bool HasRope()
        {
            if (rope > 0)
            {
                rope -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddRope()
        {
            rope += 1;
        }

        public int GetRope()
        {
            return rope;
        }

        public bool HasFrisbee()
        {
            if (frisbee > 0)
            {
                frisbee -= 1;
                return true;
            }
            else
                return false;
        }

        public int GetFrisbee()
        {
            return frisbee;
        }

        public void AddFrisbee()
        {
            frisbee += 1;
        }

        public bool HasSqueakyToy()
        {
            if (squeakyToy > 0)
            {
                squeakyToy -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddSqueakyToy()
        {
            squeakyToy += 1;
        }

        public int GetSqueakyToy()
        {
            return squeakyToy;
        }

        public bool HasPerch()
        {
            if (perch > 0)
            {
                perch -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddPerch()
        {
            perch += 1;
        }

        public int GetPerch()
        {
            return perch;
        }

        public bool HasActivityCenter()
        {
            if (activityCenter > 0)
            {
                activityCenter -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddActivityCenter()
        {
            activityCenter += 1;
        }

        public int GetActivityCenter()
        {
            return activityCenter;
        }

        public bool HasDryFood()
        {
            if (dryFood > 0)
            {
                dryFood -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddDryFood()
        {
            dryFood += 1;
        }

        public int GetDryFood()
        {
            return dryFood;
        }

        public bool HasPremiumDryFood()
        {
            if (pDryFood > 0)
            {
                pDryFood -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddPremiumDryFood()
        {
            pDryFood += 1;
        }

        public int GetPremiumDryFood()
        {
            return pDryFood;
        }

        public bool HasCannedFood()
        {
            if (cannedFood > 0)
            {
                cannedFood -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddCannedFood()
        {
            cannedFood += 1;
        }

        public int GetCannedFood()
        {
            return cannedFood;
        }

        public bool HasPremiumCannedFood()
        {
            if (pCannedFood > 0)
            {
                pCannedFood -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddPremiumCannedFood()
        {
            pCannedFood += 1;
        }

        public int GetPremiumCannedFood()
        {
            return pCannedFood;
        }
        
        public bool HasDogBiscut()
        {
            if (dogBiscut > 0)
            {
                dogBiscut -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddDogBiscut()
        {
            dogBiscut += 1;
        }

        public int GetDogBiscut()
        {
            return dogBiscut;
        }

        public bool HasCatTreat()
        {
            if (catTreat > 0)
            {
                catTreat -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddCatTreat()
        {
            catTreat += 1;
        }

        public int GetCatTreat()
        {
            return catTreat;
        }

        public bool HasBirdFeed()
        {
            if (birdFeed > 0)
            {
                birdFeed -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddBirdFeed()
        {
            birdFeed += 1;
        }

        public int GetBirdFeed()
        {
            return birdFeed;
        }


        public bool HasPremiumBirdFeed()
        {
            if (pBirdFeed > 0)
            {
                pBirdFeed -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddPremiumBirdFeed()
        {
            pBirdFeed += 1;
        }

        public int GetPremiumBirdFeed()
        {
            return pBirdFeed;
        }

        public bool HasMilletTreat()
        {
            if (milletTreat > 0)
            {
                milletTreat -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddMilletTreat()
        {
            milletTreat += 1;
        }

        public int GetBirdTreat()
        {
            return milletTreat;
        }

        public bool HasWater()
        {
            if (water > 0)
            {
                water -= 1;
                return true;
            }
            else
                return false;
        }

        public void AddWater()
        {
            water += 1;
        }

        public int GetWater()
        {
            return water;
        }

    }
}
