using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombies : MonoBehaviour
{
    public GameObject player;
    // private NavMeshAgent enemy;
    [SerializeField] private float moveSpeed = 1.0f; 
    // [SerializeField] private float health = 100.0f; 

    // [SerializeField] private float damageToPlayer = 20.0f;
    // [SerializeField] private float damageRate = 0.2f;
    // [SerializeField] private float damageTime; 
    // Start is called before the first frame update
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
