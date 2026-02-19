using UnityEngine; // Motor de Unity

public struct Arma // Estructura d'arma
{
    public string nom; // Nom de l'arma
    public int danys; // Dany de l'arma

    public Arma(string nom, int danys) // Constructor
    {
        this.nom = nom; // Assigna el nom
        this.danys = danys; // Assigna el dany
    }

    public void ImprimirEstadístiquesArma() // Mètode de mostra
    {
        Debug.LogFormat("Arma --> {0} - {1} DANYS", this.nom, this.danys); // Imprimeix dades
    }
}
