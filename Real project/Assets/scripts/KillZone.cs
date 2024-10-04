using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Transform spawnPoint;   // Assign the spawn point in the editor
    public GameObject player;      // Assign the player GameObject in the editor

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player hit the block
        if (collision.gameObject == player)
        {
            RespawnPlayer();
        }
    }

    void RespawnPlayer()
    {
        // Move the player to the spawn point position
        player.transform.position = spawnPoint.position;

        // Optionally reset the player's velocity if you use Rigidbody2D
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;  // Reset velocity to stop any momentum
        }
    }
}


