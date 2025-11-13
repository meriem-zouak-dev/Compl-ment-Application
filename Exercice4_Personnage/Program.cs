namespace Exercice4_Personnage;

internal class Program
{
    static void Main(string[] args)
    {
        List<IAttaquable> personnages = new List<IAttaquable>
        {
            new Guerrier("Arthur", 120, 30),
            new Magicien("Merlin", 80, 100),
            new Guerrier("Lancelot", 110, 40)
        };

        foreach (var p in personnages)
        {
            if (p is Personnage perso)
                perso.AfficherInfos();

            p.Attaquer();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}