using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShowCredits()
    {
        // Show credits screen
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
