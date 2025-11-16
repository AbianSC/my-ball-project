using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
