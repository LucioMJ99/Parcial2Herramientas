using UnityEngine;

public class PlatformEdgeTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificamos si el objeto que entra tiene el tag "Player"
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                player.DieAndRespawn(); // Ejecuta la muerte y el respawn
            }
        }
    }
}
