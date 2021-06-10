using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KY_PP
{
    class Moon:Planet
    {
        private string mName;

        public Moon (string pName, string mName):base(pName)
        {
            this.mName = mName;
        }

        public string MName { get => mName; set => mName = value; }

        public void ListMoon()
        {
            Console.WriteLine($"--- List of all researched moons ---");
            Console.WriteLine($"{mName}");
            Console.WriteLine("--- End of moons list---");
        }



        public void PrintMoon()
        {
            Console.WriteLine("              Moons:");
            Console.WriteLine($"                   {MName}");
        }

    }
}
