namespace Exercice6_Personnage;

public class Guerrier : Personnage
{
    public int Force { get; }

    public Guerrier(string nom, int pointsDeVie, int force) : base(nom, pointsDeVie)
    {
        Force = force;
    }

    public override void Attaquer(Personnage cible)
    {
        // dégâts = Force fixe
        InfligerDegats(cible, Force);
    }
}