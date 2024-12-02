using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] cisla = new int[] { -11, 0, 5, -12, 13, 24, 19, 13, -17 };
        //sem přijde váš kód
        Console.WriteLine("Zadej cislo");
        int index = int.Parse(Console.ReadLine());
        for (int i = 0; i < cisla.Length; i++)
        {
            if (cisla[i] == index)
            {
                Console.WriteLine("cislo je na " + i + " indexu");
                return;
            }
        }
        Console.WriteLine("Cislo se nenachazi v poli");
    }
}