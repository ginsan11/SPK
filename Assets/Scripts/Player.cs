using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static float health = 100.0f;



    // public GameObject deathEffect;
    public Slider healthSlider;
    // public GameObject powerupEffect;
    // public GameObject healingEffect;
    public int healef = 0;
    public int powU = 0;


    void Start()
    {
        healthSlider.maxValue = 100.0f;
        healthSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;

        // if (healef == 1)
        // {
        //     healEffect();
        // }

        // if(powU == 1)
        // {
        //     powerEffect();
        // }
    }

  

    // public void TakeDamage(float damage) {
    //     health -= damage;

    //     if (health <= 0) {
    //         GameObject effect = Instantiate(deathEffect, transform.position, transform.rotation);
    //         Destroy(effect, 1.0f);
    //         Destroy(this.gameObject);
    //     }
    // }

    // public void Healing (float heals) {
    //     if (health < 100.0f) {
    //         health += heals;
    //     }
    // }

   

    // public void healEffect()
    // {
    //     GameObject effect = Instantiate(healingEffect, transform.position, transform.rotation);
    //     Destroy(effect, 1.0f);
    //     healef = 0;
    // }


    // public void powerEffect()
    // {
    //     GameObject effect = Instantiate(powerupEffect, transform.position, transform.rotation);
    //     Destroy(effect, 1.0f);
    //     powU = 0;
    // }

    // public void setPEffect()
    // {
    //     powU = 1;
    // }


}


