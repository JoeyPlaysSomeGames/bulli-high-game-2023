using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            win(collision.gameObject);
        }
    }

    private void win(GameObject player)
    {
        



        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        

        
    }

    
}