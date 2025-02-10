using System.Text.Json.Serialization;

namespace matice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radky = 10;
            int sloupce = 10;
            int[,] matice = new int[radky, sloupce];
           Random rand = new Random();

            for (int i = 0; i < radky; i++) {
                for (int j = 0; j < sloupce; j++)
                {
                    matice[i, j] = rand.Next(1, 10); //naplneni matice
                }
            }
            //vypis matice
            for (int i = 0; i < radky; i++) { 
            for(int j = 0;j < sloupce; j++)
                {
                    Console.Write(matice[i,j] + " ");
                                    }
            Console.WriteLine();
            }


            Console.WriteLine("Hlavni diagonala:");
            for(int i = 0; i < radky; i++)
            {
                Console.Write(matice[i, i] + ",");
            }
            
            Console.WriteLine("\nVedlejsi diagonala:");
            for(int i=0;i< radky; i++)
            {
                Console.Write(matice[i, radky - i - 1] + ",");
            }
        }
    }
}
