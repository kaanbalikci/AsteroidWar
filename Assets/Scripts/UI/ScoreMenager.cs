using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
     

public class ScoreMenager : MonoBehaviour
{
    public static ScoreMenager SM;

    [SerializeField] private Text scoreText;
    [SerializeField] private Text LifeText;
    [SerializeField] private Text HighScoreText;
    [SerializeField] private Text ScoreGOP;


    private int Life = 3;
    private int Score = 0;
    private int HighScore = 0;
    private void Awake()
    {
        SM = this;
    }

    private void Start()
    {
        scoreText.text = "SCORE : " + Score.ToString();
        LifeText.text = "LIFE : " + Life.ToString();
        HighScore = PlayerPrefs.GetInt("", 0);
        HighScoreText.text = "" + HighScore.ToString();
    }

    public void AddScore()
    {
        Score += 10;
        scoreText.text = "SCORE : " + Score.ToString();
        ScoreGOP.text = "SCORE : " + Score.ToString();
        if (HighScore < Score)
        {
            PlayerPrefs.SetInt("",Score);
        }
    }

    public void LifeScore()
    {
        Life--;
        LifeText.text = "LIFE : " + Life.ToString();
    }

}
