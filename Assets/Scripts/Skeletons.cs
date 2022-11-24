using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeletons : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private float moveSpeed = 1.0f; 
    [SerializeField] private float health = 100.0f; 

    [SerializeField] private float damageToPlayer = 10.0f;
    [SerializeField] private float damageRate = 0.2f;
    [SerializeField] private float damageTime; 

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

        
    }

     public void TakeDamage (float damage) {
        health -= damage; 

        if (health <= 0) {
            Destroy(this.gameObject); 
        }
    }

    void OnTriggerStay(Collider other) {
        if (other.transform.CompareTag("Player") && Time.time > damageTime) {
            other.transform.GetComponent<Player>().TakeDamage(damageToPlayer); 
            damageTime = Time.time + damageRate;             
        }        
    }
}

