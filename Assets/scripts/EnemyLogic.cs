using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    private int randSpawnPoint;
    public Transform[] spawnPoints;
    public GameObject objectPrefab;

    private float nextActionTime = 0.0f;
    public float period = 5;

    GameObject enemyObject;

    private void Start()
    {
            randSpawnPoint = Random.Range(0, spawnPoints.Length);
            enemyObject = Instantiate(objectPrefab, spawnPoints[randSpawnPoint].position, transform.rotation);       
    }

    void SpawnEnemy()
    {
        Destroy(enemyObject);
        randSpawnPoint = Random.Range(0, spawnPoints.Length);
        enemyObject = Instantiate(objectPrefab, spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            SpawnEnemy();
        }      
    }
}
