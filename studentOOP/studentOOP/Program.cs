namespace studentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student st1 = new Student();
            st1.PredstavSe();
           Student st2 = new Student("Pepa", 4, "Lucni 5");
            st2.PredstavSe();
            st1.setJmeno("Karel");
            st1.setVek(5);
            st1.setAdresa("Kvitkova 4");
            st1.PredstavSe();
            Console.WriteLine("Seznam znamek studenta st1:");
            st1.setZnamky(1);
            st1.setZnamky(2);
            foreach (int znamka in st1.getZnamky())
            {
                Console.Write(znamka + ",");
            }
        }
    }
}
