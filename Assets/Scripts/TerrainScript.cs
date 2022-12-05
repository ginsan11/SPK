using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{
    GroundSpawner gs;
    // Start is called before the first frame update
    void Start()
    {
        gs = GameObject.FindObjectOfType<GroundSpawner>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit (Collider other){
        if (other.transform.tag == "cars"){
            other.transform.GetComponent<cars>().Destroy();
        }

        gs.SpawnTile();
        //Destroy(gameObject, 6);
    }
}
