using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text highScore;
    private int scoreCount = 0;
    public static ScoreManager instance;
    private void Awake()
    {
        instance = this;
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void AddScore(int points)
    {
        scoreCount += points;
        score.text = scoreCount.ToString();
        AddHighScore();
    }

    public void AddHighScore()
    {
        if (scoreCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreCount);
            highScore.text = scoreCount.ToString();
        }
    }
}
