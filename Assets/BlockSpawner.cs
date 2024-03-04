using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    private float spawnTime = 2f;

    private int score = 0;

    public float spawnInterval = 1f;
    
    // Start is called before the first frame update
    void Update()
    {
        if (Time.time >= spawnTime)
        {
            SpawnBlocks();
            spawnTime = Time.time + spawnInterval;

        }
        
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if(randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }

        score++;
        Debug.Log(score);
    }

    int playerScore(){
        return score;
    }

}
