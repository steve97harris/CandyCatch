using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject livesHolder;
    public GameObject gameOverHolder;
    
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
        score++;
        scoreText.text = score.ToString();
        // print("Score = " + score);
    }

    public void DecreaseLife()
    {
        if (lives > 0)
        {
            lives--;
            print("Lives = " + lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if (lives <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameOver = true;
        print("GameOver!");
        
        gameOverHolder.transform.GetChild(lives).gameObject.SetActive(true);
    }
    

}
