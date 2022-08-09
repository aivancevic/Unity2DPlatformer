using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Script: MainMenuManager\t Quit game");
    }

    public void ResumeGame()
    {
        UIManager.instance.ToggleEscapeMenu();
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
