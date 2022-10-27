//Allexus Bain
//Colossal Cave Adventure
//14th April 2021
//Game of Choices

using System;

namespace ABain_Colossal_Cave_Adventure
{
    class Program
    {
        //Amount of rooms
        public const int roomAmount = 12;

        //Room class
        static void OpenRoom(Room[] items)
        {
            //for loop to change rooms.
            for (int i = 0; i < roomAmount; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        //Room List
        static void ManyRooms(Room[] theseRooms)
        {   
            //End of Road
             theseRooms[0] = new ComplexRoom("End of Road" , "\nYou are standing at the end of a road before a small brick building." +
             "\nAround you is a forest.\nA small stream flows out of the building and down a gully.",
             -1, 1, -1, -1, -1, -1, -1, -1); //Values represent directions through Room and ComplexRoom classes.

            //The Valley
            theseRooms[1] = new ComplexRoom("Valley" , "\nYou are in a valley in the forest beside a stream tumbling along a " +
                "rocky bed.", 
                0, 2, -1, -1, -1, -1, -1, -1);

            //Slit in Streambed
            theseRooms[2] = new ComplexRoom("Slit in Streambed", "\nAt your feet all the water of the stream splashes into a 2-inch slit" +
                " in the rock.\nDownstream the streambed is a bare rock.", 
                1, 3, -1, -1, -1, -1, -1, -1);

            //Outside Grate
            theseRooms[3] = new ComplexRoom("Outside Grate", "\nYou are in a 20-foor depression floored with bare dirt." +
                "\nSet into the dirt is a strong " +
                "steel grate mounted in concrete.\nA dry streambed leads into the depression.\nThe grate is locked.", 
                2, -1, -1, -1, -1, -1, -1, 4);

            //Cobble Crawl
            theseRooms[4] = new ComplexRoom("Cobble Crawl", "You are in a small chamber beneath a 3x3 steel grate to the surface. " +
                "A low crawl over cobbles leads inward to the west. The grate is open.", -1, -1, -1, 5, -1, -1, 3, -1);

            //Debris Room
            theseRooms[5] = new ComplexRoom("Debris Room", "\nIt is now pitch dark. If you proceed you will likely fall into a pit." +
            "\nIF THIS GAME HAD ITEMS, YOU WOULD USE THE LAMP YOU PICKED UP IN THE BUILDING" +
            "\nYour lamp is now on. You are in a debris room filled with stuff washed in from the surface." +
            "\nA low wide passage with cobbles becomes plugged with mud and debris here, " +
            "but an awkward canyon leads upward and west.\nA note on the wall says \"Magic word XYZZY\". " +
            "A three foot black rod with a rusty star on an end lies nearby.", -1, -1, 4, 6, -1, -1, -1, -1);

            //Canyon
            theseRooms[6] = new ComplexRoom("Canyon", "\nYou are in an awkward sloping east/west canyon.",
                -1, -1, 5, 7, -1, -1, -1, -1);

            //Chamber
            theseRooms[7] = new ComplexRoom("Chamber", "\nYou are in a splendid chamber thirty feet high." +
                "The walls are frozen rivers of orange stone.\nAn awkward canyon and a good passage exit " +
                "from east and west sides of the chamber.\nA cheerful little bird is sitting here singing.",
                -1,-1,6,8,-1,-1,-1,-1);

            //Pit
            theseRooms[8] = new ComplexRoom("Pit", "\nAt your feet is a small pit breathing traces of white mist." +
                "\nAn east passage ends here except for a small crack leading on. Rough stone steps lead down the pit.", 
                -1,-1,7,-1,-1,-1,-1,9);

            //Hall of Mists
            theseRooms[9] = new ComplexRoom("Hall of Mists", "\nYou are at one end of a vast hall stretching" +
                "forward out of sight to the west. \nThere are openings to either side. Nearby, a wide stone staircase leads downward." +
                "The hall is filled with wisps of white mist swaying to and fro almost as if alive.\nA cold wind blows up the staircase." +
                "There is a passage at the top of a dome behind you. \nRough stone steps lead up the dome.",
                -1, -1, -1, 10, -1, -1, 8, -1);

            //Fissure
            theseRooms[10] = new ComplexRoom("Fissure", "\nYou are on the east bank of a fissure slicing clear across the hall." +
                "\nThe mist is quite thick here, and the fissure is too wide to jump.", 
                -1,-1,9,11,-1,-1,-1,-1);

            //Diamond Room
            theseRooms[11] = new ComplexRoom("Diamond Room", "\nYou are on the west side of the fissure in the Hall of Mists." +
                "\nThere are diamonds here! A crystal bridge now spans the fissure.", 
                -1,-1,10,-1,-1,-1,-1,-1); 
        }

        //User directional commands are looped here.
        static void Commands(Room[] moreRooms, ref int curLoc)
        {
            //user input
            string userInput = "";
            userInput = Console.ReadLine();

            //If statement for directions.
                //NORTH
                if (userInput == "north" || userInput == "n")
                {
                //Controls Room Location
                int newLoc = moreRooms[curLoc].goNorth();
                if (newLoc == -1)
                {
                    Console.WriteLine("Sorry, you can't go that way.");
                }
                //current location becomes new location.
                else
                {
                    curLoc = newLoc;
                }
            }
                //SOUTH
                else if (userInput == "south" || userInput == "s")
                {
                //Controls Room Location
                    int newLoc = moreRooms[curLoc].goSouth(); 
                    if(newLoc == -1)
                    {
                        Console.WriteLine("Sorry, you can't go that way.");
                    }
                    else
                    {
                        curLoc = newLoc;
                    }
                }
                //EAST
                else if (userInput == "east" || userInput == "e")
                {
                //Controls Room Location
                    int newLoc = moreRooms[curLoc].goEast();
                    if (newLoc == -1)
                    {
                        Console.WriteLine("Sorry, you can't go that way.");
                    }
                    else
                    {
                        curLoc = newLoc;
                    }
                }
                //WEST
                else if(userInput == "west" || userInput == "w")
                {
                    //Controls Room Location
                    int newLocation = moreRooms[curLoc].goWest();
                    if (newLocation == -1)
                    {
                        Console.WriteLine("Sorry, you can't go that way.");
                    }
                    else
                    {
                        curLoc = newLocation;
                    }
                }
                //If user wants to see description again.
                if (userInput == "look" || userInput == "l")
                {
                    Console.WriteLine(moreRooms[curLoc].getDescription());
                }
                //IN
                if(userInput == "in" || userInput == "i")
                {
                if (moreRooms[curLoc].GetType() == typeof(ComplexRoom))
                {
                    //Controls Room Location
                    int newLoc = ((ComplexRoom)moreRooms[curLoc]).goIn();
                    if (newLoc == -1)
                    {
                        Console.WriteLine("Sorry, you can't go that way.");
                    }
                    else
                    {
                        curLoc = newLoc;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you can't go that way.");
                }
            }
                //OUT
                if (userInput == "out" || userInput == "o")
                {
                if (moreRooms[curLoc].GetType() == typeof(ComplexRoom))
                {
                    //Controls Room Location
                    int newLoc = ((ComplexRoom)moreRooms[curLoc]).goOut();
                    if (newLoc == -1)
                    {
                        Console.WriteLine("Sorry, you can't go that way.");
                    }
                    else
                    {
                        curLoc = newLoc;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you can't go that way.");
                }
            }
                //UP
                if (userInput == "up" || userInput == "u")
                {
                if (moreRooms[curLoc].GetType() == typeof(ComplexRoom))
                {
                    //Controls Room Location
                    int newLoc = ((ComplexRoom)moreRooms[curLoc]).goUp();
                    if (newLoc == -1)
                    {
                        Console.WriteLine("Sorry, you can't go that way.");
                    }
                    else
                    {
                        curLoc = newLoc;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you can't go that way.");
                }
            }
            //DOWN
            if (userInput == "down" || userInput == "d")
            {
                if (moreRooms[curLoc].GetType()==typeof(ComplexRoom))
                {
                    //Controls Room Location
                    int newLoc = ((ComplexRoom)moreRooms[curLoc]).goDown();
                    if (newLoc == -1)
                    {
                        Console.WriteLine("Sorry, you can't go that way.");
                    }
                    else
                    {
                        curLoc = newLoc;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you can't go that way.");
                }
            }

            //Quit
            else if (userInput == "quit" || userInput == "q")
            {
                Console.WriteLine("Thank you for Playing this game!" +
                    "\nQuitting....");
                //Exits Game.
                System.Environment.Exit(0);
            }

         }
        
        //Main
        static void Main(string[] args)
        {
            //Arrays to call each room
            Room[] roomList = new Room[roomAmount];
            ComplexRoom[] direct = new ComplexRoom[roomAmount];

            ManyRooms(roomList);

            //starting at end of road which is 0.
            int currentLoc = 0;

            //Welcome statement
            Console.WriteLine("Welcome to Colossal Cave Adventure!" +
                "\n\nYou have have directions:\nnorth(n) south(s) east(e) west(w)" +
                "\nin(i) out(o) up(u) down(d)" +
                "\n\nlook (l) to check description" +
                "\nquit (q) at anytime to exit");

            //Loop for commands.
            while(true)
           {
                //Checks to see if the name is repeated.
                if (roomList[currentLoc].getVisit()==true)
                {
                    //Writes the current room location and outputs its description.
                    Console.WriteLine(roomList[currentLoc].getDescription());
                    roomList[currentLoc].setVisit();
                }
                else
                {
                    //If location is repeated, say name and not description.
                    Console.WriteLine(roomList[currentLoc].getName());
                }

                //Call directional Commands
                Commands(roomList, ref currentLoc);
            }
        }
    }
}
