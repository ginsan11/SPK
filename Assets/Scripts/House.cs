using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class House : MonoBehaviour
{
    private bool switch1;
    public GameObject ShopMenu;
    public GameObject ZombiePrefab;
    public GameObject SkeletonPrefab;


    // Start is called before the first frame update
    void Start()
    {
        switch1 = false;
        ShopMenu.gameObject.SetActive(false);
        regainMouse();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void regainMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void OpenShop(){
        PauseGame();
        //Time.timeScale = 0;
        //ShopMenu.gameObject.SetActive(true);
        }
        
    void OnTriggerStay(Collider other){
        if(other.transform.tag == "Player" && switch1 == false){
        //other.transform.GetComponent<Player>().TakeDamage(damageToPlayer);
        switch1 = true;
        OpenShop();
        }
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        ShopMenu.gameObject.SetActive(true);
    }

    public void NextLevel()
    {
        ZombiePrefab.GetComponent<Zombies>().damageToPlayer += 1.0f;
        SkeletonPrefab.GetComponent<Skeletons>().damageToPlayer += 1.0f;
        ShopMenu.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }



}
