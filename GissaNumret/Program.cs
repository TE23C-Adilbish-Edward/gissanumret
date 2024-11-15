Random rnd = new Random();
int vinst = 0;
int hemligtnummer = rnd.Next(1, 100);

Console.WriteLine("Gissa det numret jag tänker på");
while (vinst == 0) {

string gissning = Console.ReadLine();
int numgissning = 0;
bool success = int.TryParse(gissning, out numgissning);
if (success) {
    Console.Clear();
    if (numgissning == hemligtnummer) {
        vinst = 1;
    } else if (numgissning > hemligtnummer) {
        Console.WriteLine("Du gissade för högt, mitt nummer är lägre.");
        Console.WriteLine("");
        Console.WriteLine("Din Gissning: " + numgissning);
    } else if (numgissning < hemligtnummer) {
        Console.WriteLine("Du gissade för lågt, mitt nummer är högre.");
        Console.WriteLine("");
        Console.WriteLine("Din Gissning: " + numgissning);
    }
} else {
    Console.Clear();
    Console.WriteLine("Skriv in ett nummer idiot");
}

}

Console.Clear();
Console.WriteLine("Grattis du vann! Du gissade: " + hemligtnummer);
Console.ReadLine();


