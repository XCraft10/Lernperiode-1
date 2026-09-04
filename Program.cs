// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
bool BE = true;
bool BE2 = true;
int Weight = 0;
int Height = 0;


do
{


     Console.WriteLine("Hallo möchten sie den Richtigen ccm stock für sie herausfinden");
    string A1 = Console.ReadLine();

    if (A1 == "ja")
    {
        BE = false;
        Console.WriteLine("Super Prima idee beginnen wir also direkt.");
        Console.WriteLine("Wie gross sind sie denn?");
        Height = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Und was wäre dein Gewicht");
        Weight = System.Convert.ToInt32(Console.ReadLine());




        double Flex1 = 60 - 0.25 * (Height - 160);
        double Flex2 = (Weight - 25) / Flex1;
        double Flex3 = 20 + 85 * (1 - Math.Exp(-1 * Flex2));






        Console.WriteLine("Den richtigen Flex für dich ist " + Flex3 + " !");
        Console.WriteLine("Wollen sie noch einen Flex ausrechnen ?");
        string A2 = Console.ReadLine();
        if (A2 == ("ja"))
        {
            BE = true;
            BE2 = true;
        }
        else if (A2 == ("Ja"))
        {
            BE = true;
            BE2 = true;
        }
        else
        {
            BE2 = false;
            Console.WriteLine("Danke das sie diesen Flexberechner gebraucht haben");

        }
    }
    else if (A1 == "nein")
    {
        BE2 = false;
        Console.WriteLine("Dann wiso sind sie hierdrauf gekommen!");
    }
    else if (A1 == "nein")
    {
        BE2 = false;
        Console.WriteLine("Dann wiso sind sie hierdrauf gekommen!");
    }
    else
    {
        BE2 = true;
        Console.WriteLine("Ungültige eingabe Bitte fersuchen sie es nochmals");
    }
} while (BE2);