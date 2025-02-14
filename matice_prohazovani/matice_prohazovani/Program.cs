namespace matice_prohazovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matice = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            // Součet všech prvků
            int soucet = 0;
            foreach (int prvek in matice)
            {
                soucet += prvek;
            }
            Console.WriteLine($"Součet všech prvků matice: {soucet}");

            // Prohození 0. a 2. sloupce
            for (int i = 0; i < 3; i++)
            {
                int temp = matice[i, 0];
                matice[i, 0] = matice[i, 2];
                matice[i, 2] = temp;
            }
            // Prohození 1. a 2. řádku
            for (int j = 0; j < 3; j++)
            {
                int temp = matice[1, j];
                matice[1, j] = matice[2, j];
                matice[2, j] = temp;
            }

            // Výpis výsledné matice
            Console.WriteLine("Upravená matice:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matice[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    }

