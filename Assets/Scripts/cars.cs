using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars : MonoBehaviour
{
    public GameObject player;

    [SerializeField] private float Speed = 8.0f;
    [SerializeField] private float health = 100.0f;

    [SerializeField] private float damageToPlayer = 20.0f;
    [SerializeField] private float damageRate = 0.2f;
    [SerializeField] private float damageTime;


    // Start is called before the first frame update
    void Start()
    {

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

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //void OnTriggerStay(Collider other)
    //{
    //    if (other.transform.tag == "Player" && Time.time > damageTime)
    //    {
    //        other.transform.GetComponent<Player>().TakeDamage(damageToPlayer);
    //        damageTime = Time.time + damageRate;
    //    }
    //}
}
