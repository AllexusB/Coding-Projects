//Room Class

using System;
using System.Collections.Generic;
using System.Text;

namespace ABain_Colossal_Cave_Adventure
{
    class Room
    {
        //----- Data Members -----//
        public const int noDoor = -1;

        protected int roomAmount;
        protected string name;
        protected string description;
        protected int nDoor;
        protected int sDoor;
        protected int eDoor;
        protected int wDoor;
        protected bool firstVist;


        //Parameterized Constructor
        public Room(string newName, string NewsDescription, int newNDoor, int newSDoor, int newEDoor, int newWDoor)
        {
            //Constructor variables
            roomAmount = 12;
            name = newName;
            description = NewsDescription;
            nDoor = newNDoor;
            sDoor = newSDoor;
            eDoor = newEDoor;
            wDoor = newWDoor;
            firstVist = true;
        }

        //Methods for room draw
        public string getName()
        {
            return name;
        }

        public string getDescription()
        {
            return description;
        }

        public int goNorth()
        {
            return nDoor;
        }

        public int goSouth()
        {
            return sDoor;
        }

        public int goWest()
        {
            return wDoor;
        }

        public int goEast()
        {
            return eDoor;
        }

        public bool getVisit()
        {
            return firstVist;
        }

        public void setVisit()
        {
            firstVist = false;
        }
        //override + ToString():string
    }
}
