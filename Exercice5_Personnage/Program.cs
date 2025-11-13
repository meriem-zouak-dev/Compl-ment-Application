using Exercice5_Personnage;

internal class Program
{
    static void Main(string[] args)
    {
        var personnages = new List<Personnage>
        {
            new Guerrier("Lancelot", 110, 40),
            new Magicien("Merlin", 80, 100),
            new Archer("Robin", 90, 3)
        };

        foreach (var p in personnages)
        {
            p.AfficherInfos();
            p.Attaquer();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}