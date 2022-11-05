using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBox : MonoBehaviour
{
    public GameObject PlayerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print("NNNNNNNNNNNNOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTHING");

    }

    public void PickUp (){
        //GameObject effect = Instantiate(deathEffect, transform.position, transform.rotation);
        //Destroy(effect, 0.1f);
        Destroy(this.gameObject);
        //GameManager.instance.AddKills(1);  -- Adde points to health bar and lamp fuel
        }
        
    void OnTriggerStay(Collider other){
        print("Touch");
        if(other.transform.tag == "Player"){
            print("Player Touch!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            PlayerHealth.GetComponent<Player>().health += 30.0f;
            //Player.health += 20.0f;
            //other.transform.GetComponent<Player>().Healing(20);
            PickUp();
        }
    }
}
