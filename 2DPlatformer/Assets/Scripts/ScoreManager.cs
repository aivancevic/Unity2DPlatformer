using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text score;
    private int scoreSum = 0;
    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int points)
    {
        scoreSum += points;
        score.text = scoreSum.ToString();
    }
}
