using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    public float speed = 3f;      // Velocidad a la que se desplaza
    public float distance = 4f;   // Distancia máxima que se mueve hacia los lados

    private float startX;

    void Start()
    {
        // Guardamos la posición X inicial
        startX = transform.position.x;
    }

    void Update()
    {
        // Movimiento de lado a lado con PingPong
        float newX = startX + Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
