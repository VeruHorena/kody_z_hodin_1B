namespace Pole_ulohy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velikost;

            do
            {
                Console.WriteLine("Zadej velikost pole:");
            }while(int.TryParse(Console.ReadLine(), out velikost)==false || velikost<=0);
            int[] pole = new int[velikost];

            for (int i = 0; i < pole.Length; i++)
            {
                do
                {
                    Console.WriteLine("Zadej hodnotu:");
                } while (int.TryParse(Console.ReadLine(), out pole[i]) == false);
            }

            Console.WriteLine("Vypis pole:");
            for (int i = 0; i < pole.Length; i++) {
                Console.Write($"{pole[i]} "); 
            }
            Console.WriteLine();
            foreach (int vcela in pole)
            {
                Console.Write($"{vcela} ");
            }
        }
    }
}
