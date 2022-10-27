//Complex Room

using System;
using System.Collections.Generic;
using System.Text;

namespace ABain_Colossal_Cave_Adventure
{
    class ComplexRoom : Room
    {
        //----- Data Members ------//
        private int inDoor;
        private int outDoor;
        private int upDoor;
        private int downDoor;

        //Constructor
        public ComplexRoom(string name, string description, int nDoor, int sDoor, int eDoor, int wDoor,
            int inDoor, int outDoor, int upDoor, int downDoor) 
            : base(name, description, nDoor, sDoor, eDoor, wDoor) //Passes arguments to base constructor (Room)
        {
            this.inDoor = inDoor;
            this.outDoor = outDoor;
            this.upDoor = upDoor;
            this.downDoor = downDoor;
        }

        //Getters
        public int goIn()
        {
            return inDoor;
        }

        public int goOut()
        {
            return outDoor;
        }

        public int goUp()
        {
            return upDoor;
        }

        public int goDown()
        {
            return downDoor;
        }
    }
}
