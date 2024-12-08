namespace Drinks_Maschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Drinks maschine1 = new Drinks(12,14,18,5);

            maschine1.DrinksMenu();


        }
    }
}
