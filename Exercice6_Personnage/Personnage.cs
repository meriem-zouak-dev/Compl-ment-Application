namespace Exercice6_Personnage;

public abstract class Personnage : IAttaquable
{
    public string Nom { get; }
    public int PointsDeVie { get; private set; }
    public bool EstVivant => PointsDeVie > 0;

    protected Personnage(string nom, int pointsDeVie)
    {
        Nom = nom;
        PointsDeVie = Math.Max(pointsDeVie, 0);
    }

    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Nom : {Nom}, Points de vie : {PointsDeVie}");
    }

    public void SubirDegats(int degats)
    {
        if (degats < 0) degats = 0;
        PointsDeVie = Math.Max(0, PointsDeVie - degats);
        Console.WriteLine($"{Nom} subit {degats} dégâts. PV restants : {PointsDeVie}");
        if (!EstVivant) Console.WriteLine($"{Nom} est vaincu !");
    }

    protected void InfligerDegats(Personnage cible, int degats)
    {
        Console.WriteLine($"{Nom} attaque {cible.Nom} !");
        cible.SubirDegats(degats);
    }

    public abstract void Attaquer(Personnage cible);
}