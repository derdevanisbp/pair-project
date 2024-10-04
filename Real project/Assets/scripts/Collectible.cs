using UnityEngine;

public class Collectible : MonoBehaviour
{
    // This method is called when another collider enters the trigger collider attached to the GameObject
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided with the collectible has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Optionally, you can add code here to update the player's score or inventory

            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}
