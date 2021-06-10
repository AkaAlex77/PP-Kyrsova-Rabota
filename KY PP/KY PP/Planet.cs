using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KY_PP
{
    class Planet:Star
    {
        private string pName;
        private string pType;
        private string supLive;
        
        public Planet(string pName)
        {
            this.pName = pName;
        }
        public Planet (string sName,string pName,string pType, string supLive):base(sName)
        {
            this.pName = pName;
            this.pType = TypePlanet(pType);
            this.supLive = supLive;
        }

        public string PName { get => pName; set => pName = value; }
        public string PType { get => pType; set => pType = value; }
        public string SupLive { get => supLive; set => supLive = value; }

        internal string TypePlanet(string pType)
        {
            if (pType == "terrestrial") return "terrestrial";
            else if (pType == "giant planet") return "giant planet";
            else if (pType == "ice giant") return "ice giant";
            else if (pType == "mesoplanet") return "mesoplanet";
            else if (pType == "mini-neptune") return "mini-neptune";
            else if (pType == "planetar") return "planetar";
            else if (pType == "super-earth") return "super-earth";
            else if (pType == "super-jupiter") return "super-jupiter";
            else if (pType == "sub-earth") return "sub-earth";
            else return "none";
        }

        public void ListPlanet()
        {
            Console.WriteLine($"--- List of all researched planets ---");
            Console.WriteLine($"{pName}");
            Console.WriteLine("--- End of planets list---");
        }


        public void PrintPlanet()
        {
            Console.WriteLine("       Planets:");
            Console.WriteLine($"              Name:{PName}");
            Console.WriteLine($"              Type:{PType}");
            Console.WriteLine($"              Support life:{SupLive}");
        }
    }
}
