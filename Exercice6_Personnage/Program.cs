using Exercice6_Personnage;

internal class Program
{
    static void Main(string[] args)
    {
        // Choisis deux combattants (tu peux changer les combos)
        Personnage a = new Guerrier("Lancelot", 120, 30);
        Personnage b = new Magicien("Merlin", 90, 60);
        // ou: Personnage b = new Archer("Robin", 100, 3);

        a.AfficherInfos();
        b.AfficherInfos();
        Console.WriteLine();

        int round = 1;
        while (a.EstVivant && b.EstVivant)
        {
            Console.WriteLine($"--- Round {round} ---");

            a.Attaquer(b);
            if (!b.EstVivant) break;

            b.Attaquer(a);
            Console.WriteLine();

            round++;
        }

        var vainqueur = a.EstVivant ? a.Nom : b.Nom;
        Console.WriteLine($"Vainqueur : {vainqueur}");
        Console.ReadLine();
    }
}