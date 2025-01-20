namespace metodyKalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vitejte v kalkulacce!");
            int volba;
            do
            {
                volba = Menu();
                switch (volba)
                {
                    case 1:
                        int[] hodnoty = new int[2];
                        hodnoty = nactiCisla(2);
                        Soucet(hodnoty[0],hodnoty[1]);
                        break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                        //   case 5: break;
                }
            } while (volba != 5);
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

        public static int Menu() {
            int volba;
            do {
                Console.WriteLine("1: Scitani");
                Console.WriteLine("2: Odcitani");
                Console.WriteLine("3: Nasobeni");
                Console.WriteLine("4: Deleni");
                Console.WriteLine("5: Konec");
            }
           while( int.TryParse(Console.ReadLine(), out volba)==false || volba<1 || volba>5);
            return volba;
        }

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
    }
}
