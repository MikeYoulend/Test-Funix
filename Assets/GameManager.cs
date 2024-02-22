using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
       
    }
    public void StopGame()
    {
        
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        
        if (player != null)
        {
            Movement playerMovement = player.GetComponent<Movement>();
            if (playerMovement != null)
            {   
                
                Time.timeScale = 0;
            }
        }
    }
}
