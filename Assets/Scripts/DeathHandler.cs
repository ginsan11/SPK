using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    private bool switch1;
    public GameObject deathMenu;
    // Start is called before the first frame update
    void Start()
    {
        switch1 = false;
        deathMenu.gameObject.SetActive(false);
        regainMouse();
    }
    public void regainMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player" && switch1 == false)
        {
            //other.transform.GetComponent<Player>().TakeDamage(damageToPlayer);
            switch1 = true;
            OpenShop();
        }
    }

    public void OpenShop()
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

    public void KillGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
