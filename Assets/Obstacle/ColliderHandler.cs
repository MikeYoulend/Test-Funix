using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    public bool ObstacleLeft = true;


     void OnTriggerEnter(Collider other) {

       switch (other.gameObject.tag)  
        {
            case "Player":    
                Destroy(gameObject);
                break;
            case "ColliderRight":     
                if(ObstacleLeft == true)
                {
                Destroy(gameObject);
                }
                break;
            case "ColliderLeft":      
                if(ObstacleLeft == false)
            {
                Destroy(gameObject);
            }
                break;  
        }
        
    }
}
