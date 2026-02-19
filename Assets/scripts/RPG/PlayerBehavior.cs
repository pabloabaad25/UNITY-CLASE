using UnityEngine; // Motor de Unity

public class PlayerBehavior : MonoBehaviour // Control del jugador
{
    public float VelocitatMoviment = 10f; // Velocitat de moviment
    public float VelocitatRotacio = 75f; // Velocitat de gir

    private float _vInput; // Entrada vertical
    private float _hInput; // Entrada horitzontal

    void Update() // Cada frame
    {
        _vInput = Input.GetAxis("Vertical") * VelocitatMoviment; // Llegeix W/S
        _hInput = Input.GetAxis("Horizontal") * VelocitatRotacio; // Llegeix A/D

        transform.Translate(Vector3.forward * _vInput * Time.deltaTime); // Mou endavant
        transform.Rotate(Vector3.up * _hInput * Time.deltaTime); // Gira
    }
}
