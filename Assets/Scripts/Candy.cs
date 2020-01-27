using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            // Increment score
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }
        
        else if (collider.gameObject.tag == "Boundary")
        {
            // Decrease lives
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }
    }
}
