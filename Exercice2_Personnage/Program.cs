namespace Exercice2_Personnage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerrier g = new Guerrier("Arthur", 120, 30);
            Magicien m = new Magicien("Merlin", 80, 100);

            g.AfficherInfos();
            m.AfficherInfos();

            g.Attaquer();
            m.Attaquer();

            Console.ReadLine();
        }
    }
}