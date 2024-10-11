using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadej poradove cislo dne:");
        int poradove = int.Parse(Console.ReadLine());
        string nazev = "";

        switch (poradove) {
            case 1:
                nazev = "pondeli";
                break;
            case 2:
                nazev = "utery";
                break;
            case 3:
                nazev = "streda";
                break;
            case 4:
                nazev = "ctvrtek";
                break;
            case 5:
                nazev = "patek";
                break;
            case 6:
                nazev = "sobota";
                break;
            case 7:
                nazev = "nedele";
                break;
            default:
                Console.WriteLine("Hodnota neni platna.");              
                break;
        }
        if (nazev != "")
            Console.WriteLine("Nazev dne je: " + nazev);
 

    }
}