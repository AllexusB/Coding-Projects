//Food class

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10__Minecraft_Inheritance
{
    class Food
    {
        //----------- Data Members ----------//
       protected int hungerReplenished = 0;

        //-------- Getters and Setters ----------//

        //Gets Hunger value.
        private int getHungerReplenished()
        {
            return hungerReplenished;
        }

        //Sets replenished value.
        private int setHungerReplenished(int newVal)
        {
            hungerReplenished = newVal;
            return newVal;
        }
    }
}
