using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 3f;
    public float distance = 4f; // Qué tan lejos se mueve a la izquierda y derecha
    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        // Mathf.PingPong crea un movimiento de ida y vuelta constante
        float newX = startX + Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
