using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameConfig config; // Arrastra aquí tu ScriptableObject GameConfig
    private int currentLives;
    private Vector3 initialSpawnPosition;

    void Start()
    {
        // Inicializamos las vidas desde el ScriptableObject y guardamos la posición de inicio
        currentLives = config.maxLives;
        initialSpawnPosition = transform.position;
    }

    // Método que se llama cuando choca contra un borde letal o cae al vacío
    public void DieAndRespawn()
    {
        currentLives--;
        Debug.Log("¡Vida perdida! Vidas restantes: " + currentLives);

        if (currentLives > 0)
        {
            // Respawn: Devuelve al jugador a la plataforma inicial estática
            transform.position = initialSpawnPosition;

            // Opcional: Reiniciar la velocidad del Rigidbody si tienes físicas aplicadas
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero; // En Unity 6 se usa linearVelocity (o velocity en versiones anteriores)
            }
        }
        else
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over - Se acabaron las vidas");
        // Aquí puedes activar tu panel de Game Over en la UI
    }
}
