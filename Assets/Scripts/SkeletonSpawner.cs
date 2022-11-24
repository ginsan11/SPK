using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject SkeletonPrefab;
    //public Transform[] spawnPoints;

    [SerializeField] private float spawnRate;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 5.5f;
    }

    // Update is called once per frame
    void Update()
    {
        EnnemySpawner();
    }
 
    private void EnnemySpawner()
    {
        if (Time.time > spawnTimer)
        {
            //int randSpawnPoints = Random.Range(0, spawnPoints.Length);                                      

            Instantiate(SkeletonPrefab, transform.position, transform.rotation);
            spawnTimer = Time.time + spawnRate;
        }
    }
}
