using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KY_PP
{
    class Galaxy
    {
        private string ime;
        private string tip;
        private double age;
        private string godini;

        public string Ime { get => ime; set => ime = value; }
        public string Tip { get => tip; set => tip = value; }
        public double Age { get => age; set => age = value; }
        public string Godini { get => godini; set => godini = value; }

        public Galaxy(string ime, string tip, double age, string godini)
        {
            this.ime = ime;
            this.tip = tip;
            this.age = age;
            this.godini = godini;
        }

        public Galaxy(string ime)
        {
            this.ime = ime;
        }

        public Galaxy()
        {

        }

        internal string TypeGalaxy(string tip)
        {
            if (tip == "elliptical") return "elliptical";
            else if (tip == "lenticular") return "lenticular";
            else if (tip == "spiral") return "spiral";
            else if (tip == "irregular") return "irregular";
            else return "none";
        }

        public void ListGalaxy()
        {
            Console.WriteLine($"--- List of all researched galaxies ---");
            Console.WriteLine($"{Ime}");
            Console.WriteLine("--- End of galaxies list---");
        }


        public void PrintGalaxy()
        {
            Console.WriteLine($"---Data for {Ime} galaxy---");
            Console.WriteLine($"Type: {TypeGalaxy(Tip)}");
            Console.WriteLine($"Age: {Age}{Godini}");
        }

        public void EndList()
        {
            Console.WriteLine($"---End of data for {Ime} galacy---");
        }
    }
}
