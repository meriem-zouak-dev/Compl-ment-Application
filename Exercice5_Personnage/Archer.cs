namespace Exercice5_Personnage;

public class Archer : Personnage
{
    public int Fleches { get; private set; }

    public Archer(string nom, int pointsDeVie, int fleches)
        : base(nom, pointsDeVie)
    {
        Fleches = fleches;
    }

    public override void Attaquer()
    {
        if (Fleches > 0)
        {
            Fleches--;
            Console.WriteLine($"{Nom} tire une flèche ! Flèches restantes : {Fleches}");
        }
        else
        {
            Console.WriteLine($"{Nom} n'a plus de flèches.");
        }
    }
}