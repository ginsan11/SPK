using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombies : MonoBehaviour
{
    public GameObject player;
    // private NavMeshAgent enemy;
    [SerializeField] private float moveSpeed = 1.0f; 
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        Movement();
      
    }

     private void Movement () {

        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, moveSpeed * Time.deltaTime);
        transform.position += transform.forward * 1f * Time.deltaTime;

       

        // if (player) { //null reference check
        //     transform.LookAt(player.transform.position); //Look at the player
        //     transform.position += transform.forward * moveSpeed * Time.deltaTime;
             
        // }
        
    }
}
