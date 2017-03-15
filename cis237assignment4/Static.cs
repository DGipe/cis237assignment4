using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Static 
    {
        //Create a class level variable for the droid collection
        IDroidCollection droidCollection;

        //Constructor that will take in a droid collection to use
        public Static(IDroidCollection DroidCollection)
        {
            this.droidCollection = DroidCollection;
        }
        
        //Add Static droids
        public void addStatic()
        {
            droidCollection.Add("Carbonite", "Utility", "Bronze", false, false, true);
            droidCollection.Add("Vanadium", "Astromech", "Gold", false, true, true, false, 12);
            droidCollection.Add("Quadranium", "Utility", "Bronze", true, false, true);
            droidCollection.Add("Carbonite", "Utility", "Silver", true, false, true);
            droidCollection.Add("Carbonite", "Janitor", "Bronze", true, false, false, true, true);
            droidCollection.Add("Vanadium", "Janitor", "Silver", false, true, true, true, false);
            droidCollection.Add("Carbonite", "Protocol", "Gold", 44);
            droidCollection.Add("Vanadium", "Protocol", "Silve", 18);
            droidCollection.Add("Quadranium", "Astromech", "Silver", true, false, false, false, 3);
            droidCollection.Add("Quadranium", "Janitor", "Bronze", false, true, true, true, false);
            droidCollection.Add("Vanadium", "Protocol", "Silve", 18);
            droidCollection.Add("Quadranium", "Astromech", "Gold", false, false, false, true, 6);
            droidCollection.Add("Vanadium", "Utility", "Bronze", true, false, false);

        }

    }
}
