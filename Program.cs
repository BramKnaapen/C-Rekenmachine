float getal1;
float getal2;

Console.WriteLine("Operatie?(+, -, *, % of /): ");
string operatie = Console.ReadLine();

Console.WriteLine("Voer getal 1 in: ");
getal1 = float.Parse(Console.ReadLine());

Console.WriteLine("Voer getal 2 in: ");
getal2 = float.Parse(Console.ReadLine());

try
{
    if (operatie == "+")
    {
        Console.WriteLine("Resultaaat: ");
        Console.WriteLine(getal1 + getal2);
    }
    else if (operatie == "-")
    {
        Console.WriteLine("Resultaaat: ");
        Console.WriteLine(getal1 - getal2);
    }
    else if (operatie == "%")
    {
        Console.WriteLine("Resultaaat: ");
        Console.WriteLine(getal1 % getal2);
    }
    else if (operatie == "*")
    {
        Console.WriteLine("Resultaaat: ");
        Console.WriteLine(getal1 * getal2);
    }
    else if (operatie == "/")
    {
        if (getal2 == 0)
        {
            Console.WriteLine("Kan niet delen door 0.");
        }
        else
        {
            Console.WriteLine("Resultaaat: ");
            Console.WriteLine(getal1 / getal2);
        }
    }
    else
    {
        Console.WriteLine(operatie + " is een ongeldige operatie.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Voer een getal in.");
}
