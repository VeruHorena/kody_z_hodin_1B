using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double[] rozmery = { 1.3, 2.2, 4.5, 2.1, 6.7 };

        Console.WriteLine("V datbázi jsou tyto rozměry:");
        for (int i = 0; i < rozmery.Length; i++)
        {
            Console.WriteLine(rozmery[i]);
        }
    }
}