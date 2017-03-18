//David Gipe
//CIS237
//3-20-17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);

            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);

            //Create a static variable class and pass the droidCollection into it as a dependency
            Static staticInput = new Static(droidCollection);

            //Display the main greeting for the program
            userInterface.DisplayGreeting();

            //Display the main menu for the program
            userInterface.DisplayMainMenu();

            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();
           

            //While the choice is not equal to 3, continue to do work with the program
            while (choice != 6)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Add all hard coded droids in static class
                    case 2:
                        staticInput.addStatic();
                        break;

                    //Choose to Print the droid
                    case 3:
                        userInterface.PrintDroidList();
                        break;

                    //Categorize by model
                    case 4:

                        break;

                    // Sort by total cosr
                    case 5:

                        break;
                }
                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }
        }
    }
}
