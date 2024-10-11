using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // This method can be called by the EndGate
    public void ThisEvent()
    {
        // Log a message for debugging
        Debug.Log("End gate triggered, switching scene!");

        // Switch to a new scene
        SceneManager.LoadScene("GameoverScene");  // Replace with the actual scene name
    }

    // Other player-related methods (movement, etc.) go here...
}
