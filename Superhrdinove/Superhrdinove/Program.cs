namespace Superhrdinove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Superhrdina[] superhrdinove = new Superhrdina[2];
            int pocetHrdinu = 0;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Vytvořit superhrdinu");
                Console.WriteLine("2 - Zobrazit informace o superhrdinech");
                Console.WriteLine("3 - Trénovat superhrdinu");
                Console.WriteLine("4 - Útok superhrdiny");
                Console.WriteLine("5 - Ukončit");
                Console.Write("Vyberte možnost: ");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        if (pocetHrdinu < 2)
                        {
                            Console.Write("Zadejte jméno superhrdiny: ");
                            string jmeno = Console.ReadLine();
                            Console.Write("Zadejte superschopnost: ");
                            string schopnost = Console.ReadLine();

                            superhrdinove[pocetHrdinu] = new Superhrdina(jmeno, schopnost);
                            pocetHrdinu++;
                            Console.WriteLine("Superhrdina úspěšně vytvořen!");
                        }
                        else
                        {
                            Console.WriteLine("Maximální počet superhrdinů byl vytvořen!");
                        }
                        break;

                    case "2":
                        foreach (var hrdina in superhrdinove)
                        {
                            hrdina?.ShowInfo();
                        }
                        break;

                    case "3":
                        Console.Write("Vyberte superhrdinu k tréninku (1 nebo 2): ");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= pocetHrdinu)
                        {
                            Console.Write("Zadejte hodnotu tréninku: ");
                            if (int.TryParse(Console.ReadLine(), out int hodnota))
                            {
                                superhrdinove[index - 1].Train(hodnota);
                            }
                        }
                        break;

                    case "4":
                        if (pocetHrdinu < 2)
                        {
                            Console.WriteLine("Nejsou dostateční hrdinové k útoku!");
                        }
                        else
                        {
                            superhrdinove[0].Attack(superhrdinove[1]);
                        }
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Neplatná volba, zkuste to znovu.");
                        break;
                }
            }

        }
    }
}
