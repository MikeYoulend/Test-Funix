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
        else
        {
            Destroy(gameObject);
        }
    }

    // Metodo per fermare il gioco
   public void StopGame()
{
    // Disabilita o distruggi gli oggetti che contengono gli script MovingObstacle e SpawnPoint

    GameObject player = GameObject.FindGameObjectWithTag("Player");
    GameObject obstacleSpawn = GameObject.FindObjectOfType<SpawnPoint>().gameObject;
    GameObject BonusSpawn = GameObject.FindObjectOfType<BonusSpawnPoint>().gameObject;
   

    if (player != null)
    {
        Movement playerMovement = player.GetComponent<Movement>();

        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
    }
    
    obstacleSpawn.SetActive(false);
    BonusSpawn.SetActive(false);
    
}
}