namespace FibonaccihoRadaPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do {
                Console.WriteLine("Zadej delku rady:");
            }
            while(int.TryParse(Console.ReadLine(), out n)==false || n<=0);

            int[] rada = new int[n];
            //inicializace prvnich dvou prvku
            rada[0] = 0;
            rada[1] = 1;
            for (int i = 2; i < n; i++)
            {
                rada[i] = rada[i - 1] + rada[i - 2];
            }

            Console.WriteLine("Vypis Fibonacciho rady:");
            foreach (int prvek in rada)
            {
                Console.Write($"{prvek} ");
            }
        }
    }
}
