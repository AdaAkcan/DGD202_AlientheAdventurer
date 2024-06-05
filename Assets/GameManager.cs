using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
        // Log a message to the console (useful for testing in the Editor)
        Debug.Log("Game is exiting");

        // Quit the application
        Application.Quit();
    }
}
