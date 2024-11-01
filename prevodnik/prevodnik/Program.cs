using System;

class Program
{
    static void Main()
    {
        char nahrada1 = ' ';
        char nahrada2 = ' ';
        char nahrada3 = ' ';
        string slovo = "";
        bool zadanoVymena = false;
        bool zadanoSlovo = false;

        while (true)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Zadej znaky pro nahrazení");
            Console.WriteLine("2. Zadej slovo");
            Console.WriteLine("3. Proveď převod");
            Console.WriteLine("4. Konec");
            Console.Write("Vyber možnost: ");
            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    Console.Write("Zadej znak, který nahradí písmeno 'a': ");
                    nahrada1 = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    Console.Write("Zadej znak, který nahradí písmeno 'e': ");
                    nahrada2 = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    Console.Write("Zadej znak, který nahradí písmeno 'u': ");
                    nahrada3 = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    zadanoVymena = true;
                    Console.WriteLine("Znaky pro výměnu byly nastaveny.");
                    break;

                case "2":
                    Console.Write("Zadej slovo, ve kterém chceš provést změny: ");
                    slovo = Console.ReadLine();
                    zadanoSlovo = true;
                    Console.WriteLine("Slovo bylo nastaveno.");
                    break;

                case "3":
                    if (zadanoVymena == true && zadanoSlovo == true)
                    {
                        string prevedeneSlovo = slovo.Replace('a', nahrada1);
                        prevedeneSlovo = prevedeneSlovo.Replace('e', nahrada2);
                        prevedeneSlovo = prevedeneSlovo.Replace('u', nahrada3);


                        Console.WriteLine("Převedené slovo: " + prevedeneSlovo);
                    }
                    else
                    {
                        Console.WriteLine("Nejdříve nastav znaky pro výměnu a slovo pro převod.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Program se ukončuje...");
                    return;

                default:
                    Console.WriteLine("Neplatná volba, zkus to znovu.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
