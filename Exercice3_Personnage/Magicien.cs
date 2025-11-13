namespace Exercice3_Personnage;

public class Magicien : Personnage
{
    public int Mana { get; set; }

    public Magicien(string nom, int pointsDeVie, int mana)
        : base(nom, pointsDeVie)
    {
        Mana = mana;
    }

    public override void Attaquer()
    {
        Console.WriteLine($"{Nom} lance un sort magique ! Mana : {Mana}");
    }
}