using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    public GameObject ZombiePrefab;
    public GameObject player;


    // public Transform[] spawnPoints;

    [SerializeField] private float spawnRate = 5.5f;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

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
            transform.position = player.transform.position + new Vector3(-3,0,3);

            Instantiate(ZombiePrefab, transform.position, transform.rotation);
            spawnTimer = Time.time + spawnRate;
        }
    }
}
