// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
int FlexGesucht = 0;
bool BE = true;
bool BE2 = true;
bool HG1 = true;
bool WG1 = true;
int Weight = 0;
int Height = 0;


do
{


    Console.WriteLine("Hallo möchten sie den Richtigen ccm stock für sie herausfinden");
    string A1 = Console.ReadLine();

    if (A1 == "ja"|| A1 =="JA" || A1 =="Ja" || A1 =="jA")
    {
        BE = false;
        Console.WriteLine("Super Prima Idee beginnen wir also direkt.");
        Console.WriteLine("Wie gross sind sie denn?");
        Console.WriteLine("Bitte in cm eingeben !");
        Height = System.Convert.ToInt32(Console.ReadLine());
        do
        {
            if (Height >= 90 && Height <= 250)
            {
                HG1 = false;
                Console.WriteLine("Und was wäre dein Gewicht");
                Weight = System.Convert.ToInt32(Console.ReadLine());

                if (Weight >= 15 && Weight <= 200)
                {
                    WG1 = false;
                }
                else if (Weight >= 200)
                {
                    Console.WriteLine("Sie sind übergewichtig, suchen sie einen Arzt und lassen sie sich Helfen! ");
                }
                else if (Weight <=90)
                {
                    Console.WriteLine("Sie sind zu leicht bitte versuchen sie es mit einem höheren Gewicht");
                }
                else
                {
                    Console.WriteLine("Bitte geben sie eine Zahl ein und keine Buchstaben!");
                }
            }
            else if (Height < 90)
            {
                Console.WriteLine("Du bist zu klein, wir können leider keine Berechnungen mit dieser grösse druchfüren");
            }
            else if (Height > 250)
            {
                Console.WriteLine("Wiso lügen sie wir wissen beide das du nicht so gross bist!");
                Console.WriteLine("Bite geben sie ihre Richtige grösse diesmal ein!");
            }
            else
            {
                Console.WriteLine("Bitte geben sie ihre grösse ein!");
            }
        } while (HG1);

        double Flex1 = 60 - 0.25 * (Height - 160);
        double Flex2 = (Weight - 25) / Flex1;
        double Flex3 = 20 + 85 * (1 - Math.Exp(-1 * Flex2));

        Console.WriteLine(Flex3);

        Flex3 = Math.Round (Flex3 / 5)* 5;


        FlexGesucht = +1;
        Console.WriteLine("Den richtigen Flex für dich ist " + Flex3 + " !");
        Console.WriteLine("Wollen sie noch einen Flex ausrechnen ?");
        string A2 = Console.ReadLine();
        if (A2 == "ja" || A2 == "JA" || A2 == "Ja" || A2 == "jA")
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
    else if (A1 == "nein" || A1 == "Nein" || A1 == "NEIN")
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
if (FlexGesucht >= 100)
{
    Console.WriteLine("Glückwunsch du hast über 100 mal diesen Rechner gebraucht");
}