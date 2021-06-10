using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KY_PP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("add galaxy ");
            Galaxy g1 = new Galaxy(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()), Console.ReadLine());
            Console.Write("add star ");
            Star s1 = new Star(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.Write("add planet ");
            Planet p1 = new Planet(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.Write("add moon ");
            Moon m1 = new Moon(Console.ReadLine(), Console.ReadLine());

            string theGalaxy;
            string retry = "exit";
            do
            {
                Console.WriteLine("Enter a command");
                theGalaxy = Console.ReadLine();

                switch (theGalaxy)
                {
                    case "list galaxies":
                        g1.ListGalaxy();
                        break;
                    case "list stars":
                        s1.ListStar();
                        break;
                    case "list planets":
                        p1.ListPlanet();
                        break;
                    case "list moons":
                        m1.ListMoon();
                        break;
                    case "print galaxy":
                        g1.PrintGalaxy();
                        s1.PrintStar();
                        p1.PrintPlanet();
                        m1.PrintMoon();
                        g1.EndList();
                        break;
                    default:
                        Console.WriteLine("No command entered");
                        Console.WriteLine("If you want to exit write: exit");
                        retry = Console.ReadLine();
                        break;
                }
            } while (retry != "exit");

        }

    }
}
