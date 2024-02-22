using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawnPoint : MonoBehaviour
{
    public GameObject bonusPrefab;
    public GameObject parentGameObject;
    public bool Left = true;
    
    float Xposition;
    float Yposition;
    float RandomZ;

    // Start is called before the first frame update
    void Start()
    {
       parentGameObject = GameObject.FindWithTag("SpawnBonus");
       Invoke("SpawnBonus", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBonus()
    {   
        if(Left == true)
        {
        Xposition = -20f;   
        }
        else
        {
        Xposition = 20f; 
        }
        Yposition = 0.60f;
        RandomZ = Random.Range(7, -7);    

        Vector3 spawnPosition = new Vector3(Xposition, Yposition, RandomZ);
        
        GameObject newBonus = Instantiate(bonusPrefab, spawnPosition, Quaternion.identity);
        newBonus.transform.parent = parentGameObject.transform;
    }
}
