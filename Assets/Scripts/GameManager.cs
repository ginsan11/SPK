using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    // public GameObject player;

     public Text scoreText;
    // public Text NAMENSID;

    // public int SpawnChoice = 100;
    // [SerializeField] private float spawnRate = 2.0f;
    // private float timePassed = 0f;

    // public float EnnemyHealth = 100f;


     private int score = 0;
    // private int kills = 0;

    //public static Canvas ShopMenu = GetComponent<Canvas>();
    // public GameObject ShopMenu;
    // public GameObject Projectile;
    // public GameObject Health;
    //public GameObject CoinAmount;


    // Start is called before the first frame update
    void Start()
    {
        // ShopMenu.gameObject.SetActive(false);
        SetScoreText();
        // NAMENSID.text = "HBM657 \n BETUBONSO MUNUNU";
        //damageIncrease();
    }

    // Update is called once per frame
    void Update()
    {
        // timePassed += Time.deltaTime;
        // if(timePassed > 1f)
        // {
        //     SpawnChoice = Random.Range(1, 5);
        //     print("The pick is: " + SpawnChoice);
        //     timePassed = 0f;
        //     }
        // KillCount();    
    }

    // void Awake(){
    //     if(instance == null){
    //         instance = this;
    //     }
    //     else if (instance != this){
    //         Destroy(gameObject);
    //     }
    // }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoints(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log(score);
        SetScoreText();
    }

    // public void AddKills(int killToAdd){
    //     kills += killToAdd;
    // }

    // public int SpawnPicker(){
    //     SpawnChoice = Random.Range(1, 20);
    //     return SpawnChoice;

    // }

    // public void KillCount(){
    //     print("KILLLLLLL AMOOOOUUUNNNT: " + kills);
    //     if(kills == 10){
    //         kills = 0;
    //         PauseGame();
    //     }
    // }


    // public void PauseGame(){
    //     Time.timeScale = 0;
    //     ShopMenu.gameObject.SetActive(true);
    // }

    // public void ResumeGame(){
    //     ShopMenu.gameObject.SetActive(false);
    //     Time.timeScale = 1;
    // }

    // public void damageIncrease(){
    //     if(score >= 10){
    //         Projectile.GetComponent<Projectile>().upTen();
    //         score -= 10;
    //         SetScoreText();
    //     }
    // }

    // public void healthIncrease(float health){
    //     Health.GetComponent<Player>().health += 30.0f;
    // }

}
