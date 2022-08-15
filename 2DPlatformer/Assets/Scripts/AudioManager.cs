using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public static AudioClip collectDiamond, playerDeath, gameOver, mainTheme;
    [SerializeField] private static AudioSource source;
    [SerializeField] private AudioMixer audioMixer;

    private static bool audioManagerFirstTime = true;
    [SerializeField] private Slider volumeSlider;

    private void Awake()
    {

        source = GetComponent<AudioSource>();

        if (source == null)
        {
            Debug.LogError("Script: AudioManager\t AudioSource is NULL");
        }

        GetAudioClips();

        volumeSlider.value = PlayerPrefs.GetFloat("MainVolume");

        if (audioManagerFirstTime)
        {
            DontDestroyOnLoad(this);
            source.clip = mainTheme;
            source.Play();
            audioManagerFirstTime = false;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    private void GetAudioClips()
    {
        collectDiamond = Resources.Load<AudioClip>("Diamond Collect");
        playerDeath = Resources.Load<AudioClip>("Death");
        gameOver = Resources.Load<AudioClip>("Game Over");
        mainTheme = Resources.Load<AudioClip>("Main Theme");
    }

    public static void PlaySound(string soundName)
    {

        switch (soundName)
        {
            case "Diamond Collect":
                source.PlayOneShot(collectDiamond);
                break;
            case "Death":
                source.PlayOneShot(playerDeath);
                break;
            case "Game Over":
                source.PlayOneShot(gameOver);
                break;
            default:
                Debug.LogError("Script: AudioManager\t Undefined sound name");
                break;
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("master", volume);
        PlayerPrefs.SetFloat("MainVolume", volume);
    }
}
