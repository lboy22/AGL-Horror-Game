using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class keySpawn : MonoBehaviour
{
    private int randSpawnPoint;
    public Transform[] spawnPoints;
    public GameObject objectPrefab;


    public GameObject[] keyObject;

    private void Start()
    {
        
        for(int index = 0; index < keyObject.Length; index++)
        {
            randSpawnPoint = Random.Range(0, spawnPoints.Length);
            keyObject[index] = Instantiate(objectPrefab, spawnPoints[randSpawnPoint].position, transform.rotation);
        }      
    }
}
