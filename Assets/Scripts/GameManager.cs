using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject player;
    public Text scoreText;
    public int score = 0;
    public GameObject Health;
    //[SerializeField] public float lvl = 1.0f;
    public float lvl = 1.0f;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else if (instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6,7);

        SetScoreText();


        // if (instance==null){
        //     instance = this;
        //     }
        // else if (instance != this){
        //     //Duplicate GameManager created every time the scene is loaded
        //     Destroy(gameObject);
        //     }
        // DontDestroyOnLoad(gameObject);



    }

    // Update is called once per frame
    void Update()
    {
       
        SetScoreText();
    }



    void SetScoreText()
    {
        // scoreTEXT <-- is the tag for scoretext
        scoreText.text = "Score: " + score.ToString(); //This will allow us to concatonate two strings in C#    

    }

    public void AddPoints(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log(score);
        SetScoreText();
    }

    public void healthIncrease(float health){
        Health.GetComponent<Player>().health += 30.0f;
    }

    public void lvlup(){
        lvl++;
        print("NEEEEEEEEEEEEEEEEEEEEEEWWWW: "+lvl);
    }

    public float getlvl(){
        print("RETURNED THE FOLLOWING NUMBER  : " + lvl);
        return lvl;
    }

}
