using UnityEngine;

public class Killzone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Ensure your player has the "Player" tag
        {
            // Call a method to handle player death
            PlayerDeath(collision.gameObject);
        }
    }

    private void PlayerDeath(GameObject player)
    {
        // Implement what happens when the player dies
        // For example, you can reload the level or respawn the player
        Debug.Log("Player has entered the killzone!");

        // Example: Reload the current scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
