using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] prisady = { "kokos", "povidla", "tvaroh", "ořechy", "mák" };

        for (int i = 0; i < prisady.Length; i++)
        {
            Console.WriteLine("Na pečení se hodí také {0}.", prisady[i]);
        }
    }
}