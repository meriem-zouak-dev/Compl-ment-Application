namespace Exercice4_Personnage;

public abstract class Personnage : IAttaquable
{
    public string Nom { get; set; }
    public int PointsDeVie { get; set; }

    protected Personnage(string nom, int pointsDeVie)
    {
        Nom = nom;
        PointsDeVie = pointsDeVie;
    }

    public abstract void Attaquer();

    public void AfficherInfos()
    {
        Console.WriteLine($"Nom : {Nom}, Points de vie : {PointsDeVie}");
    }
}