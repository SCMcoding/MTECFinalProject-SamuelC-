using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public static ScoreManager instance;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;   
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + "POINTS";
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";
        if (highscore< score)
        PlayerPrefs.SetInt("highscore", score);
    }
}