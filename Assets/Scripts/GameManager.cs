using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameConfig config; 
    private int currentLives;

    void Start()
    {
        currentLives = config.maxLives; 
        Debug.Log("Vidas iniciales: " + currentLives);
    }

    public void LoseLife()
    {
        currentLives--;
        if (currentLives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
    }
}
