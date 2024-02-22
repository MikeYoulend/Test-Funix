using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{   
    
    [SerializeField] float speed = 10.0f;
    [SerializeField] bool moveLeftToRight = true; 
    Rigidbody rb;

   
    void Start()
    {
        ObstacleMovement();
    }

    void ObstacleMovement()
    {
        rb = GetComponent<Rigidbody>();
        if (moveLeftToRight)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else
        {
            rb.velocity = new Vector3(-speed, 0, 0);
        }
    }
}
