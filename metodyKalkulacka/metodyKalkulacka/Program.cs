namespace metodyKalkulacka
{
    internal class Program
    {
        //globalni promenne
        public static string[] historie = new string[10];
        public static int pozice = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Vitejte v kalkulacce!");
            int volba;
            int[] hodnoty;

            do
            {
                volba = Menu();
                switch (volba)
                {
                    case 1:
                        hodnoty = nactiCisla(2);
                        Soucet(hodnoty[0], hodnoty[1]);
                        break;
                    case 2:
                        hodnoty = nactiCisla(2);
                        Rozdil(hodnoty[0], hodnoty[1]);
                        break; 
                    case 3:
                        hodnoty = nactiCisla(2);
                        Soucin(hodnoty[0], hodnoty[1]);
                        break;
                    case 4:
                        hodnoty = nactiCisla(2);
                        Podil(hodnoty[0], hodnoty[1]); 
                        break;
                    case 5:
                        hodnoty = nactiCisla(2);
                        long v = Mocnina(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"Mocnina cisla {hodnoty[0]} na {hodnoty[1]} je {v}");
                        break;
                      
                    case 6:
                        hodnoty = nactiCisla(1);
                        long v2 = Faktorial(hodnoty[0]);
                        Console.WriteLine($"Faktorial cisla {hodnoty[0]} je {v2}");
                        break;
                    case 7:
                        vypisHistorii();
                        break;
                }
            } while (volba != 8);
            Console.WriteLine("Dekujeme za pouziti kalkulacky!");
        }
        public static int[] nactiCisla (int pocet)
        {
            int[] nactene = new int[pocet];
            for(int i = 0; i < nactene.Length; i++)
            {
                Console.WriteLine($"Zadej {i+1}. hodnotu");
                int.TryParse(Console.ReadLine(), out nactene[i]);
            }
            return nactene;

        }

        public static void vypisHistorii()
        {
            foreach(string s in historie)
            {
                Console.WriteLine(s);
            }
        }

        public static int Menu() {
            int volba;
            do {
                Console.WriteLine("1: Scitani");
                Console.WriteLine("2: Odcitani");
                Console.WriteLine("3: Nasobeni");
                Console.WriteLine("4: Deleni");
                Console.WriteLine("5: Mocnina");
                Console.WriteLine("6: Faktorial");
                Console.WriteLine("7: Historie");
                Console.WriteLine("8: Konec");
            }
           while( int.TryParse(Console.ReadLine(), out volba)==false || volba<1 || volba>8);
            if (pozice < 10)
            {
                switch (volba)
                {
                    case 1:
                        historie[pozice] = "scitani";
                        break;
                    case 2:
                        historie[pozice] = "rozdil";
                        break;
                    case 3:
                        historie[pozice] = "soucin";
                        break;
                    case 4:
                        historie[pozice] = "podil";
                        break;
                    case 5:
                        historie[pozice] = "mocnina";
                        break;
                    case 6:
                        historie[pozice] = "faktorial";
                        break;
                    case 7:
                        historie[pozice] = "historie";
                        break;
                }
                pozice++;
            }
            return volba;
        }
//metody pro vypocty
        public static void Soucet(int a, int b) {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }

        public static void Rozdil(int a, int b)
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b));
        }

        public static void Soucin(int a, int b)
        {
            Console.WriteLine(a + " * " + b + " = " + (a * b));
        }

        public static void Podil(int a, int b)
        {
            if (b != 0)
                Console.WriteLine(a + " / " + b + " = " + (double)(a / b));
            else
                Console.WriteLine("Nelze vydelit!");
        }

        public static long Mocnina (int a, int mocnitel)
        {
            long vysledek = 1;
            for (int i = 0; i < mocnitel; i++)
            {
                vysledek = vysledek * a;
            }
            return vysledek;
        }

        public static long Faktorial(int a)
        {

            long vysledek = 1;
            for(int i = 1; i <= a; i++)
            {
                vysledek *= i;
            }
            return vysledek;
        }
    }
}
