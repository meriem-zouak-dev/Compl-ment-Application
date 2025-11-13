namespace Exercice6_Personnage;

public class Magicien : Personnage
{
    public int Mana { get; private set; }

    public Magicien(string nom, int pointsDeVie, int mana) : base(nom, pointsDeVie)
    {
        Mana = mana;
    }

    public override void Attaquer(Personnage cible)
    {
        // Si assez de mana, sort puissant et on dépense 10 mana. Sinon petit sort.
        int degats;
        if (Mana >= 10)
        {
            degats = 25;
            Mana -= 10;
            Console.WriteLine($"{Nom} lance un sort puissant ! Mana : {Mana}");
        }
        else
        {
            degats = 8;
            Console.WriteLine($"{Nom} lance un petit sort… Mana insuffisante ({Mana})");
        }

        InfligerDegats(cible, degats);
    }

    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine($"Mana : {Mana}");
    }
}