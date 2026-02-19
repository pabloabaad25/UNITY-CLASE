using UnityEngine; // Motor de Unity

public class Paladin : Character // Classe que hereta de Character
{
    public Paladin(string nom, Arma weapon) : base(nom, arma) // Constructor
    {
        Experiencia = 100; // Exp inicial alta
    }

    public override void PrintStatsInfo() // Sobrescriu el mètode
    {
        Debug.LogFormat( // Escriu a la consola
            "Pedra {0} - agafa el teu {1}!", // Missatge
            this.Nom, // Nom del paladí
            this.ArmaPrincipal.nom); // Nom de l'arma
    }
}
