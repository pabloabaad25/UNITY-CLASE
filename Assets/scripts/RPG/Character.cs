using Unity.Burst.Intrinsics;
using UnityEngine; // Motor de Unity

public class Character // Classe del personatge
{
    public string Nom; // Nom del personatge
    public int Experiencia; // Experienciaeriència
    public Arma ArmaPrincipal; // Arma principal

    public Character() // Constructor buit
    {
        Nom = "No asignado"; // Nom per defecte
        Experiencia = 0; // Experienciaeriència inicial
    }

    public Character(string Nom) // Constructor amb nom
    {
        this.Nom = Nom; // Assigna el nom
        Experiencia = 0; // Experiencia inicial
    }

    public Character(string Nom, Arma arma) // Constructor amb arma
    {
        this.Nom = Nom; // Assigna el nom
        this.ArmaPrincipal = arma; // Assigna l'arma
        Experiencia = 0; // Experiencia inicial
    }

    public virtual void PrintStatsInfo() // Mètode virtual
    {
        Debug.LogFormat("Heroi --> {0} - {1} Experiencia", this.Nom, this.Experiencia); // Mostra dades
    }
}
