using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // [SerializeField] private GameObject mainAudio;
    // private static AudioSource audioSource;
    // private static bool isFirstTimePlay = true;

    // private void Awake()
    // {
    //     audioSource = mainAudio.gameObject.GetComponent<AudioSource>();

    //     if (audioSource == null)
    //     {
    //         Debug.LogError("Script: Options\t AudioSource is NULL");
    //     }

    //     if (isFirstTimePlay)
    //     {
    //         audioSource.Play();
    //         isFirstTimePlay = false;
    //     }

    //     // if (GameObject.FindGameObjectsWithTag("AudioManager").Length > 1)
    //     // {
    //     //     GameObject audioManagerDuplciate = GameObject.FindGameObjectWithTag("AudioManager");
    //     //     Destroy(audioManagerDuplciate);
    //     // }

    // }

    public void PlayGame()
    {
        // DontDestroyOnLoad(mainAudio);
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
