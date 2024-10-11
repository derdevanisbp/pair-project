using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGate : MonoBehaviour
{
    // This method gets called when something triggers the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object is tagged as "Player"
        if (collision.CompareTag("Player"))
        {
            // Get the Player component from the collided object
            Player player = collision.GetComponent<Player>();
            if (player != null)
            {
                player.ThisEvent();  // Call the ThisEvent method on the Player
            }
            else
            {
                Debug.LogError("Player component not found on the Player GameObject!");
            }
        }
    }
}


