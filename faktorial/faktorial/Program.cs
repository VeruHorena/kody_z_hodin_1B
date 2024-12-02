namespace faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
          ulong faktorial = 1;
            do
            {
                Console.WriteLine("Zadej cislo:");
            }
            while(int.TryParse(Console.ReadLine(), out cislo) == false || cislo<=0);

            for (int i = 1; i <= cislo; i++) {
                faktorial *= (ulong)i; // faktorial = faktorial * i
            }
         if( faktorial > 0 ) 
            Console.WriteLine("Hodnota faktorialu je: " + faktorial);
           else
                Console.WriteLine("Mimo rozsah ");
        }
    }
}
