using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;  // (Singleton)

    // Variables globales del juego
    public int score = 0;
    public int playerLives = 3;

    private void Awake()
    {      
        if (instance == null) instance = this;
        else Destroy(gameObject); // Evitar duplicados
    }

    public void ResetGame()
    {
        // Aca se haria la logica para reiniciar el juego.
    }
}




//SceneManager y DonDestroyOnLoad








