// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int Weight = 0;
int Height = 0;


Console.WriteLine("Hallo möchten sie den Richtigen ccm stock für sie herausfinden");
string A1 = Console.ReadLine();
if (A1 == "ja")
{
    Console.WriteLine("Super Prima idee beginnen wir also direkt.");
    Console.WriteLine("Wie gross sind sie denn?");
    Height = System.Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Und was wäre dein Gewicht");
    Weight = System.Convert.ToInt32(Console.ReadLine());
}

decimal Flex1 = 60 - 0.25 * (Height - 160);
decimal Flex2 = (Weight - 25) / Flex1;
double Flex = 0.6 * Weight + 0.05 * (Height - 170);
Console.WriteLine(Flex);