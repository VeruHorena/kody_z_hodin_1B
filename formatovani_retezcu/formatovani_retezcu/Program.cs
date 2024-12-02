using static System.Runtime.InteropServices.JavaScript.JSType;

namespace formatovani_retezcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uloha 1
            Console.Write("Zadej číslo: ");
            int cislo = int.Parse(Console.ReadLine());
           // Console.WriteLine($"{cislo:D4,10}"); // Pevná délka 4, zarovnání na šířku 10 znaků
            //Console.WriteLine("{0,10:D4}", cislo);
            Console.WriteLine($"{cislo,10:D4}");

            //uloha 2
            Console.WriteLine("Jmeno      Vek   Skore");
            Console.WriteLine("------------------------");
            Console.WriteLine("{0,-10} {1,3}   {2,5}", "Jonatán", 30, 21);
            Console.WriteLine("{0,-10} {1,3}   {2,5}", "Alex", 24, 18);
            Console.WriteLine("{0,-10} {1,3}   {2,5}", "Honza", 27, 40);
            Console.WriteLine("{0,-10} {1,3}   {2,5}", "Beáta", 26, 50);

            //uloha 3
            Console.Write("Zadej první číslo: ");
            double prvni = double.Parse(Console.ReadLine());
            Console.Write("Zadejte druhé číslo: ");
            double druhe = double.Parse(Console.ReadLine());
            double soucet = prvni + druhe;
            Console.WriteLine($"Soucet je: {soucet:F2}"); // 2 des. mista

            //uloha 4
            Console.Write("Zadejte cenu zbozi: ");
            double cena = double.Parse(Console.ReadLine());
            Console.WriteLine($"Cena je: {cena:C}"); // mena

            //uloha 5
            Console.WriteLine("cislo   2.mocnina   3.mocnina");
            Console.WriteLine("-------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0,-8} {1,-15} {2,-12}", i, i * i, i * i * i);
            }

            //uloha 6
            Console.Write("Zadej cislo: ");
            double cisloDes = double.Parse(Console.ReadLine());
            Console.WriteLine($"Zaokrouhlene: {cisloDes:F3}"); // 3 des. mista

            //uloha 7
            Console.Write("prvni slovo: ");
            string prvniSlovo = Console.ReadLine();

            Console.Write("druhe slovo: ");
            string druheSlovo = Console.ReadLine();

            Console.Write("treti slovo: ");
            string tretiSlovo = Console.ReadLine();

            Console.WriteLine("{0,-15}{1,-15}", prvniSlovo, druheSlovo); //doleva
            Console.WriteLine("{0,15}", tretiSlovo);// doprava
        }
    }
}
