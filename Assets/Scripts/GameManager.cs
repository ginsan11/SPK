using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject player;
    [SerializeField] public Text scoreText;
    public int score = 0;
    public GameObject Health;


    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6,7);

        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {

        if (player == null)
        {
            score = 0;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else if (instance != this){
            Destroy(gameObject);
        }
    }

    void SetScoreText()
    {
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

}
