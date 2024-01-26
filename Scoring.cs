using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Domenica 
//Fragoso Entertainment - YouTube Channel

public class Scoring : MonoBehaviour
{
    public int score = 0;
    public GameObject scoreCounter;

    // When player passes the finish line, its score increases by 100 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            score += 100;

            scoreCounter.GetComponent<Text>().text = "Score: " + score;
        }


    }

    // If the player collides with an enemy, it loses 25 points
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Debug.Log("Destroyed enemy");
            score -= 25;

            // This updates the points in the panel
            scoreCounter.GetComponent<Text>().text = "Score: " + score;

        }
    }

}