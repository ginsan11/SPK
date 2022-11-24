using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float health;
    public GameObject deathMenu;



    // public GameObject deathEffect;
    public Slider healthSlider;
    // public GameObject powerupEffect;
    // public GameObject healingEffect;
    public int healef = 0;
    public int powU = 0;


    void Start()
    {
        deathMenu.gameObject.SetActive(false);
        healthSlider.maxValue = 100.0f;
        healthSlider.value = health;
        health = 100.0f;
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

  

    public void TakeDamage(float damage) {
        health -= damage;

        if (health <= 0) {
            Destroy(this.gameObject);
            regainMouse();
            OpenDeathMenu();
        }
    }

    public void killGame()
    {
        Application.Quit();
    }

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



    public void regainMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    public void OpenDeathMenu()
    {
        PauseGame();
        //Time.timeScale = 0;
        //ShopMenu.gameObject.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        deathMenu.gameObject.SetActive(true);
    }

}


