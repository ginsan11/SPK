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
    GameObject Shop;


    // Start is called before the first frame update
    void Start()
    {
        switch1 = false;
        ShopMenu.gameObject.SetActive(false);
        Shop = GameObject.FindGameObjectWithTag("House");
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-140.0f, -140.0f-(100.0f * (GameManager.instance.getlvl()-1))), 2.6f, Random.Range(-112.0f, -69f));
        Shop.transform.position = randomSpawnPosition;
        //regainMouse();

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

    public void ReleaseMouse()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    public void OpenShop(){
        ShowShop();
        Time.timeScale = 0;
        ShopMenu.gameObject.SetActive(true);
    }
        
    void OnTriggerStay(Collider other){
        if(other.transform.tag == "Player" && switch1 == false){
        //other.transform.GetComponent<Player>().TakeDamage(damageToPlayer);
        switch1 = true;
        OpenShop();
        }
    }


    public void ShowShop()
    {
        Time.timeScale = 0;
        ShopMenu.gameObject.SetActive(true);
        regainMouse();
    }

    public void NextLevel()
    {
        ZombiePrefab.GetComponent<Zombies>().damageToPlayer += 1.0f;
        SkeletonPrefab.GetComponent<Skeletons>().damageToPlayer += 1.0f;
        ShopMenu.gameObject.SetActive(false);
        switch1 = false;
        GameManager.instance.lvlup();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1;
        ReleaseMouse();
    }



}
