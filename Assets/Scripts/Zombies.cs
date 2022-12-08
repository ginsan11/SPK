using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombies : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f; 
    [SerializeField] private float health = 100.0f; 

    [SerializeField] public float damageToPlayer = 20.0f;
    [SerializeField] private float damageRate = 0.2f;
    [SerializeField] private float damageTime; 
    
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");


    }

    // Update is called once per frame
    void Update()

    {
        Movement();
      
    }

     private void Movement () {

        if (GameManager.instance.player) { //null reference check
            transform.LookAt(player.transform.position); //Look at the player
            transform.position += transform.forward * moveSpeed * Time.deltaTime;             
        }
   
    }

     public void TakeDamage (float damage) {
        health -= damage; 

        if (health <= 0) {
            GameManager.instance.AddPoints(1);
            Destroy(this.gameObject);
          
        }
    }

    void OnTriggerStay(Collider other) {
        if (other.transform.tag == "Player" && Time.time > damageTime) {
            other.transform.GetComponent<Player>().TakeDamage(damageToPlayer); 
            damageTime = Time.time + damageRate;             
        }        
    }
}
