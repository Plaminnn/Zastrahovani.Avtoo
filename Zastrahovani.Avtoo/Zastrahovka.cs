using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zastrahovani.Avtoo
{

        public class Zastrahovka
        {
            private string nomer;
            private double data;

            public string ImeSobstvenik { get; set; }
            public double Data { get; set; }
            public double Cena { get; set; }


            public Zastrahovka(string nomer, string ime)
            {
                Nomer = nomer;
                ImeSobstvenik = ime;
                Data = data;
                Cena = 0;
            }

            public Zastrahovka(string nomer, string ime, double data, double cena)
            {
                Nomer = nomer;
                ImeSobstvenik = ime;
                Data = data;
                Cena = cena;
            }


            public string Nomer
            {
                get { return nomer; }
                set
                {
                    if (value.Length < 4)
                    {
                        throw new ArgumentException("Greshka");
                    }
                    nomer = value;
                }
            }

            public void Print()
            {
                Console.WriteLine($"Nomer: {Nomer} | Sobstvenik: {ImeSobstvenik} | Data: {Data} | Cena: {Cena} evro.");
            }
        }
    }


