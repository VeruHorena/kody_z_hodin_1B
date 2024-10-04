namespace kod_hodina4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Zadej cislo:");
             int cislo = int.Parse(Console.ReadLine());
             if (cislo >= 10)
             {
                 Console.WriteLine("Vetsi nez 10");
             }
             else
             {
                 Console.WriteLine("Neni vetsi nez 10");

             }
            */
            Console.WriteLine("Zadej text:");
            string text = Console.ReadLine();
            text = text.ToLower(); //prevod na mala pismena
            if(/*(text == "Ahoj")||(text=="ahoj")*/ text=="ahoj")
            {
                Console.WriteLine("Text byl ahoj");
            }
            else
            {
                Console.WriteLine("Text byl cau");
            }
        }
    }
}
