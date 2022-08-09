using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text highScore;
    private int scoreCount = 0;
    public static UIManager instance;
    [SerializeField] private GameObject escapeMenu;
    private void Awake()
    {
        instance = this;
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleEscapeMenu();
        }
    }

    public void ToggleEscapeMenu()
    {
        if (escapeMenu.activeSelf)
        {
            escapeMenu.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;

        }
        else
        {
            escapeMenu.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
        }
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
