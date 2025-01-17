namespace metodyPozdrav
{
    internal class Program
    {
        public static void Pozdrav(string jmenoUzivatele, int pocetPrihlaseni = 0)
        {
            int prihlaseni = Soucet(pocetPrihlaseni, 1);
            Console.WriteLine("Ahoj uzivateli " + jmenoUzivatele + "! jsi tu s nami po: " + prihlaseni);
        }

        public static int Soucet(int a, int b)
        {
            //   Console.WriteLine("Jsem v metode soucet.");
            int vysledek;
            vysledek = a + b;
            return vysledek;
        }

        public static int[] vratLicha(int[] poleCisel)
        {
            int[] licha = new int[poleCisel.Length];
            int pozice = 0;

            for(int i = 0; i < poleCisel.Length; i++)
            {
                if (poleCisel[i] % 2 != 0)
                {                
                    licha[pozice] = poleCisel[i];
                    pozice++;
                }
            }


            return licha;
        }

        static void Main(string[] args)
        {
            string uzivatel = "PepaVyskoc";
           Pozdrav(uzivatel,7);
            int v = Soucet(3, 5);
            Console.WriteLine("Soucet cisel je: " + v);
            Console.WriteLine("Soucet cisel 1 a 2 je: " + Soucet(1,2));

            int[] cisla = new int[10];
            Random generator = new Random();
            for (int i = 0; i < cisla.Length; i++)
            {
                cisla[i] = generator.Next(1, 11);
            }
            int[] vysledek = vratLicha(cisla);
            foreach (int i in vysledek)
            {
                if(i!=0)
                Console.Write(i + ",");
            }
        }
    }
}
