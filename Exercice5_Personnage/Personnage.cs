namespace Exercice5_Personnage;

public abstract class Personnage : IAttaquable
{
    public string Nom { get; }
    public int PointsDeVie { get; protected set; }

    protected Personnage(string nom, int pointsDeVie)
    {
        Nom = nom;
        PointsDeVie = pointsDeVie;
    }

    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Nom : {Nom}, Points de vie : {PointsDeVie}");
    }

    public abstract void Attaquer();
}