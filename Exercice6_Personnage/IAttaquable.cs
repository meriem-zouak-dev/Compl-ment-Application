namespace Exercice6_Personnage;

public interface IAttaquable
{
    bool EstVivant { get; }
    void SubirDegats(int degats);
}