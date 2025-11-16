using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        // Solo funciona en build, no en el editor
        Application.Quit();
        Debug.Log("Juego cerrado (solo en build)");
    }
}
