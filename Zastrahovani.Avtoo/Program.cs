using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zastrahovani.Avtoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete broi zastrahovki ");
            int n = int.Parse(Console.ReadLine());

            List<Zastrahovka> zastrahovka = new List<Zastrahovka>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Vuvejdane na avtomobil {i + 1}:");
                Console.Write("Nomer na zastrahovka: ");
                string nomer = Console.ReadLine();

                Console.Write("Ime: ");
                string ime = Console.ReadLine();

                Console.Write("Data na zastrahovkata: ");
                double data = double.Parse(Console.ReadLine());

                Console.Write("Cena na zastrahovkata: ");
                double cena = double.Parse(Console.ReadLine());

                zastrahovka.Add(new Zastrahovka(nomer, ime, data, cena));
            }

            // Izvezhdane na vsichki
            Console.WriteLine("Vsichki zastrahovki:");
            zastrahovka.ForEach(x => x.Print());
            Console.WriteLine("------------------------------");
            //  Cena nad 200
            Console.WriteLine("Zastrahovki s cena nad 200 evro:");
            zastrahovka.Where(x => x.Cena > 200).ToList().ForEach(x => x.Print());
            Console.WriteLine("------------------------------");
            //  Izticha nay-skoro
            Console.WriteLine("Zastrahovka, koqto izticha nai skoro:");
            zastrahovka.OrderBy(x => x.Data).First().Print();
            Console.WriteLine("------------------------------");
            //  Sortirani po ime
            Console.WriteLine("Sortirani po ime na sobstvenika:");
            zastrahovka.OrderBy(x => x.ImeSobstvenik).ToList().ForEach(x => x.Print());
        }
    }
    }

