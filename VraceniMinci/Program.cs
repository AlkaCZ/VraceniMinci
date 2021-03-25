using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VraceniMinci
{

   public class Program
    {
       public static int pocetPadesat = 0;
       public static int pocetDvacet = 0;
       public static int pocetDeset = 0;
       public static int pocetPet = 0;
       public static int pocetDva = 0;
       public static int pocetJedna = 0;

        public static void Rozdeleni(bool MaxPadesat,bool MaxDvacet, bool MaxDeset, bool MaxPet, bool MaxDva, int castka)
        {
            //50
            if (MaxPadesat)
            {
                int zbytekPadesat = castka % 50;

                if (zbytekPadesat != 0)
                {
                    pocetPadesat = (castka - zbytekPadesat) / 50;
                    Console.WriteLine("50 - " + pocetPadesat);
                    Rozdeleni(false, true, true, true,true, zbytekPadesat);


                }
                else
                {
                    pocetPadesat = (castka - zbytekPadesat) / 50;
                    Console.WriteLine("50 - " + pocetPadesat);


                }

            }
            //
            //20
          else  if (MaxDvacet)
            {
                int zbytekDvacet = castka % 20;

                if (zbytekDvacet != 0)
                {
                    pocetDvacet = (castka - zbytekDvacet) / 20;
                    Console.WriteLine("20 - " + pocetDvacet);
                    Rozdeleni(false, false, true, true, true, zbytekDvacet);
                }
                else
                {
                    pocetDvacet = (castka - zbytekDvacet) / 20;
                    Console.WriteLine("20 - " + pocetDvacet);

                }

            }
            //
            //10
            else if (MaxDeset)
            {
                int zbytekDeset = castka % 10;

                if (zbytekDeset != 0)
                {
                    pocetDeset = (castka - zbytekDeset) / 10;
                    Console.WriteLine("10 - " + pocetDeset);
                    Rozdeleni(false, false, false, true, true, zbytekDeset);
                }
                else
                {
                    pocetDeset = (castka - zbytekDeset) / 10;
                    Console.WriteLine("10 - " + pocetDeset);

                }

            }
            //
            //5
            else if (MaxPet)
            {
                int zbytekPet = castka % 5;

                if (zbytekPet != 0)
                {
                    pocetPet = (castka - zbytekPet) / 5;
                    Console.WriteLine("5 - " + pocetPet);
                    Rozdeleni(false, false, false, false, true, zbytekPet);
                }
                else
                {
                    pocetPet = (castka - zbytekPet) / 5;
                    Console.WriteLine("5 - " + pocetPet);

                }

            }
            //
            //2
            else if (MaxDva)
            {
                if (castka != 1)
                {
                    int zbytekDva = castka % 2;
                    if (zbytekDva != 0)
                    {
                        pocetDva = (castka - zbytekDva) / 2;
                        Console.WriteLine("2 - " + pocetDva);
                        Console.WriteLine("1 - " + pocetJedna);
                        Rozdeleni(false, false, false, false, false, pocetDva);
                    }
                }
               
                else
                {
                    pocetJedna = castka;
                    Console.WriteLine("2 - " + pocetDva);
                    Console.WriteLine("1 - " + pocetJedna);
                }
                
    

            }






        }

        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.Write("Cena nákupu : ");
                int cenaNakupu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Zaplacená částka : ");
                int zaplacenaCastka = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (cenaNakupu < zaplacenaCastka)
                {
                    Rozdeleni(true, true, true, true, true, zaplacenaCastka - cenaNakupu);
                    start = false;
                }
                else if(cenaNakupu > zaplacenaCastka)
                {
                    Console.WriteLine("Nezaplatil jsi nákup, zadej informace znovu");
                    Console.WriteLine("");

                    start = true;
                }
                else
                {
                    Console.WriteLine("Nic se nemúže vrátit");
                    start = false;
                }
            }


            Console.ReadKey();
        }
    }
}
