using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cars : MonoBehaviour
{
    public GameObject player;

    [SerializeField] private float Speed;
    //[SerializeField] private float health = 100.0f;

    //[SerializeField] private float damageToPlayer = -9999.0f;
    //[SerializeField] private float damageRate = 0.2f;
    [SerializeField] private float damageTime;

    void Start()
    {
        //float value = (GameManager.instance.getlvl * 8.9f);
        Speed = Random.Range(8.0f, (GameManager.instance.getlvl() * 8.9f)); 

    }

    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }

    private void Movement()
    {
        //transform.position += transform.forward * Speed * Time.deltaTime;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

    }

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player" && Time.time > damageTime)
        {
            other.transform.GetComponent<Player>().KillPlayer();
            //damageTime = Time.time + damageRate;
        }
    }

    public void Destroy()
    {
        Destroy(gameObject, 1);
    }
}
