using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadej prvni cislo:");
        int a = int.Parse(Console.ReadLine());//nacteni prvni hodnoty
        Console.WriteLine("Zadej druhe cislo:");
        int b = int.Parse(Console.ReadLine()); //nacteni druhe hodnoty
        /*toto je viceradkovy komentar*/
        int vysledek; //promenna pro mezivysledky
        vysledek = a + b;
        Console.WriteLine("Soucet cisel je: " + vysledek);
        vysledek = a - b; //puvodni hodnota ulozena ve vysledku se vymaze
        Console.WriteLine("Rozdil cisel je: " + vysledek);
        vysledek = a * b;
        Console.WriteLine("Soucin cisel je: " + vysledek);
    }
}