using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject SkeletonPrefab;
    // public Transform[] spawnPoints;

    [SerializeField] private float spawnRate = 5.5f;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
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
            // int randSpawnPoints = Random.Range(0, spawnPoints.Length);  

            transform.position = GameManager.instance.player.transform.position + new Vector3(3,0,3);

            Instantiate(SkeletonPrefab, transform.position, transform.rotation);
            spawnTimer = Time.time + spawnRate;
        }
    }
}
