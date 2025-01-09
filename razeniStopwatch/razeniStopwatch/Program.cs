using System.Diagnostics;

namespace razeniStopwatch
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] poleHodnot = new int[1000];
            Random generator = new Random();
            for (int i = 0; i < poleHodnot.Length; i++)
            {
                poleHodnot[i] = generator.Next(1,101);
            }
            for (int i = 0; i < poleHodnot.Length; i++)
            {
                Console.Write(poleHodnot[i] + ",");
            }

            //razeni minimem

            int min;
            int pozice = 0;
            int pom;

            Stopwatch stopky = new Stopwatch();
            stopky.Start();
            for (int i = 0; i < poleHodnot.Length; i++)
            {
                min = poleHodnot[i];
                for (int j = i; j< poleHodnot.Length; j++)
                {
                    if (poleHodnot[j] < min)
                    {
                        min = poleHodnot[j];
                        pozice = j;
                    }
                }
                pom = poleHodnot[i];
                poleHodnot[i] = min;
                poleHodnot[pozice] = pom;
            }
            stopky.Stop();

            for (int i = 0; i < poleHodnot.Length; i++)
            {
                Console.Write(poleHodnot[i] + ",");
            }
            Console.WriteLine("_______________________________________");
            long stopkyCas = stopky.ElapsedMilliseconds;
            Console.WriteLine("Razeni trvalo: " + stopkyCas);
        }
    }
}
