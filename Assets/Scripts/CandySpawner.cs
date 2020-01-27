using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;

    public GameObject[] candies;
    
    void Start()
    {
        SpawnCandy();
    }

    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int randomCandy = Random.Range(0, candies.Length);

        Instantiate(candies[randomCandy], transform.position, transform.rotation);
    }
}
