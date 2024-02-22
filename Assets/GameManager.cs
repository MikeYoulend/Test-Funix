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

    // Metodo per fermare il gioco e mostrare il gameover
    public void StopGame()
    {
        // Ottieni il punteggio finale dal Scoreboard
       
        
        // Mostra il gameover screen e passa il punteggio finale
        
        // Disabilita o distruggi gli oggetti che contengono gli script MovingObstacle e SpawnPoint
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject obstacleSpawn = GameObject.FindObjectOfType<SpawnPoint>().gameObject;
        GameObject bonusSpawn = GameObject.FindObjectOfType<BonusSpawnPoint>().gameObject;
        
        if (player != null)
        {
            Movement playerMovement = player.GetComponent<Movement>();
            if (playerMovement != null)
            {
                playerMovement.enabled = false;
            }
        }
        
        obstacleSpawn.SetActive(false);
        bonusSpawn.SetActive(false);
        
        
    }
}
