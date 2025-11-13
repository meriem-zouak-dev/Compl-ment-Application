namespace Exercice6_Personnage;

public class Archer : Personnage
{
    public int Fleches { get; private set; }

    public Archer(string nom, int pointsDeVie, int fleches) : base(nom, pointsDeVie)
    {
        Fleches = fleches;
    }

    public override void Attaquer(Personnage cible)
    {
        int degats;
        if (Fleches > 0)
        {
            Fleches--;
            degats = 18;
            Console.WriteLine($"{Nom} tire une flèche ! Flèches restantes : {Fleches}");
        }
        else
        {
            degats = 4;
            Console.WriteLine($"{Nom} n’a plus de flèches, coup faible.");
        }

        InfligerDegats(cible, degats);
    }

    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine($"Flèches : {Fleches}");
    }
}