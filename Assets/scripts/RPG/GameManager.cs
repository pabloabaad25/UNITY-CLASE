using UnityEngine; // Motor de Unity

public class GameManager : MonoBehaviour // Script de control
{
    void Start() // S'executa a l'inici
    {
        Character heroi = new Character(); // Crea heroii
        Character dolent = heroi; // Còpia per referència

        dolent.Nom = "Sir Kane l'Atrevit"; // Canvia el nom

        heroi.PrintStatsInfo(); // Mostra heroii
        dolent.PrintStatsInfo(); // Mostra vilà

        Character heroina = new Character("Agatha"); // Crea heroiïna
        heroina.PrintStatsInfo(); // Mostra heroiïna

        Arma huntingBow = new Arma("Arc de caça", 105); // Crea arma
        Arma warBow = huntingBow; // Còpia per valor

        warBow.nom = "Arc de guerra"; // Canvia nom
        warBow.danys = 155; // Canvia dany

        huntingBow.ImprimirEstadístiquesArma(); // Mostra arma original
        warBow.ImprimirEstadístiquesArma(); // Mostra arma copiada

        Paladin knight = new Paladin("Senyor Artur", huntingBow); // Crea paladí
        knight.PrintStatsInfo(); // Mostra paladí
    }
}
