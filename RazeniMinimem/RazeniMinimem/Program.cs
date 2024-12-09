namespace RazeniMinimem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { -3, 5, 1, -2, 3, 4, 5 };
            foreach (int i in pole)
            {
                Console.Write($"{i   }");
            }

            char zpusob; 
            Console.WriteLine();
            int min, pom, pozice;
            for (int i = 0; i < pole.Length; i++) {
                min = pole[i];
                pozice = i;
                for (int j = i + 1; j < pole.Length; j++)
                {
                    if (pole[j] < min)
                    {
                        min = pole[j];
                        pozice = j;
                    }
                }
                pom = pole[i];
                pole[i] = min;
                pole[pozice] = pom;
            }
            Console.WriteLine("Serazene pole: ");
            foreach (int i in pole) { 
            Console.Write($"{i   }");
            }
        }
    }
}
