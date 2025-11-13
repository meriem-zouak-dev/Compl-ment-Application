namespace Exercice2_Personnage;

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
        Console.WriteLine($"{Nom} frappe avec son épée ! Force : {Force}");
    }
}
