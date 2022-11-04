using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeletons : MonoBehaviour
{
    public GameObject player;
        [SerializeField] private float moveSpeed = 1.0f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        Movement();
      
    }


    private void Movement () {

        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, moveSpeed * Time.deltaTime);
        transform.position += transform.forward * 1f * Time.deltaTime;

       
        
    }
}
