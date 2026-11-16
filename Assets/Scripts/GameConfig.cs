using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "ScriptableObjects/GameConfig", order = 1)]
public class GameConfig : ScriptableObject
{
    [Header("Configuración del Jugador")]
    public int maxLives = 3;
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    [Header("Configuración de Plataformas")]
    public float platformSpeed = 3f;
}
