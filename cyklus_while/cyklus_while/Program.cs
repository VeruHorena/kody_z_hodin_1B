namespace cyklus_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetVypsani = 0;            
            int pruchod = 0;
            
            do
            {
                Console.WriteLine("Zadej mi pocet opakovani: ");
                //osetrena vyjimka
                int.TryParse(Console.ReadLine(), out pocetVypsani); //zkusi prevest vstup uzivatele na cislo, prvni argument je odkud ma hodnotu brat a druhy je, do ktere promenne
            } while (pocetVypsani <= 0); //resim zadanou hodnotu

            while (pruchod < pocetVypsani)
            {
                pruchod++; //pruchod = pruchod + 1, pruchod-- ->snizeni o 1

                Console.WriteLine("Pruchod cislo: " + pruchod);
            }
        }
    }
}
