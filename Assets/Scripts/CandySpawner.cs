using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;

    [SerializeField] 
    float spawnInterval;
    
    public GameObject[] candies;

    public static CandySpawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Start()
    {
        // SpawnCandy();
        StartSpawningCandies();
    }

    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int randomCandy = Random.Range(0, candies.Length);

        float randomX = Random.Range(-maxX, maxX);
        
        Vector3 randomPosition = new Vector3(randomX, transform.position.y, transform.position.z);
        
        Instantiate(candies[randomCandy], randomPosition, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();
            
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }
}
