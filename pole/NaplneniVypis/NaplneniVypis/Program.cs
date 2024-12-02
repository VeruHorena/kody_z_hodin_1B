namespace NaplneniVypis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] smery = { "sever", "jih", "vychod", "zapad", "nova" };
            for (int i = 0; i < smery.Length; i++)
            {
                Console.WriteLine("Muzete jit na " + smery[i]);
            }
        }
    }
}
