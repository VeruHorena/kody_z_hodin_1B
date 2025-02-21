namespace sousede
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[,] matice = { { 1, 0, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };
            int[,] sousede = new int[matice.GetLength(0), matice.GetLength(1)];

            for (int i = 0; i < matice.GetLength(0); i++) {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    sousede[i, j] = pocetSousedu(matice, i,j);
                }
            }

            foreach (int i in sousede)
            {
                Console.Write(i + ",");
            }

        }

        public static int pocetSousedu(int[,] matice, int i, int j)
        {
            int pocetsousedu = 0;

            if ((i - 1 >= 0) && (j - 1 >= 0))
                if (matice[i - 1, j - 1] == 1)
                    pocetsousedu++;

            if ((i - 1 >= 0) && (j >= 0))
                if (matice[i - 1, j] == 1)
                    pocetsousedu++;

            if ((i - 1 >= 0) && (j + 1 < matice.GetLength(1)))
                if (matice[i - 1, j + 1] == 1)
                    pocetsousedu++;

            if ((i >= 0) && (j - 1 >=0))
                if (matice[i, j - 1] == 1)
                    pocetsousedu++;

            if ((i >= 0) && (j + 1 < matice.GetLength(1)))
                if (matice[i, j + 1] == 1)
                    pocetsousedu++;

            if ((i+1 < matice.GetLength(0)) && (j - 1 >=0))
                if (matice[i+1, j -1] == 1)
                    pocetsousedu++;

            if ((i+1 < matice.GetLength(0)) && (j >=0 ))
                if (matice[i+1, j] == 1)
                    pocetsousedu++;

            if ((i + 1 < matice.GetLength(0)) && (j + 1 < matice.GetLength(1)))
                if (matice[i+1, j + 1] == 1)
                    pocetsousedu++;



            return pocetsousedu;
        }
    }
}
