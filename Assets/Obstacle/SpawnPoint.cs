using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject parentGameObject;
    [SerializeField] bool Left = true;
    
    float Xposition;
    float Yposition;
    float RandomZ;

    public UnityEngine.Quaternion rotation = UnityEngine.Quaternion.identity;
    
    void Start()
    {
       parentGameObject = GameObject.FindWithTag("Spawn");
       Invoke("SpawnObstacleRandom", 1f);
    }

    void SpawnObstacleRandom()
    {
        HowIsPositioned();

        UnityEngine.Vector3 spawnPosition = new UnityEngine.Vector3(Xposition, Yposition, RandomZ);

        GameObject newObstacle = Instantiate(obstaclePrefab, spawnPosition, rotation);
        newObstacle.transform.parent = parentGameObject.transform;
    }

    void HowIsPositioned()
    {
        if (Left == true)
        {
            Xposition = -15f;
            rotation = UnityEngine.Quaternion.Euler(90f, 0f, 0f);
        }
        else
        {
            Xposition = 15f;
        }
        Yposition = 0.60f;
        RandomZ = Random.Range(7, -7);
    }
}
