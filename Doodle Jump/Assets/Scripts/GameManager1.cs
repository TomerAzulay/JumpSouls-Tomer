using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    // platform variabels
    public Vector3 spawnPosition;
    public GameObject platformPrefab;
    public Transform playerTransform;
    public GameObject[] randomPlatforms;
    // coins variabels
    public GameObject coins;
    public Vector3 spawnCoinPos;
    // enemy variabels
    public GameObject enemyPrefab;
    public Vector3 spawnEnemyPos;
    
    void Start()
    {
        //first platforms loop
        for (int i = 0; i < 10; i++)
        {
            CreatePlatform();
        }
        
    }

    
    void Update()
    {
        //difficulty sets random platform after score 60
        if (playerTransform.position.y>spawnPosition.y -15)
        {
            if (playerTransform.position.y>30)
            {
                RandomPlatform();
            }
            else
            {
            CreatePlatform();

            }
        }
        //Coins creation 
        if (playerTransform.position.y > spawnCoinPos.y - 15)
        {
            Createcoins();
        }
        //Enemy creation above score 80
        if (playerTransform.position.y > spawnEnemyPos.y - 15)
        {
            if (playerTransform.position.y > 40)
            {
                CreateEnemies();
            }
        }
    }
    //  Functions :
    public void CreatePlatform()
    {
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(2.5f,3.5f);

        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

    }

    void RandomPlatform()
    {
        int choose = Random.Range(0, randomPlatforms.Length);
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(2.5f,4.5f);

        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(randomPlatforms[choose], spawnPosition, Quaternion.identity);
    }
    void Createcoins()
    {
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(2.5f, 7);

        spawnCoinPos.y += randy;
        spawnCoinPos.x = randx;
        Instantiate(coins, spawnCoinPos, Quaternion.identity);

    }
    void CreateEnemies()
    {
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(15, 20);

        spawnEnemyPos.y += randy;
        spawnEnemyPos.x = randx;
        
        Instantiate(enemyPrefab, spawnEnemyPos, Quaternion.identity);

    }
}
