using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char volba = char.Parse(Console.ReadLine());
            switch (volba)
            {
                case 'a':
                    Console.WriteLine("V čem budete počítat? 1- m,s 2- km,h");
                    int cislo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("zadejte dráhu: ");
                    double draha = double.Parse(Console.ReadLine());
                    Console.WriteLine("zadejte cas: ");
                    double cas = double.Parse(Console.ReadLine());
                    double vysledek = draha / cas;
                    if (cislo == 1)
                    {
                        Console.WriteLine("vysledek: " + vysledek + "m/s");
                    }
                    else if (cislo == 2)
                    {
                        Console.WriteLine("vysledek: " + vysledek + "km/h");
                    }
                    else
                    {
                        Console.WriteLine("Vyberte volbu 1/2");
                    }
                    
                    break;
                case 'b':
                    Console.WriteLine("zadejte cas: ");
                    double t = double.Parse(Console.ReadLine());
                    Console.WriteLine("zadejte zrychleni: ");
                    double g = double.Parse(Console.ReadLine());
                    double v = t * g;
                    double h = 0.5 * g * (Math.Pow(t, 2));
                    Console.WriteLine(h);
                    break;
                case 'c':
                    Console.WriteLine("Vybrali jste volbu 3");
                    break;
                case 'd':
                    Console.WriteLine("Vybrali jste volbu 4");
                    break;
               /*default: Console.WriteLine("V daném rozsahu není volba");*/
            }
            Console.ReadKey();
        }
    }
}
