using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    public GameObject carsPreFab;

    [SerializeField] private float spawnRate;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 5.0f;

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
