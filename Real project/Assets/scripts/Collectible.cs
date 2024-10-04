using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 10; // Points awarded for collecting the item

    // This method is called when another collider enters the trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided with the collectible has a "Player" tag
        if (other.CompareTag("Player"))
        {
            // Optionally, you could add logic to increase the player's score here
            // Example: PlayerScore.Instance.AddScore(points);

            // Destroy the collectible game object
            Destroy(gameObject);
        }
    }
}
