using UnityEngine;
using UnityEngine.UI;

public class ending : MonoBehaviour
{
    public GameObject victoryScreen; // Reference to the victory screen UI panel

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with a flag
        if (other.CompareTag("Player"))
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        // Activate the victory screen
        victoryScreen.SetActive(true);

        // Optionally, you can stop the player movement and other gameplay mechanics here
        Time.timeScale = 0; // This will freeze the game
    }
}
