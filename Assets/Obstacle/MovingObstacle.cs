using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{   
    
    public float speed = 10.0f;
    public bool moveLeftToRight = true; // True se l'ostacolo deve muoversi da sinistra a destra, False altrimenti
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
