using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject SkeletonPrefab;


    [SerializeField] private float spawnRate = 1.0f;

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
            Instantiate(SkeletonPrefab, transform.position, transform.rotation);
            spawnTimer = Time.time + spawnRate;
        }
    }
}
