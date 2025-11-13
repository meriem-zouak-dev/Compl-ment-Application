namespace Exercice4_Personnage;

public class Guerrier : Personnage
{
    public int Force { get; set; }

    public Guerrier(string nom, int pointsDeVie, int force)
        : base(nom, pointsDeVie)
    {
        Force = force;
    }

    public override void Attaquer()
    {
        Console.WriteLine($"{Nom} attaque avec une épée ! Force : {Force}");
    }
}