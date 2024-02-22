using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{   

    LifePoint lifepoints;
    [SerializeField] int HealthPerHit = 1;
    [Tooltip("How fast you move")] [SerializeField] float moveSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        lifepoints = FindObjectOfType<LifePoint>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
       float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
       float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
       transform.Translate(xValue, 0, zValue);
    }

  void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Obstacle") 
        {
            lifepoints.ReduceHealth(HealthPerHit);
            if(lifepoints.life < 1)
            {
                GameManager.Instance.StopGame();
            }
        }
    }
}
