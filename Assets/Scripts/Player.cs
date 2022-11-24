using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject deathMenu;
    public float health;
    // public GameObject deathEffect;
    public Slider healthSlider;
    // public GameObject powerupEffect;
    // public GameObject healingEffect;
    public int healef = 0;
    public int powU = 0;
    
    //This is the new player Animator attached to this player.
    private Animator _playerAnimator;
    //Use the hash for the animator parameter for efficiency.
    private int _isAttackingAnimationHash;
    private int _isMoveForwardAnimationHash;
    
    //This is the projectile that will be Instantiated when the player presses the right mouse button.
    //The projectile is supposed to deal damage to the skeleton too.
    public GameObject projectile;
    public Transform projectileInstantiationPoint;

    //This will be referenced in the third person controller to ensure that if it's true,
    //we don't play both idle and attack animation.
    public bool isPlayAttackAnimation;
    
    //Define the projectile speed when the player shoots with the right mouse button.
    public float projectileSpeed = 800f;
    
    //This will disable movements from the Third person controller when the player dies.
    public bool isPlayerDead;


    void Start()
    {
        deathMenu.gameObject.SetActive(false);
        healthSlider.maxValue = 100.0f;
        healthSlider.value = health;
        health = 100.0f;
        
        //Get reference of the Animator from this player.
        _playerAnimator = GetComponent<Animator>();
        
        //Set the hash value of the animation with the relevant animation.
        _isAttackingAnimationHash = Animator.StringToHash("IsPlayAttackAnimation");
        _isMoveForwardAnimationHash = Animator.StringToHash("IsMoveForwardAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;
        if (isPlayerDead)
        {
            healthSlider.value = 0;
        }

        CheckMouseInput();
        // if (healef == 1)
        // {
        //     healEffect();
        // }

        // if(powU == 1)
        // {
        //     powerEffect();
        // }
    }

    //check for Mouse Inputs Using the new Input System.
    //Left Mouse click is used to Attack .
    //Right Mouse click is used to shoot projectile.
    private void CheckMouseInput()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //This Means that we've Pressed the left mouse button so call the Attack Function.
            PlayAttackAnimation();
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //Right Mouse Button Pressed so Shoot Projectile forward.
            ShootProjectile();
        }
    }

    private void ShootProjectile()
    {
        GameObject instantiatedProjectile =
            Instantiate(projectile, projectileInstantiationPoint.position, Quaternion.identity);
        //Vector3 projectileTargetPosition = FindObjectOfType<Skeletons>().transform.position;
        //instantiatedProjectile.GetComponent<Transform>().LookAt(projectileTargetPosition);
        
        instantiatedProjectile.GetComponent<Rigidbody>().AddForce(
            gameObject.transform.forward * (projectileSpeed * Time.deltaTime), ForceMode.Impulse);
        
        Destroy(instantiatedProjectile, 5f);
    }
  

    public void TakeDamage(float damage) {
        health -= damage;

        if (health <= 0)
        {
            healthSlider.value = health;
            //Set the bool of death to be true so as to disable the movement.
            isPlayerDead = true;
            Destroy(this.gameObject);
            regainMouse();
            OpenDeathMenu();
        }
    }

    public void restartGame()
    {

        print("restarting");
        deathMenu.gameObject.SetActive(false);
        Cursor.visible = false;
    }

    public void killGame()
    {
        Application.Quit();
        deathMenu.gameObject.SetActive(false);
        Cursor.visible = false;
    }
    public void regainMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    public void OpenDeathMenu()
    {
        regainMouse();
        Time.timeScale = 0;
        deathMenu.gameObject.SetActive(true);
    }

   

    public void KillPlayer() {
        isPlayerDead = true;
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

    //This function is called from the Third Person Controller Script when Input is detected to set the boolean 
    //animation condition to true in the animator and make the player move.
    public void PlayMoveAnimation()
    {
        if (!this) return;
        _playerAnimator.Play("MoveFWD_Normal_InPlace_SwordAndShield");
        isPlayAttackAnimation = false;
        //_playerAnimator.SetBool(_isMoveForwardAnimationHash, true);
        //Debug.Log("Called Move Animation From Player Script.");
    }

    public void PlayIdleAnimation()
    {
        if (!this) return;
        _playerAnimator.Play("Idle_Battle_SwordAndShield");
        isPlayAttackAnimation = false;
        //_playerAnimator.SetBool(_isMoveForwardAnimationHash, false);
        //Debug.Log("Called Idle Animation From Player Script.");
    }

    //This function is called To Set the bool of playing Attack animation to true when the player wants to attack.
    public void PlayAttackAnimation()
    {
        isPlayAttackAnimation = true;
        _playerAnimator.Play("Attack02_SwordAndShiled");
        //Debug.Log("Called Play Attack Animation.");
    }

    public void fullHeal()
    {
        if (GameManager.instance.score >= 2)
        {
            healef = 1;
            GameManager.instance.score -= 2;
            GameManager.instance.scoreText.text = "Score: " + GameManager.instance.score.ToString();
            health = 100f;
        }
        else
        {
            print("Tryna scam me eh?");
        }
    }
}


