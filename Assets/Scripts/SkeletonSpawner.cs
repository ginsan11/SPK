using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject SkeletonPrefab;
    // public Transform[] spawnPoints;

    [SerializeField] private float spawnRate = 5.5f;

    private float spawnTimer;
    public GameObject player;


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
        

            transform.position = player.transform.position + new Vector3(3,0,3);

            Instantiate(SkeletonPrefab, transform.position, transform.rotation);
            // PlayerPos();
            spawnTimer = Time.time + spawnRate;
        }
    }


    // void PlayerPos(){

    //     Vector3 playerPos = GameManager.instance.player.transform.position;
    //     Vector3 playerDirection = GameManager.instance.player.transform.forward;
    //     Quaternion playerRotation = GameManager.instance.player.transform.rotation;
    //     float spawnDistance = 3;
    //     Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
    //     Instantiate(SkeletonPrefab, spawnPos, transform.rotation);

    // }

    // Vector3 PlayerPos(){
    //     Vector3 playerpos =  GameManager.instance.player.transform.position + new Vector3(3,0,3);
    //     return playerpos;
    // }


}
