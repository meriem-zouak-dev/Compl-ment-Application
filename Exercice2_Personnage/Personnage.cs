namespace Exercice2_Personnage;

public class Personnage
{
    public string Nom { get; set; }
    public int PointsDeVie { get; set; }

    public Personnage(string nom, int pointsDeVie)
    {
        Nom = nom;
        PointsDeVie = pointsDeVie;
    }

    public virtual void Attaquer()
    {
        Console.WriteLine($"{Nom} attaque !");
    }

    public void AfficherInfos()
    {
        Console.WriteLine($"Nom : {Nom}, Points de vie : {PointsDeVie}");
    }
}
