namespace nah_cisla2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random generator = new Random(); //vytvoreni generatoru
            int cislo1 = generator.Next(); //vrati hodnotu Integer.minValue do Integer.maxValue
            Console.WriteLine("Nahodne cislo z celeho intervalu: " + int.MinValue + " do " + int.MaxValue + " je " + cislo1);
            int cislo2 = generator.Next(1, 11); //v rozsahu 1-10
            Console.WriteLine("Nahodne cislo z intervalu: " + cislo2);
            double cislo3 = generator.NextDouble(); //v rozsahu <0.0,1.0)
            Console.WriteLine("Nahodne cislo desetinne: " + cislo3);

            /*nahodne vygenerovani, zda padl orel nebo panna*/
            int nahodne = generator.Next(1,3); //vygeneruju cislo 1-2
            switch (nahodne)
            {
                case 1: 
                    Console.WriteLine("Padl orel.");
                    break;
                case 2:
                    Console.WriteLine("Padla panna.");
                    break;
            }
        }
    }
}
