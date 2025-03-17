namespace evidenceZnamek
{
    internal class Program
    {
        static Dictionary<string, List<int>> studenti = new Dictionary<string, List<int>>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Přidat studenta");
                Console.WriteLine("2. Přidat známku studentovi");
                Console.WriteLine("3. Zobrazit známky studenta");
                Console.WriteLine("4. Výpis studentů");
                Console.WriteLine("5. Ukončit");
                Console.Write("Vyberte možnost: ");

                string volba = Console.ReadLine();
                switch (volba)
                {
                    case "1":
                        pridejStudenta();
                        break;
                    case "2":
                        pridejZnamku();
                        break;
                    case "3":
                        ukazZnamkyStudenta();
                        break;
                    case "4":
                        vypisVsechny();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Neplatná volba, zkuste to znovu.");
                        break;
                }
            }
        }

        static void pridejStudenta()
        {
            Console.Write("Zadejte jméno studenta: ");
            string jmeno = Console.ReadLine();

            if (studenti.ContainsKey(jmeno))
            {
                Console.WriteLine("Student s tímto jménem již existuje.");
                return;
            }

            studenti[jmeno] = new List<int>();
            Console.WriteLine("Student přidán.");
        }

        static void pridejZnamku()
        {
            Console.Write("Zadejte jméno studenta: ");
            string jmeno = Console.ReadLine();

            if (studenti.ContainsKey(jmeno) ==false)
            {
                Console.WriteLine("Student nenalezen.");
                return;
            }

            Console.Write("Zadejte známku (1-5): ");
            if (int.TryParse(Console.ReadLine(), out int znamka) && znamka >= 1 && znamka <= 5)
            {
                studenti[jmeno].Add(znamka);
                Console.WriteLine("Známka přidána.");
            }
            else
            {
                Console.WriteLine("Neplatná známka.");
            }
        }

        static void ukazZnamkyStudenta()
        {
            Console.Write("Zadejte jméno studenta: ");
            string jmeno = Console.ReadLine();

            if (studenti.ContainsKey(jmeno)==false)
            {
                Console.WriteLine("Student nenalezen.");
                return;
            }

            Console.WriteLine($"Známky studenta {jmeno}: {string.Join(", ", studenti[jmeno])}");
        }

        static void vypisVsechny()
        {
            Console.WriteLine();
            Console.WriteLine("Seznam studentů se známkami:");
            foreach (var student in studenti)
            {
                Console.WriteLine($"{student.Key} : {string.Join(", ", studenti[student.Key])}");
            }
        }
    }
}
