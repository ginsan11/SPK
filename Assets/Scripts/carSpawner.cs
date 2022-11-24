using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    public GameObject carsPreFab;

    [SerializeField] private float spawnRate = 1.0f;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Spawncars();
    }

    private void Spawncars()
    {
        if (Time.time > spawnTimer)
        {
            Instantiate(carsPreFab, transform.position, transform.rotation);
            spawnTimer = Time.time + spawnRate;
        }
    }
}
