using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject livesHolder;
    public GameObject gameOverPanel;
    
    public int score = 0;
    public Text scoreText;

    public int lives = 3;
    
    public bool gameOver = false;
    
    private void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();        
        }

        // print("Score = " + score);
    }

    public void DecreaseLife()
    {
        if (lives > 0)
        {
            lives--;
            print("Lives = " + lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);        // Gets children of 'Lives Holder' game object, set's each object as inactive when losing a life.
        }

        if (lives <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameOver = true;
        
        CandySpawner.instance.StopSpawningCandies();        // Finds instance of 'CandySpawner' script and stops spawning candies.               
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;        // Finds game object 'player', gets component 'player controller' script, sets 'canMove' to false. 

        gameOverPanel.SetActive(true);

        print("GameOver!");
    }
    

}
