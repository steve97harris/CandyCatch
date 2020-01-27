using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canMove = true;
    
    [SerializeField]
    float maxPosition;
    
    [SerializeField]
    float moveSpeed;
    
    void Start()
    {
        // PossibleDeath();
    }

    void Update()
    {
        if (canMove)
        {
            Move();   
        }
    }

    // void PossibleDeath()
    // {
    //     if (GameManager.instance.lives == 0)
    //     {
    //         GameManager.instance.Die();
    //         Destroy(gameObject);
    //     }
    // }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        
        transform.position += Vector3.right * (inputX * moveSpeed * Time.deltaTime);    // a = a + 5 : a += 5

        float xPosition = Mathf.Clamp(transform.position.x, -maxPosition, maxPosition);

        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
        
    }
}
