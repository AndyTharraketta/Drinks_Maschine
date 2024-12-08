using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Maschine
{
    internal class Drinks
    {
        int colaBottles;
        int pepsiBottles;
        int sodaBottles;
        int beerBottles;

        static int maxColaBottles = 20;
        static int maxPepsiBottles = 20;
        static int maxSodaBottles = 20;
        static int maxBeerBottles = 20;

        public int ColaBottles { get => colaBottles; set => colaBottles = value; }
        public int PepseBottles { get => pepsiBottles; set => pepsiBottles = value; }
        public int SodaBottles { get => sodaBottles; set => sodaBottles = value; }
        public int BeerBottles { get => beerBottles; set => beerBottles = value; }
        public static int MaxColaBottles { get => maxColaBottles; }
        public static int MaxPepsiBottles { get => maxPepsiBottles; }
        public static int MaxSodaBottles { get => maxSodaBottles; }
        public static int MaxBeerBottles { get => maxBeerBottles; }

        public Drinks (int colaBottles, int pepsiBottles, int sodaBottles, int beerBottles)
        {
            this.colaBottles = colaBottles;
            this.pepsiBottles = pepsiBottles;
            this.sodaBottles = sodaBottles;
            this.beerBottles = beerBottles;
        }

        public void ColaStockUp()
        {
            int stockUp = MaxColaBottles - colaBottles;
            colaBottles = MaxColaBottles;
            Console.WriteLine($"\t\t -Neuer Bestand:\t{colaBottles} Flaschen Cola-\n\t\t -Auffüllmenge:\t\t{stockUp} Flaschen Cola-");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t -Drücke Taste zum fortfahren-");
            Console.ReadKey();

        }

        public void PepsiStockUp()
        {
            int stockUp = MaxPepsiBottles - pepsiBottles;
            pepsiBottles = MaxPepsiBottles;
            Console.WriteLine($"\t\t -Neuer Bestand:\t{pepsiBottles} Flaschen Pepsi-\n\t\t -Auffüllmenge:\t\t{stockUp} Flaschen Pepsi-");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t -Drücke Taste zum fortfahren-");
            Console.ReadKey();
        }

        public void SodaStockUp()
        {
            int stockUp = MaxSodaBottles - sodaBottles;
            sodaBottles = MaxSodaBottles;
            Console.WriteLine($"\t\t -Neuer Bestand:\t{sodaBottles} Flaschen Wasser-\n\t\t -Auffüllmenge:\t\t{stockUp} Flaschen Wasser-");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t -Drücke Taste zum fortfahren-");
            Console.ReadKey();
        }

        public void BeerStockUp()
        {
            int stockUp = MaxBeerBottles - beerBottles;
            beerBottles = MaxBeerBottles;
            Console.WriteLine($"\t\t -Neuer Bestand:\t{beerBottles} Flaschen Bier-\n\t\t -Auffüllmenge:\t\t{stockUp} Flaschen Bier-");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t -Drücke Taste zum fortfahren-");
            Console.ReadKey();
        }

        private bool CheckColaBottles()
        {
            if (colaBottles >= 1) return true;
            else return false;
        }

        public void ColaOutPut()
        {
            if (CheckColaBottles())
            {
                colaBottles -= 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t     -Genieße Deine Cola-");     // fünf Leerzeichen 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t-Nicht vorhanden!-\n\t\t     -Bitte Cola auffüllen!-");     // fünf Leerzeichen   
            }   
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\t\t -Drücke Taste zum fortfahren-");
            Console.ReadKey();
        }

        private bool CheckPepsiBottles()
        {
            if (pepsiBottles >= 1) return true;
            else return false;
        }

        public void PepsiOutPut()
        {
            if (CheckPepsiBottles())
            {
                pepsiBottles -= 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t     -Genieße Deine Pepsi-");        // fünf Leerzeichen 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t-Nicht vorhanden!-\n\t\t     -Bitte Pepsi auffüllen!-");     // fünf Leerzeichen   
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\t\t -Drücke Taste zum fortfahren-");
            Console.ReadKey();
        }

        private bool CheckSodaBottles()
        {
            if (sodaBottles >= 1) return true;
            else return false;
        }

        public void SodaOutPut()
        {
            if (CheckSodaBottles())
            {
                sodaBottles -= 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t     -Genieße Dein Wasser-");        // fünf Leerzeichen 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t-Nicht vorhanden!-\n\t\t     -Bitte Wasser auffüllen!-");     // fünf Leerzeichen   
            }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\t\t -Drücke Taste zum fortfahren-");
                Console.ReadKey();
        }

        private bool CheckBeerBottles()
        {
            if (beerBottles >= 1) return true;
            else return false;
        }

        public void BeerOutPut()
        {
            if (CheckBeerBottles())
            {
                beerBottles -= 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t     -Genieße Dein Bier-");      // fünf Leerzeichen
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t-Nicht vorhanden!-\n\t\t     -Bitte Bier auffüllen!-");     // fünf Leerzeichen   
            }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\t\t -Drücke Taste zum fortfahren-");
                Console.ReadKey();
        }

        public void DrinksMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Aktueller Bestand:\n{colaBottles} Flaschen Cola\t{pepsiBottles} Flaschen Pepsi\t{sodaBottles} Flaschen Wasser\t {beerBottles} Flaschen Bier");
                Console.WriteLine("\nWählen Sie eine Aktion:\n\t-1- Cola\t\t-5- Cola auffüllen\n\t-2- Pepsi\t\t-6- Pepsi auffüllen\n\t-3- Wasser\t\t-7- Wasser auffüllen\n\t-4- Bier\t\t-8- Bier auffüllen");
                Console.Write("\nEingabe: ");
                string input = Console.ReadLine();

                    if (input == "1") ColaOutPut();
                    else if (input == "2") PepsiOutPut();
                    else if (input == "3") SodaOutPut();
                    else if (input == "4") BeerOutPut();
                    else if (input == "5") ColaStockUp();
                    else if (input == "6") PepsiStockUp();
                    else if (input == "7") SodaStockUp();
                    else if (input == "8") BeerStockUp();
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t-Falsch Eingabe-");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\t\t -Drücke Taste zum fortfahren-");
                        Console.ReadKey();
                        Console.ResetColor();
                    }

                
            }
        }
    }
}
