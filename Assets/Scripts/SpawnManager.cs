using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject[] obstacles;
    public GameObject powerup;

    private float zObstacleSpawn = 30;
    private float xSpawnRange = 10;
    

    private float xPowerupRange = 5.0f;
    private float zPowerupRange = 5.0f;
    

    private float powerupSpawnTime = 5.0f;
    private float obstacleSpawnTime = 1.0f;
    private float startDelay = 1.10f;
    
    
    private Vector3 spawnPos = new Vector3(9, 0, 0.2f);

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
            InvokeRepeating("SpawnRandomObstacles", startDelay, obstacleSpawnTime);
            InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void SpawnRandomObstacles()
    {
        if (gameManager.isGameActive)
        {
            float randomX = Random.Range(-xSpawnRange, xSpawnRange);
            float randomY = Random.Range(2, 10);
            int randomIndex = Random.Range(0, obstacles.Length);

            Vector3 spawnPos = new Vector3(randomX, randomY, zObstacleSpawn);
            Instantiate(obstacles[randomIndex], spawnPos, obstacles[randomIndex].gameObject.transform.rotation);
        }
    }

    void SpawnPowerup()
    {
        if (gameManager.isGameActive)
        {
            float randomX = Random.Range(-xPowerupRange, xPowerupRange);
            float randomY = Random.Range(2, 10);
            float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

            Vector3 spawnPos = new Vector3(randomX, randomY, zObstacleSpawn);

            Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
        }
    }
}
