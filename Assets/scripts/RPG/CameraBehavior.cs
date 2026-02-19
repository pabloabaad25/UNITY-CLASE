using UnityEngine; // Motor de Unity

public class CameraBehavior : MonoBehaviour // Control de la càmera
{
    public Vector3 DesplaçamentCamera = new Vector3(0f, 1.2f, -2.6f); // Distància càmera
    private Transform _target; // Objectiu a seguir

    void Start() // A l'inici
    {
        _target = GameObject.Find("Player").transform; // Busca el Player
    }

    void LateUpdate() // Després del moviment
    {
        transform.position = _target.TransformPoint(DesplaçamentCamera); // Mou càmera
        transform.LookAt(_target); // Mira al Player
    }
}
