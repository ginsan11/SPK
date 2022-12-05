using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject Terrain1;
    public GameObject Terrain2;
    public GameObject Terrain3;
    public GameObject Terrain4;
    public GameObject Terrain5;
    public GameObject Terrain6;
    public GameObject Terrain7;
    public GameObject Terrain8;
    public GameObject Terrain9;
    GameObject[] TerrainArray;

    Vector3 nexTileSpawn;
    public float currentlvl;
    

 


    // Start is called before the first frame update
    void Start()
    {
        TerrainArray = new GameObject[] { Terrain1, Terrain2, Terrain3, Terrain4, Terrain5, Terrain6, Terrain7, Terrain8, Terrain9 };
        currentlvl = GameManager.instance.getlvl();
        print("THIS IS THE CURRENT LEVL    :  " + GameManager.instance.getlvl());

        
        nexTileSpawn = TerrainArray[0].transform.GetChild(0).transform.position;
        for(float i = 1.0f; i < currentlvl; i++){
            SpawnTile(false);
        }
        SpawnTile(true);

        //SpawnTile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile(bool wall)
    {
        if (!wall){
            int rand_num = Random.Range(0, 8); //Random Terrain Index Selected 
            GameObject temp = Instantiate(TerrainArray[rand_num], nexTileSpawn, Quaternion.identity);   //Terrain created
            nexTileSpawn = temp.transform.GetChild(0).transform.position;  //Spawn point for next terrain selected
        }else{
            int rand_num = Random.Range(0, 8); //Random Terrain Index Selected 
            GameObject temp = Instantiate(TerrainArray[rand_num], nexTileSpawn, Quaternion.identity);   //Terrain created
            //Transform edge_wall = temp.transform.Find("Child Name");
            temp.transform.Find("Edge Rocks").transform.Find("Rock_02 (3)").gameObject.SetActive(true); 
            //edge_wall.active = true;
            nexTileSpawn = temp.transform.GetChild(0).transform.position;  //Spawn point for next terrain selected
        }
    }

}
