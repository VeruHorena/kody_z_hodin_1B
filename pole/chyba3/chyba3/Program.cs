using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //deklarace pole našich nejvyšších hor - tu neměňte
        string[] hory = {
        "Sněžka",
        "Luční hora",
        "Studniční hora",
        "Vysoké kolo",
        "Praděd",
        "Stříbrný hřbet",
        "Vysoká pláň",
        "Violík",
        "Vysoká hole",
        "Petrovy kameny"
    };

        Console.WriteLine("Seznam 10 nejvyšších hor ve vzestupném pořadí:");

        //odsud níže je třeba opravovat
        for (int i = 0; i <hory.Length; i++)
        {
            Console.WriteLine("{0}. nejvyšší je {1}", i+1, hory[i]);
        }
    }
}