using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    private bool switch1;

    // Start is called before the first frame update
    void Start()
    {
        switch1 = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OpenShop(){
        Time.timeScale = 0;
        //ShopMenu.gameObject.SetActive(true);
        }
        
    void OnTriggerStay(Collider other){
        if(other.transform.tag == "Player" && switch1 == false){
        //other.transform.GetComponent<Player>().TakeDamage(damageToPlayer);
        switch1 = true;
        OpenShop();
        }
    }
}
