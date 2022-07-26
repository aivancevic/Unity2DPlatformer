using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public static AudioClip collectDiamond, playerDeath, gameOver;
    [SerializeField] private static AudioSource source;

    private void Awake()
    {
        collectDiamond = Resources.Load<AudioClip>("Diamond Collect");
        playerDeath = Resources.Load<AudioClip>("Death");
        gameOver = Resources.Load<AudioClip>("Game Over");
        source = GetComponent<AudioSource>();

        if (source == null)
        {
            Debug.LogError("Script: AudioManager\t AudioSource is NULL");
        }
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
}
