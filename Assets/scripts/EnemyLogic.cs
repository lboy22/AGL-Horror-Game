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

    GameObject a;

    private void Start()
    {
        randSpawnPoint = Random.Range(0, spawnPoints.Length);
        a = Instantiate(objectPrefab, spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    void SpawnEnemy()
    {
        Destroy(a);
        randSpawnPoint = Random.Range(0, spawnPoints.Length);
        a = Instantiate(objectPrefab, spawnPoints[randSpawnPoint].position, transform.rotation);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
