using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{

    public GameManager GameManager;
    // Start is called before the first frame update
    // void Start()
    // {
    //     if(GameManager.instance == null){
    //         Instantiate(GameManager);
    //     }
        
    // }
    void Awake(){
        if(GameManager.instance == null){
            Instantiate(GameManager);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
