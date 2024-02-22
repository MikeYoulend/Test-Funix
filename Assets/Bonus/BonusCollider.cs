using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCollider : MonoBehaviour
{
    Scoreboard scoreboard;
    [SerializeField] int scorePerHit = 100;
    [SerializeField] bool BonusLeft = true;
    // Start is called before the first frame update
    void Start()
    {
          scoreboard = FindObjectOfType<Scoreboard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnTriggerEnter(Collider other) {

       switch (other.gameObject.tag)  
        {
            case "Player":
                ProcessHit();
                Destroy(gameObject);
                break;
            case "ColliderRight":     
                if(BonusLeft == true)
                {
                Destroy(gameObject);
                }
                break;
            case "ColliderLeft":      
                if(BonusLeft == false)
                {
                Destroy(gameObject);
                }
                break;  
        }
        
    }

    private void ProcessHit()
    {
        scoreboard.IncreaseScore(scorePerHit);
    }


}
