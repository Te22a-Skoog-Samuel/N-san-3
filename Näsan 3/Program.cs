void Hello32()
{
    for (int i = 0; 1 < 32; i++)
    {
        Console.WriteLine("Hello, World");
    }
}

Hello32();



void Square()
{
    Console.WriteLine("Välj en siffra.");
    string tal = Console.ReadLine();
    int resultat;
    bool lyckad = int.TryParse(tal, out resultat);
}


Console.ReadKey();