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
        GameObject obstacleSpawn = GameObject.FindObjectOfType<SpawnPoint>().gameObject;
        GameObject bonusSpawn = GameObject.FindObjectOfType<BonusSpawnPoint>().gameObject;
        
        if (player != null)
        {
            Movement playerMovement = player.GetComponent<Movement>();
            if (playerMovement != null)
            {   
                obstacleSpawn.SetActive(false);
                bonusSpawn.SetActive(false);
                playerMovement.enabled = false;
            }
        }
    }
}
