using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject molePrefab;
    private float spawnRangeX = 10f;
    private float spawnRangeZLow = -8f;
    private float spawnRangeZUp = -1f;
    private float spawnHeight = 3f;
    public float startTime = 2;
    public float spawnInterval = 2;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMole", startTime, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMole()
    {   //pak een random positie om een mol te spawnen binnen de opgezetten boundaries
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnHeight, Random.Range(spawnRangeZLow, spawnRangeZUp));
        Instantiate(molePrefab, spawnPos, molePrefab.transform.rotation); //het inspawnen van een mol
         
    }
}
