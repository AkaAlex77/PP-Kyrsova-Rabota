using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KY_PP
{
    class Star:Galaxy
    {
        private string sName;
        private string klass;
        private double masa;
        private double razmer;
        private int temp;
        private double svetimost;

        public string SName { get => sName; set => sName = value; }
        public string Klass { get => klass; set => klass = value; }
        public double Masa { get => masa; set => masa = value; }
        public double Razmer { get => razmer; set => razmer = value; }
        public int Temp { get => temp; set => temp = value; }
        public double Svetimost { get => svetimost; set => svetimost = value; }

        public Star()
        {

        }
        public Star (string sName)
        {
            this.sName = sName;
        }
        public Star(string ime, string klass, string sName, double svetimost, double masa, int temp, double razmer) : base(ime)
        {
            this.sName = sName;
            this.temp = temp;
            this.svetimost = svetimost;
            this.masa = masa;
            this.razmer = razmer;
            this.klass = KlassStar(temp);
        }
        public Star(string ime, string sName,  double svetimost, double masa, int temp, double razmer) : base(ime)
        {
            this.sName = sName;
            this.temp = temp;
            this.svetimost = svetimost;
            this.masa = masa;
            this.razmer = razmer;
            this.klass = KlassStar(temp);
        }

        internal string KlassStar(int temp)
        {
            if (temp > 2400 && temp < 3700) return "M";
            else if (temp > 3700 && temp < 5200) return "K";
            else if (temp > 5200 && temp < 6000) return "G";
            else if (temp > 6000 && temp < 7500) return "F";
            else if (temp > 7500 && temp < 10000) return "A";
            else if (temp > 10000 && temp < 30000) return "B";
            else return "O";
        }

        public void ListStar()
        {
            Console.WriteLine($"--- List of all researched stars ---");
            Console.WriteLine($"{sName}");
            Console.WriteLine("--- End of stars list---");
        }

        public void PrintStar()
        {
            Console.WriteLine("Stars:");
            Console.WriteLine($"      Name: {SName}");
            Console.WriteLine($"      Class:{KlassStar(Temp)} ({Svetimost}, {Masa}, {Temp}, {Razmer})");
        }
    }
}
