using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5NIT_ConsApp_OefeningenMethodes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Oefening 1
            /// 
            /// Oefening 1: 
            /// 
            Console.WriteLine("Oefening 1");

            //versie 01
            mijnIntroductie();

            //versie 02
            mijnIntroductie("Tom", 43, "Esplanade 6");

            //versie 03
            Console.Write("Wat is jouw naam:     ");
            string naam = Console.ReadLine();
            Console.Write("Wat is jouw leeftijd:     ");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wat is jouw adres:     ");
            string adres = Console.ReadLine();

            mijnIntroductie(naam, leeftijd, adres);

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening Wiskundige formules
            /// 
            /// Oefening Wiskundige formules 
            /// 
            Console.WriteLine("Oefening Wiskundige formules");

            Console.Write("Gelieve een lengte in te vullen:     ");
            int lengte = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Jouw vierkant heeft een oppervlakte van: {vierkant(lengte)}.");
            
            //-----------------------------------------------------

            Console.Write("Gelieve een diameter in te vullen:     ");
            int diameter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Jouw cirkel heeft een straal van: {straal(diameter)}.");
            Console.WriteLine($"Jouw cirkel heeft een omtrek van: {omtrekCirkel(diameter)}.");
            Console.WriteLine($"Jouw cirkel heeft een oppervlakte van: {oppervlakteCirkel(diameter)}.");
            
            //-----------------------------------------------------

            Console.Write("Gelieve een 1ste getal in te vullen:     ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gelieve een 2de getal in te vullen:     ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Het grootste getal is: {grootste(getal1, getal2)}.");

            //-----------------------------------------------------

            Console.Write("Gelieve een getal in te vullen:     ");
            int getal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Is jouw getal even: {isEven(getal)}.");

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening Tijd voor tijd
            /// 
            /// Oefening Tijd voor tijd
            /// 
            Console.WriteLine("Oefening Tijd voor tijd");

            Console.Write("Gelieve een aantal seconden in te vullen:     ");
            int seconden = Convert.ToInt32(Console.ReadLine());

            tijdVoorTijd(seconden);

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening askNumber
            /// 
            /// Oefening askNumber 
            /// 
            Console.WriteLine("Oefening askNumber");

            Console.Write("Gelieve een getal in te vullen:     ");
            string vraaggetal = Console.ReadLine();

            Console.WriteLine(askNumber(vraaggetal));

            Console.ReadKey();
            Console.Clear();
            #endregion

            
            #region Oefening addOne
            /// 
            /// Oefening addOne 
            /// 
            Console.WriteLine("Oefening addOne");

            Console.Write("Gelieve een getal in te vullen:     ");
            int waarde = Convert.ToInt32(Console.ReadLine());

            waarde = addOne(waarde);
            waarde = addOne(waarde);

            Console.WriteLine(waarde);
            
            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening cmToInch
            /// 
            /// Oefening cmToInch 
            /// 
            Console.WriteLine("Oefening cmToInch");

            Console.Write("Gelieve het # cm's in te vullen:     ");
            int centimeters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{centimeters} cm levert {cmToInch(centimeters)} inch op.");

            Console.ReadKey();
            Console.Clear();
            #endregion


        }

        static void mijnIntroductie()
        {
            Console.WriteLine("Ik ben Harry Potter. Ik ben 16 jaar oud en woon in de Ligusterlaan 666.");
        }

        static void mijnIntroductie(string naam, int leeftijd, string adres)
        {
            Console.WriteLine($"Ik ben {naam}. Ik ben {leeftijd} jaar oud en woon in de {adres}");
        }

        static double vierkant(int lengte)
        {
            return Math.Pow(lengte, 2);
        }

        static double straal(int diameter)
        {
            return diameter/2;
        }

        static double omtrekCirkel(int diameter)
        {
            return diameter * Math.PI;
        }

        static double oppervlakteCirkel(int diameter)
        {
            return Math.Pow(diameter, 2) * Math.PI / 4;
        }

        static int grootste(int getal1, int getal2)
        {
            if (getal1 > getal2)
            {
                return getal1;
            }
            else
            {
                return getal2;
            }
        }

        static bool isEven(int getal)
        {
            if (getal % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void tijdVoorTijd(int seconden)
        {
            TimeSpan tijd = TimeSpan.FromSeconds(seconden);

            Console.WriteLine(tijd.Hours + " uur, " + tijd.Minutes + " minuten, " + tijd.Seconds + " seconden");
        }

        static (bool, int) askNumber(string getal)
        {
            bool controle =  getal.All(char.IsNumber);
            int waarde;

            if (controle)
            {
                waarde= Convert.ToInt32(getal);
            }
            else
            {
                waarde = 0;
            }

            return (controle, waarde);
        }








        static int addOne(int waarde)
        {
            waarde = waarde + 1;
            return waarde;
        }







        static double cmToInch(int centimeters)
        {
            return centimeters * 0.394;
        }
    }
}
