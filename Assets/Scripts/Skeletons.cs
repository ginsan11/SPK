using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeletons : MonoBehaviour
{
    public GameObject childObject;
    [SerializeField] private float moveSpeed = 1.0f; 
    [SerializeField] private float health = 100.0f; 

    [SerializeField] public float damageToPlayer = 1.0f;
    [SerializeField] private float damageRate = 0.2f;
    [SerializeField] private float damageTime; 

    public Animator animator;
    // Start is called before the first frame update
    
    void Start()
    {
        childObject = transform.GetChild(0).gameObject;
        animator = childObject.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    

     void Update()

    {
        Movement();
    }

     private void Movement () {

        if (GameManager.instance.player) { //null reference check
            transform.LookAt(GameManager.instance.player.transform.position); //Look at the player
            transform.position += transform.forward * moveSpeed * Time.deltaTime;             
        }

        
    }

     public void TakeDamage (float damage) {
        health -= damage; 

        if (health <= 0) {
            Destroy(this.gameObject); 
        }
    }

    void OnTriggerStay(Collider other) {

        if (other.transform.tag == "Player" && Time.time > damageTime) {
            animator.SetTrigger("attack");
            other.transform.GetComponent<Player>().TakeDamage(damageToPlayer); 
            damageTime = Time.time + damageRate;             
        }

            
    }

   
}

