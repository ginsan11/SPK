using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars : MonoBehaviour
{
    public GameObject player;

    [SerializeField] private float Speed = 8.0f;
    //[SerializeField] private float health = 100.0f;

    [SerializeField] private float damageToPlayer = -9999.0f;
    [SerializeField] private float damageRate = 0.2f;
    [SerializeField] private float damageTime;

    public GameObject zombie;
    public GameObject skeleton;
    void Start()
    {
        // zombie = FindObjectOfType<Zombies>();
        // skeleton = FindObjectOfType<Skeletons>();
        Physics.IgnoreCollision(zombie.GetComponent<Collider>(), GetComponent<Collider>(), true);
        Physics.IgnoreCollision(skeleton.GetComponent<Collider>(), GetComponent<Collider>(), true);
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
}
