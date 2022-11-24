using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDamageScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //If We have triggered with the enemy which is the skeleton.
            //Give the skeleton a damage of 10
            FindObjectOfType<Skeletons>().TakeDamage(10);
            Debug.Log("Received Enemy Damage From Projectile");
            
            //Destroy this Projectile.
            Destroy(gameObject);
        }
    }
}
