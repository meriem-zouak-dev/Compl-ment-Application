namespace Exercice1_Personnage
{
    public class Personnage
    {
        public string Nom { get; set; }
        public string Classe { get; set; }
        public int PointsDeVie { get; set; }
        public int Niveau { get; set; }

        public Personnage(string nom, string classe, int pointsDeVie, int niveau)
        {
            Nom = nom;
            Classe = classe;
            PointsDeVie = pointsDeVie;
            Niveau = niveau;
        }
        public void Presenter()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Classe : {Classe}");
            Console.WriteLine($"Points de Vie : {PointsDeVie}");
            Console.WriteLine($"Niveau : {Niveau}");
            Console.WriteLine($"Expérience : {experience}");
        }
        private int experience = 0; // champ privé pour stocker l'expérience

        public void PrendreExp(int exp)
        {
            experience += exp;
            Console.WriteLine($"{Nom} gagne {exp} points d'expérience. Total : {experience}");

            if (experience >= 100)
            {
                Niveau++;
                experience -= 100;
                Console.WriteLine($"{Nom} monte au niveau {Niveau} !");
            }
        }

    }
}