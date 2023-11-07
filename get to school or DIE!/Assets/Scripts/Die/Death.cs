using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Kill the player
            KillPlayer(collision.gameObject);
        }
    }

    private void KillPlayer(GameObject player)
    {
        // Add your player death logic here
        // For example, you can disable the player's movement script, play death animation, or reset the level

        // For demonstration purposes, let's destroy the player object

        Destroy(player);




        //Application.LoadLevel(Application.loadedLevel);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
