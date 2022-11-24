using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    public GameObject ZombiePrefab;

    [SerializeField] private float spawnRate;

    private float spawnTimer;
    //public Transform[] spawnPoints;




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

            Instantiate(ZombiePrefab, transform.position, transform.rotation);
            spawnTimer = Time.time + spawnRate;
        }
    }
}
