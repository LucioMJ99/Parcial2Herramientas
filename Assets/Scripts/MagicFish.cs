using UnityEngine;

public class MagicFish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el jugador tocó al pez
        if (collision.CompareTag("Player"))
        {
            Debug.Log("¡Victoria! Has alcanzado al pez mágico.");
            // Aquí puedes llamar a una función de victoria en tu GameManager o mostrar un panel de UI
            WinGame();
        }
    }

    void WinGame()
    {
        // Pausar el juego o mostrar pantalla de victoria
        Time.timeScale = 0f;
        // Si tienes una UI de victoria, la activas aquí
    }
}
