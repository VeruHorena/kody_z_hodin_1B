using System.Security.Cryptography;

namespace dynamicke_struktury_skola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studenti = new List<string>();
            int rozhodnuti = 0;
            while (true)
            {
                rozhodnuti = vypisMenu(); // kompletni zobrazeni a nacteni hodnoty od uzivatele
                switch (rozhodnuti)
                {
                    case 1:
                        Console.WriteLine("Zadej jmeno:");
                        studenti.Add(Console.ReadLine());
                        Console.WriteLine("Student pridan!");
                        break;
                    case 2:
                        Console.WriteLine("Zadej jmeno k nalezeni:");
                        string hledane = Console.ReadLine();
                        if (studenti.Find(x => x == hledane) != null)
                            Console.WriteLine("Student nalezen.");
                        else
                            Console.WriteLine("Student nenalezen.");
                        break;
                    case 3:
                        Console.WriteLine("Zadej jmeno pro odstraneni:");
                        if (studenti.Remove(Console.ReadLine()))
                            Console.WriteLine("Student odstraněn.");
                        else
                            Console.WriteLine("Student nenalezen.");
                        break;
                    case 4:
                        Console.WriteLine("Celkovy pocet zapsanych studentu: " + studenti.Count);
                        foreach (string s in studenti)
                            Console.WriteLine(s);
                       
                        /*for (int i = 0; i < studenti.Count; i++)
                        {
                            Console.WriteLine(studenti[i]);
                        }*/
                        break;


                }
                if (rozhodnuti == 5)
                    break;
            }
  
        }

        public static int vypisMenu() {
            int volba = 0;
            Console.WriteLine("1. Pridej studenta");
            Console.WriteLine("2. Vyhledej studenta");
            Console.WriteLine("3. Odstran studenta");
            Console.WriteLine("4. Vypis studenty");
            Console.WriteLine("5. Konec");

            do
            {
                Console.WriteLine("Zadej svou volbu:");
            } while (int.TryParse(Console.ReadLine(), out volba) == false || volba < 1 || volba > 5);
            return volba;
        
        }
    }
}
